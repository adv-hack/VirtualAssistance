using Consensus.Activities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.activities.controls
{
    public partial class ComplaintDetail : BaseControl<Complaint, String>
    {
        #region properties
        public override string DataTypeName
        {
            get
            {
                return "Complaint";
            }
        }
        #endregion
        protected override void PopulateControl()
        {
            base.PopulateControl();
        }
        protected override void OnPreRender(EventArgs eventArguments)
        {
            base.OnPreRender(eventArguments);

            if (this.DataSource == null || this.DataSource.Id == null)
            {

                this.medtrProleId.FieldValue = this.CurrentSession.User.Person.PrincipalRole.Id;
                this.medtrProleId.FieldText = this.CurrentSession.User.Person.FullName;

                this.mgrProleId.FieldValue = this.CurrentSession.User.Person.PrincipalRole.Id;
                this.mgrProleId.FieldText = this.CurrentSession.User.Person.FullName;
                this.complaintDate.FieldValue = DateTime.Now.Date;
                this.recdDate.FieldValue = DateTime.Now.Date;

            }

        }
    }
}