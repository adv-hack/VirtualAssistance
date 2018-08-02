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
    /// <typeparam name="TId">
    ///     The data type of the unique value which distinctly identifies an instance of the data structure.
    /// </typeparam>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IRepository<TRecord, TId> : IRepository<TRecord> where TRecord : Record<TId>, new() where TId : IComparable<TId>, IEquatable<TId>
    {
        /// <summary>
        ///     Retrieves a single <typeparamref name="TRecord" /> instance from the data store.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <typeparamref name="TRecord" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <typeparamref name="TRecord" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        TRecord FetchById(TId id);
    }
}
