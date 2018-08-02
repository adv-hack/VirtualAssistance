using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="PackXrefRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IPackXrefRepository : IRepository<PackXrefRecord, String>
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
        ///     Retrieves a collection of <see cref="T:Consensus.Document.PackXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="packId">
        ///     The value which identifies the <see cref="!:PackXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Document.PackXrefRecord" /> instances that match the specified <paramref name="packId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.PackXrefRecord> FetchAllByPackId(System.String packId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Document.PackXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="litId">
        ///     The value which identifies the <see cref="!:PackXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Document.PackXrefRecord" /> instances that match the specified <paramref name="litId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.PackXrefRecord> FetchAllByLitId(System.String litId);

        System.Collections.Generic.IEnumerable<Consensus.Document.PackXrefRecord> FetchAllBySmsId(System.Nullable<System.Int32> smsId);

        System.Collections.Generic.IEnumerable<Consensus.Document.PackXrefRecord> FetchAllByIcmId(System.Nullable<System.Int32> icmId);

        #endregion
    }
}
