using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="HistoryLinkModel" /> object.
    /// </summary>
    public partial class LocalHistoryLinkFactory
    {       
        
        /// <summary>
        ///     Retrieves a specific <see cref='CodeModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='CodeModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='CodeModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalHistoryLinkModel FetchByUserIDAndURL(int userId, String URL)
        {
            HistorylinkRecord record = this.Provider.DataProvider.UserInterface.HistoryLink.FetchByUserIDandURL(userId, URL);
            LocalHistoryLinkModel model = record == null ? null : new LocalHistoryLinkModel(this.Provider, record);
            return model;
        }

    }
}
