using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="PriceModel" /> object.
    /// </summary>
    public partial class LocalPriceFactory
    {
        /// <summary>
        ///     Retrieves a single <see cref='PriceModel' /> instance.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref='PriceModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PriceModel' /> instance that match the specified <paramref name='productId' />.
        /// </returns>
        public LocalPriceModel RecalculateMemberFee(String productId, String plId, DateTime? startDate, DateTime? endDate, Int32 qtyTotal)
        {
            PricesRecord record = this.Provider.DataProvider.Finance.Price.RecalculateMemberFee(productId, plId, startDate, endDate, qtyTotal);
            LocalPriceModel model = record == null ? null : new LocalPriceModel(this.Provider, record);
            return model;
        }
        /// <summary>
        ///     Retrieves a specific <see cref='PriceModel' /> instance.
        /// </summary>
        /// <param name="recType">
        ///     The recType value for the <see cref='PriceModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PriceModel' /> instance that matches the specified <paramref name='productId' />; or null, if no matching instance can be found.
        /// </returns>
        public IEnumerable<LocalPriceModel> FetchAllByProdidPriceListid(String productId, String plId)
        {
          IEnumerable<PricesRecord> recordCollection = this.Provider.DataProvider.Finance.Price.FetchAllByProdidPriceListid(productId, plId);
          IEnumerable<LocalPriceModel> modelCollection = recordCollection.Select(record => new LocalPriceModel(this.Provider, record));
          return modelCollection;
        }
    }
}
