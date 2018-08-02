using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Learning;

namespace Consensus.Finance
{
    /// <summary>
    ///     Encapsulates the <see cref="PricesRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalPriceModel : LocalModel<PricesRecord, String>, IPriceModel
    {
        #region fields

        /// <summary>
        ///     The value of the "PRS_PL_ID" field.
        /// </summary>
        private LocalPriceListModel _priceList;

        /// <summary>
        ///     The value of the "PRS_PROD_ID" field.
        /// </summary>
        private LocalProductModel _product;

        /// <summary>
        ///     The value of the "PRS_VAT_CODE" field.
        /// </summary>
        private LocalCodeModel _vatCode;

        /// <summary>
        ///     The value of the "PRS_REGION" field.
        /// </summary>
        private LocalCodeModel _region;

        /// <summary>
        ///     The collection of <see cref="ElementModel" /> instances that reference this <see cref="PriceModel" />.
        /// </summary>
        private LocalCollection<LocalElementModel, IElementModel> _elements;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<PricesRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Finance.Price.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<PricesRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Finance.Price.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<PricesRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Finance.Price.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "PRS_PL_ID" field.
        /// </summary>
        public LocalPriceListModel PriceList
        {
            get
            {
                if (_priceList == null && this.PriceListId != null)
                    _priceList = this.Provider.Finance.PriceList.FetchById(this.PriceListId);
                if (_priceList == null)
                    _priceList = this.Provider.Finance.PriceList.Create();
                
                return _priceList;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PRS_PL_ID" field.
        /// </summary>
        public String PriceListId
        {
            get { return this.ModifiedData.PlId; }
            set
            {
                if (this.ModifiedData.PlId != value)
                     _priceList = null;
                this.ModifiedData.PlId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "PRS_PROD_ID" field.
        /// </summary>
        public LocalProductModel Product
        {
            get
            {
                if (_product == null && this.ProductId != null)
                    _product = this.Provider.Learning.Product.FetchById(this.ProductId);
                if (_product == null)
                    _product = this.Provider.Learning.Product.Create();
                
                return _product;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PRS_PROD_ID" field.
        /// </summary>
        public String ProductId
        {
            get { return this.ModifiedData.ProdId; }
            set
            {
                if (this.ModifiedData.ProdId != value)
                     _product = null;
                this.ModifiedData.ProdId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "PRS_PRICE" field.
        /// </summary>
        public Decimal Amount
        {
            get { return this.ModifiedData.Price; }
            set { this.ModifiedData.Price = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PRS_COST_PRICE" field.
        /// </summary>
        public Decimal CostPrice
        {
            get { return this.ModifiedData.CostPrice; }
            set { this.ModifiedData.CostPrice = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PRS_VAT_CODE" field.
        /// </summary>
        public LocalCodeModel VatCode
        {
            get
            {
                if (_vatCode == null && !String.IsNullOrEmpty(this.VatCodeCode))
                    _vatCode = this.Provider.Common.Code.FetchByTypeAndCode("VATCD", this.VatCodeCode);
                if (_vatCode == null)
                    _vatCode = this.Provider.Common.Code.Create("VATCD");
                return _vatCode;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PRS_VAT_CODE" field.
        /// </summary>
        public String VatCodeCode
        {
            get { return this.ModifiedData.VatCode; }
            set
            {
                if (this.ModifiedData.VatCode != value)
                     _vatCode = null;
                this.ModifiedData.VatCode = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "PRS_RETAIL_PRICE" field.
        /// </summary>
        public Decimal RetailPrice
        {
            get { return this.ModifiedData.RetailPrice; }
            set { this.ModifiedData.RetailPrice = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PRS_PRICE_A" field.
        /// </summary>
        public Decimal PriceA
        {
            get { return this.ModifiedData.PriceA; }
            set { this.ModifiedData.PriceA = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PRS_QTY_MIN" field.
        /// </summary>
        public Int32? QtyMin
        {
            get { return this.ModifiedData.QtyMin; }
            set { this.ModifiedData.QtyMin = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PRS_QTY_MAX" field.
        /// </summary>
        public Int32? QtyMax
        {
            get { return this.ModifiedData.QtyMax; }
            set { this.ModifiedData.QtyMax = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PRS_VALID_FROM" field.
        /// </summary>
        public DateTime? ValidFrom
        {
            get { return this.ModifiedData.ValidFrom; }
            set { this.ModifiedData.ValidFrom = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PRS_VALID_UNTIL" field.
        /// </summary>
        public DateTime? ValidUntil
        {
            get { return this.ModifiedData.ValidUntil; }
            set { this.ModifiedData.ValidUntil = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PRS_VAT_CODE2" field.
        /// </summary>
        public String VatCode2
        {
            get { return this.ModifiedData.VatCode2; }
            set { this.ModifiedData.VatCode2 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PRS_CURR_TYPE" field.
        /// </summary>
        public String CurrType
        {
            get { return this.ModifiedData.CurrType; }
            set { this.ModifiedData.CurrType = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PRS_START" field.
        /// </summary>
        public Int32? Start
        {
            get { return this.ModifiedData.Start; }
            set { this.ModifiedData.Start = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PRS_END" field.
        /// </summary>
        public Int32? End
        {
            get { return this.ModifiedData.End; }
            set { this.ModifiedData.End = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PRS_VALID_DATE" field.
        /// </summary>
        public Byte ValidDate
        {
            get { return this.ModifiedData.ValidDate; }
            set { this.ModifiedData.ValidDate = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PRS_REGION" field.
        /// </summary>
        public LocalCodeModel Region
        {
            get
            {
                if (_region == null && !String.IsNullOrEmpty(this.RegionCode))
                    _region = this.Provider.Common.Code.FetchByTypeAndCode("ROREG", this.RegionCode);
                if (_region == null)
                    _region = this.Provider.Common.Code.Create("ROREG");
                return _region;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PRS_REGION" field.
        /// </summary>
        public String RegionCode
        {
            get { return this.ModifiedData.Region; }
            set
            {
                if (this.ModifiedData.Region != value)
                     _region = null;
                this.ModifiedData.Region = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "PRS_TYPE" field.
        /// </summary>
        public Byte? Type
        {
            get { return this.ModifiedData.Type; }
            set { this.ModifiedData.Type = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ElementModel" /> instances that reference this <see cref="PriceModel" />.
        /// </summary>
        public LocalCollection<LocalElementModel, IElementModel> Elements
        {
            get
            {
                if (_elements == null)
                    _elements = new LocalCollection<LocalElementModel, IElementModel>(this.Provider.Learning.Element.FetchAllByPriceIdId(this.Id));
                
                return _elements;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalPriceModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalPriceModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalPriceModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalPriceModel(LocalProvider provider, PricesRecord record) : base(provider, record)
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
            if (_vatCode != null)
            {
                _vatCode.Save();
                this.ModifiedData.VatCode = _vatCode.Value1;
            }
            if (_region != null)
            {
                _region.Save();
                this.ModifiedData.Region = _region.Value1;
            }
            if (_priceList != null)
            {
                _priceList.Save();
                this.ModifiedData.PlId = _priceList.Id == null && this.ModifiedData.PlId != null ? "" : _priceList.Id;
            }
            if (_product != null)
            {
                _product.Save();
                this.ModifiedData.ProdId = _product.Id == null && this.ModifiedData.ProdId != null ? "" : _product.Id;
            }
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
            if (_elements != null)
                _elements.Execute(obj => obj.PriceIdId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the The value of the "PRS_TYPE" field.
        /// </summary>
        Consensus.Common.ICodeModel IPriceModel.TypeModel
        {
            get { return this.TypeModel; }
        }

        /// <summary>
        ///     Gets the The value of the "PRS_PL_ID" field.
        /// </summary>
        Consensus.Finance.IPriceListModel IPriceModel.PriceList
        {
            get { return this.PriceList; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PRS_PL_ID" field.
        /// </summary>
        System.String IPriceModel.PriceListId
        {
            get { return this.PriceListId; }
            set { this.PriceListId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PRS_PROD_ID" field.
        /// </summary>
        Consensus.Learning.IProductModel IPriceModel.Product
        {
            get { return this.Product; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PRS_PROD_ID" field.
        /// </summary>
        System.String IPriceModel.ProductId
        {
            get { return this.ProductId; }
            set { this.ProductId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PRS_PRICE" field.
        /// </summary>
        System.Decimal IPriceModel.Amount
        {
            get { return this.Amount; }
            set { this.Amount = (System.Decimal)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PRS_COST_PRICE" field.
        /// </summary>
        System.Decimal IPriceModel.CostPrice
        {
            get { return this.CostPrice; }
            set { this.CostPrice = (System.Decimal)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PRS_VAT_CODE" field.
        /// </summary>
        Consensus.Common.ICodeModel IPriceModel.VatCode
        {
            get { return this.VatCode; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PRS_VAT_CODE" field.
        /// </summary>
        System.String IPriceModel.VatCodeCode
        {
            get { return this.VatCodeCode; }
            set { this.VatCodeCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PRS_RETAIL_PRICE" field.
        /// </summary>
        System.Decimal IPriceModel.RetailPrice
        {
            get { return this.RetailPrice; }
            set { this.RetailPrice = (System.Decimal)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PRS_PRICE_A" field.
        /// </summary>
        System.Decimal IPriceModel.PriceA
        {
            get { return this.PriceA; }
            set { this.PriceA = (System.Decimal)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PRS_QTY_MIN" field.
        /// </summary>
        System.Nullable<System.Int32> IPriceModel.QtyMin
        {
            get { return this.QtyMin; }
            set { this.QtyMin = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PRS_QTY_MAX" field.
        /// </summary>
        System.Nullable<System.Int32> IPriceModel.QtyMax
        {
            get { return this.QtyMax; }
            set { this.QtyMax = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PRS_VALID_FROM" field.
        /// </summary>
        System.Nullable<System.DateTime> IPriceModel.ValidFrom
        {
            get { return this.ValidFrom; }
            set { this.ValidFrom = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PRS_VALID_UNTIL" field.
        /// </summary>
        System.Nullable<System.DateTime> IPriceModel.ValidUntil
        {
            get { return this.ValidUntil; }
            set { this.ValidUntil = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PRS_VAT_CODE2" field.
        /// </summary>
        System.String IPriceModel.VatCode2
        {
            get { return this.VatCode2; }
            set { this.VatCode2 = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PRS_CURR_TYPE" field.
        /// </summary>
        System.String IPriceModel.CurrType
        {
            get { return this.CurrType; }
            set { this.CurrType = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PRS_START" field.
        /// </summary>
        System.Nullable<System.Int32> IPriceModel.Start
        {
            get { return this.Start; }
            set { this.Start = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PRS_END" field.
        /// </summary>
        System.Nullable<System.Int32> IPriceModel.End
        {
            get { return this.End; }
            set { this.End = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PRS_VALID_DATE" field.
        /// </summary>
        System.Byte IPriceModel.ValidDate
        {
            get { return this.ValidDate; }
            set { this.ValidDate = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PRS_REGION" field.
        /// </summary>
        Consensus.Common.ICodeModel IPriceModel.Region
        {
            get { return this.Region; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PRS_REGION" field.
        /// </summary>
        System.String IPriceModel.RegionCode
        {
            get { return this.RegionCode; }
            set { this.RegionCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PRS_TYPE" field.
        /// </summary>
        System.Nullable<System.Byte> IPriceModel.Type
        {
            get { return this.Type; }
            set { this.Type = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ElementModel" /> instances that reference this <see cref="!:PriceModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IElementModel> IPriceModel.Elements
        {
            get { return this.Elements; }
        }

        #endregion
    }
}
