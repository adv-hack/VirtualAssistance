using Consensus.Security;
using Consensus.Web.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.security.controls
{
    public partial class UserMemberList : BaseControl<UserGroup>
    {
        public override String DataTypeName
        {
            get { return "Group Membership"; }
        }

        protected override void PopulateControl()
        {
            base.PopulateControl();
            this.MemberList.Data = this.DataSource.UserGroupMemberships.OfType<UserGroupMember>().Select(member => member.Principal).OrderBy(principal => principal.PrincipalType);
        }
    }
}