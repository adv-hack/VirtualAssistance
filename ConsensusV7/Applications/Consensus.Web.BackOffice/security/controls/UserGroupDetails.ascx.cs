using Consensus.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.security.controls
{
    public partial class UserGroupDetails : BaseControl<UserGroup, String>
    {
        public override string DataTypeName
        {
            get { return "User Group"; }
        }
    }
}