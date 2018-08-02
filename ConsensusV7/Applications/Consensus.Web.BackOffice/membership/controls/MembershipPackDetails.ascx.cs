using Consensus.Learning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.membership.controls
{
    public partial class MembershipPackDetails : BaseControl<ProductMembership>
    {
        public override string DataTypeName
        {
            get { return "Membership Product"; }
        }

        protected override void PopulateControl()
        {
            base.PopulateControl();
            if (DataSource.Id != null)
            {
                ////reformat reminder day fields as integers
                this.Reminder1Days.FieldValue = this.DataSource.Reminder1Days.HasValue ? this.DataSource.Reminder1Days.Value.ToString("N0") : "";
                this.Reminder2Days.FieldValue = this.DataSource.Reminder2Days.HasValue ? this.DataSource.Reminder2Days.Value.ToString("N0") : "";
                this.Reminder3Days.FieldValue = this.DataSource.Reminder3Days.HasValue ? this.DataSource.Reminder3Days.Value.ToString("N0") : "";
                this.LapsedDays.FieldValue = this.DataSource.LapsedDays.HasValue ? this.DataSource.LapsedDays.Value.ToString("N0") : "";
            }

        }

    }
}