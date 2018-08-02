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
    public partial class EventProduct : Proxy<IEventProductModel, Int32>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="SessionXrefMaster" /> member.
        /// </summary>
        private Consensus.Learning.SessionXref _sessionXrefMaster;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Event" /> member.
        /// </summary>
        private Consensus.Learning.Event _event;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Product" /> member.
        /// </summary>
        private Consensus.Learning.Product _product;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Notes" /> member.
        /// </summary>
        private Consensus.Common.Notes _notes;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="EPSessionXref" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.SessionXref, Consensus.Learning.ISessionXrefModel> _ePSessionXref;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the main session.
        /// </summary>
        public Consensus.Learning.SessionXref SessionXrefMaster
        {
            get
            {
                if (_sessionXrefMaster == null && this.Model.SessionXrefMaster != null)
                    _sessionXrefMaster = new Consensus.Learning.SessionXref(this.Model.SessionXrefMaster);
                if (_sessionXrefMaster == null)
                    _sessionXrefMaster = Consensus.Learning.SessionXref.Create();
                return _sessionXrefMaster;
            }
        }

        public System.Boolean IsModified
        {
            get { return this.Model.IsModified; }
        }

        /// <summary>
        ///     Gets the The value of the "EP_COURSE_ID" field.
        /// </summary>
        public Consensus.Learning.Event Event
        {
            get
            {
                if (_event == null && this.Model.Event != null)
                    _event = new Consensus.Learning.Event(this.Model.Event);
                if (_event == null)
                    _event = Consensus.Learning.Event.Create();
                return _event;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "EP_COURSE_ID" field.
        /// </summary>
        public System.String EventId
        {
            get { return this.Model.EventId; }
            set { this.Model.EventId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "EP_PROD_ID" field.
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
        ///     Gets or sets the unique code for the value of the "EP_PROD_ID" field.
        /// </summary>
        public System.String ProductId
        {
            get { return this.Model.ProductId; }
            set { this.Model.ProductId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "EP_NOTES" field.
        /// </summary>
        public Consensus.Common.Notes Notes
        {
            get
            {
                if (_notes == null && this.Model.Notes != null)
                    _notes = new Consensus.Common.Notes(this.Model.Notes);
                if (_notes == null)
                    _notes = Consensus.Common.Notes.Create();
                return _notes;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "EP_NOTES" field.
        /// </summary>
        public System.String NotesId
        {
            get { return this.Model.NotesId; }
            set { this.Model.NotesId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "EP_QTY" field.
        /// </summary>
        public System.Nullable<System.Int32> Qty
        {
            get { return this.Model.Qty; }
            set { this.Model.Qty = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "EP_DELEGATE_QTY" field.
        /// </summary>
        public System.Nullable<System.Int32> DelegateQty
        {
            get { return this.Model.DelegateQty; }
            set { this.Model.DelegateQty = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "EP_PREDELIV" field.
        /// </summary>
        public System.Byte Predeliv
        {
            get { return this.Model.Predeliv; }
            set { this.Model.Predeliv = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SessionXrefModel" /> instances that reference this <see cref="!:EventProductModel" />.
        /// </summary>
        public Collection<Consensus.Learning.SessionXref> EPSessionXref
        {
            get
            {
                if (_ePSessionXref == null)
                    _ePSessionXref = new ProxyCollection<Consensus.Learning.SessionXref, Consensus.Learning.ISessionXrefModel>(this.Model.EPSessionXref, model => new Consensus.Learning.SessionXref(model));
                return _ePSessionXref;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal EventProduct(IEventProductModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:EventProductModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:EventProductModel" /> instance.
        /// </returns>
        public static Consensus.Learning.EventProduct Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return EventProduct.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:EventProductModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:EventProductModel" /> instance.
        /// </returns>
        public static Consensus.Learning.EventProduct Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Learning.IEventProductModel model = provider.Learning.EventProduct.Create();
            return model == null ? null : new Consensus.Learning.EventProduct(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:EventProductModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:EventProductModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Learning.EventProduct> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return EventProduct.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:EventProductModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:EventProductModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Learning.EventProduct> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IEventProductModel> collection = provider.Learning.EventProduct.FetchAll();
            return collection.Select(model => new Consensus.Learning.EventProduct(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:EventProductModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:EventProductModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventProductModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Learning.EventProduct FetchById(System.Int32 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return EventProduct.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:EventProductModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:EventProductModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventProductModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Learning.EventProduct FetchById(ConsensusSite site, System.Int32 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Learning.IEventProductModel model = provider.Learning.EventProduct.FetchById(id);
            return model == null ? null : new Consensus.Learning.EventProduct(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return EventProduct.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Learning.EventProduct.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventProductModel" /> instances.
        /// </summary>
        /// <param name="eventId">
        ///     The value which identifies the <see cref="!:EventProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventProductModel" /> instances that match the specified <paramref name="eventId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.EventProduct> FetchAllByEventId(System.String eventId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return EventProduct.FetchAllByEventId(site,eventId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventProductModel" /> instances.
        /// </summary>
        /// <param name="eventId">
        ///     The value which identifies the <see cref="!:EventProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventProductModel" /> instances that match the specified <paramref name="eventId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.EventProduct> FetchAllByEventId(ConsensusSite site, System.String eventId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IEventProductModel> collection = provider.Learning.EventProduct.FetchAllByEventId(eventId);
            return collection.Select(model => new Consensus.Learning.EventProduct(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventProductModel" /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref="!:EventProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventProductModel" /> instances that match the specified <paramref name="productId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.EventProduct> FetchAllByProductId(System.String productId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return EventProduct.FetchAllByProductId(site,productId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventProductModel" /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref="!:EventProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventProductModel" /> instances that match the specified <paramref name="productId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.EventProduct> FetchAllByProductId(ConsensusSite site, System.String productId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IEventProductModel> collection = provider.Learning.EventProduct.FetchAllByProductId(productId);
            return collection.Select(model => new Consensus.Learning.EventProduct(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventProductModel" /> instances.
        /// </summary>
        /// <param name="notesId">
        ///     The value which identifies the <see cref="!:EventProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventProductModel" /> instances that match the specified <paramref name="notesId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.EventProduct> FetchAllByNotesId(System.String notesId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return EventProduct.FetchAllByNotesId(site,notesId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventProductModel" /> instances.
        /// </summary>
        /// <param name="notesId">
        ///     The value which identifies the <see cref="!:EventProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventProductModel" /> instances that match the specified <paramref name="notesId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.EventProduct> FetchAllByNotesId(ConsensusSite site, System.String notesId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IEventProductModel> collection = provider.Learning.EventProduct.FetchAllByNotesId(notesId);
            return collection.Select(model => new Consensus.Learning.EventProduct(model));
        }

        #endregion
    }
}
