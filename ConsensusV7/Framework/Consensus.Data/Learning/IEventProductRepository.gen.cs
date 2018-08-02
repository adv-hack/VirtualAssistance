using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="EventProductRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IEventProductRepository : IRepository<EventProductRecord, Int32>
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
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.EventProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="eventId">
        ///     The value which identifies the <see cref="!:EventProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.EventProductRecord" /> instances that match the specified <paramref name="eventId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.EventProductRecord> FetchAllByEventId(System.String eventId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.EventProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="prodId">
        ///     The value which identifies the <see cref="!:EventProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.EventProductRecord" /> instances that match the specified <paramref name="prodId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.EventProductRecord> FetchAllByProdId(System.String prodId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.EventProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="notes">
        ///     The value which identifies the <see cref="!:EventProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.EventProductRecord" /> instances that match the specified <paramref name="notes" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.EventProductRecord> FetchAllByNotes(System.String notes);

        #endregion
    }
}
