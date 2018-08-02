using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Contact;
using Consensus.Learning;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Encapsulates the <see cref="SaqQueryRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ISaqQueryModel : IModel<Int64>
    {
        System.Boolean PnDoNotEmailBool
        {
            get;
            set;
        }

        System.Boolean PnDoNotMailBool
        {
            get;
            set;
        }

        System.Boolean PnDoNotFaxBool
        {
            get;
            set;
        }

        System.Boolean PnDoNotSwapBool
        {
            get;
            set;
        }

        System.Boolean PnExcludeArchivedBool
        {
            get;
            set;
        }

        System.Boolean ProleDoNotEmailBool
        {
            get;
            set;
        }

        System.Boolean ProleDoNotMailBool
        {
            get;
            set;
        }

        System.Boolean ProleDoNotFaxBool
        {
            get;
            set;
        }

        System.Boolean ProleDoNotSwapBool
        {
            get;
            set;
        }

        System.Boolean ProleDoNotCallBool
        {
            get;
            set;
        }

        System.Boolean ProleExcludeDisabledBool
        {
            get;
            set;
        }

        System.Boolean OrgDoNotEmailBool
        {
            get;
            set;
        }

        System.Boolean OrgDoNotMailBool
        {
            get;
            set;
        }

        System.Boolean OrgDoNotFaxBool
        {
            get;
            set;
        }

        System.Boolean OrgDoNotRentBool
        {
            get;
            set;
        }

        System.Byte Dedupe
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_NAME" field.
        /// </summary>
        System.String Name
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_DESC" field.
        /// </summary>
        System.String Desc
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "QRY_STATUS" field.
        /// </summary>
        Consensus.Common.ICodeModel Status
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "QRY_STATUS" field.
        /// </summary>
        System.String StatusCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "QRY_PM_ID" field.
        /// </summary>
        Consensus.Marketing.IPromotionModel SourceCode
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "QRY_PM_ID" field.
        /// </summary>
        System.String SourceCodeId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "QRY_COURSE_ID" field.
        /// </summary>
        Consensus.Learning.IEventModel Event
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "QRY_COURSE_ID" field.
        /// </summary>
        System.String EventId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "QRY_CHANNEL" field.
        /// </summary>
        Consensus.Common.ICodeModel Channel
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "QRY_CHANNEL" field.
        /// </summary>
        System.String ChannelCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "QRY_MGR_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel Manager
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "QRY_MGR_PROLE_ID" field.
        /// </summary>
        System.String ManagerId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "QRY_APP_BY_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel Approver
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "QRY_APP_BY_PROLE_ID" field.
        /// </summary>
        System.String ApproverId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_TITLE_SLUG" field.
        /// </summary>
        System.String TitleSlug
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_ORG_ONLY" field.
        /// </summary>
        System.Byte OrgOnly
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_ORG_DEDUPE" field.
        /// </summary>
        System.Byte OrgDedupe
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PN_DEDUPE" field.
        /// </summary>
        System.Byte PnDedupe
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_SAVE_MAIL_SAMPLE" field.
        /// </summary>
        System.Byte SaveMailSample
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_LOCKED" field.
        /// </summary>
        System.Byte Locked
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PEOPLE_PER_ORG" field.
        /// </summary>
        System.Int32 PeoplePerOrg
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PN_DONOTMAIL" field.
        /// </summary>
        System.Byte PnDonotmail
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PN_DONOTMAIL2" field.
        /// </summary>
        System.Byte PnDonotmail2
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PN_DONOTMAIL3" field.
        /// </summary>
        System.Byte PnDonotmail3
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PROLE_DO_NOT_FAX" field.
        /// </summary>
        System.Byte ProleDoNotFax
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PROLE_DO_NOT_MAIL" field.
        /// </summary>
        System.Byte ProleDoNotMail
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PN_FLAG_3" field.
        /// </summary>
        System.Byte PnFlag3
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PROLE_DIS_FLAG" field.
        /// </summary>
        System.Byte ProleDisFlag
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PROLE_USERNUM_1" field.
        /// </summary>
        System.Byte ProleUsernum1
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PN_FLAG_2" field.
        /// </summary>
        System.Byte PnFlag2
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_RESULTS_SIZE_OPT" field.
        /// </summary>
        System.Byte ResultsSizeOpt
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_RESULTS_SIZE" field.
        /// </summary>
        System.Int64 ResultsSize
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_SCHED_RUN_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> SchedRunDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_SCHED_RUN_TIME" field.
        /// </summary>
        System.Nullable<System.DateTime> SchedRunTime
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_CALCULATED_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> CalculatedDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_OUTPUT_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> OutputDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_TOTAL_RECORDS" field.
        /// </summary>
        System.Int64 TotalRecords
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_SAMPLE" field.
        /// </summary>
        System.Int64 Sample
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_SEEDS" field.
        /// </summary>
        System.Int64 Seeds
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_IN_USE" field.
        /// </summary>
        System.Byte InUse
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_LAST_RESULT_FILE" field.
        /// </summary>
        System.String LastResultFile
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_APP_STATUS" field.
        /// </summary>
        System.Byte AppStatus
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PROLE_DO_NOT_SWAP" field.
        /// </summary>
        System.Byte ProleDoNotSwap
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PN_FLAG_1" field.
        /// </summary>
        System.Byte PnFlag1
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PROLE_DO_NOT_EMAIL" field.
        /// </summary>
        System.Byte ProleDoNotEmail
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PROLE_DO_NOT_SPARE" field.
        /// </summary>
        System.Byte ProleDoNotSpare
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_ORG_DONOTMAIL" field.
        /// </summary>
        System.Byte OrgDonotmail
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_ORG_USERNUM_1" field.
        /// </summary>
        System.Byte OrgUsernum1
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_ORG_FLAG_1" field.
        /// </summary>
        System.Byte OrgFlag1
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_ORG_DONOTFAX" field.
        /// </summary>
        System.Byte OrgDonotfax
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PROLE_DO_NOT_SPARE1" field.
        /// </summary>
        System.Nullable<System.Byte> ProleDoNotSpare1
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PROLE_DO_NOT_SPARE2" field.
        /// </summary>
        System.Nullable<System.Byte> ProleDoNotSpare2
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PROLE_DO_NOT_SPARE3" field.
        /// </summary>
        System.Nullable<System.Byte> ProleDoNotSpare3
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PROLE_DO_NOT_SPARE4" field.
        /// </summary>
        System.Nullable<System.Byte> ProleDoNotSpare4
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PN_DO_NOT_SPARE1" field.
        /// </summary>
        System.Nullable<System.Byte> PnDoNotSpare1
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PN_DO_NOT_SPARE2" field.
        /// </summary>
        System.Nullable<System.Byte> PnDoNotSpare2
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PN_DO_NOT_SPARE3" field.
        /// </summary>
        System.Nullable<System.Byte> PnDoNotSpare3
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PN_DO_NOT_SPARE4" field.
        /// </summary>
        System.Nullable<System.Byte> PnDoNotSpare4
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_ORG_DO_NOT_SPARE1" field.
        /// </summary>
        System.Nullable<System.Byte> OrgDoNotSpare1
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_ORG_DO_NOT_SPARE2" field.
        /// </summary>
        System.Nullable<System.Byte> OrgDoNotSpare2
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_ORG_DO_NOT_SPARE3" field.
        /// </summary>
        System.Nullable<System.Byte> OrgDoNotSpare3
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_ORG_DO_NOT_SPARE4" field.
        /// </summary>
        System.Nullable<System.Byte> OrgDoNotSpare4
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SaqQueryStepModel" /> instances that reference this <see cref="!:SaqQueryModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Marketing.ISaqQueryStepModel> SaqQueryStepQuery
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SaqQueueModel" /> instances that reference this <see cref="!:SaqQueryModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Marketing.ISaqQueueModel> SaqQueueQuery
        {
            get;
        }
    }
}
