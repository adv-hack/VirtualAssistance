using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="TrainProdXrefRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ITrainProdXrefRepository : IRepository<TrainProdXrefRecord, String>
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
        ///     Retrieves a collection of <see cref="T:Consensus.Contact.TrainProdXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="trainId">
        ///     The value which identifies the <see cref="!:TrainProdXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Contact.TrainProdXrefRecord" /> instances that match the specified <paramref name="trainId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.TrainProdXrefRecord> FetchAllByTrainId(System.String trainId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Contact.TrainProdXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="prodId">
        ///     The value which identifies the <see cref="!:TrainProdXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Contact.TrainProdXrefRecord" /> instances that match the specified <paramref name="prodId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.TrainProdXrefRecord> FetchAllByProdId(System.String prodId);

        #endregion
    }
}
