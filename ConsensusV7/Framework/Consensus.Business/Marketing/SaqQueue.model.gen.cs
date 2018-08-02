using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Document;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Encapsulates the <see cref="SaqQueryQueueRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ISaqQueueModel : IModel<Int64>
    {
        /// <summary>
        ///     Gets or sets the value of the "QQ_PRIORITY" field.
        /// </summary>
        System.Byte Priority
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_PROCESSED" field.
        /// </summary>
        System.Byte Processed
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "QQ_QRY_ID" field.
        /// </summary>
        Consensus.Marketing.ISaqQueryModel Query
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "QQ_QRY_ID" field.
        /// </summary>
        System.Int64 QueryId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_OUTPUT_OPTION" field.
        /// </summary>
        System.Nullable<System.Byte> OutputOption
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_PROCESS_OPTION" field.
        /// </summary>
        System.Nullable<System.Byte> ProcessOption
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_EMAIL_WHEN_DONE" field.
        /// </summary>
        System.Byte EmailWhenDone
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_REDO_RESULTS_IF_EXIST" field.
        /// </summary>
        System.Byte RedoResultsIfExist
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_EMAIL_ADDRESS" field.
        /// </summary>
        System.String EmailAddress
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "QQ_ACT_TYPE" field.
        /// </summary>
        Consensus.Common.ICodeModel ActType
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "QQ_ACT_TYPE" field.
        /// </summary>
        System.String ActTypeCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_ACT_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> ActDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_ACT_NOTE" field.
        /// </summary>
        System.String ActNote
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "QQ_LIST_ID" field.
        /// </summary>
        Consensus.Marketing.IMailingListModel MailingList
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "QQ_LIST_ID" field.
        /// </summary>
        System.String MailingListId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "QQ_PROF_KEY" field.
        /// </summary>
        Consensus.Common.IProfilePersonModel ProfilePerson
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "QQ_PROF_KEY" field.
        /// </summary>
        System.String ProfilePersonId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_PROF_VALUE" field.
        /// </summary>
        System.String ProfValue
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_PROF_VALUE2" field.
        /// </summary>
        System.String ProfValue2
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_PROF_VALUE3" field.
        /// </summary>
        System.String ProfValue3
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_FILE_TYPE" field.
        /// </summary>
        System.String FileType
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_DATE_SELECTED" field.
        /// </summary>
        System.Nullable<System.DateTime> DateSelected
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_STATUS" field.
        /// </summary>
        System.String Status
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_ERROR" field.
        /// </summary>
        System.String Error
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "QQ_PROF_KEY_ORG" field.
        /// </summary>
        Consensus.Common.IProfileOrganisationModel ProfileOrg
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "QQ_PROF_KEY_ORG" field.
        /// </summary>
        System.String ProfileOrgId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_PROF_VALUE_ORG" field.
        /// </summary>
        System.String ProfValueOrg
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_PROF_VALUE2_ORG" field.
        /// </summary>
        System.String ProfValue2Org
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_RESULTS_TYPE" field.
        /// </summary>
        System.String ResultsType
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "QQ_PACK_ID" field.
        /// </summary>
        Consensus.Document.IPackModel Pack
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "QQ_PACK_ID" field.
        /// </summary>
        System.String PackId
        {
            get;
            set;
        }
    }
}
