using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Learning;

namespace Consensus.Sales
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SalesChannel : Proxy<ISalesChannelModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="RelatedProducts" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.RelatedProduct, Consensus.Learning.IRelatedProductModel> _relatedProducts;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Bookings" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Booking, Consensus.Learning.IBookingModel> _bookings;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the value of the "SCHN_NAME" field.
        /// </summary>
        public System.String Name
        {
            get { return this.Model.Name; }
            set { this.Model.Name = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:RelatedProductModel" /> instances that reference this <see cref="!:SalesChannelModel" />.
        /// </summary>
        public Collection<Consensus.Learning.RelatedProduct> RelatedProducts
        {
            get
            {
                if (_relatedProducts == null)
                    _relatedProducts = new ProxyCollection<Consensus.Learning.RelatedProduct, Consensus.Learning.IRelatedProductModel>(this.Model.RelatedProducts, model => new Consensus.Learning.RelatedProduct(model));
                return _relatedProducts;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BookingModel" /> instances that reference this <see cref="!:SalesChannelModel" />.
        /// </summary>
        public Collection<Consensus.Learning.Booking> Bookings
        {
            get
            {
                if (_bookings == null)
                    _bookings = new ProxyCollection<Consensus.Learning.Booking, Consensus.Learning.IBookingModel>(this.Model.Bookings, model => new Consensus.Learning.Booking(model));
                return _bookings;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal SalesChannel(ISalesChannelModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:SalesChannelModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SalesChannelModel" /> instance.
        /// </returns>
        public static Consensus.Sales.SalesChannel Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SalesChannel.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:SalesChannelModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SalesChannelModel" /> instance.
        /// </returns>
        public static Consensus.Sales.SalesChannel Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Sales.ISalesChannelModel model = provider.Sales.SalesChannel.Create();
            return model == null ? null : new Consensus.Sales.SalesChannel(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SalesChannelModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SalesChannelModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Sales.SalesChannel> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SalesChannel.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SalesChannelModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SalesChannelModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Sales.SalesChannel> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Sales.ISalesChannelModel> collection = provider.Sales.SalesChannel.FetchAll();
            return collection.Select(model => new Consensus.Sales.SalesChannel(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:SalesChannelModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SalesChannelModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SalesChannelModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Sales.SalesChannel FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SalesChannel.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:SalesChannelModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SalesChannelModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SalesChannelModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Sales.SalesChannel FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Sales.ISalesChannelModel model = provider.Sales.SalesChannel.FetchById(id);
            return model == null ? null : new Consensus.Sales.SalesChannel(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SalesChannel.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Sales.SalesChannel.GetTableName();
        }

        #endregion
    }
}
