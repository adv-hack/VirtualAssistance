using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Portal
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="PortalUserModel" /> object.
    /// </summary>
    public partial class LocalPortalUserFactory
    {
        public bool CheckIfUsernameExist(string name,string userId)
        {
            var userlist = this.FetchAll().ToList();
            var usernames = userlist.Where(x => x.LoginId != null && x.LoginId.Trim().ToLower() == name.Trim().ToLower()).ToList();
            bool result = false;
            if (usernames.Count > 0)
            {
                if (Convert.ToInt32(userId) == 0)
                {
                    result = true;
                }
                else
                {
                    if (!usernames.Any(x => x.Id == Convert.ToInt32(userId)))
                    {
                        result = true;
                    }
                }
                
            }
            return result;
        }
        
    }
}
