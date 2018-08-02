using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus
{
    /// <summary>
    ///     Provides the abstraction for repositories which persist and retrieve the <typeparamref name="TRecord" /> data structure, in a Microsoft SQL Server database.
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
    public abstract partial class SqlServerRepository<TRecord, TId> : SqlServerRepository<TRecord>, IRepository<TRecord, TId> where TRecord : Record<TId>, new() where TId : IComparable<TId>, IEquatable<TId>
    {
        #region properties

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <typeparamref name="TRecord" />.
        /// </summary>
        protected abstract String TypeKeyName
        {
            get;
        }

        #endregion

        #region methods

        /// <summary>
        ///     Retrieves a single <typeparamref name="TRecord" /> instance from the data store.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <typeparamref name="TRecord" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <typeparamref name="TRecord" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public virtual TRecord FetchById(TId id)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.Fetch, "Id");
            this.MapParameterIn(command, this.TypeKeyName, id);
            return this.Execute(command).FirstOrDefault();
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Retrieves a single <typeparamref name="TRecord" /> instance from the data store.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <typeparamref name="TRecord" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <typeparamref name="TRecord" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        TRecord IRepository<TRecord, TId>.FetchById(TId id)
        {
            return this.FetchById(id);
        }

        #endregion
    }
}
