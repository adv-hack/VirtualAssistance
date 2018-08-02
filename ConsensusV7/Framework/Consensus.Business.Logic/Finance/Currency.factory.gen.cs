using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="CurrencyModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalCurrencyFactory : LocalFactory<LocalCurrencyModel, C4currencyRecord, String>, ICurrencyFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='CurrencyModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='CurrencyModel' /> instance.
        /// </returns>
        public LocalCurrencyModel Create()
        {
            return new LocalCurrencyModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='CurrencyModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='CurrencyModel' /> instances.
        /// </returns>
        public IEnumerable<LocalCurrencyModel> FetchAll()
        {
            IEnumerable<C4currencyRecord> recordCollection = this.Provider.DataProvider.Finance.Currency.FetchAll();
            foreach (C4currencyRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalCurrencyModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='CurrencyModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='CurrencyModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='CurrencyModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalCurrencyModel FetchById(String id)
        {
            C4currencyRecord record = this.Provider.DataProvider.Finance.Currency.FetchById(id);
            if (record == null)
                return null;
            return new LocalCurrencyModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='Currency/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Finance.Currency.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='CurrencyModel' /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref='CurrencyModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='CurrencyModel' /> instances that match the specified <paramref name='sellingCompanyId' />.
        /// </returns>
        public IEnumerable<LocalCurrencyModel> FetchAllBySellingCompanyId(String sellingCompanyId)
        {
            IEnumerable<C4currencyRecord> recordCollection = this.Provider.DataProvider.Finance.Currency.FetchAllBySpId(sellingCompanyId);
            foreach (C4currencyRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalCurrencyModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Retrieves a specific <see cref="!:CodeModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The <see cref="!:CodeModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Finance.ICurrencyModel ICurrencyFactory.FetchByCodeAndSellingCompany(System.String code, System.String sellingCompany)
        {
            return this.FetchByCodeAndSellingCompany(code, sellingCompany);
        }

        /// <summary>
        ///     Creates a new <see cref="!:CurrencyModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:CurrencyModel" /> instance.
        /// </returns>
        Consensus.Finance.ICurrencyModel ICurrencyFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:CurrencyModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:CurrencyModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.ICurrencyModel> ICurrencyFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:CurrencyModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:CurrencyModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CurrencyModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Finance.ICurrencyModel ICurrencyFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String ICurrencyFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:CurrencyModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:CurrencyModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CurrencyModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.ICurrencyModel> ICurrencyFactory.FetchAllBySellingCompanyId(System.String sellingCompanyId)
        {
            return this.FetchAllBySellingCompanyId(sellingCompanyId);
        }

        #endregion
    }
}
