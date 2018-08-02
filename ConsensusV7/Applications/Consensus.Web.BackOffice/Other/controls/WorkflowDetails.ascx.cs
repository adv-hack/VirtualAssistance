using Consensus.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.Other.controls
{
    public partial class WorkflowDetails : BaseControl<Workflow, String>
    {
        public override String DataTypeName
        {
            get { return "Workflow"; }
        }
        protected override void PopulateControl()
        {
            base.PopulateControl();
            // Set the cost codes to those applicable to the currently selected selling company

            this.RecType.DataSource = WorkflowRecType.FetchAll().OrderBy(recType => recType.RecType);
            this.RecType.DataBind();

            this.RecType.FieldValue = this.DataSource.RecType;

            this.Group.DataSource = Workflow.FetchAllByRecType(this.RecType.FieldValue).Select(wf => wf.Group ?? "").Distinct();


            this.RunDatetime.FieldValue = this.DataSource.RunDatetime.ToString();
            this.LastRunDttime.FieldValue = this.DataSource.LastRunDttime.ToString();

            if (this.RunDatetime.FieldValue == null)
            {
                this.RunDatetime.FieldValue = NormalTime.ToString();
            }


        }
        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);

            this.Occurs.ClientOnChange = "HideFrequencyFields();";
            this.RecType.ClientOnChange = "updateGroup('" + this.RecType.ClientID + "', '" + this.Group.ClientID + "');";
        }
    }
}