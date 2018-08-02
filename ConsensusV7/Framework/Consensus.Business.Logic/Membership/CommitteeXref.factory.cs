using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Membership
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="CommitteeXrefModel" /> object.
    /// </summary>
    public partial class LocalCommitteeXrefFactory
    {
        public bool CheckIfPersonExist(string committeeid, string personid, string committeexrefid)
        {
            var committelist = this.FetchAll().ToList();
            var personlist = committelist.Where(x => x.CommitteeId == committeeid && x.RecordId == personid).ToList();
            bool result = false;
            if (personlist.Count > 0)
            {
                if (string.IsNullOrEmpty(committeexrefid))
                {
                    result = true;
                }
                else
                {
                    if (!personlist.Any(x => x.Id == committeexrefid))
                    {
                        result = true;
                    }
                } 
            }    
            return result;
        }
    }
}
