using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Sales;

namespace Consensus.Learning
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class RelatedProduct : Proxy<IRelatedProductModel, Int32>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="RelatedProdId" /> member.
        /// </summary>
        private Consensus.Learning.Product _relatedProdId;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="SalesChannel" /> member.
        /// </summary>
        private Consensus.Sales.SalesChannel _salesChannel;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the value of the "PPX_MAST_PROD_ID" field.
        /// </summary>
        public System.String MastProdId
        {
            get { return this.Model.MastProdId; }
            set { this.Model.MastProdId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PPX_SIM_PROD_ID" field.
        /// </summary>
        public Consensus.Learning.Product RelatedProdId
        {
            get
            {
                if (_relatedProdId == null && this.Model.RelatedProdId != null)
                    _relatedProdId = new Consensus.Learning.Product(this.Model.RelatedProdId);
                if (_relatedProdId == null)
                    _relatedProdId = Consensus.Learning.Product.Create();
                return _relatedProdId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PPX_SIM_PROD_ID" field.
        /// </summary>
        public System.String RelatedProdIdId
        {
            get { return this.Model.RelatedProdIdId; }
            set { this.Model.RelatedProdIdId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PPX_NOTES" field.
        /// </summary>
        public System.String Notes
        {
            get { return this.Model.Notes; }
            set { this.Model.Notes = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PPX_PREREQ" field.
        /// </summary>
        public System.Byte Prereq
        {
            get { return this.Model.Prereq; }
            set { this.Model.Prereq = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PPX_SCHN_ID" field.
        /// </summary>
        public Consensus.Sales.SalesChannel SalesChannel
        {
            get
            {
                if (_salesChannel == null && this.Model.SalesChannel != null)
                    _salesChannel = new Consensus.Sales.SalesChannel(this.Model.SalesChannel);
                if (_salesChannel == null)
                    _salesChannel = Consensus.Sales.SalesChannel.Create();
                return _salesChannel;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PPX_SCHN_ID" field.
        /// </summary>
        public System.String SalesChannelId
        {
            get { return this.Model.SalesChannelId; }
            set { this.Model.SalesChannelId = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal RelatedProduct(IRelatedProductModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:RelatedProductModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:RelatedProductModel" /> instance.
        /// </returns>
        public static Consensus.Learning.RelatedProduct Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return RelatedProduct.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:RelatedProductModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:RelatedProductModel" /> instance.
        /// </returns>
        public static Consensus.Learning.RelatedProduct Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Learning.IRelatedProductModel model = provider.Learning.RelatedProduct.Create();
            return model == null ? null : new Consensus.Learning.RelatedProduct(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:RelatedProductModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:RelatedProductModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Learning.RelatedProduct> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return RelatedProduct.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:RelatedProductModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:RelatedProductModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Learning.RelatedProduct> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IRelatedProductModel> collection = provider.Learning.RelatedProduct.FetchAll();
            return collection.Select(model => new Consensus.Learning.RelatedProduct(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:RelatedProductModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:RelatedProductModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:RelatedProductModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Learning.RelatedProduct FetchById(System.Int32 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return RelatedProduct.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:RelatedProductModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:RelatedProductModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:RelatedProductModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Learning.RelatedProduct FetchById(ConsensusSite site, System.Int32 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Learning.IRelatedProductModel model = provider.Learning.RelatedProduct.FetchById(id);
            return model == null ? null : new Consensus.Learning.RelatedProduct(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return RelatedProduct.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Learning.RelatedProduct.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:RelatedProductModel" /> instances.
        /// </summary>
        /// <param name="relatedProdIdId">
        ///     The value which identifies the <see cref="!:RelatedProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:RelatedProductModel" /> instances that match the specified <paramref name="relatedProdIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.RelatedProduct> FetchAllByRelatedProdIdId(System.String relatedProdIdId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return RelatedProduct.FetchAllByRelatedProdIdId(site,relatedProdIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:RelatedProductModel" /> instances.
        /// </summary>
        /// <param name="relatedProdIdId">
        ///     The value which identifies the <see cref="!:RelatedProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:RelatedProductModel" /> instances that match the specified <paramref name="relatedProdIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.RelatedProduct> FetchAllByRelatedProdIdId(ConsensusSite site, System.String relatedProdIdId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IRelatedProductModel> collection = provider.Learning.RelatedProduct.FetchAllByRelatedProdIdId(relatedProdIdId);
            return collection.Select(model => new Consensus.Learning.RelatedProduct(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:RelatedProductModel" /> instances.
        /// </summary>
        /// <param name="salesChannelId">
        ///     The value which identifies the <see cref="!:RelatedProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:RelatedProductModel" /> instances that match the specified <paramref name="salesChannelId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.RelatedProduct> FetchAllBySalesChannelId(System.String salesChannelId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return RelatedProduct.FetchAllBySalesChannelId(site,salesChannelId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:RelatedProductModel" /> instances.
        /// </summary>
        /// <param name="salesChannelId">
        ///     The value which identifies the <see cref="!:RelatedProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:RelatedProductModel" /> instances that match the specified <paramref name="salesChannelId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.RelatedProduct> FetchAllBySalesChannelId(ConsensusSite site, System.String salesChannelId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IRelatedProductModel> collection = provider.Learning.RelatedProduct.FetchAllBySalesChannelId(salesChannelId);
            return collection.Select(model => new Consensus.Learning.RelatedProduct(model));
        }

        #endregion
    }
}
