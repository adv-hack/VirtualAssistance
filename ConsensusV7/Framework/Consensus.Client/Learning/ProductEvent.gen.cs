using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;

namespace Consensus.Learning
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class ProductEvent : Proxy<IProductEventModel, Int32>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Product" /> member.
        /// </summary>
        private Consensus.Learning.Product _product;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="AcadyCode" /> member.
        /// </summary>
        private Consensus.Common.Code _acadyCode;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the The value of the "PE_PROD_ID" field.
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
        ///     Gets or sets the unique code for the value of the "PE_PROD_ID" field.
        /// </summary>
        public System.String ProductId
        {
            get { return this.Model.ProductId; }
            set { this.Model.ProductId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PE_INSTANCE" field.
        /// </summary>
        public System.Int32 Instance
        {
            get { return this.Model.Instance; }
            set { this.Model.Instance = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PE_ACADY_CODE" field.
        /// </summary>
        public Consensus.Common.Code AcadyCode
        {
            get
            {
                if (_acadyCode == null && this.Model.AcadyCode != null)
                    _acadyCode = new Consensus.Common.Code(this.Model.AcadyCode);
                if (_acadyCode == null)
                    _acadyCode = Consensus.Common.Code.Create();
                return _acadyCode;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PE_ACADY_CODE" field.
        /// </summary>
        public System.String AcadyCodeCode
        {
            get { return this.Model.AcadyCodeCode; }
            set { this.Model.AcadyCodeCode = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal ProductEvent(IProductEventModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:ProductEventModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ProductEventModel" /> instance.
        /// </returns>
        public static Consensus.Learning.ProductEvent Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProductEvent.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:ProductEventModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ProductEventModel" /> instance.
        /// </returns>
        public static Consensus.Learning.ProductEvent Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Learning.IProductEventModel model = provider.Learning.ProductEvent.Create();
            return model == null ? null : new Consensus.Learning.ProductEvent(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ProductEventModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ProductEventModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Learning.ProductEvent> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProductEvent.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ProductEventModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ProductEventModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Learning.ProductEvent> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IProductEventModel> collection = provider.Learning.ProductEvent.FetchAll();
            return collection.Select(model => new Consensus.Learning.ProductEvent(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ProductEventModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ProductEventModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductEventModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Learning.ProductEvent FetchById(System.Int32 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProductEvent.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ProductEventModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ProductEventModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductEventModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Learning.ProductEvent FetchById(ConsensusSite site, System.Int32 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Learning.IProductEventModel model = provider.Learning.ProductEvent.FetchById(id);
            return model == null ? null : new Consensus.Learning.ProductEvent(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProductEvent.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Learning.ProductEvent.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductEventModel" /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref="!:ProductEventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductEventModel" /> instances that match the specified <paramref name="productId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.ProductEvent> FetchAllByProductId(System.String productId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProductEvent.FetchAllByProductId(site,productId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductEventModel" /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref="!:ProductEventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductEventModel" /> instances that match the specified <paramref name="productId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.ProductEvent> FetchAllByProductId(ConsensusSite site, System.String productId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IProductEventModel> collection = provider.Learning.ProductEvent.FetchAllByProductId(productId);
            return collection.Select(model => new Consensus.Learning.ProductEvent(model));
        }

        #endregion
    }
}
