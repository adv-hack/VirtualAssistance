using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus
{
    /// <summary>
    ///     Supports the persistence and retrieval of data structures.
    /// </summary>
    /// <typeparam name="TRecord">
    ///     The type of data structure which is persisted within the repository.
    /// </typeparam>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IRepository<TRecord> : IRepository where TRecord : Record, new()
    {
        /// <summary>
        ///     Retrieves all existing <typeparamref name="TRecord" /> instances from the data store.
        /// </summary>
        /// <returns>
        ///     The enumerable collection of <typeparamref name="TRecord" /> instances that are persisted within the data store.
        /// </returns>
        System.Collections.Generic.IEnumerable<TRecord> FetchAll();

        /// <summary>
        ///     Creates a new <typeparamref name="TRecord" /> instance within the data store.
        /// </summary>
        /// <param name="record">
        ///     The data structure to be created within the data store.
        /// </param>
        void Create(TRecord record);

        /// <summary>
        ///     Modifies an existing <typeparamref name="TRecord" /> instance within the data store.
        /// </summary>
        /// <param name="record">
        ///     The data structure to be modified within the data store.
        /// </param>
        void Modify(TRecord record);

        /// <summary>
        ///     Removes an existing <typeparamref name="TRecord" /> instance from the data store.
        /// </summary>
        /// <param name="record">
        ///     The data structure to be removed from the data store.
        /// </param>
        void RemoveById(TRecord record);
    }
}
