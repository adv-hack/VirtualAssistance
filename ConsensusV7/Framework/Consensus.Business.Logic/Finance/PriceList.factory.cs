using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="PriceListModel" /> object.
    /// </summary>
    public partial class LocalPriceListFactory
    {
        /// <summary>
        ///     Retrieves a collection of <see cref='IPriceListModel' /> instances, that are referenced by the valid prices recorded against a given product.
        /// </summary>
        /// <param name="productId">
        ///     The unique identifier for the product whoses prices are inspected.
        /// </param>
        /// <returns>
        ///     The collection of <see cref='IPriceListModel' /> that are referenced by the valid prices recorded against the specified <paramref name="productId"/>.
        /// </returns>
        public IEnumerable<LocalPriceListModel> FetchAllByProductId(String productId)
        {
            IEnumerable<PriceListRecord> recordCollection = this.Provider.DataProvider.Finance.PriceList.FetchAllByProductId(productId);
            IEnumerable<LocalPriceListModel> modelCollection = recordCollection.Select(record => new LocalPriceListModel(this.Provider, record));
            return modelCollection;
        }
    }
}
