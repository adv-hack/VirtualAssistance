using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="CurrencyModel" /> object.
    /// </summary>
    public partial class LocalCurrencyFactory
    {

        /// <summary>
        ///     Retrieves a specific <see cref='CodeModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='CodeModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='CodeModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalCurrencyModel FetchByCodeAndSellingCompany(String code, String sellingCompany)
        {
            C4currencyRecord record = this.Provider.DataProvider.Finance.Currency.FetchByCodeandSellingCompany(code, sellingCompany);
            LocalCurrencyModel model = record == null ? null : new LocalCurrencyModel(this.Provider, record);
            return model;
        }
    }
}
