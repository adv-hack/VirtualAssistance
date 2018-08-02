using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Membership
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="BranchXrefModel" /> object.
    /// </summary>
    public partial class LocalBranchXrefFactory
    {
        /// <summary>
        /// Checks if district already exist for that branch in database
        /// </summary>
        /// <param name="branchid">BranchId</param>        
        /// <param name="districtid">DistrictId</param>
        /// <param name="branchxrefid">BranchXrefId</param>
        /// <returns>Whether that district already exist for that branch in database</returns>
        public bool CheckIfDistrictExist(string branchid,string districtid,string branchxrefid)
        {
            var branchlist = this.FetchAll().ToList();
            var districtlist = branchlist.Where(x => x.BranchId == branchid && x.RecordId == districtid).ToList();
            bool result = false;
            if (districtlist.Count > 0)
            {
                if (string.IsNullOrEmpty(branchxrefid))
                {
                    result = true;
                }
                else
                {
                    if (!districtlist.Any(x => x.Id == branchxrefid))
                    {
                        result = true;
                    }
                }
            }
            return result;
        }
    }
}
