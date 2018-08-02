using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Learning;
using Consensus.Marketing;

namespace Consensus.Common
{
    /// <summary>
    ///     Encapsulates the <see cref="C4textRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface INotesModel : IModel<String>
    {
        /// <summary>
        ///     Gets or sets the value of the "TEXT_TYPE" field.
        /// </summary>
        System.String Type
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "TEXT_BODY" field.
        /// </summary>
        System.String Body
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "TEXT_RTF" field.
        /// </summary>
        System.String Rtf
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "TEXT_HTML" field.
        /// </summary>
        System.String Html
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:EventModel" /> instances that reference this <see cref="!:NotesModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IEventModel> CourseNotes
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:EventModel" /> instances that reference this <see cref="!:NotesModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IEventModel> CourseIntNotes
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BookingModel" /> instances that reference this <see cref="!:NotesModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IBookingModel> Bookings
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BookingModel" /> instances that reference this <see cref="!:NotesModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IBookingModel> InvoiceBookings
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:EventProductModel" /> instances that reference this <see cref="!:NotesModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IEventProductModel> EventProducts
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MailingListModel" /> instances that reference this <see cref="!:NotesModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Marketing.IMailingListModel> MailingListNotes
        {
            get;
        }
    }
}
