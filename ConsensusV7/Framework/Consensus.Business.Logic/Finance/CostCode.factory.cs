using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="CostCodeModel" /> object.
    /// </summary>
    public partial class LocalCostCodeFactory
    {
        /// <summary>
        /// Checks if Country's name or code exist
        /// </summary>
        /// <param name="code">Name of the country</param>
        /// <param name="sellingCompId">Code of the country</param>
        /// <param name="costCodeId">Id of the country</param>
        /// <returns>Whether country's name or code exist in database</returns>
        public bool CheckIfCodeExist(string code, string sellingCompId, string costCodeId)
        {
            var codes = this.FetchAll().ToList();
            var codeList = codes.Where(x => x.Code != null && x.Code.Trim().ToLower() == code.Trim().ToLower() && x.SelcoSpIdId.ToLower() == sellingCompId.ToLower()).ToList();

            bool result = false;

            if (codeList.Count > 0)
            {
                if (string.IsNullOrEmpty(costCodeId))
                {
                    result = true;
                }
                else
                {
                    if (!codeList.Any(x => x.Id == costCodeId))
                    {
                        result = true;
                    }
                }
            }

            return result;
            
        }
    }
}