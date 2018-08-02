using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Search
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="SystemSearchesGridColumnsRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ISearchColumnRepository : IRepository<SystemSearchesGridColumnsRecord, Int32>
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
        ///     Retrieves a collection of <see cref="T:Consensus.Search.SystemSearchesGridColumnsRecord" /> instances from the data store.
        /// </summary>
        /// <param name="syssId">
        ///     The value which identifies the <see cref="!:SearchColumnModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Search.SystemSearchesGridColumnsRecord" /> instances that match the specified <paramref name="syssId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Search.SystemSearchesGridColumnsRecord> FetchAllBySyssId(System.Int32 syssId);

        #endregion
    }
}
