using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Learning;
using Consensus.Marketing;

namespace Consensus.Common
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class Notes : Proxy<INotesModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="CourseNotes" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Event, Consensus.Learning.IEventModel> _courseNotes;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="CourseIntNotes" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Event, Consensus.Learning.IEventModel> _courseIntNotes;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Bookings" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Booking, Consensus.Learning.IBookingModel> _bookings;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="InvoiceBookings" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Booking, Consensus.Learning.IBookingModel> _invoiceBookings;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="EventProducts" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.EventProduct, Consensus.Learning.IEventProductModel> _eventProducts;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="MailingListNotes" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Marketing.MailingList, Consensus.Marketing.IMailingListModel> _mailingListNotes;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the value of the "TEXT_TYPE" field.
        /// </summary>
        public System.String Type
        {
            get { return this.Model.Type; }
            set { this.Model.Type = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TEXT_BODY" field.
        /// </summary>
        public System.String Body
        {
            get { return this.Model.Body; }
            set { this.Model.Body = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TEXT_RTF" field.
        /// </summary>
        public System.String Rtf
        {
            get { return this.Model.Rtf; }
            set { this.Model.Rtf = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TEXT_HTML" field.
        /// </summary>
        public System.String Html
        {
            get { return this.Model.Html; }
            set { this.Model.Html = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:EventModel" /> instances that reference this <see cref="!:NotesModel" />.
        /// </summary>
        public Collection<Consensus.Learning.Event> CourseNotes
        {
            get
            {
                if (_courseNotes == null)
                    _courseNotes = new ProxyCollection<Consensus.Learning.Event, Consensus.Learning.IEventModel>(this.Model.CourseNotes, model => new Consensus.Learning.Event(model));
                return _courseNotes;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:EventModel" /> instances that reference this <see cref="!:NotesModel" />.
        /// </summary>
        public Collection<Consensus.Learning.Event> CourseIntNotes
        {
            get
            {
                if (_courseIntNotes == null)
                    _courseIntNotes = new ProxyCollection<Consensus.Learning.Event, Consensus.Learning.IEventModel>(this.Model.CourseIntNotes, model => new Consensus.Learning.Event(model));
                return _courseIntNotes;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BookingModel" /> instances that reference this <see cref="!:NotesModel" />.
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

        /// <summary>
        ///     Gets the collection of <see cref="!:BookingModel" /> instances that reference this <see cref="!:NotesModel" />.
        /// </summary>
        public Collection<Consensus.Learning.Booking> InvoiceBookings
        {
            get
            {
                if (_invoiceBookings == null)
                    _invoiceBookings = new ProxyCollection<Consensus.Learning.Booking, Consensus.Learning.IBookingModel>(this.Model.InvoiceBookings, model => new Consensus.Learning.Booking(model));
                return _invoiceBookings;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:EventProductModel" /> instances that reference this <see cref="!:NotesModel" />.
        /// </summary>
        public Collection<Consensus.Learning.EventProduct> EventProducts
        {
            get
            {
                if (_eventProducts == null)
                    _eventProducts = new ProxyCollection<Consensus.Learning.EventProduct, Consensus.Learning.IEventProductModel>(this.Model.EventProducts, model => new Consensus.Learning.EventProduct(model));
                return _eventProducts;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MailingListModel" /> instances that reference this <see cref="!:NotesModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public Collection<Consensus.Marketing.MailingList> MailingListNotes
        {
            get
            {
                if (_mailingListNotes == null)
                    _mailingListNotes = new ProxyCollection<Consensus.Marketing.MailingList, Consensus.Marketing.IMailingListModel>(this.Model.MailingListNotes, model => new Consensus.Marketing.MailingList(model));
                return _mailingListNotes;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal Notes(INotesModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:NotesModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:NotesModel" /> instance.
        /// </returns>
        public static Consensus.Common.Notes Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Notes.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:NotesModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:NotesModel" /> instance.
        /// </returns>
        public static Consensus.Common.Notes Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Common.INotesModel model = provider.Common.Notes.Create();
            return model == null ? null : new Consensus.Common.Notes(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:NotesModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:NotesModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Common.Notes> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Notes.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:NotesModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:NotesModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Common.Notes> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Common.INotesModel> collection = provider.Common.Notes.FetchAll();
            return collection.Select(model => new Consensus.Common.Notes(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:NotesModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:NotesModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:NotesModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Common.Notes FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Notes.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:NotesModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:NotesModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:NotesModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Common.Notes FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Common.INotesModel model = provider.Common.Notes.FetchById(id);
            return model == null ? null : new Consensus.Common.Notes(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Notes.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Common.Notes.GetTableName();
        }

        #endregion
    }
}
