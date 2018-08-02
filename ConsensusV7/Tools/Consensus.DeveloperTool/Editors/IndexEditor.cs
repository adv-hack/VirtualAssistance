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
    public partial class IndexEditor : BaseEditor
    {
        #region fields

        /// <summary>
        ///     The database index instance that is being created or modified.
        /// </summary>
        private DomainTableIndex DomainTableIndex;

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="IndexEditor" /> instance.
        /// </summary>
        public IndexEditor(DomainTableIndex domainTableIndex)
        {
            this.InitializeComponent();
            this.DomainTableIndex = domainTableIndex;
        }

        #endregion

        #region methods

        protected override bool ValidateForm()
        {
            Boolean result = base.ValidateForm();
            result = result && this.ValidateForm(this.DetailTab, this.NameTextbox, !String.IsNullOrEmpty(this.NameTextbox.Text), "Please specify a name for the index", false);
            // if (result && this.Selections.Count(s => s.Selected) == 0)
            // {
            //     this.MainTabControl.SelectedTab = this.ColumnTab;
            //     MessageBox.Show("Please select at least one column to include in this index", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //     result = false;
            // }

            return result;
        }

        protected override void OnInit()
        {
            this.Size = new Size(500, 400);
            this.NameTextbox.Text = this.DomainTableIndex.IndexName;
            this.DescriptionTextbox.Text = this.DomainTableIndex.IndexDescription;
        }

        protected override void OnConfirm()
        {
            this.DomainTableIndex.IndexName = this.NameTextbox.Text;
            this.DomainTableIndex.IndexDescription = this.DescriptionTextbox.Text;
        }

        #endregion
    }
}
