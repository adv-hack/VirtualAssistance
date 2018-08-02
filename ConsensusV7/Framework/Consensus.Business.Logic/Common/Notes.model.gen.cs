using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Learning;
using Consensus.Marketing;

namespace Consensus.Common
{
    /// <summary>
    ///     Encapsulates the <see cref="C4textRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalNotesModel : LocalModel<C4textRecord, String>, INotesModel
    {
        #region fields

        /// <summary>
        ///     The collection of <see cref="EventModel" /> instances that reference this <see cref="NotesModel" />.
        /// </summary>
        private LocalCollection<LocalEventModel, IEventModel> _courseNotes;

        /// <summary>
        ///     The collection of <see cref="EventModel" /> instances that reference this <see cref="NotesModel" />.
        /// </summary>
        private LocalCollection<LocalEventModel, IEventModel> _courseIntNotes;

        /// <summary>
        ///     The collection of <see cref="BookingModel" /> instances that reference this <see cref="NotesModel" />.
        /// </summary>
        private LocalCollection<LocalBookingModel, IBookingModel> _bookings;

        /// <summary>
        ///     The collection of <see cref="BookingModel" /> instances that reference this <see cref="NotesModel" />.
        /// </summary>
        private LocalCollection<LocalBookingModel, IBookingModel> _invoiceBookings;

        /// <summary>
        ///     The collection of <see cref="EventProductModel" /> instances that reference this <see cref="NotesModel" />.
        /// </summary>
        private LocalCollection<LocalEventProductModel, IEventProductModel> _eventProducts;

        /// <summary>
        ///     The collection of <see cref="MailingListModel" /> instances that reference this <see cref="NotesModel" />.
        /// </summary>
        private LocalCollection<LocalMailingListModel, IMailingListModel> _mailingListNotes;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<C4textRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Common.Notes.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<C4textRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Common.Notes.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<C4textRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Common.Notes.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TEXT_TYPE" field.
        /// </summary>
        public String Type
        {
            get { return this.ModifiedData.Type; }
            set { this.ModifiedData.Type = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TEXT_BODY" field.
        /// </summary>
        public String Body
        {
            get { return this.ModifiedData.Body; }
            set { this.ModifiedData.Body = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TEXT_RTF" field.
        /// </summary>
        public String Rtf
        {
            get { return this.ModifiedData.Rtf; }
            set { this.ModifiedData.Rtf = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TEXT_HTML" field.
        /// </summary>
        public String Html
        {
            get { return this.ModifiedData.Html; }
            set { this.ModifiedData.Html = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="EventModel" /> instances that reference this <see cref="NotesModel" />.
        /// </summary>
        public LocalCollection<LocalEventModel, IEventModel> CourseNotes
        {
            get
            {
                if (_courseNotes == null)
                    _courseNotes = new LocalCollection<LocalEventModel, IEventModel>(this.Provider.Learning.Event.FetchAllByNotesId(this.Id));
                
                return _courseNotes;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="EventModel" /> instances that reference this <see cref="NotesModel" />.
        /// </summary>
        public LocalCollection<LocalEventModel, IEventModel> CourseIntNotes
        {
            get
            {
                if (_courseIntNotes == null)
                    _courseIntNotes = new LocalCollection<LocalEventModel, IEventModel>(this.Provider.Learning.Event.FetchAllByIntNotesId(this.Id));
                
                return _courseIntNotes;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="BookingModel" /> instances that reference this <see cref="NotesModel" />.
        /// </summary>
        public LocalCollection<LocalBookingModel, IBookingModel> Bookings
        {
            get
            {
                if (_bookings == null)
                    _bookings = new LocalCollection<LocalBookingModel, IBookingModel>(this.Provider.Learning.Booking.FetchAllByNotesId(this.Id));
                
                return _bookings;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="BookingModel" /> instances that reference this <see cref="NotesModel" />.
        /// </summary>
        public LocalCollection<LocalBookingModel, IBookingModel> InvoiceBookings
        {
            get
            {
                if (_invoiceBookings == null)
                    _invoiceBookings = new LocalCollection<LocalBookingModel, IBookingModel>(this.Provider.Learning.Booking.FetchAllByInvExtNotesId(this.Id));
                
                return _invoiceBookings;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="EventProductModel" /> instances that reference this <see cref="NotesModel" />.
        /// </summary>
        public LocalCollection<LocalEventProductModel, IEventProductModel> EventProducts
        {
            get
            {
                if (_eventProducts == null)
                    _eventProducts = new LocalCollection<LocalEventProductModel, IEventProductModel>(this.Provider.Learning.EventProduct.FetchAllByNotesId(this.Id));
                
                return _eventProducts;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="MailingListModel" /> instances that reference this <see cref="NotesModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public LocalCollection<LocalMailingListModel, IMailingListModel> MailingListNotes
        {
            get
            {
                if (_mailingListNotes == null)
                    _mailingListNotes = new LocalCollection<LocalMailingListModel, IMailingListModel>(this.Provider.Marketing.MailingList.FetchAllByNotesHtmlId(this.Id));
                
                return _mailingListNotes;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalNotesModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalNotesModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalNotesModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalNotesModel(LocalProvider provider, C4textRecord record) : base(provider, record)
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
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
            if (_courseNotes != null)
                _courseNotes.Execute(obj => obj.NotesId = this.Id).Execute(obj => obj.Save());
            if (_courseIntNotes != null)
                _courseIntNotes.Execute(obj => obj.IntNotesId = this.Id).Execute(obj => obj.Save());
            if (_bookings != null)
                _bookings.Execute(obj => obj.NotesId = this.Id).Execute(obj => obj.Save());
            if (_invoiceBookings != null)
                _invoiceBookings.Execute(obj => obj.InvExtNotesId = this.Id).Execute(obj => obj.Save());
            if (_eventProducts != null)
                _eventProducts.Execute(obj => obj.NotesId = this.Id).Execute(obj => obj.Save());
            if (_mailingListNotes != null)
                _mailingListNotes.Execute(obj => obj.NotesHtmlId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets or sets the value of the "TEXT_TYPE" field.
        /// </summary>
        System.String INotesModel.Type
        {
            get { return this.Type; }
            set { this.Type = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TEXT_BODY" field.
        /// </summary>
        System.String INotesModel.Body
        {
            get { return this.Body; }
            set { this.Body = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TEXT_RTF" field.
        /// </summary>
        System.String INotesModel.Rtf
        {
            get { return this.Rtf; }
            set { this.Rtf = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TEXT_HTML" field.
        /// </summary>
        System.String INotesModel.Html
        {
            get { return this.Html; }
            set { this.Html = (System.String)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:EventModel" /> instances that reference this <see cref="!:NotesModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IEventModel> INotesModel.CourseNotes
        {
            get { return this.CourseNotes; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:EventModel" /> instances that reference this <see cref="!:NotesModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IEventModel> INotesModel.CourseIntNotes
        {
            get { return this.CourseIntNotes; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BookingModel" /> instances that reference this <see cref="!:NotesModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IBookingModel> INotesModel.Bookings
        {
            get { return this.Bookings; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BookingModel" /> instances that reference this <see cref="!:NotesModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IBookingModel> INotesModel.InvoiceBookings
        {
            get { return this.InvoiceBookings; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:EventProductModel" /> instances that reference this <see cref="!:NotesModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IEventProductModel> INotesModel.EventProducts
        {
            get { return this.EventProducts; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MailingListModel" /> instances that reference this <see cref="!:NotesModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Marketing.IMailingListModel> INotesModel.MailingListNotes
        {
            get { return this.MailingListNotes; }
        }

        #endregion
    }
}
