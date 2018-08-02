using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Learning;

namespace Consensus.Document
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class PackProduct : Proxy<IPackProductModel, Int32>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Product" /> member.
        /// </summary>
        private Consensus.Learning.Product _product;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Pack" /> member.
        /// </summary>
        private Consensus.Document.Pack _pack;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the The value of the "PPA_PROD_ID" field.
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
        ///     Gets or sets the unique code for the value of the "PPA_PROD_ID" field.
        /// </summary>
        public System.String ProductId
        {
            get { return this.Model.ProductId; }
            set { this.Model.ProductId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PPA_PACK_ID" field.
        /// </summary>
        public Consensus.Document.Pack Pack
        {
            get
            {
                if (_pack == null && this.Model.Pack != null)
                    _pack = new Consensus.Document.Pack(this.Model.Pack);
                if (_pack == null)
                    _pack = Consensus.Document.Pack.Create();
                return _pack;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PPA_PACK_ID" field.
        /// </summary>
        public System.String PackId
        {
            get { return this.Model.PackId; }
            set { this.Model.PackId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PPA_TYPE" field.
        /// </summary>
        public System.String Type
        {
            get { return this.Model.Type; }
            set { this.Model.Type = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PPA_SUPPRESS" field.
        /// </summary>
        public System.Byte Suppress
        {
            get { return this.Model.Suppress; }
            set { this.Model.Suppress = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal PackProduct(IPackProductModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:PackProductModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PackProductModel" /> instance.
        /// </returns>
        public static Consensus.Document.PackProduct Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PackProduct.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:PackProductModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PackProductModel" /> instance.
        /// </returns>
        public static Consensus.Document.PackProduct Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Document.IPackProductModel model = provider.Document.PackProduct.Create();
            return model == null ? null : new Consensus.Document.PackProduct(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PackProductModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PackProductModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Document.PackProduct> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PackProduct.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PackProductModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PackProductModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Document.PackProduct> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Document.IPackProductModel> collection = provider.Document.PackProduct.FetchAll();
            return collection.Select(model => new Consensus.Document.PackProduct(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:PackProductModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PackProductModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PackProductModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Document.PackProduct FetchById(System.Int32 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PackProduct.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:PackProductModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PackProductModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PackProductModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Document.PackProduct FetchById(ConsensusSite site, System.Int32 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Document.IPackProductModel model = provider.Document.PackProduct.FetchById(id);
            return model == null ? null : new Consensus.Document.PackProduct(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PackProduct.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Document.PackProduct.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PackProductModel" /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref="!:PackProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PackProductModel" /> instances that match the specified <paramref name="productId" />.
        /// </returns>
        public static IEnumerable<Consensus.Document.PackProduct> FetchAllByProductId(System.String productId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PackProduct.FetchAllByProductId(site,productId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PackProductModel" /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref="!:PackProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PackProductModel" /> instances that match the specified <paramref name="productId" />.
        /// </returns>
        public static IEnumerable<Consensus.Document.PackProduct> FetchAllByProductId(ConsensusSite site, System.String productId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Document.IPackProductModel> collection = provider.Document.PackProduct.FetchAllByProductId(productId);
            return collection.Select(model => new Consensus.Document.PackProduct(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PackProductModel" /> instances.
        /// </summary>
        /// <param name="packId">
        ///     The value which identifies the <see cref="!:PackProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PackProductModel" /> instances that match the specified <paramref name="packId" />.
        /// </returns>
        public static IEnumerable<Consensus.Document.PackProduct> FetchAllByPackId(System.String packId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PackProduct.FetchAllByPackId(site,packId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PackProductModel" /> instances.
        /// </summary>
        /// <param name="packId">
        ///     The value which identifies the <see cref="!:PackProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PackProductModel" /> instances that match the specified <paramref name="packId" />.
        /// </returns>
        public static IEnumerable<Consensus.Document.PackProduct> FetchAllByPackId(ConsensusSite site, System.String packId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Document.IPackProductModel> collection = provider.Document.PackProduct.FetchAllByPackId(packId);
            return collection.Select(model => new Consensus.Document.PackProduct(model));
        }

        #endregion
    }
}
