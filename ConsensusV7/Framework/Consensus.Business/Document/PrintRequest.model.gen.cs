using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Contact;
using Consensus.Other;

namespace Consensus.Document
{
    /// <summary>
    ///     Encapsulates the <see cref="PrintReqRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IPrintRequestModel : IModel<String>
    {
        /// <summary>
        ///     Gets or sets the value of the "PR_ID_1" field.
        /// </summary>
        System.String Id1
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PR_ID_2" field.
        /// </summary>
        System.String Id2
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PR_ID_3" field.
        /// </summary>
        System.String Id3
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PR_TYPE" field.
        /// </summary>
        System.String Type
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PR_STATUS" field.
        /// </summary>
        System.Nullable<System.Int32> Status
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PR_REQ_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> ReqDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PR_REQ_BY" field.
        /// </summary>
        System.String ReqBy
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PR_PQ_ID" field.
        /// </summary>
        Consensus.Document.IOutputQueueModel Queue
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PR_PQ_ID" field.
        /// </summary>
        System.String QueueId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PR_ACT_PQ_STATUS" field.
        /// </summary>
        System.String ActPqStatus
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PR_PQ_SEND_TYPE" field.
        /// </summary>
        System.String PqSendType
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PR_PACK_ID" field.
        /// </summary>
        Consensus.Document.IPackModel Pack
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PR_PACK_ID" field.
        /// </summary>
        System.String PackId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PR_BAT_ID" field.
        /// </summary>
        Consensus.Other.IBatchModel Batch
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PR_BAT_ID" field.
        /// </summary>
        System.String BatchId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PR_SEND_TO_BOOKER" field.
        /// </summary>
        System.Nullable<System.Byte> SendToBooker
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PR_SEND_TO_DELEGATE" field.
        /// </summary>
        System.Nullable<System.Byte> SendToDelegate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PR_SEND_FROM_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IPersonModel SendFromProle
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PR_SEND_FROM_PROLE_ID" field.
        /// </summary>
        System.String SendFromProleId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PR_SEND_TO_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IPersonModel SendToProle
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PR_SEND_TO_PROLE_ID" field.
        /// </summary>
        System.String SendToProleId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PR_ID_4" field.
        /// </summary>
        System.String Id4
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PR_ID_5" field.
        /// </summary>
        System.String Id5
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PR_NAME" field.
        /// </summary>
        System.String Name
        {
            get;
            set;
        }
    }
}
