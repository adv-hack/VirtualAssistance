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
    public partial class UserGroupList : BaseControl<UserPrincipal>
    {
        public override String DataTypeName
        {
            get { return "Group Membership"; }
        }

        protected override void PopulateControl()
        {
            base.PopulateControl();
            this.GroupList.Data = this.DataSource.UserGroupMemberships.OfType<UserGroupMember>().Select(member => member.Group);
        }
    }
}