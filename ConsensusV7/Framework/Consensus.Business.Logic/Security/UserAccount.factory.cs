using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="UserAccountModel" /> object.
    /// </summary>
    public partial class LocalUserAccountFactory
    {
        /// <summary>
        ///     Retrieves a specific <see cref='UserAccountModel' /> instance.
        /// </summary>
        /// <param name="username">
        ///     The unique username which distinctly identifies the <see cref='UserAccountModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='UserAccountModel' /> instance that matches the specified <paramref name='username' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalUserAccountModel FetchByUsername(String username)
        {
            UserAccountRecord record = this.Provider.DataProvider.Security.UserAccount.FetchByUsername(username);
            return record == null ? null : new LocalUserAccountModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the reporting URL
        /// </summary>
        /// <returns>
        ///     A <see cref="String"/> containing a URL
        /// </returns>
        public String ReportingURL(String portalPage)
        {
            return this.Provider.DataProvider.Security.UserAccount.ReportingURL(portalPage) + "&BOValidation=" + this.Provider.Security.UserSession.FetchCurrent().Id.ToString();
        }

        /// <summary>
        /// Checks whether Pool B user is allowed to create account
        /// </summary>
        /// <param name="userAccountId">Id of UserAccount</param>
        /// <param name="licenseType">Type of License whether its Pool A or Pool B</param>
        /// <param name="status">Determins whether status is Active</param>
        /// <returns>Whether PoolB account can be created or not</returns>
        public Boolean CheckPoolBUserAllowed(string userAccountId, string licenseType, string status)
        {
            var isUserAllowed = true;

            //Checks if license is of PoolB type and status is Active
            if (licenseType == ((int)LicenseLimitTypes.PoolB).ToString() && status == "1")
            {
                if (string.IsNullOrEmpty(userAccountId))
                {
                    isUserAllowed = CheckIsUserAllowed(isUserAllowed, userAccountId);
                }
                else
                {
                    isUserAllowed = CheckIsUserAllowed(isUserAllowed, userAccountId);
                }
            }
            return isUserAllowed;
        }

        /// <summary>
        /// Checks if user is allowed to create Pool B license
        /// </summary>
        /// <param name="isUserAllowed">Whether PoolB account can be created or not</param>
        /// <param name="userAccountId">Id of User account</param>
        /// <returns>Whether PoolB account can be created or not</returns>
        public Boolean CheckIsUserAllowed(bool isUserAllowed, string userAccountId)
        {
            var isEdit = false;
            var poolBLicenseObject = this.Provider.DataProvider.Security.LicenseLimit.FetchAll().Where(x => x.Type == (int)LicenseLimitTypes.PoolB).FirstOrDefault();
            if (poolBLicenseObject != null)
            {
                var totalNoOfLicenses = poolBLicenseObject.Value * 5;
                var noOfActivePoolBUsers = this.FetchAll().Where(x => x.LicenseType == (int)LicenseLimitTypes.PoolB && x.Status == 1).ToList();

                if (!string.IsNullOrEmpty(userAccountId))
                {
                    var userAccount = this.FetchById(Convert.ToInt32(userAccountId));
                    if (userAccount != null)
                    {
                        isEdit = noOfActivePoolBUsers.Any(x => x.Id == userAccount.Id);
                    }
                }

                if (isEdit && noOfActivePoolBUsers.Count > totalNoOfLicenses)
                {
                    isUserAllowed = false;
                }

                //Checks whether active PoolB user accounts are greater than licenses provided
                if (!isEdit && noOfActivePoolBUsers.Count >= totalNoOfLicenses)
                {
                    isUserAllowed = false;
                }
            }
            else
            {
                isUserAllowed = false;
            }
            return isUserAllowed;
        }

        /// <summary>
        /// Checks if username already exist in database
        /// </summary>
        /// <param name="username">Username of User account</param>        
        /// <param name="userId">Id of User</param>        
        /// <returns>Whether username already exist in database</returns>
        public bool CheckIfUsernameExist(string username, string userId)
        {
            var userList = this.FetchAll().ToList();
            var usernameList = userList.Where(x => x.Username.ToLower() == username.ToLower()).ToList();

            bool result = false;

            if (usernameList.Count > 0)
            {
                if (Convert.ToInt32(userId) == 0)
                {
                    result = true;
                }
                else
                {
                    if (!usernameList.Any(x => x.Id == Convert.ToInt32(userId)))
                    {
                        result = true;
                    }
                }
            }
            return result;

        }

    }
}
