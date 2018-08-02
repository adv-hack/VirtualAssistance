using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="AccountModel" /> object.
    /// </summary>
    public partial class LocalAccountFactory
    {
        /// <summary>
        ///     Retrieves a specific <see cref='AccountModel' /> instance.
        /// </summary>
        /// <param name="recType">
        ///     The recType value for the <see cref='AccountModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='AccountModel' /> instance that matches the specified <paramref name='roleId' />; or null, if no matching instance can be found.
        /// </returns>
        public IEnumerable<LocalAccountModel> FetchByXrefRoleIdandOrgId(String roleId, String orgId, String spId)
        {
            IEnumerable<AccountRecord> recordCollection = this.Provider.DataProvider.Finance.Account.FetchByXrefRoleIdandOrgId(roleId, orgId, spId);
            IEnumerable<LocalAccountModel> modelCollection = recordCollection.Select(record => new LocalAccountModel(this.Provider, record));
            return modelCollection;
        }


        /// <summary>
        /// Checks if ARNumber exist
        /// </summary>
        /// <param name="arNumber">ARNumber of Account</param>
        /// <param name="sellingCompId">Id of Selling Company</param>
        /// <param name="accountId">Id of the Account</param>
        /// <returns>Whether ARNumber exist in database</returns>
        public bool CheckIfARNumberExist(string arNumber, string sellingCompId, string accountId)
        {
            var accounts = this.FetchAll().ToList();
            var accountList = accounts.Where(x => x.ARNumber != null && x.ARNumber.Trim().ToLower() == arNumber.Trim().ToLower() && x.SellingComanpyId.ToLower() == sellingCompId.ToLower()).ToList();

            bool result = false;

            if (accountList.Count > 0)
            {
                if (string.IsNullOrEmpty(accountId))
                {
                    result = true;
                }
                else
                {
                    if (!accountList.Any(x => x.Id == accountId))
                    {
                        result = true;
                    }
                }
            }

            return result;

        }


    }
}
