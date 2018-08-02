using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Activities
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="C4textModel" /> object.
    /// </summary>
    public partial class LocalC4textFactory
    {
        public IEnumerable<LocalC4textModel> FetchAllByOwnerUrlAndOwnerId(String ownerUrl, String ownerId)
        {
            IEnumerable<C4textRecord> recordCollection = this.Provider.DataProvider.Activities.C4text.FetchAllByOwnerUrlAndOwnerId(ownerUrl, ownerId);
            IEnumerable<LocalC4textModel> modelCollection = recordCollection.Select(record => new LocalC4textModel(this.Provider, record));
            return modelCollection;
        }
    }
}
