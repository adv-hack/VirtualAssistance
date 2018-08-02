using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Other
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="BatchXrefRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IBatchXrefRepository : IRepository<BatchXrefRecord, Int32>
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
        ///     Retrieves a collection of <see cref="T:Consensus.Other.BatchXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="batId">
        ///     The value which identifies the <see cref="!:BatchXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Other.BatchXrefRecord" /> instances that match the specified <paramref name="batId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Other.BatchXrefRecord> FetchAllByBatId(System.String batId);

        #endregion
    }
}
