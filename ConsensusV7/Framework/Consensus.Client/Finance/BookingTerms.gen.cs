using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Learning;

namespace Consensus.Finance
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class BookingTerms : Proxy<IBookingTermsModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Product" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Product, Consensus.Learning.IProductModel> _product;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Events" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Event, Consensus.Learning.IEventModel> _events;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Elements" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Element, Consensus.Learning.IElementModel> _elements;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the value of the "BKT_DESCRIPTION" field.
        /// </summary>
        public System.String Description
        {
            get { return this.Model.Description; }
            set { this.Model.Description = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductModel" /> instances that reference this <see cref="!:BookingTermsModel" />.
        /// </summary>
        public Collection<Consensus.Learning.Product> Product
        {
            get
            {
                if (_product == null)
                    _product = new ProxyCollection<Consensus.Learning.Product, Consensus.Learning.IProductModel>(this.Model.Product, model => new Consensus.Learning.Product(model));
                return _product;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:EventModel" /> instances that reference this <see cref="!:BookingTermsModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public Collection<Consensus.Learning.Event> Events
        {
            get
            {
                if (_events == null)
                    _events = new ProxyCollection<Consensus.Learning.Event, Consensus.Learning.IEventModel>(this.Model.Events, model => new Consensus.Learning.Event(model));
                return _events;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ElementModel" /> instances that reference this <see cref="!:BookingTermsModel" />.
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
        internal BookingTerms(IBookingTermsModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:BookingTermsModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:BookingTermsModel" /> instance.
        /// </returns>
        public static Consensus.Finance.BookingTerms Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return BookingTerms.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:BookingTermsModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:BookingTermsModel" /> instance.
        /// </returns>
        public static Consensus.Finance.BookingTerms Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Finance.IBookingTermsModel model = provider.Finance.BookingTerms.Create();
            return model == null ? null : new Consensus.Finance.BookingTerms(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:BookingTermsModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:BookingTermsModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Finance.BookingTerms> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return BookingTerms.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:BookingTermsModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:BookingTermsModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Finance.BookingTerms> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IBookingTermsModel> collection = provider.Finance.BookingTerms.FetchAll();
            return collection.Select(model => new Consensus.Finance.BookingTerms(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:BookingTermsModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:BookingTermsModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingTermsModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Finance.BookingTerms FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return BookingTerms.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:BookingTermsModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:BookingTermsModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingTermsModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Finance.BookingTerms FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Finance.IBookingTermsModel model = provider.Finance.BookingTerms.FetchById(id);
            return model == null ? null : new Consensus.Finance.BookingTerms(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return BookingTerms.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Finance.BookingTerms.GetTableName();
        }

        #endregion
    }
}
