using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;

namespace Consensus.Finance
{
    /// <summary>
    ///     Encapsulates the <see cref="C4currencyRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalCurrencyModel : LocalModel<C4currencyRecord, String>, ICurrencyModel
    {
        #region fields

        /// <summary>
        ///     The value of the "CURR_SP_ID" field.
        /// </summary>
        private LocalSellingCompanyModel _sellingCompany;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<C4currencyRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Finance.Currency.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<C4currencyRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Finance.Currency.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<C4currencyRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Finance.Currency.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CURR_CODE" field.
        /// </summary>
        public String Code
        {
            get { return this.ModifiedData.Code; }
            set { this.ModifiedData.Code = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CURR_START_DATE" field.
        /// </summary>
        public DateTime? StartDate
        {
            get { return this.ModifiedData.StartDate; }
            set { this.ModifiedData.StartDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CURR_END_DATE" field.
        /// </summary>
        public DateTime? EndDate
        {
            get { return this.ModifiedData.EndDate; }
            set { this.ModifiedData.EndDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CURR_CONV_FACTOR" field.
        /// </summary>
        public Decimal ConversionFactor
        {
            get { return this.ModifiedData.ConvFactor; }
            set { this.ModifiedData.ConvFactor = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CURR_CONV_FACT2" field.
        /// </summary>
        public Decimal ConversionFactor2
        {
            get { return this.ModifiedData.ConvFact2; }
            set { this.ModifiedData.ConvFact2 = value; }
        }

        /// <summary>
        ///     Gets the The value of the "CURR_SP_ID" field.
        /// </summary>
        public LocalSellingCompanyModel SellingCompany
        {
            get
            {
                if (_sellingCompany == null && this.SellingCompanyId != null)
                    _sellingCompany = this.Provider.Common.SellingCompany.FetchById(this.SellingCompanyId);
                if (_sellingCompany == null)
                    _sellingCompany = this.Provider.Common.SellingCompany.Create();
                
                return _sellingCompany;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CURR_SP_ID" field.
        /// </summary>
        public String SellingCompanyId
        {
            get { return this.ModifiedData.SpId; }
            set
            {
                if (this.ModifiedData.SpId != value)
                     _sellingCompany = null;
                this.ModifiedData.SpId = value;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalCurrencyModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalCurrencyModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalCurrencyModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalCurrencyModel(LocalProvider provider, C4currencyRecord record) : base(provider, record)
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
            if (_sellingCompany != null)
            {
                _sellingCompany.Save();
                this.ModifiedData.SpId = _sellingCompany.Id == null && this.ModifiedData.SpId != null ? "" : _sellingCompany.Id;
            }
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
        ///     Gets or sets the value of the "CURR_CODE" field.
        /// </summary>
        System.String ICurrencyModel.Code
        {
            get { return this.Code; }
            set { this.Code = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CURR_START_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> ICurrencyModel.StartDate
        {
            get { return this.StartDate; }
            set { this.StartDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CURR_END_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> ICurrencyModel.EndDate
        {
            get { return this.EndDate; }
            set { this.EndDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CURR_CONV_FACTOR" field.
        /// </summary>
        System.Decimal ICurrencyModel.ConversionFactor
        {
            get { return this.ConversionFactor; }
            set { this.ConversionFactor = (System.Decimal)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CURR_CONV_FACT2" field.
        /// </summary>
        System.Decimal ICurrencyModel.ConversionFactor2
        {
            get { return this.ConversionFactor2; }
            set { this.ConversionFactor2 = (System.Decimal)value; }
        }

        /// <summary>
        ///     Gets the The value of the "CURR_SP_ID" field.
        /// </summary>
        Consensus.Common.ISellingCompanyModel ICurrencyModel.SellingCompany
        {
            get { return this.SellingCompany; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CURR_SP_ID" field.
        /// </summary>
        System.String ICurrencyModel.SellingCompanyId
        {
            get { return this.SellingCompanyId; }
            set { this.SellingCompanyId = (System.String)value; }
        }

        #endregion
    }
}
