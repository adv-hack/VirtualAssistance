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
    public partial class TableImporter : BaseEditor
    {
        #region fields

        /// <summary>
        ///     The business domain from which tables can be imported.
        /// </summary>
        private Domain Domain;

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="TableImporter" /> instance.
        /// </summary>
        public TableImporter(Domain domain)
        {
            this.InitializeComponent();
            this.Domain = domain;
        }

        #endregion

        #region event handlers

        private void TableDropdown_Leave(object sender, EventArgs e)
        {
            String bestMatch = null;
            for (Int32 i = this.TableDropdown.Text.Length; i > 0 && bestMatch == null; i--)
                bestMatch = (this.TableDropdown.DataSource as String[]).Where(t => t.StartsWith(this.TableDropdown.Text.Substring(0, i))).FirstOrDefault();
            if (!String.IsNullOrEmpty(bestMatch))
                this.TableDropdown.SelectedItem = bestMatch;
        }

        private void DataSourceDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            DomainDataSource dataSource = this.DataSourceDropdown.SelectedItem as DomainDataSource;
            this.TableDropdown.DataSource = dataSource.GetTables().Where(table => !this.Domain.Tables.Any(t => String.Equals(t.TableName, table, StringComparison.OrdinalIgnoreCase))).ToArray();
            this.TableDropdown.SelectedIndex = -1;
        }

        #endregion

        #region methods

        protected override void OnInit()
        {
            this.Size = new Size(400, 225);
            this.DataSourceDropdown.DisplayMember = "Name";
            this.DataSourceDropdown.ValueMember = "Name";
            this.DataSourceDropdown.DataSource = this.Domain.DataSources.ToList();
        }

        protected override void OnShow()
        {
            this.TableDropdown.Focus();
        }

        protected override Boolean ValidateForm()
        {
            Boolean result = base.ValidateForm();
            result = result && this.ValidateForm(this.TableDropdown, this.TableDropdown.SelectedIndex != -1, "Please select a table to be imported", false);
            return result;
        }

        protected override void OnConfirm()
        {
            DomainDataSource domainDataSource = this.DataSourceDropdown.SelectedItem as DomainDataSource;
            domainDataSource.ImportTable(this.TableDropdown.SelectedItem as String);
        }

        #endregion
    }
}
