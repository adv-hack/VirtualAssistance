using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Consensus.Membership;
using Consensus.UserInterface;
using Consensus.Web.Controls;

namespace Consensus.Web.BackOffice.membership.controls
{
    public partial class MemberBranchDetail : BaseControl<BranchXref, String>
    {
        #region properties
        
        public override String DataTypeName
        {
            get { return "Branch Membership"; }
        }

        #endregion

        #region page cycle

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            this.StartDate.FieldValue = DateTime.Now;
            var MepId = this.Request.QueryString["mepid"];            
            this.Mepid.FieldValue = MepId;
            this.TableName.FieldValue = "MEMBER_PERIOD";
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        #endregion
    }
}