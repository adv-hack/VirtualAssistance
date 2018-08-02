using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Contact;

namespace Consensus.Document
{
    /// <summary>
    ///     Encapsulates the <see cref="PrintQueueRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IOutputQueueModel : IModel<String>
    {
        /// <summary>
        ///     Gets or sets the value of the "PQ_QUEUE_TYPE" field.
        /// </summary>
        System.String QueueType
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PQ_SEND_TYPE" field.
        /// </summary>
        System.Nullable<System.Byte> SendType
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PQ_ADMIN_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel AdminProle
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PQ_ADMIN_PROLE_ID" field.
        /// </summary>
        System.String AdminProleId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PQ_MAIL_SERVER" field.
        /// </summary>
        System.String MailServer
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PQ_LOGON_ID" field.
        /// </summary>
        System.String LogonId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PQ_LOGON_PASSWORD" field.
        /// </summary>
        System.String LogonPassword
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PQ_PRINT_SERVER" field.
        /// </summary>
        System.String PrintServer
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PQ_PRINTER_NOTES" field.
        /// </summary>
        System.String PrinterNotes
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PQ_DESCRIPTION" field.
        /// </summary>
        System.String Description
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PQ_SYSTEM_DEFAULT" field.
        /// </summary>
        System.Nullable<System.Byte> SystemDefault
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PQ_DPM_SERVER" field.
        /// </summary>
        System.String DpmServer
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PQ_PORT" field.
        /// </summary>
        System.String Port
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PQ_SSL" field.
        /// </summary>
        System.Nullable<System.Byte> Ssl
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PQ_PROXY" field.
        /// </summary>
        System.Nullable<System.Byte> Proxy
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PQ_FROM" field.
        /// </summary>
        System.String From
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PackModel" /> instances that reference this <see cref="!:OutputQueueModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Document.IPackModel> PackOutputQueue
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PrintRequestModel" /> instances that reference this <see cref="!:OutputQueueModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Document.IPrintRequestModel> OutputQueueRequests
        {
            get;
        }
    }
}
