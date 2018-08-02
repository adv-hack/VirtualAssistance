using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Searches;

namespace Consensus.Document
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ICalMessageModel" /> object.
    /// </summary>
    public partial class LocalICalMessageFactory 
    {
        /// <summary>
        /// Checks if iCalMessage name exist
        /// </summary>
        /// <param name="name">Name of the iCalendar Message</param>        
        /// <param name="iCalMessageId">Id of the iCalendar Message</param>
        /// <returns>Whether iCalendar Message's name exist in database</returns>
        public System.Boolean CheckIfNameExist(string name, string iCalMessageId)
        {
            var iCalMessages = this.FetchAll().ToList();
            var iCalMessageList = iCalMessages.Where(x => x.Name != null && x.Name.Trim().ToLower() == name.Trim().ToLower()).ToList();

            bool result = false;

            if (iCalMessageList.Count > 0)
            {
                if (Convert.ToInt32(iCalMessageId) == 0)
                {
                    result = true;
                }
                else
                {
                    if (!iCalMessageList.Any(x => x.Id == Convert.ToInt32(iCalMessageId)))
                    {
                        result = true;
                    }
                }
            }

            return result;

        }        
    }
}
