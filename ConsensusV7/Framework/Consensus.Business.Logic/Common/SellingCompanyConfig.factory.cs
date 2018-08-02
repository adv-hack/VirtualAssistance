using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="SellingCompanyConfigModel" /> object.
    /// </summary>
    public partial class LocalSellingCompanyConfigFactory
    {
        /// <summary>
        ///     Retrieves a collection of <see cref='SellingCompanyConfigModel' /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref='SellingCompanyConfigModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='SellingCompanyConfigModel' /> instances that match the specified <paramref name='productId' />.
        /// </returns>
        internal IEnumerable<LocalSellingCompanyConfigModel> FetchAllBySellingCompanyId(String sellingCompanyId)
        {
            IEnumerable<SysConfigRecord> recordCollection = this.Provider.DataProvider.Common.SellingCompanyConfig.FetchAllBySellingCompanyId(sellingCompanyId);
            foreach (SysConfigRecord record in recordCollection)
                if (record != null)
                    yield return new LocalSellingCompanyConfigModel(this.Provider, record);
        }

        /// <summary>
        ///     Retrieves a specific <see cref='SellingCompanyConfigModel' /> instance.
        /// </summary>
        /// <param name="recType">
        ///     The recType value for the <see cref='SellingCompanyConfigModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='SellingCompanyConfigModel' /> instance that matches the specified <paramref name='sellingCompanyId' />; or null, if no matching instance can be found.
        /// </returns>
        public IEnumerable<LocalSellingCompanyConfigModel> FetchAllBySellingCompanyIdKeyName(String sellingCompanyId, String keyName)
        {
          IEnumerable<SysConfigRecord> recordCollection = this.Provider.DataProvider.Common.SellingCompanyConfig.FetchAllBySellingCompanyIdKeyName(sellingCompanyId, keyName);
          IEnumerable<LocalSellingCompanyConfigModel> modelCollection = recordCollection.Select(record => new LocalSellingCompanyConfigModel(this.Provider, record));
          return modelCollection;
        }
    }
}
