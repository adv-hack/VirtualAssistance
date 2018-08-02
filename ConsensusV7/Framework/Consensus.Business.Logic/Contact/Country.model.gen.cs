using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Encapsulates the <see cref="CountryRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalCountryModel : LocalModel<CountryRecord, String>, ICountryModel
    {
        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<CountryRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Contact.Country.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<CountryRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Contact.Country.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<CountryRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Contact.Country.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CO_NAME" field.
        /// </summary>
        public String Name
        {
            get { return this.ModifiedData.Name; }
            set { this.ModifiedData.Name = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CO_FORMAT" field.
        /// </summary>
        public String Format
        {
            get { return this.ModifiedData.Format; }
            set { this.ModifiedData.Format = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CO_LANGUAGE" field.
        /// </summary>
        public String Language
        {
            get { return this.ModifiedData.Language; }
            set { this.ModifiedData.Language = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CO_CURRENCY" field.
        /// </summary>
        public String Currency
        {
            get { return this.ModifiedData.Currency; }
            set { this.ModifiedData.Currency = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CO_COUNTRY_CODE" field.
        /// </summary>
        public String CountryCode
        {
            get { return this.ModifiedData.CountryCode; }
            set { this.ModifiedData.CountryCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CO_PCODE_LU" field.
        /// </summary>
        public Byte? PcodeLu
        {
            get { return this.ModifiedData.PcodeLu; }
            set { this.ModifiedData.PcodeLu = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CO_VAT_CODE" field.
        /// </summary>
        public String VatCode
        {
            get { return this.ModifiedData.VatCode; }
            set { this.ModifiedData.VatCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CO_VAT_COUNTRY_CODE" field.
        /// </summary>
        public String VatCountryCode
        {
            get { return this.ModifiedData.VatCountryCode; }
            set { this.ModifiedData.VatCountryCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CO_COUNTRY_CODE_2" field.
        /// </summary>
        public String AltCountryCode
        {
            get { return this.ModifiedData.CountryCode2; }
            set { this.ModifiedData.CountryCode2 = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalCountryModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalCountryModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalCountryModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalCountryModel(LocalProvider provider, CountryRecord record) : base(provider, record)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Resolves the dependencies by means of persisting all models that this model is referencing.
        /// </summary>
        protected override void ResolveGeneratedDependency()
        {
            base.ResolveGeneratedDependency();
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets or sets the value of the "CO_NAME" field.
        /// </summary>
        System.String ICountryModel.Name
        {
            get { return this.Name; }
            set { this.Name = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CO_FORMAT" field.
        /// </summary>
        System.String ICountryModel.Format
        {
            get { return this.Format; }
            set { this.Format = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CO_LANGUAGE" field.
        /// </summary>
        System.String ICountryModel.Language
        {
            get { return this.Language; }
            set { this.Language = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CO_CURRENCY" field.
        /// </summary>
        System.String ICountryModel.Currency
        {
            get { return this.Currency; }
            set { this.Currency = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CO_COUNTRY_CODE" field.
        /// </summary>
        System.String ICountryModel.CountryCode
        {
            get { return this.CountryCode; }
            set { this.CountryCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CO_PCODE_LU" field.
        /// </summary>
        System.Nullable<System.Byte> ICountryModel.PcodeLu
        {
            get { return this.PcodeLu; }
            set { this.PcodeLu = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CO_VAT_CODE" field.
        /// </summary>
        System.String ICountryModel.VatCode
        {
            get { return this.VatCode; }
            set { this.VatCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CO_VAT_COUNTRY_CODE" field.
        /// </summary>
        System.String ICountryModel.VatCountryCode
        {
            get { return this.VatCountryCode; }
            set { this.VatCountryCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CO_COUNTRY_CODE_2" field.
        /// </summary>
        System.String ICountryModel.AltCountryCode
        {
            get { return this.AltCountryCode; }
            set { this.AltCountryCode = (System.String)value; }
        }

        #endregion
    }
}
