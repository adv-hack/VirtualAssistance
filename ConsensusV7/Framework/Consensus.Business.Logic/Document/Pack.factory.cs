using Consensus.Searches;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="PackModel" /> object.
    /// </summary>
    public partial class LocalPackFactory
    {
        /// <summary>
        /// Checks if iCalMessage name exist
        /// </summary>
        /// <param name="packName">Name of the iCalendar Message</param>        
        /// <param name="packId">Id of the iCalendar Message</param>
        /// <returns>Whether iCalendar Message's name exist in database</returns>
        public System.Boolean CheckIfNameExist(string packName, string packId)
        {
            var packs = this.FetchAll().ToList();
            var packList = packs.Where(x => x.Name != null && x.Name.Trim().ToLower() == packName.Trim().ToLower()).ToList();

            bool result = false;

            if (packList.Count > 0)
            {
                if (string.IsNullOrEmpty(packId))
                {
                    result = true;
                }
                
                else
                {
                    if (!packList.Any(x => x.Id == packId))
                    {
                        result = true;
                    }
                }
            }

            return result;

        }
    }
}
