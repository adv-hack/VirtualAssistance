using Consensus.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.security
{
    public partial class UserAccountPage : BaseStandardPage<UserAccount, Int32>
    {
        #region properties

        /// <summary>
        ///     Gets the icon displayed within the header of the page.
        /// </summary>
        public override string DefaultIcon
        {
            get { return "account"; }
        }

        /// <summary>
        ///     Gets the text displayed within the header of the page.
        /// </summary>
        public override String DefaultTitle
        {
            get { return this.Data.Person.FullName; }
        }

        /// <summary>
        ///     Gets the unique identifier for the API object that is presented within the page.
        /// </summary>
        public override Int32 DataId
        {
            get
            {
                if (base.DataId > 0)
                    return base.DataId;
                else if (this.Request.QueryString.AllKeys.Contains("id"))
                    return 0;
                else if (this.Request.QueryString.AllKeys.Contains("personId"))
                    return 0;
                else if (this.CurrentSession != null)
                    return this.CurrentSession.UserId;
                
                return 0;
            }
        }

        /// <summary>
        ///     Gets the delegated method for loading the API object that is presented within the page.
        /// </summary>
        public override Func<Int32, UserAccount> DataLoader
        {
            get { return UserAccount.FetchById; }
        }

        /// <summary>
        ///     Gets the delegated method for creating the API object that is presented within the page.
        /// </summary>
        public override Func<UserAccount> DataCreator
        {
            get { return UserAccount.Create; }
        }

        #endregion

        #region methods

        protected override void PopulateControls()
        {
            this.UserDetails.DataSource = this.Data;
            this.UserGroupList.DataSource = this.Data.Principal;
            this.UserPermissionList.DataSource = this.Data.Principal;
        }

        #endregion
    }
}