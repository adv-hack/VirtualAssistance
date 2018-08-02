using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Contact;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Encapsulates the <see cref="ListMemberRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IMailingListMemberModel : IModel<String>
    {
        /// <summary>
        ///     Gets the The value of the "LM_LIST_ID" field.
        /// </summary>
        Consensus.Marketing.IMailingListModel MailingList
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "LM_LIST_ID" field.
        /// </summary>
        System.String MailingListId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "LM_PN_ID" field.
        /// </summary>
        Consensus.Contact.IPersonModel Person
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "LM_PN_ID" field.
        /// </summary>
        System.String PersonId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LM_TABLE_NAME" field.
        /// </summary>
        System.String TableName
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LM_RECORD_ID" field.
        /// </summary>
        System.String RecordId
        {
            get;
            set;
        }
    }
}
