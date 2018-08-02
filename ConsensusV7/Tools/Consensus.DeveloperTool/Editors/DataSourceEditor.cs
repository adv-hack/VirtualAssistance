using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consensus.CodeGenerator
{
    public partial class DataSourceEditor : BaseEditor
    {
        #region fields

        /// <summary>
        ///     The data source instance that is being created or modified.
        /// </summary>
        private DomainDataSource DomainDataSource;

        /// <summary>
        ///     Tracks whether the connection string has been tested.
        /// </summary>
        private Boolean Tested;

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="DataSourceEditor" /> instance.
        /// </summary>
        public DataSourceEditor(DomainDataSource domainDataSource)
        {
            this.InitializeComponent();
            this.DomainDataSource = domainDataSource;
        }

        #endregion

        #region event handlers

        private void TypeDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            Type dataSourceType = this.TypeDropdown.SelectedValue as Type;
            if (this.DomainDataSource.GetType() != dataSourceType)
            {
                this.DomainDataSource.Domain.Delete(this.DomainDataSource);
                this.DomainDataSource = this.DomainDataSource.Domain.CreateDataSource(dataSourceType);
            }
        }

        private void ConnectionStringTextbox_TextChanged(object sender, EventArgs e)
        {
            this.Tested = (this.ConnectionStringTextbox.Text == this.DomainDataSource.ConnectionString);
        }

        private void TestButton_Click(Object sender, EventArgs e)
        {
            // Test the connection using the updated connection string
            String originalConnectionString = this.DomainDataSource.ConnectionString;
            this.DomainDataSource.ConnectionString = this.ConnectionStringTextbox.Text;
            Exception exception = this.DomainDataSource.TestConnection();
            this.DomainDataSource.ConnectionString = originalConnectionString;

            // Display the result of the test
            if (this.Tested = (exception == null))
                MessageBox.Show("The connection was successfully established", "Connection Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(exception.Message, "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        
        #endregion

        #region methods

        protected override bool ValidateForm()
        {
            Boolean result = base.ValidateForm();
            result = result && this.ValidateForm(this.NameTextbox, !String.IsNullOrEmpty(this.NameTextbox.Text), "Please specify a name for the data source", false);
            result = result && this.ValidateForm(this.ConnectionStringTextbox, !String.IsNullOrEmpty(this.ConnectionStringTextbox.Text), "Please specify a connection string", false);
            result = result && this.ValidateForm(this.ConnectionStringTextbox, this.Tested, "The connection has not been successfully tested, are you sure you want to save this connection?", true);
            return result;
        }

        protected override void OnInit()
        {
            // Identify the data source types that are supported
            Dictionary<Type, String> supportedTypes = typeof(DomainDataSource).Assembly.GetTypes()
                .Where(type => type.IsSubclassOf(typeof(DomainDataSource)) && !type.IsAbstract)
                .ToDictionary(type => type, type => type.GetCustomAttributes(true).OfType<DescriptionAttribute>().Select(attr => attr.Description).FirstOrDefault() ?? type.FullName);

            // Initialise the UI controls
            this.TypeDropdown.DisplayMember = "Value";
            this.TypeDropdown.ValueMember = "Key";
            this.TypeDropdown.DataSource = supportedTypes.ToList();
            this.TypeDropdown.SelectedItem = this.DomainDataSource.GetType();
            this.NameTextbox.Text = this.DomainDataSource.Name;
            this.DescriptionTextbox.Text = this.DomainDataSource.Description;
            this.ConnectionStringTextbox.Text = this.DomainDataSource.ConnectionString;
        }

        protected override void OnConfirm()
        {
            // Update the data source object
            this.DomainDataSource.Name = this.NameTextbox.Text;
            this.DomainDataSource.Description = this.DescriptionTextbox.Text;
            this.DomainDataSource.ConnectionString = this.ConnectionStringTextbox.Text;            
        }

        #endregion
    }
}
