using Consensus.Membership;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.membership.controls
{
    public partial class CommitteeDetail : BaseControl<Committee, String>
    {
        #region properties

        public override string DataTypeName
        {
            get { return "Committee"; }
        }

        protected override void OnPreRender(EventArgs eventArguments)
        {
            base.OnPreRender(eventArguments);
            if (this.DataSource == null || this.DataSource.Id == null)
            {
                this.StartDate.FieldValue = DateTime.Now;
                this.Members.FieldValue = "0";
            }

        }

        #endregion
    }
}