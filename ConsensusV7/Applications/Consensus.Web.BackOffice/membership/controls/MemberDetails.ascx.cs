using Consensus.Membership;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.membership.controls
{
    public partial class MemberDetails : BaseControl<MemberPeriod>
    {
        public override string DataTypeName
        {
            get { return "Member"; }
        }

        protected override void PopulateControl()
        {
            base.PopulateControl();

            this.LapseDate.Visible = this.DataSource.Current == 0;
            this.CurrentDate.Visible = this.DataSource.Current == 1;

            if (this.DataSource.Id != null)
            {
                this.TotalLoc.FieldValue = (1 + this.DataSource.Qty2 + this.DataSource.Qty3).ToString();
                int totalActive = 0;
                foreach (MemberLocation locRecord in this.DataSource.MemberLocations)
                {
                    if (locRecord.Current == 0 && locRecord.Status == 0 && locRecord.SyType == 0)
                        totalActive++;
                }
                this.TotalCurLoc.FieldValue = totalActive.ToString();

            }
        }
    }
}