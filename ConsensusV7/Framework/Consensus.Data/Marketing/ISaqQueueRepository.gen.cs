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
    public interface ISaqQueueRepository : IRepository<SaqQueryQueueRecord, Int64>
    {
        #region properties

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String TableName
        {
            get;
        }

        #endregion

        #region methods

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Marketing.SaqQueryQueueRecord" /> instances from the data store.
        /// </summary>
        /// <param name="qryId">
        ///     The value which identifies the <see cref="!:SaqQueueModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Marketing.SaqQueryQueueRecord" /> instances that match the specified <paramref name="qryId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.SaqQueryQueueRecord> FetchAllByQryId(System.Int64 qryId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Marketing.SaqQueryQueueRecord" /> instances from the data store.
        /// </summary>
        /// <param name="listId">
        ///     The value which identifies the <see cref="!:SaqQueueModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Marketing.SaqQueryQueueRecord" /> instances that match the specified <paramref name="listId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.SaqQueryQueueRecord> FetchAllByListId(System.String listId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Marketing.SaqQueryQueueRecord" /> instances from the data store.
        /// </summary>
        /// <param name="profKey">
        ///     The value which identifies the <see cref="!:SaqQueueModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Marketing.SaqQueryQueueRecord" /> instances that match the specified <paramref name="profKey" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.SaqQueryQueueRecord> FetchAllByProfKey(System.String profKey);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Marketing.SaqQueryQueueRecord" /> instances from the data store.
        /// </summary>
        /// <param name="profKeyOrg">
        ///     The value which identifies the <see cref="!:SaqQueueModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Marketing.SaqQueryQueueRecord" /> instances that match the specified <paramref name="profKeyOrg" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.SaqQueryQueueRecord> FetchAllByProfKeyOrg(System.String profKeyOrg);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Marketing.SaqQueryQueueRecord" /> instances from the data store.
        /// </summary>
        /// <param name="packId">
        ///     The value which identifies the <see cref="!:SaqQueueModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Marketing.SaqQueryQueueRecord" /> instances that match the specified <paramref name="packId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.SaqQueryQueueRecord> FetchAllByPackId(System.String packId);

        #endregion
    }
}
