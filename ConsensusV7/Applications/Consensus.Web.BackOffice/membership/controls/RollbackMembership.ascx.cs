using Consensus.Membership;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.membership.controls
{
    public partial class RollbackMembership : BaseControl<MemberPeriod, String>
    {
        public override string DataTypeName
        {
            get { return "Rollback Membership"; }
        }

        public override Func<String, MemberPeriod> DataLoader
        {
            get { return MemberPeriod.FetchById; }
        }

        /// <summary>
        ///     Sets if record can be deleted
        /// </summary>
        public override bool AllowDelete
        {
            get { return false; }
        }

        protected override void PopulateControl()
        {
            base.PopulateControl();
            this.Status.FieldValue = "00-Application";
            
        }
    }
}