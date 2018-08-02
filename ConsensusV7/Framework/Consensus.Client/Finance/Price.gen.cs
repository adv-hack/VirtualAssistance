using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Learning;

namespace Consensus.Finance
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class Price : Proxy<IPriceModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="TypeModel" /> member.
        /// </summary>
        private Consensus.Common.Code _typeModel;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="PriceList" /> member.
        /// </summary>
        private Consensus.Finance.PriceList _priceList;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Product" /> member.
        /// </summary>
        private Consensus.Learning.Product _product;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="VatCode" /> member.
        /// </summary>
        private Consensus.Common.Code _vatCode;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Region" /> member.
        /// </summary>
        private Consensus.Common.Code _region;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Elements" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Element, Consensus.Learning.IElementModel> _elements;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the The value of the "PRS_TYPE" field.
        /// </summary>
        public Consensus.Common.Code TypeModel
        {
            get
            {
                if (_typeModel == null && this.Model.TypeModel != null)
                    _typeModel = new Consensus.Common.Code(this.Model.TypeModel);
                if (_typeModel == null)
                    _typeModel = Consensus.Common.Code.Create();
                return _typeModel;
            }
        }

        /// <summary>
        ///     Gets the The value of the "PRS_PL_ID" field.
        /// </summary>
        public Consensus.Finance.PriceList PriceList
        {
            get
            {
                if (_priceList == null && this.Model.PriceList != null)
                    _priceList = new Consensus.Finance.PriceList(this.Model.PriceList);
                if (_priceList == null)
                    _priceList = Consensus.Finance.PriceList.Create();
                return _priceList;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PRS_PL_ID" field.
        /// </summary>
        public System.String PriceListId
        {
            get { return this.Model.PriceListId; }
            set { this.Model.PriceListId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PRS_PROD_ID" field.
        /// </summary>
        public Consensus.Learning.Product Product
        {
            get
            {
                if (_product == null && this.Model.Product != null)
                    _product = new Consensus.Learning.Product(this.Model.Product);
                if (_product == null)
                    _product = Consensus.Learning.Product.Create();
                return _product;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PRS_PROD_ID" field.
        /// </summary>
        public System.String ProductId
        {
            get { return this.Model.ProductId; }
            set { this.Model.ProductId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PRS_PRICE" field.
        /// </summary>
        public System.Decimal Amount
        {
            get { return this.Model.Amount; }
            set { this.Model.Amount = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PRS_COST_PRICE" field.
        /// </summary>
        public System.Decimal CostPrice
        {
            get { return this.Model.CostPrice; }
            set { this.Model.CostPrice = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PRS_VAT_CODE" field.
        /// </summary>
        public Consensus.Common.Code VatCode
        {
            get
            {
                if (_vatCode == null && this.Model.VatCode != null)
                    _vatCode = new Consensus.Common.Code(this.Model.VatCode);
                if (_vatCode == null)
                    _vatCode = Consensus.Common.Code.Create();
                return _vatCode;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PRS_VAT_CODE" field.
        /// </summary>
        public System.String VatCodeCode
        {
            get { return this.Model.VatCodeCode; }
            set { this.Model.VatCodeCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PRS_RETAIL_PRICE" field.
        /// </summary>
        public System.Decimal RetailPrice
        {
            get { return this.Model.RetailPrice; }
            set { this.Model.RetailPrice = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PRS_PRICE_A" field.
        /// </summary>
        public System.Decimal PriceA
        {
            get { return this.Model.PriceA; }
            set { this.Model.PriceA = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PRS_QTY_MIN" field.
        /// </summary>
        public System.Nullable<System.Int32> QtyMin
        {
            get { return this.Model.QtyMin; }
            set { this.Model.QtyMin = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PRS_QTY_MAX" field.
        /// </summary>
        public System.Nullable<System.Int32> QtyMax
        {
            get { return this.Model.QtyMax; }
            set { this.Model.QtyMax = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PRS_VALID_FROM" field.
        /// </summary>
        public System.Nullable<System.DateTime> ValidFrom
        {
            get { return this.Model.ValidFrom; }
            set { this.Model.ValidFrom = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PRS_VALID_UNTIL" field.
        /// </summary>
        public System.Nullable<System.DateTime> ValidUntil
        {
            get { return this.Model.ValidUntil; }
            set { this.Model.ValidUntil = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PRS_VAT_CODE2" field.
        /// </summary>
        public System.String VatCode2
        {
            get { return this.Model.VatCode2; }
            set { this.Model.VatCode2 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PRS_CURR_TYPE" field.
        /// </summary>
        public System.String CurrType
        {
            get { return this.Model.CurrType; }
            set { this.Model.CurrType = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PRS_START" field.
        /// </summary>
        public System.Nullable<System.Int32> Start
        {
            get { return this.Model.Start; }
            set { this.Model.Start = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PRS_END" field.
        /// </summary>
        public System.Nullable<System.Int32> End
        {
            get { return this.Model.End; }
            set { this.Model.End = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PRS_VALID_DATE" field.
        /// </summary>
        public System.Byte ValidDate
        {
            get { return this.Model.ValidDate; }
            set { this.Model.ValidDate = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PRS_REGION" field.
        /// </summary>
        public Consensus.Common.Code Region
        {
            get
            {
                if (_region == null && this.Model.Region != null)
                    _region = new Consensus.Common.Code(this.Model.Region);
                if (_region == null)
                    _region = Consensus.Common.Code.Create();
                return _region;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PRS_REGION" field.
        /// </summary>
        public System.String RegionCode
        {
            get { return this.Model.RegionCode; }
            set { this.Model.RegionCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PRS_TYPE" field.
        /// </summary>
        public System.Nullable<System.Byte> Type
        {
            get { return this.Model.Type; }
            set { this.Model.Type = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ElementModel" /> instances that reference this <see cref="!:PriceModel" />.
        /// </summary>
        public Collection<Consensus.Learning.Element> Elements
        {
            get
            {
                if (_elements == null)
                    _elements = new ProxyCollection<Consensus.Learning.Element, Consensus.Learning.IElementModel>(this.Model.Elements, model => new Consensus.Learning.Element(model));
                return _elements;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal Price(IPriceModel model) : base(model)
        {
        }

        #endregion

        #region methods

        public static Consensus.Finance.Price RecalculateMemberFee(System.String productId, System.String plId, System.Nullable<System.DateTime> startDate, System.Nullable<System.DateTime> endDate, System.Int32 qtyTotal)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Price.RecalculateMemberFee(site,productId,plId,startDate,endDate,qtyTotal);
        }

        public static Consensus.Finance.Price RecalculateMemberFee(ConsensusSite site, System.String productId, System.String plId, System.Nullable<System.DateTime> startDate, System.Nullable<System.DateTime> endDate, System.Int32 qtyTotal)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Finance.IPriceModel model = provider.Finance.Price.RecalculateMemberFee(productId,plId,startDate,endDate,qtyTotal);
            return model == null ? null : new Consensus.Finance.Price(model);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:PriceModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The <see cref="!:PriceModel" /> instance that matches the specified <paramref name="productId" />; or null, if no matching instance can be found.
        /// </returns>
        public static IEnumerable<Consensus.Finance.Price> FetchAllByProdidPriceListid(System.String productId, System.String plId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Price.FetchAllByProdidPriceListid(site,productId,plId);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:PriceModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The <see cref="!:PriceModel" /> instance that matches the specified <paramref name="productId" />; or null, if no matching instance can be found.
        /// </returns>
        public static IEnumerable<Consensus.Finance.Price> FetchAllByProdidPriceListid(ConsensusSite site, System.String productId, System.String plId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IPriceModel> collection = provider.Finance.Price.FetchAllByProdidPriceListid(productId,plId);
            return collection.Select(model => new Consensus.Finance.Price(model));
        }

        /// <summary>
        ///     Creates a new <see cref="!:PriceModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PriceModel" /> instance.
        /// </returns>
        public static Consensus.Finance.Price Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Price.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:PriceModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PriceModel" /> instance.
        /// </returns>
        public static Consensus.Finance.Price Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Finance.IPriceModel model = provider.Finance.Price.Create();
            return model == null ? null : new Consensus.Finance.Price(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PriceModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PriceModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Finance.Price> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Price.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PriceModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PriceModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Finance.Price> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IPriceModel> collection = provider.Finance.Price.FetchAll();
            return collection.Select(model => new Consensus.Finance.Price(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:PriceModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PriceModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PriceModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Finance.Price FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Price.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:PriceModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PriceModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PriceModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Finance.Price FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Finance.IPriceModel model = provider.Finance.Price.FetchById(id);
            return model == null ? null : new Consensus.Finance.Price(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Price.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Finance.Price.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PriceModel" /> instances.
        /// </summary>
        /// <param name="priceListId">
        ///     The value which identifies the <see cref="!:PriceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PriceModel" /> instances that match the specified <paramref name="priceListId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.Price> FetchAllByPriceListId(System.String priceListId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Price.FetchAllByPriceListId(site,priceListId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PriceModel" /> instances.
        /// </summary>
        /// <param name="priceListId">
        ///     The value which identifies the <see cref="!:PriceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PriceModel" /> instances that match the specified <paramref name="priceListId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.Price> FetchAllByPriceListId(ConsensusSite site, System.String priceListId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IPriceModel> collection = provider.Finance.Price.FetchAllByPriceListId(priceListId);
            return collection.Select(model => new Consensus.Finance.Price(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PriceModel" /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref="!:PriceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PriceModel" /> instances that match the specified <paramref name="productId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.Price> FetchAllByProductId(System.String productId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Price.FetchAllByProductId(site,productId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PriceModel" /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref="!:PriceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PriceModel" /> instances that match the specified <paramref name="productId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.Price> FetchAllByProductId(ConsensusSite site, System.String productId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IPriceModel> collection = provider.Finance.Price.FetchAllByProductId(productId);
            return collection.Select(model => new Consensus.Finance.Price(model));
        }

        #endregion
    }
}
