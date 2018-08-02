using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Contact
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class Country : Proxy<ICountryModel, String>
    {
        #region properties

        /// <summary>
        ///     Gets or sets the value of the "CO_NAME" field.
        /// </summary>
        public System.String Name
        {
            get { return this.Model.Name; }
            set { this.Model.Name = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CO_FORMAT" field.
        /// </summary>
        public System.String Format
        {
            get { return this.Model.Format; }
            set { this.Model.Format = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CO_LANGUAGE" field.
        /// </summary>
        public System.String Language
        {
            get { return this.Model.Language; }
            set { this.Model.Language = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CO_CURRENCY" field.
        /// </summary>
        public System.String Currency
        {
            get { return this.Model.Currency; }
            set { this.Model.Currency = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CO_COUNTRY_CODE" field.
        /// </summary>
        public System.String CountryCode
        {
            get { return this.Model.CountryCode; }
            set { this.Model.CountryCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CO_PCODE_LU" field.
        /// </summary>
        public System.Nullable<System.Byte> PcodeLu
        {
            get { return this.Model.PcodeLu; }
            set { this.Model.PcodeLu = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CO_VAT_CODE" field.
        /// </summary>
        public System.String VatCode
        {
            get { return this.Model.VatCode; }
            set { this.Model.VatCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CO_VAT_COUNTRY_CODE" field.
        /// </summary>
        public System.String VatCountryCode
        {
            get { return this.Model.VatCountryCode; }
            set { this.Model.VatCountryCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CO_COUNTRY_CODE_2" field.
        /// </summary>
        public System.String AltCountryCode
        {
            get { return this.Model.AltCountryCode; }
            set { this.Model.AltCountryCode = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal Country(ICountryModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Checks if Country's name or code exist.
        /// </summary>
        /// <param name="name">
        ///     Name of the country.
        /// </param>
        /// <param name="code">
        ///     Code of the country.
        /// </param>
        /// <param name="countryId">
        ///     Id of the country.
        /// </param>
        /// <returns>
        ///     Whether country's name or code exist in database.
        /// </returns>
        public static System.Object CheckIfCountryOrCodeExist(System.String name, System.String code, System.String countryId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Country.CheckIfCountryOrCodeExist(site,name,code,countryId);
        }

        /// <summary>
        ///     Checks if Country's name or code exist.
        /// </summary>
        /// <param name="name">
        ///     Name of the country.
        /// </param>
        /// <param name="code">
        ///     Code of the country.
        /// </param>
        /// <param name="countryId">
        ///     Id of the country.
        /// </param>
        /// <returns>
        ///     Whether country's name or code exist in database.
        /// </returns>
        public static System.Object CheckIfCountryOrCodeExist(ConsensusSite site, System.String name, System.String code, System.String countryId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Contact.Country.CheckIfCountryOrCodeExist(name,code,countryId);
        }

        /// <summary>
        ///     Creates a new <see cref="!:CountryModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:CountryModel" /> instance.
        /// </returns>
        public static Consensus.Contact.Country Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Country.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:CountryModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:CountryModel" /> instance.
        /// </returns>
        public static Consensus.Contact.Country Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Contact.ICountryModel model = provider.Contact.Country.Create();
            return model == null ? null : new Consensus.Contact.Country(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:CountryModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:CountryModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Country> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Country.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:CountryModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:CountryModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Country> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Contact.ICountryModel> collection = provider.Contact.Country.FetchAll();
            return collection.Select(model => new Consensus.Contact.Country(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:CountryModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:CountryModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CountryModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Contact.Country FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Country.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:CountryModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:CountryModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CountryModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Contact.Country FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Contact.ICountryModel model = provider.Contact.Country.FetchById(id);
            return model == null ? null : new Consensus.Contact.Country(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Country.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Contact.Country.GetTableName();
        }

        #endregion
    }
}
