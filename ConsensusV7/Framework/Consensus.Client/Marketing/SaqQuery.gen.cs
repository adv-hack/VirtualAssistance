using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Contact;
using Consensus.Learning;

namespace Consensus.Marketing
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SaqQuery : Proxy<ISaqQueryModel, Int64>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Status" /> member.
        /// </summary>
        private Consensus.Common.Code _status;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="SourceCode" /> member.
        /// </summary>
        private Consensus.Marketing.Promotion _sourceCode;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Event" /> member.
        /// </summary>
        private Consensus.Learning.Event _event;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Channel" /> member.
        /// </summary>
        private Consensus.Common.Code _channel;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Manager" /> member.
        /// </summary>
        private Consensus.Contact.Role _manager;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Approver" /> member.
        /// </summary>
        private Consensus.Contact.Role _approver;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="SaqQueryStepQuery" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Marketing.SaqQueryStep, Consensus.Marketing.ISaqQueryStepModel> _saqQueryStepQuery;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="SaqQueueQuery" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Marketing.SaqQueue, Consensus.Marketing.ISaqQueueModel> _saqQueueQuery;

        #endregion

        #region properties

        public System.Boolean PnDoNotEmailBool
        {
            get { return this.Model.PnDoNotEmailBool; }
            set { this.Model.PnDoNotEmailBool = value; }
        }

        public System.Boolean PnDoNotMailBool
        {
            get { return this.Model.PnDoNotMailBool; }
            set { this.Model.PnDoNotMailBool = value; }
        }

        public System.Boolean PnDoNotFaxBool
        {
            get { return this.Model.PnDoNotFaxBool; }
            set { this.Model.PnDoNotFaxBool = value; }
        }

        public System.Boolean PnDoNotSwapBool
        {
            get { return this.Model.PnDoNotSwapBool; }
            set { this.Model.PnDoNotSwapBool = value; }
        }

        public System.Boolean PnExcludeArchivedBool
        {
            get { return this.Model.PnExcludeArchivedBool; }
            set { this.Model.PnExcludeArchivedBool = value; }
        }

        public System.Boolean ProleDoNotEmailBool
        {
            get { return this.Model.ProleDoNotEmailBool; }
            set { this.Model.ProleDoNotEmailBool = value; }
        }

        public System.Boolean ProleDoNotMailBool
        {
            get { return this.Model.ProleDoNotMailBool; }
            set { this.Model.ProleDoNotMailBool = value; }
        }

        public System.Boolean ProleDoNotFaxBool
        {
            get { return this.Model.ProleDoNotFaxBool; }
            set { this.Model.ProleDoNotFaxBool = value; }
        }

        public System.Boolean ProleDoNotSwapBool
        {
            get { return this.Model.ProleDoNotSwapBool; }
            set { this.Model.ProleDoNotSwapBool = value; }
        }

        public System.Boolean ProleDoNotCallBool
        {
            get { return this.Model.ProleDoNotCallBool; }
            set { this.Model.ProleDoNotCallBool = value; }
        }

        public System.Boolean ProleExcludeDisabledBool
        {
            get { return this.Model.ProleExcludeDisabledBool; }
            set { this.Model.ProleExcludeDisabledBool = value; }
        }

        public System.Boolean OrgDoNotEmailBool
        {
            get { return this.Model.OrgDoNotEmailBool; }
            set { this.Model.OrgDoNotEmailBool = value; }
        }

        public System.Boolean OrgDoNotMailBool
        {
            get { return this.Model.OrgDoNotMailBool; }
            set { this.Model.OrgDoNotMailBool = value; }
        }

        public System.Boolean OrgDoNotFaxBool
        {
            get { return this.Model.OrgDoNotFaxBool; }
            set { this.Model.OrgDoNotFaxBool = value; }
        }

        public System.Boolean OrgDoNotRentBool
        {
            get { return this.Model.OrgDoNotRentBool; }
            set { this.Model.OrgDoNotRentBool = value; }
        }

        public System.Byte Dedupe
        {
            get { return this.Model.Dedupe; }
            set { this.Model.Dedupe = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_NAME" field.
        /// </summary>
        public System.String Name
        {
            get { return this.Model.Name; }
            set { this.Model.Name = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_DESC" field.
        /// </summary>
        public System.String Desc
        {
            get { return this.Model.Desc; }
            set { this.Model.Desc = value; }
        }

        /// <summary>
        ///     Gets the The value of the "QRY_STATUS" field.
        /// </summary>
        public Consensus.Common.Code Status
        {
            get
            {
                if (_status == null && this.Model.Status != null)
                    _status = new Consensus.Common.Code(this.Model.Status);
                if (_status == null)
                    _status = Consensus.Common.Code.Create();
                return _status;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "QRY_STATUS" field.
        /// </summary>
        public System.String StatusCode
        {
            get { return this.Model.StatusCode; }
            set { this.Model.StatusCode = value; }
        }

        /// <summary>
        ///     Gets the The value of the "QRY_PM_ID" field.
        /// </summary>
        public Consensus.Marketing.Promotion SourceCode
        {
            get
            {
                if (_sourceCode == null && this.Model.SourceCode != null)
                    _sourceCode = new Consensus.Marketing.Promotion(this.Model.SourceCode);
                if (_sourceCode == null)
                    _sourceCode = Consensus.Marketing.Promotion.Create();
                return _sourceCode;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "QRY_PM_ID" field.
        /// </summary>
        public System.String SourceCodeId
        {
            get { return this.Model.SourceCodeId; }
            set { this.Model.SourceCodeId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "QRY_COURSE_ID" field.
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
        ///     Gets or sets the unique code for the value of the "QRY_COURSE_ID" field.
        /// </summary>
        public System.String EventId
        {
            get { return this.Model.EventId; }
            set { this.Model.EventId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "QRY_CHANNEL" field.
        /// </summary>
        public Consensus.Common.Code Channel
        {
            get
            {
                if (_channel == null && this.Model.Channel != null)
                    _channel = new Consensus.Common.Code(this.Model.Channel);
                if (_channel == null)
                    _channel = Consensus.Common.Code.Create();
                return _channel;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "QRY_CHANNEL" field.
        /// </summary>
        public System.String ChannelCode
        {
            get { return this.Model.ChannelCode; }
            set { this.Model.ChannelCode = value; }
        }

        /// <summary>
        ///     Gets the The value of the "QRY_MGR_PROLE_ID" field.
        /// </summary>
        public Consensus.Contact.Role Manager
        {
            get
            {
                if (_manager == null && this.Model.Manager != null)
                    _manager = new Consensus.Contact.Role(this.Model.Manager);
                if (_manager == null)
                    _manager = Consensus.Contact.Role.Create();
                return _manager;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "QRY_MGR_PROLE_ID" field.
        /// </summary>
        public System.String ManagerId
        {
            get { return this.Model.ManagerId; }
            set { this.Model.ManagerId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "QRY_APP_BY_PROLE_ID" field.
        /// </summary>
        public Consensus.Contact.Role Approver
        {
            get
            {
                if (_approver == null && this.Model.Approver != null)
                    _approver = new Consensus.Contact.Role(this.Model.Approver);
                if (_approver == null)
                    _approver = Consensus.Contact.Role.Create();
                return _approver;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "QRY_APP_BY_PROLE_ID" field.
        /// </summary>
        public System.String ApproverId
        {
            get { return this.Model.ApproverId; }
            set { this.Model.ApproverId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_TITLE_SLUG" field.
        /// </summary>
        public System.String TitleSlug
        {
            get { return this.Model.TitleSlug; }
            set { this.Model.TitleSlug = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_ORG_ONLY" field.
        /// </summary>
        public System.Byte OrgOnly
        {
            get { return this.Model.OrgOnly; }
            set { this.Model.OrgOnly = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_ORG_DEDUPE" field.
        /// </summary>
        public System.Byte OrgDedupe
        {
            get { return this.Model.OrgDedupe; }
            set { this.Model.OrgDedupe = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PN_DEDUPE" field.
        /// </summary>
        public System.Byte PnDedupe
        {
            get { return this.Model.PnDedupe; }
            set { this.Model.PnDedupe = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_SAVE_MAIL_SAMPLE" field.
        /// </summary>
        public System.Byte SaveMailSample
        {
            get { return this.Model.SaveMailSample; }
            set { this.Model.SaveMailSample = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_LOCKED" field.
        /// </summary>
        public System.Byte Locked
        {
            get { return this.Model.Locked; }
            set { this.Model.Locked = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PEOPLE_PER_ORG" field.
        /// </summary>
        public System.Int32 PeoplePerOrg
        {
            get { return this.Model.PeoplePerOrg; }
            set { this.Model.PeoplePerOrg = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PN_DONOTMAIL" field.
        /// </summary>
        public System.Byte PnDonotmail
        {
            get { return this.Model.PnDonotmail; }
            set { this.Model.PnDonotmail = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PN_DONOTMAIL2" field.
        /// </summary>
        public System.Byte PnDonotmail2
        {
            get { return this.Model.PnDonotmail2; }
            set { this.Model.PnDonotmail2 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PN_DONOTMAIL3" field.
        /// </summary>
        public System.Byte PnDonotmail3
        {
            get { return this.Model.PnDonotmail3; }
            set { this.Model.PnDonotmail3 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PROLE_DO_NOT_FAX" field.
        /// </summary>
        public System.Byte ProleDoNotFax
        {
            get { return this.Model.ProleDoNotFax; }
            set { this.Model.ProleDoNotFax = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PROLE_DO_NOT_MAIL" field.
        /// </summary>
        public System.Byte ProleDoNotMail
        {
            get { return this.Model.ProleDoNotMail; }
            set { this.Model.ProleDoNotMail = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PN_FLAG_3" field.
        /// </summary>
        public System.Byte PnFlag3
        {
            get { return this.Model.PnFlag3; }
            set { this.Model.PnFlag3 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PROLE_DIS_FLAG" field.
        /// </summary>
        public System.Byte ProleDisFlag
        {
            get { return this.Model.ProleDisFlag; }
            set { this.Model.ProleDisFlag = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PROLE_USERNUM_1" field.
        /// </summary>
        public System.Byte ProleUsernum1
        {
            get { return this.Model.ProleUsernum1; }
            set { this.Model.ProleUsernum1 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PN_FLAG_2" field.
        /// </summary>
        public System.Byte PnFlag2
        {
            get { return this.Model.PnFlag2; }
            set { this.Model.PnFlag2 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_RESULTS_SIZE_OPT" field.
        /// </summary>
        public System.Byte ResultsSizeOpt
        {
            get { return this.Model.ResultsSizeOpt; }
            set { this.Model.ResultsSizeOpt = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_RESULTS_SIZE" field.
        /// </summary>
        public System.Int64 ResultsSize
        {
            get { return this.Model.ResultsSize; }
            set { this.Model.ResultsSize = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_SCHED_RUN_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> SchedRunDate
        {
            get { return this.Model.SchedRunDate; }
            set { this.Model.SchedRunDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_SCHED_RUN_TIME" field.
        /// </summary>
        public System.Nullable<System.DateTime> SchedRunTime
        {
            get { return this.Model.SchedRunTime; }
            set { this.Model.SchedRunTime = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_CALCULATED_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> CalculatedDate
        {
            get { return this.Model.CalculatedDate; }
            set { this.Model.CalculatedDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_OUTPUT_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> OutputDate
        {
            get { return this.Model.OutputDate; }
            set { this.Model.OutputDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_TOTAL_RECORDS" field.
        /// </summary>
        public System.Int64 TotalRecords
        {
            get { return this.Model.TotalRecords; }
            set { this.Model.TotalRecords = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_SAMPLE" field.
        /// </summary>
        public System.Int64 Sample
        {
            get { return this.Model.Sample; }
            set { this.Model.Sample = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_SEEDS" field.
        /// </summary>
        public System.Int64 Seeds
        {
            get { return this.Model.Seeds; }
            set { this.Model.Seeds = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_IN_USE" field.
        /// </summary>
        public System.Byte InUse
        {
            get { return this.Model.InUse; }
            set { this.Model.InUse = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_LAST_RESULT_FILE" field.
        /// </summary>
        public System.String LastResultFile
        {
            get { return this.Model.LastResultFile; }
            set { this.Model.LastResultFile = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_APP_STATUS" field.
        /// </summary>
        public System.Byte AppStatus
        {
            get { return this.Model.AppStatus; }
            set { this.Model.AppStatus = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PROLE_DO_NOT_SWAP" field.
        /// </summary>
        public System.Byte ProleDoNotSwap
        {
            get { return this.Model.ProleDoNotSwap; }
            set { this.Model.ProleDoNotSwap = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PN_FLAG_1" field.
        /// </summary>
        public System.Byte PnFlag1
        {
            get { return this.Model.PnFlag1; }
            set { this.Model.PnFlag1 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PROLE_DO_NOT_EMAIL" field.
        /// </summary>
        public System.Byte ProleDoNotEmail
        {
            get { return this.Model.ProleDoNotEmail; }
            set { this.Model.ProleDoNotEmail = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PROLE_DO_NOT_SPARE" field.
        /// </summary>
        public System.Byte ProleDoNotSpare
        {
            get { return this.Model.ProleDoNotSpare; }
            set { this.Model.ProleDoNotSpare = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_ORG_DONOTMAIL" field.
        /// </summary>
        public System.Byte OrgDonotmail
        {
            get { return this.Model.OrgDonotmail; }
            set { this.Model.OrgDonotmail = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_ORG_USERNUM_1" field.
        /// </summary>
        public System.Byte OrgUsernum1
        {
            get { return this.Model.OrgUsernum1; }
            set { this.Model.OrgUsernum1 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_ORG_FLAG_1" field.
        /// </summary>
        public System.Byte OrgFlag1
        {
            get { return this.Model.OrgFlag1; }
            set { this.Model.OrgFlag1 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_ORG_DONOTFAX" field.
        /// </summary>
        public System.Byte OrgDonotfax
        {
            get { return this.Model.OrgDonotfax; }
            set { this.Model.OrgDonotfax = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PROLE_DO_NOT_SPARE1" field.
        /// </summary>
        public System.Nullable<System.Byte> ProleDoNotSpare1
        {
            get { return this.Model.ProleDoNotSpare1; }
            set { this.Model.ProleDoNotSpare1 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PROLE_DO_NOT_SPARE2" field.
        /// </summary>
        public System.Nullable<System.Byte> ProleDoNotSpare2
        {
            get { return this.Model.ProleDoNotSpare2; }
            set { this.Model.ProleDoNotSpare2 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PROLE_DO_NOT_SPARE3" field.
        /// </summary>
        public System.Nullable<System.Byte> ProleDoNotSpare3
        {
            get { return this.Model.ProleDoNotSpare3; }
            set { this.Model.ProleDoNotSpare3 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PROLE_DO_NOT_SPARE4" field.
        /// </summary>
        public System.Nullable<System.Byte> ProleDoNotSpare4
        {
            get { return this.Model.ProleDoNotSpare4; }
            set { this.Model.ProleDoNotSpare4 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PN_DO_NOT_SPARE1" field.
        /// </summary>
        public System.Nullable<System.Byte> PnDoNotSpare1
        {
            get { return this.Model.PnDoNotSpare1; }
            set { this.Model.PnDoNotSpare1 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PN_DO_NOT_SPARE2" field.
        /// </summary>
        public System.Nullable<System.Byte> PnDoNotSpare2
        {
            get { return this.Model.PnDoNotSpare2; }
            set { this.Model.PnDoNotSpare2 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PN_DO_NOT_SPARE3" field.
        /// </summary>
        public System.Nullable<System.Byte> PnDoNotSpare3
        {
            get { return this.Model.PnDoNotSpare3; }
            set { this.Model.PnDoNotSpare3 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PN_DO_NOT_SPARE4" field.
        /// </summary>
        public System.Nullable<System.Byte> PnDoNotSpare4
        {
            get { return this.Model.PnDoNotSpare4; }
            set { this.Model.PnDoNotSpare4 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_ORG_DO_NOT_SPARE1" field.
        /// </summary>
        public System.Nullable<System.Byte> OrgDoNotSpare1
        {
            get { return this.Model.OrgDoNotSpare1; }
            set { this.Model.OrgDoNotSpare1 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_ORG_DO_NOT_SPARE2" field.
        /// </summary>
        public System.Nullable<System.Byte> OrgDoNotSpare2
        {
            get { return this.Model.OrgDoNotSpare2; }
            set { this.Model.OrgDoNotSpare2 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_ORG_DO_NOT_SPARE3" field.
        /// </summary>
        public System.Nullable<System.Byte> OrgDoNotSpare3
        {
            get { return this.Model.OrgDoNotSpare3; }
            set { this.Model.OrgDoNotSpare3 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_ORG_DO_NOT_SPARE4" field.
        /// </summary>
        public System.Nullable<System.Byte> OrgDoNotSpare4
        {
            get { return this.Model.OrgDoNotSpare4; }
            set { this.Model.OrgDoNotSpare4 = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SaqQueryStepModel" /> instances that reference this <see cref="!:SaqQueryModel" />.
        /// </summary>
        public Collection<Consensus.Marketing.SaqQueryStep> SaqQueryStepQuery
        {
            get
            {
                if (_saqQueryStepQuery == null)
                    _saqQueryStepQuery = new ProxyCollection<Consensus.Marketing.SaqQueryStep, Consensus.Marketing.ISaqQueryStepModel>(this.Model.SaqQueryStepQuery, model => new Consensus.Marketing.SaqQueryStep(model));
                return _saqQueryStepQuery;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SaqQueueModel" /> instances that reference this <see cref="!:SaqQueryModel" />.
        /// </summary>
        public Collection<Consensus.Marketing.SaqQueue> SaqQueueQuery
        {
            get
            {
                if (_saqQueueQuery == null)
                    _saqQueueQuery = new ProxyCollection<Consensus.Marketing.SaqQueue, Consensus.Marketing.ISaqQueueModel>(this.Model.SaqQueueQuery, model => new Consensus.Marketing.SaqQueue(model));
                return _saqQueueQuery;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal SaqQuery(ISaqQueryModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:SaqQueryModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SaqQueryModel" /> instance.
        /// </returns>
        public static Consensus.Marketing.SaqQuery Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SaqQuery.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:SaqQueryModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SaqQueryModel" /> instance.
        /// </returns>
        public static Consensus.Marketing.SaqQuery Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Marketing.ISaqQueryModel model = provider.Marketing.SaqQuery.Create();
            return model == null ? null : new Consensus.Marketing.SaqQuery(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SaqQueryModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SaqQueryModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.SaqQuery> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SaqQuery.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SaqQueryModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SaqQueryModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.SaqQuery> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Marketing.ISaqQueryModel> collection = provider.Marketing.SaqQuery.FetchAll();
            return collection.Select(model => new Consensus.Marketing.SaqQuery(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:SaqQueryModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SaqQueryModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqQueryModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Marketing.SaqQuery FetchById(System.Int64 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SaqQuery.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:SaqQueryModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SaqQueryModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqQueryModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Marketing.SaqQuery FetchById(ConsensusSite site, System.Int64 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Marketing.ISaqQueryModel model = provider.Marketing.SaqQuery.FetchById(id);
            return model == null ? null : new Consensus.Marketing.SaqQuery(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SaqQuery.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Marketing.SaqQuery.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SaqQueryModel" /> instances.
        /// </summary>
        /// <param name="sourceCodeId">
        ///     The value which identifies the <see cref="!:SaqQueryModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqQueryModel" /> instances that match the specified <paramref name="sourceCodeId" />.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.SaqQuery> FetchAllBySourceCodeId(System.String sourceCodeId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SaqQuery.FetchAllBySourceCodeId(site,sourceCodeId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SaqQueryModel" /> instances.
        /// </summary>
        /// <param name="sourceCodeId">
        ///     The value which identifies the <see cref="!:SaqQueryModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqQueryModel" /> instances that match the specified <paramref name="sourceCodeId" />.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.SaqQuery> FetchAllBySourceCodeId(ConsensusSite site, System.String sourceCodeId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Marketing.ISaqQueryModel> collection = provider.Marketing.SaqQuery.FetchAllBySourceCodeId(sourceCodeId);
            return collection.Select(model => new Consensus.Marketing.SaqQuery(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SaqQueryModel" /> instances.
        /// </summary>
        /// <param name="eventId">
        ///     The value which identifies the <see cref="!:SaqQueryModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqQueryModel" /> instances that match the specified <paramref name="eventId" />.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.SaqQuery> FetchAllByEventId(System.String eventId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SaqQuery.FetchAllByEventId(site,eventId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SaqQueryModel" /> instances.
        /// </summary>
        /// <param name="eventId">
        ///     The value which identifies the <see cref="!:SaqQueryModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqQueryModel" /> instances that match the specified <paramref name="eventId" />.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.SaqQuery> FetchAllByEventId(ConsensusSite site, System.String eventId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Marketing.ISaqQueryModel> collection = provider.Marketing.SaqQuery.FetchAllByEventId(eventId);
            return collection.Select(model => new Consensus.Marketing.SaqQuery(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SaqQueryModel" /> instances.
        /// </summary>
        /// <param name="managerId">
        ///     The value which identifies the <see cref="!:SaqQueryModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqQueryModel" /> instances that match the specified <paramref name="managerId" />.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.SaqQuery> FetchAllByManagerId(System.String managerId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SaqQuery.FetchAllByManagerId(site,managerId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SaqQueryModel" /> instances.
        /// </summary>
        /// <param name="managerId">
        ///     The value which identifies the <see cref="!:SaqQueryModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqQueryModel" /> instances that match the specified <paramref name="managerId" />.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.SaqQuery> FetchAllByManagerId(ConsensusSite site, System.String managerId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Marketing.ISaqQueryModel> collection = provider.Marketing.SaqQuery.FetchAllByManagerId(managerId);
            return collection.Select(model => new Consensus.Marketing.SaqQuery(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SaqQueryModel" /> instances.
        /// </summary>
        /// <param name="approverId">
        ///     The value which identifies the <see cref="!:SaqQueryModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqQueryModel" /> instances that match the specified <paramref name="approverId" />.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.SaqQuery> FetchAllByApproverId(System.String approverId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SaqQuery.FetchAllByApproverId(site,approverId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SaqQueryModel" /> instances.
        /// </summary>
        /// <param name="approverId">
        ///     The value which identifies the <see cref="!:SaqQueryModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqQueryModel" /> instances that match the specified <paramref name="approverId" />.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.SaqQuery> FetchAllByApproverId(ConsensusSite site, System.String approverId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Marketing.ISaqQueryModel> collection = provider.Marketing.SaqQuery.FetchAllByApproverId(approverId);
            return collection.Select(model => new Consensus.Marketing.SaqQuery(model));
        }

        #endregion
    }
}
