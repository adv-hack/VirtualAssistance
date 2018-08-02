using Consensus.Searches;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="SmsMessageModel" /> object.
    /// </summary>
    public partial class LocalSmsMessageFactory
    {
        /// <summary>
        /// Checks if smsmessage name exist
        /// </summary>
        /// <param name="name">Name of the smsmessage</param>        
        /// <param name="smsmessageId">Id of the smsmessage</param>
        /// <returns>Whether smsmessage's name exist in database</returns>
        public System.Boolean CheckIfNameExist(string name, string smsmessageId)
        {
            var smsmessages = this.FetchAll().ToList();
            var smsmessageList = smsmessages.Where(x => x.Name != null && x.Name.Trim().ToLower() == name.Trim().ToLower()).ToList();

            bool result = false;

            if (smsmessageList.Count > 0)
            {
                if (Convert.ToInt32(smsmessageId) == 0)
                {
                    result = true;
                }
                else
                {
                    if (!smsmessageList.Any(x => x.Id == Convert.ToInt32(smsmessageId)))
                    {
                        result = true;
                    }
                }
            }

            return result;

        }
    }
}

    