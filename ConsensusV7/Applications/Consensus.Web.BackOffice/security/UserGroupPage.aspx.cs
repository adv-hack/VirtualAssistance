using Consensus.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.security
{
    public partial class UserGroupPage : BaseStandardPage<UserGroup, Int32>
    {
        #region properties

        /// <summary>
        ///     Gets the text displayed within the header of the page.
        /// </summary>
        public override String DefaultTitle
        {
            get { return this.Data.Principal.Name; }
        }

        /// <summary>
        ///     Gets the icon displayed within the header of the page.
        /// </summary>
        public override String DefaultIcon
        {
            get { return "user_group_man_man"; }
        }

        /// <summary>
        ///     Gets the delegated method for loading the API object that is presented within the page.
        /// </summary>
        public override Func<Int32, UserGroup> DataLoader
        {
            get { return UserGroup.FetchById; }
        }

        #endregion

        #region methods

        protected override void PopulateControls()
        {
            this.UserGroupDetails.DataSource = this.Data;
            this.UserMemberList.DataSource = this.Data;
            this.UserGroupList.DataSource = this.Data.Principal;
            this.UserPermissionList.DataSource = this.Data.Principal;
        }

        #endregion
    }
}