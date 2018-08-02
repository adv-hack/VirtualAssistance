using Consensus.Membership;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.membership.controls
{

    public partial class MemberPersonDetail : BaseControl<MemberLocation, String>
    {
        public override String DataTypeName
        {
            get { return "Member Location"; }
        }

        protected override void PopulateControl()
        {
            base.PopulateControl();
            if(!string.IsNullOrEmpty(this.DataSource.Id))
            {
               // this.MembershipName.DataBoundValue = !string.IsNullOrEmpty(this.DataSource.MemberPeriod.MembershipName) ? this.DataSource.MemberPeriod.MembershipName : this.DataSource.Role.Person.Salutation;
                this.MembershipName.FieldValue = !string.IsNullOrEmpty(this.DataSource.MemberPeriod.MembershipName) ? this.DataSource.MemberPeriod.MembershipName : this.DataSource.Role.Person.Salutation;
            }

        }

        protected override void RegisterJavascript()
        {
        }
    }
}