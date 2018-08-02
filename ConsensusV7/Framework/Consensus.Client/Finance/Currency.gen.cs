using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;

namespace Consensus.Finance
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class Currency : Proxy<ICurrencyModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="SellingCompany" /> member.
        /// </summary>
        private Consensus.Common.SellingCompany _sellingCompany;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the value of the "CURR_CODE" field.
        /// </summary>
        public System.String Code
        {
            get { return this.Model.Code; }
            set { this.Model.Code = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CURR_START_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> StartDate
        {
            get { return this.Model.StartDate; }
            set { this.Model.StartDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CURR_END_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> EndDate
        {
            get { return this.Model.EndDate; }
            set { this.Model.EndDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CURR_CONV_FACTOR" field.
        /// </summary>
        public System.Decimal ConversionFactor
        {
            get { return this.Model.ConversionFactor; }
            set { this.Model.ConversionFactor = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CURR_CONV_FACT2" field.
        /// </summary>
        public System.Decimal ConversionFactor2
        {
            get { return this.Model.ConversionFactor2; }
            set { this.Model.ConversionFactor2 = value; }
        }

        /// <summary>
        ///     Gets the The value of the "CURR_SP_ID" field.
        /// </summary>
        public Consensus.Common.SellingCompany SellingCompany
        {
            get
            {
                if (_sellingCompany == null && this.Model.SellingCompany != null)
                    _sellingCompany = new Consensus.Common.SellingCompany(this.Model.SellingCompany);
                if (_sellingCompany == null)
                    _sellingCompany = Consensus.Common.SellingCompany.Create();
                return _sellingCompany;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CURR_SP_ID" field.
        /// </summary>
        public System.String SellingCompanyId
        {
            get { return this.Model.SellingCompanyId; }
            set { this.Model.SellingCompanyId = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal Currency(ICurrencyModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Retrieves a specific <see cref="!:CodeModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The <see cref="!:CodeModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Finance.Currency FetchByCodeAndSellingCompany(System.String code, System.String sellingCompany)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Currency.FetchByCodeAndSellingCompany(site,code,sellingCompany);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:CodeModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The <see cref="!:CodeModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Finance.Currency FetchByCodeAndSellingCompany(ConsensusSite site, System.String code, System.String sellingCompany)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Finance.ICurrencyModel model = provider.Finance.Currency.FetchByCodeAndSellingCompany(code,sellingCompany);
            return model == null ? null : new Consensus.Finance.Currency(model);
        }

        /// <summary>
        ///     Creates a new <see cref="!:CurrencyModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:CurrencyModel" /> instance.
        /// </returns>
        public static Consensus.Finance.Currency Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Currency.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:CurrencyModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:CurrencyModel" /> instance.
        /// </returns>
        public static Consensus.Finance.Currency Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Finance.ICurrencyModel model = provider.Finance.Currency.Create();
            return model == null ? null : new Consensus.Finance.Currency(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:CurrencyModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:CurrencyModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Finance.Currency> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Currency.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:CurrencyModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:CurrencyModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Finance.Currency> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.ICurrencyModel> collection = provider.Finance.Currency.FetchAll();
            return collection.Select(model => new Consensus.Finance.Currency(model));
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
        public static Consensus.Finance.Currency FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Currency.FetchById(site,id);
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
        public static Consensus.Finance.Currency FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Finance.ICurrencyModel model = provider.Finance.Currency.FetchById(id);
            return model == null ? null : new Consensus.Finance.Currency(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Currency.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Finance.Currency.GetTableName();
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
        public static IEnumerable<Consensus.Finance.Currency> FetchAllBySellingCompanyId(System.String sellingCompanyId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Currency.FetchAllBySellingCompanyId(site,sellingCompanyId);
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
        public static IEnumerable<Consensus.Finance.Currency> FetchAllBySellingCompanyId(ConsensusSite site, System.String sellingCompanyId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.ICurrencyModel> collection = provider.Finance.Currency.FetchAllBySellingCompanyId(sellingCompanyId);
            return collection.Select(model => new Consensus.Finance.Currency(model));
        }

        #endregion
    }
}
