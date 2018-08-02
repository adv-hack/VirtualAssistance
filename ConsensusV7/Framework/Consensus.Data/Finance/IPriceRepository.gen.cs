using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="PricesRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IPriceRepository : IRepository<PricesRecord, String>
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

        void Modify(Consensus.Finance.PricesRecord record);

        void Create(Consensus.Finance.PricesRecord record);

        Consensus.Finance.PricesRecord RecalculateMemberFee(System.String productId, System.String plId, System.Nullable<System.DateTime> startDate, System.Nullable<System.DateTime> endDate, System.Int32 qtyTotal);

        /// <summary>
        ///     Retrieves a single <typeparamref name="TRecord" /> instance from the data store.
        /// </summary>
        /// <returns>
        ///     The <typeparamref name="TRecord" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.PricesRecord> FetchAllByProdidPriceListid(System.String productId, System.String plId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.PricesRecord" /> instances from the data store.
        /// </summary>
        /// <param name="plId">
        ///     The value which identifies the <see cref="!:PriceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.PricesRecord" /> instances that match the specified <paramref name="plId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.PricesRecord> FetchAllByPlId(System.String plId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.PricesRecord" /> instances from the data store.
        /// </summary>
        /// <param name="prodId">
        ///     The value which identifies the <see cref="!:PriceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.PricesRecord" /> instances that match the specified <paramref name="prodId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.PricesRecord> FetchAllByProdId(System.String prodId);

        #endregion
    }
}
