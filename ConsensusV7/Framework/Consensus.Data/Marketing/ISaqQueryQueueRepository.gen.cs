using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="SaqQueryQueueRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ISaqQueryQueueRepository : IRepository<SaqQueryQueueRecord, Int64>
    {
        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Marketing.SaqQueryQueueRecord" /> instances from the data store.
        /// </summary>
        /// <param name="qryId">
        ///     The value which identifies the <see cref="!:SaqQueryQueueModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Marketing.SaqQueryQueueRecord" /> instances that match the specified <paramref name="qryId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.SaqQueryQueueRecord> FetchAllByQryId(System.Int64 qryId);
    }
}
