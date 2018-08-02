using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="AccountXrefModel" /> object.
    /// </summary>
    public partial class LocalAccountXrefFactory
    {
        /// <summary>
        /// Checks if a contact already exist for that account in database
        /// </summary>
        /// <param name="accountId">accountId</param>        
        /// <param name="roleId">RoleId</param>
        /// <param name="accounteexrefid">accounteexrefid</param>
        /// <returns>Whether that person already exist for that committee in database</returns>
        public bool CheckIfSameContactAlreadyExists(string accountId, string roleId, string accounteexrefid)
        {
            var contactsforAccountId = this.FetchAllByAccountId(accountId);
            var contactList = contactsforAccountId.Where(x => x.RoleId == roleId).ToList();
            bool result = false;
            if (contactList.Count > 0)
            {
                if (string.IsNullOrEmpty(accounteexrefid))
                {
                    result = true;
                }
                else
                {
                    if (contactList.All(x => x.Id != accounteexrefid))
                    {
                        result = true;
                    }
                }
            }
            return result;
        }
        /// <summary>
        /// Checks if a contact already exist for that account in database
        /// </summary>
        /// <param name="accountId">accountId</param>  
        /// <param name="personId">PersonId</param>      
        /// <param name="orgId">Organisation Id</param>
        /// <param name="accounteexrefid">accounteexrefid</param>
        /// <returns>Whether that person already exist for that committee in database</returns>
        public bool CheckIfSameOrganisationAlreadyExists(string accountId, string personId, string orgId, string accounteexrefid)
        {
            bool result = false;
            // if the contact is not available only organization is available, in that situation only we are suppose to validate organisation duplicasy.
            if (string.IsNullOrEmpty(personId))
            {
                var contactsforAccountId = this.FetchAllByAccountId(accountId);
                var orgList = contactsforAccountId.Where(x => x.OrganisationId == orgId && x.RoleId == null).ToList();

                if (orgList.Count > 0)
                {
                    if (string.IsNullOrEmpty(accounteexrefid))
                    {
                        result = true;
                    }
                    else
                    {
                        if (orgList.All(x => x.Id != accounteexrefid))
                        {
                            result = true;
                        }
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// Checks if a contact or organization exists while the data is saved
        /// </summary>
        /// <param name="orgId">Organization Id</param>        
        /// <param name="personid">PersonId</param>        
        /// <returns>Whether that person already exist for that committee in database</returns>
        public bool CheckIfContactOrOrganizationExists(string orgId, string personid)
        {
            if (string.IsNullOrEmpty(orgId) && string.IsNullOrEmpty(personid))
                return true;
            return false;
        }

    }
}
