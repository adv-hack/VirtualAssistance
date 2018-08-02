using Consensus.Membership;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.membership.controls
{
    public partial class BranchDetail : BaseControl<Branch, String>
    {
        #region properties

        public override string DataTypeName
        {
            get { return "Branch"; }
        }

        #endregion
    }
}