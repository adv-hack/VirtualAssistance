using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="HistorylinkRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IHistoryLinkRepository : IRepository<HistorylinkRecord, Int32>
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
        ///     Removes an existing <typeparamref name="TRecord" /> instance from the data store.
        /// </summary>
        void CleanUp(System.Int32 userId);

        /// <summary>
        ///     Retrieves a single <typeparamref name="TRecord" /> instance from the data store.
        /// </summary>
        /// <returns>
        ///     The <typeparamref name="TRecord" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.UserInterface.HistorylinkRecord FetchByUserIDandURL(System.Int32 userId, System.String URL);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.UserInterface.HistorylinkRecord" /> instances from the data store.
        /// </summary>
        /// <param name="userId">
        ///     The value which identifies the <see cref="!:HistoryLinkModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.UserInterface.HistorylinkRecord" /> instances that match the specified <paramref name="userId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.UserInterface.HistorylinkRecord> FetchAllByUserId(System.Int32 userId);

        #endregion
    }
}
