using Consensus.Marketing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Consensus.Security;

namespace Consensus.Web.BackOffice.marketing.controls
{
    public partial class StepDetail : BaseControl<SaqStep, long>
    {        
        public override string DataTypeName
        {
            get { return "Step"; }
        }


        //protected override void PopulateControl()
        //{
        //    base.PopulateControl();                        
        //}

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);

            List<object> lst = new List<object>();
            lst.Add("Partition");
            lst.Add("Include");
            lst.Add("Exclude");
            lst.Add("Match");

            this.LinkDefault.DataSource = lst;
            if (this.DataSource != null && this.DataSource.LinkDefault != null)
                this.LinkDefault.FieldValue = this.DataSource.LinkDefault.ToString();
            else
                this.LinkDefault.FieldValue = "Include";

            //this.ResultSize.Enabled = (this.DataSource != null && this.DataSource.ResultSizeOpt == 1);

            if (this.DataSource == null || this.DataSource.Id == 0)
            {
                if (this.CurrentSession != null && this.CurrentSession.User != null && this.CurrentSession.User.Person != null)
                {
                    this.Owner.FieldValue = this.CurrentSession.User.Person.PrincipalRole.Id;
                    this.Owner.FieldText = this.CurrentSession.User.Person.FullName;
                }
            }
        }
    }
}