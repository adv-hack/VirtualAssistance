using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Contact;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Encapsulates the <see cref="ListRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IMailingListModel : IModel<String>
    {
        /// <summary>
        ///     Count of members that are people.
        /// </summary>
        System.Int32 TotalPersonCount
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the value of the "LIST_RCV_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> RcvDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LIST_RCV_FROM" field.
        /// </summary>
        System.String RcvFrom
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LIST_TITLE" field.
        /// </summary>
        System.String Title
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LIST_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> Date
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "LIST_USER_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel Owner
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "LIST_USER_ID" field.
        /// </summary>
        System.String OwnerId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "LIST_STATUS" field.
        /// </summary>
        Consensus.Common.ICodeModel Status
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "LIST_STATUS" field.
        /// </summary>
        System.String StatusCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LIST_NOTES" field.
        /// </summary>
        System.String Notes
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LIST_LIMIT" field.
        /// </summary>
        System.Nullable<System.Double> Limit
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LIST_WEB_ENABLED" field.
        /// </summary>
        System.Byte WebEnabled
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "LIST_NOTES_HTML" field.
        /// </summary>
        Consensus.Common.INotesModel NotesHtml
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "LIST_NOTES_HTML" field.
        /// </summary>
        System.String NotesHtmlId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LIST_IS_DYNAMIC" field.
        /// </summary>
        System.Boolean IsDynamic
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SaqQueueModel" /> instances that reference this <see cref="!:MailingListModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Marketing.ISaqQueueModel> SaqQueueMailingList
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MailingListMemberModel" /> instances that reference this <see cref="!:MailingListModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Marketing.IMailingListMemberModel> MailingListMemberList
        {
            get;
        }
    }
}
