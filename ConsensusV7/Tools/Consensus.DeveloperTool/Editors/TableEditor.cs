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
    public partial class TableEditor : BaseEditor
    {
        #region fields

        /// <summary>
        ///     The database table instance that is being created or modified.
        /// </summary>
        private DomainTable DomainTable;

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="TableEditor" /> instance.
        /// </summary>
        public TableEditor(DomainTable domainTable)
        {
            this.InitializeComponent();
            this.DomainTable = domainTable;
        }

        #endregion

        #region methods

        protected override bool ValidateForm()
        {
            Boolean result = base.ValidateForm();
            result = result && this.ValidateForm(this.NameTextbox, !String.IsNullOrEmpty(this.NameTextbox.Text), "Please specify a name for the table", false);
            return result;
        }

        protected override void OnInit()
        {
            this.Size = new Size(400, 225);
            this.NameTextbox.Text = this.DomainTable.TableName;
            this.DescriptionTextbox.Text = this.DomainTable.TableDescription;
            this.AllocationStepper.Value = this.DomainTable.TableKeyAllocation.ConvertTo<Decimal>(0);
        }

        protected override void OnConfirm()
        {
            this.DomainTable.TableName = this.NameTextbox.Text;
            this.DomainTable.TableDescription = this.DescriptionTextbox.Text;
            this.DomainTable.TableKeyAllocation = (this.AllocationStepper.Value == 0) ? null : this.AllocationStepper.Value.ConvertTo<Int32?>();
        }

        #endregion
    }
}
