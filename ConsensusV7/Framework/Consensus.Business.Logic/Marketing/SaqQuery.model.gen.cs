using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Contact;
using Consensus.Learning;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Encapsulates the <see cref="SaqQueryRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalSaqQueryModel : LocalModel<SaqQueryRecord, Int64>, ISaqQueryModel
    {
        #region fields

        /// <summary>
        ///     The value of the "QRY_STATUS" field.
        /// </summary>
        private LocalCodeModel _status;

        /// <summary>
        ///     The value of the "QRY_PM_ID" field.
        /// </summary>
        private LocalPromotionModel _sourceCode;

        /// <summary>
        ///     The value of the "QRY_COURSE_ID" field.
        /// </summary>
        private LocalEventModel _event;

        /// <summary>
        ///     The value of the "QRY_CHANNEL" field.
        /// </summary>
        private LocalCodeModel _channel;

        /// <summary>
        ///     The value of the "QRY_MGR_PROLE_ID" field.
        /// </summary>
        private LocalRoleModel _manager;

        /// <summary>
        ///     The value of the "QRY_APP_BY_PROLE_ID" field.
        /// </summary>
        private LocalRoleModel _approver;

        /// <summary>
        ///     The collection of <see cref="SaqQueryStepModel" /> instances that reference this <see cref="SaqQueryModel" />.
        /// </summary>
        private LocalCollection<LocalSaqQueryStepModel, ISaqQueryStepModel> _saqQueryStepQuery;

        /// <summary>
        ///     The collection of <see cref="SaqQueueModel" /> instances that reference this <see cref="SaqQueryModel" />.
        /// </summary>
        private LocalCollection<LocalSaqQueueModel, ISaqQueueModel> _saqQueueQuery;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<SaqQueryRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Marketing.SaqQuery.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<SaqQueryRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Marketing.SaqQuery.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<SaqQueryRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Marketing.SaqQuery.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_NAME" field.
        /// </summary>
        public String Name
        {
            get { return this.ModifiedData.Name; }
            set { this.ModifiedData.Name = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_DESC" field.
        /// </summary>
        public String Desc
        {
            get { return this.ModifiedData.Desc; }
            set { this.ModifiedData.Desc = value; }
        }

        /// <summary>
        ///     Gets the The value of the "QRY_STATUS" field.
        /// </summary>
        public LocalCodeModel Status
        {
            get
            {
                if (_status == null && !String.IsNullOrEmpty(this.StatusCode))
                    _status = this.Provider.Common.Code.FetchByTypeAndCode("QRYST", this.StatusCode);
                if (_status == null)
                    _status = this.Provider.Common.Code.Create("QRYST");
                return _status;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "QRY_STATUS" field.
        /// </summary>
        public String StatusCode
        {
            get { return this.ModifiedData.Status; }
            set
            {
                if (this.ModifiedData.Status != value)
                     _status = null;
                this.ModifiedData.Status = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "QRY_PM_ID" field.
        /// </summary>
        public LocalPromotionModel SourceCode
        {
            get
            {
                if (_sourceCode == null && this.SourceCodeId != null)
                    _sourceCode = this.Provider.Marketing.Promotion.FetchById(this.SourceCodeId);
                if (_sourceCode == null)
                    _sourceCode = this.Provider.Marketing.Promotion.Create();
                
                return _sourceCode;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "QRY_PM_ID" field.
        /// </summary>
        public String SourceCodeId
        {
            get { return this.ModifiedData.PmId; }
            set
            {
                if (this.ModifiedData.PmId != value)
                     _sourceCode = null;
                this.ModifiedData.PmId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "QRY_COURSE_ID" field.
        /// </summary>
        public LocalEventModel Event
        {
            get
            {
                if (_event == null && this.EventId != null)
                    _event = this.Provider.Learning.Event.FetchById(this.EventId);
                if (_event == null)
                    _event = this.Provider.Learning.Event.Create();
                
                return _event;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "QRY_COURSE_ID" field.
        /// </summary>
        public String EventId
        {
            get { return this.ModifiedData.CourseId; }
            set
            {
                if (this.ModifiedData.CourseId != value)
                     _event = null;
                this.ModifiedData.CourseId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "QRY_CHANNEL" field.
        /// </summary>
        public LocalCodeModel Channel
        {
            get
            {
                if (_channel == null && !String.IsNullOrEmpty(this.ChannelCode))
                    _channel = this.Provider.Common.Code.FetchByTypeAndCode("CHAN", this.ChannelCode);
                if (_channel == null)
                    _channel = this.Provider.Common.Code.Create("CHAN");
                return _channel;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "QRY_CHANNEL" field.
        /// </summary>
        public String ChannelCode
        {
            get { return this.ModifiedData.Channel; }
            set
            {
                if (this.ModifiedData.Channel != value)
                     _channel = null;
                this.ModifiedData.Channel = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "QRY_MGR_PROLE_ID" field.
        /// </summary>
        public LocalRoleModel Manager
        {
            get
            {
                if (_manager == null && this.ManagerId != null)
                    _manager = this.Provider.Contact.Role.FetchById(this.ManagerId);
                if (_manager == null)
                    _manager = this.Provider.Contact.Role.Create();
                
                return _manager;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "QRY_MGR_PROLE_ID" field.
        /// </summary>
        public String ManagerId
        {
            get { return this.ModifiedData.MgrProleId; }
            set
            {
                if (this.ModifiedData.MgrProleId != value)
                     _manager = null;
                this.ModifiedData.MgrProleId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "QRY_APP_BY_PROLE_ID" field.
        /// </summary>
        public LocalRoleModel Approver
        {
            get
            {
                if (_approver == null && this.ApproverId != null)
                    _approver = this.Provider.Contact.Role.FetchById(this.ApproverId);
                if (_approver == null)
                    _approver = this.Provider.Contact.Role.Create();
                
                return _approver;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "QRY_APP_BY_PROLE_ID" field.
        /// </summary>
        public String ApproverId
        {
            get { return this.ModifiedData.AppByProleId; }
            set
            {
                if (this.ModifiedData.AppByProleId != value)
                     _approver = null;
                this.ModifiedData.AppByProleId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_TITLE_SLUG" field.
        /// </summary>
        public String TitleSlug
        {
            get { return this.ModifiedData.TitleSlug; }
            set { this.ModifiedData.TitleSlug = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_ORG_ONLY" field.
        /// </summary>
        public Byte OrgOnly
        {
            get { return this.ModifiedData.OrgOnly; }
            set { this.ModifiedData.OrgOnly = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_ORG_DEDUPE" field.
        /// </summary>
        public Byte OrgDedupe
        {
            get { return this.ModifiedData.OrgDedupe; }
            set { this.ModifiedData.OrgDedupe = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PN_DEDUPE" field.
        /// </summary>
        public Byte PnDedupe
        {
            get { return this.ModifiedData.PnDedupe; }
            set { this.ModifiedData.PnDedupe = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_SAVE_MAIL_SAMPLE" field.
        /// </summary>
        public Byte SaveMailSample
        {
            get { return this.ModifiedData.SaveMailSample; }
            set { this.ModifiedData.SaveMailSample = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_LOCKED" field.
        /// </summary>
        public Byte Locked
        {
            get { return this.ModifiedData.Locked; }
            set { this.ModifiedData.Locked = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PEOPLE_PER_ORG" field.
        /// </summary>
        public Int32 PeoplePerOrg
        {
            get { return this.ModifiedData.PeoplePerOrg; }
            set { this.ModifiedData.PeoplePerOrg = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PN_DONOTMAIL" field.
        /// </summary>
        public Byte PnDonotmail
        {
            get { return this.ModifiedData.PnDonotmail; }
            set { this.ModifiedData.PnDonotmail = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PN_DONOTMAIL2" field.
        /// </summary>
        public Byte PnDonotmail2
        {
            get { return this.ModifiedData.PnDonotmail2; }
            set { this.ModifiedData.PnDonotmail2 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PN_DONOTMAIL3" field.
        /// </summary>
        public Byte PnDonotmail3
        {
            get { return this.ModifiedData.PnDonotmail3; }
            set { this.ModifiedData.PnDonotmail3 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PROLE_DO_NOT_FAX" field.
        /// </summary>
        public Byte ProleDoNotFax
        {
            get { return this.ModifiedData.ProleDoNotFax; }
            set { this.ModifiedData.ProleDoNotFax = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PROLE_DO_NOT_MAIL" field.
        /// </summary>
        public Byte ProleDoNotMail
        {
            get { return this.ModifiedData.ProleDoNotMail; }
            set { this.ModifiedData.ProleDoNotMail = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PN_FLAG_3" field.
        /// </summary>
        public Byte PnFlag3
        {
            get { return this.ModifiedData.PnFlag3; }
            set { this.ModifiedData.PnFlag3 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PROLE_DIS_FLAG" field.
        /// </summary>
        public Byte ProleDisFlag
        {
            get { return this.ModifiedData.ProleDisFlag; }
            set { this.ModifiedData.ProleDisFlag = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PROLE_USERNUM_1" field.
        /// </summary>
        public Byte ProleUsernum1
        {
            get { return this.ModifiedData.ProleUsernum1; }
            set { this.ModifiedData.ProleUsernum1 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PN_FLAG_2" field.
        /// </summary>
        public Byte PnFlag2
        {
            get { return this.ModifiedData.PnFlag2; }
            set { this.ModifiedData.PnFlag2 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_RESULTS_SIZE_OPT" field.
        /// </summary>
        public Byte ResultsSizeOpt
        {
            get { return this.ModifiedData.ResultsSizeOpt; }
            set { this.ModifiedData.ResultsSizeOpt = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_RESULTS_SIZE" field.
        /// </summary>
        public Int64 ResultsSize
        {
            get { return this.ModifiedData.ResultsSize; }
            set { this.ModifiedData.ResultsSize = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_SCHED_RUN_DATE" field.
        /// </summary>
        public DateTime? SchedRunDate
        {
            get { return this.ModifiedData.SchedRunDate; }
            set { this.ModifiedData.SchedRunDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_SCHED_RUN_TIME" field.
        /// </summary>
        public DateTime? SchedRunTime
        {
            get { return this.ModifiedData.SchedRunTime; }
            set { this.ModifiedData.SchedRunTime = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_CALCULATED_DATE" field.
        /// </summary>
        public DateTime? CalculatedDate
        {
            get { return this.ModifiedData.CalculatedDate; }
            set { this.ModifiedData.CalculatedDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_OUTPUT_DATE" field.
        /// </summary>
        public DateTime? OutputDate
        {
            get { return this.ModifiedData.OutputDate; }
            set { this.ModifiedData.OutputDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_TOTAL_RECORDS" field.
        /// </summary>
        public Int64 TotalRecords
        {
            get { return this.ModifiedData.TotalRecords; }
            set { this.ModifiedData.TotalRecords = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_SAMPLE" field.
        /// </summary>
        public Int64 Sample
        {
            get { return this.ModifiedData.Sample; }
            set { this.ModifiedData.Sample = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_SEEDS" field.
        /// </summary>
        public Int64 Seeds
        {
            get { return this.ModifiedData.Seeds; }
            set { this.ModifiedData.Seeds = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_IN_USE" field.
        /// </summary>
        public Byte InUse
        {
            get { return this.ModifiedData.InUse; }
            set { this.ModifiedData.InUse = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_LAST_RESULT_FILE" field.
        /// </summary>
        public String LastResultFile
        {
            get { return this.ModifiedData.LastResultFile; }
            set { this.ModifiedData.LastResultFile = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_APP_STATUS" field.
        /// </summary>
        public Byte AppStatus
        {
            get { return this.ModifiedData.AppStatus; }
            set { this.ModifiedData.AppStatus = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PROLE_DO_NOT_SWAP" field.
        /// </summary>
        public Byte ProleDoNotSwap
        {
            get { return this.ModifiedData.ProleDoNotSwap; }
            set { this.ModifiedData.ProleDoNotSwap = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PN_FLAG_1" field.
        /// </summary>
        public Byte PnFlag1
        {
            get { return this.ModifiedData.PnFlag1; }
            set { this.ModifiedData.PnFlag1 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PROLE_DO_NOT_EMAIL" field.
        /// </summary>
        public Byte ProleDoNotEmail
        {
            get { return this.ModifiedData.ProleDoNotEmail; }
            set { this.ModifiedData.ProleDoNotEmail = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PROLE_DO_NOT_SPARE" field.
        /// </summary>
        public Byte ProleDoNotSpare
        {
            get { return this.ModifiedData.ProleDoNotSpare; }
            set { this.ModifiedData.ProleDoNotSpare = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_ORG_DONOTMAIL" field.
        /// </summary>
        public Byte OrgDonotmail
        {
            get { return this.ModifiedData.OrgDonotmail; }
            set { this.ModifiedData.OrgDonotmail = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_ORG_USERNUM_1" field.
        /// </summary>
        public Byte OrgUsernum1
        {
            get { return this.ModifiedData.OrgUsernum1; }
            set { this.ModifiedData.OrgUsernum1 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_ORG_FLAG_1" field.
        /// </summary>
        public Byte OrgFlag1
        {
            get { return this.ModifiedData.OrgFlag1; }
            set { this.ModifiedData.OrgFlag1 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_ORG_DONOTFAX" field.
        /// </summary>
        public Byte OrgDonotfax
        {
            get { return this.ModifiedData.OrgDonotfax; }
            set { this.ModifiedData.OrgDonotfax = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PROLE_DO_NOT_SPARE1" field.
        /// </summary>
        public Byte? ProleDoNotSpare1
        {
            get { return this.ModifiedData.ProleDoNotSpare1; }
            set { this.ModifiedData.ProleDoNotSpare1 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PROLE_DO_NOT_SPARE2" field.
        /// </summary>
        public Byte? ProleDoNotSpare2
        {
            get { return this.ModifiedData.ProleDoNotSpare2; }
            set { this.ModifiedData.ProleDoNotSpare2 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PROLE_DO_NOT_SPARE3" field.
        /// </summary>
        public Byte? ProleDoNotSpare3
        {
            get { return this.ModifiedData.ProleDoNotSpare3; }
            set { this.ModifiedData.ProleDoNotSpare3 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PROLE_DO_NOT_SPARE4" field.
        /// </summary>
        public Byte? ProleDoNotSpare4
        {
            get { return this.ModifiedData.ProleDoNotSpare4; }
            set { this.ModifiedData.ProleDoNotSpare4 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PN_DO_NOT_SPARE1" field.
        /// </summary>
        public Byte? PnDoNotSpare1
        {
            get { return this.ModifiedData.PnDoNotSpare1; }
            set { this.ModifiedData.PnDoNotSpare1 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PN_DO_NOT_SPARE2" field.
        /// </summary>
        public Byte? PnDoNotSpare2
        {
            get { return this.ModifiedData.PnDoNotSpare2; }
            set { this.ModifiedData.PnDoNotSpare2 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PN_DO_NOT_SPARE3" field.
        /// </summary>
        public Byte? PnDoNotSpare3
        {
            get { return this.ModifiedData.PnDoNotSpare3; }
            set { this.ModifiedData.PnDoNotSpare3 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PN_DO_NOT_SPARE4" field.
        /// </summary>
        public Byte? PnDoNotSpare4
        {
            get { return this.ModifiedData.PnDoNotSpare4; }
            set { this.ModifiedData.PnDoNotSpare4 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_ORG_DO_NOT_SPARE1" field.
        /// </summary>
        public Byte? OrgDoNotSpare1
        {
            get { return this.ModifiedData.OrgDoNotSpare1; }
            set { this.ModifiedData.OrgDoNotSpare1 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_ORG_DO_NOT_SPARE2" field.
        /// </summary>
        public Byte? OrgDoNotSpare2
        {
            get { return this.ModifiedData.OrgDoNotSpare2; }
            set { this.ModifiedData.OrgDoNotSpare2 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_ORG_DO_NOT_SPARE3" field.
        /// </summary>
        public Byte? OrgDoNotSpare3
        {
            get { return this.ModifiedData.OrgDoNotSpare3; }
            set { this.ModifiedData.OrgDoNotSpare3 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_ORG_DO_NOT_SPARE4" field.
        /// </summary>
        public Byte? OrgDoNotSpare4
        {
            get { return this.ModifiedData.OrgDoNotSpare4; }
            set { this.ModifiedData.OrgDoNotSpare4 = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="SaqQueryStepModel" /> instances that reference this <see cref="SaqQueryModel" />.
        /// </summary>
        public LocalCollection<LocalSaqQueryStepModel, ISaqQueryStepModel> SaqQueryStepQuery
        {
            get
            {
                if (_saqQueryStepQuery == null)
                    _saqQueryStepQuery = new LocalCollection<LocalSaqQueryStepModel, ISaqQueryStepModel>(this.Provider.Marketing.SaqQueryStep.FetchAllByStepQueryId(this.Id));
                
                return _saqQueryStepQuery;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="SaqQueueModel" /> instances that reference this <see cref="SaqQueryModel" />.
        /// </summary>
        public LocalCollection<LocalSaqQueueModel, ISaqQueueModel> SaqQueueQuery
        {
            get
            {
                if (_saqQueueQuery == null)
                    _saqQueueQuery = new LocalCollection<LocalSaqQueueModel, ISaqQueueModel>(this.Provider.Marketing.SaqQueue.FetchAllByQueryId(this.Id));
                
                return _saqQueueQuery;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalSaqQueryModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalSaqQueryModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalSaqQueryModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalSaqQueryModel(LocalProvider provider, SaqQueryRecord record) : base(provider, record)
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
            if (_status != null)
            {
                _status.Save();
                this.ModifiedData.Status = _status.Value1;
            }
            if (_channel != null)
            {
                _channel.Save();
                this.ModifiedData.Channel = _channel.Value1;
            }
            if (_sourceCode != null)
            {
                _sourceCode.Save();
                this.ModifiedData.PmId = _sourceCode.Id == null && this.ModifiedData.PmId != null ? "" : _sourceCode.Id;
            }
            if (_event != null)
            {
                _event.Save();
                this.ModifiedData.CourseId = _event.Id == null && this.ModifiedData.CourseId != null ? "" : _event.Id;
            }
            if (_manager != null)
            {
                _manager.Save();
                this.ModifiedData.MgrProleId = _manager.Id == null && this.ModifiedData.MgrProleId != null ? "" : _manager.Id;
            }
            if (_approver != null)
            {
                _approver.Save();
                this.ModifiedData.AppByProleId = _approver.Id == null && this.ModifiedData.AppByProleId != null ? "" : _approver.Id;
            }
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
            if (_saqQueryStepQuery != null)
                _saqQueryStepQuery.Execute(obj => obj.StepQueryId = this.Id).Execute(obj => obj.Save());
            if (_saqQueueQuery != null)
                _saqQueueQuery.Execute(obj => obj.QueryId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        System.Boolean ISaqQueryModel.PnDoNotEmailBool
        {
            get { return this.PnDoNotEmailBool; }
            set { this.PnDoNotEmailBool = (System.Boolean)value; }
        }

        System.Boolean ISaqQueryModel.PnDoNotMailBool
        {
            get { return this.PnDoNotMailBool; }
            set { this.PnDoNotMailBool = (System.Boolean)value; }
        }

        System.Boolean ISaqQueryModel.PnDoNotFaxBool
        {
            get { return this.PnDoNotFaxBool; }
            set { this.PnDoNotFaxBool = (System.Boolean)value; }
        }

        System.Boolean ISaqQueryModel.PnDoNotSwapBool
        {
            get { return this.PnDoNotSwapBool; }
            set { this.PnDoNotSwapBool = (System.Boolean)value; }
        }

        System.Boolean ISaqQueryModel.PnExcludeArchivedBool
        {
            get { return this.PnExcludeArchivedBool; }
            set { this.PnExcludeArchivedBool = (System.Boolean)value; }
        }

        System.Boolean ISaqQueryModel.ProleDoNotEmailBool
        {
            get { return this.ProleDoNotEmailBool; }
            set { this.ProleDoNotEmailBool = (System.Boolean)value; }
        }

        System.Boolean ISaqQueryModel.ProleDoNotMailBool
        {
            get { return this.ProleDoNotMailBool; }
            set { this.ProleDoNotMailBool = (System.Boolean)value; }
        }

        System.Boolean ISaqQueryModel.ProleDoNotFaxBool
        {
            get { return this.ProleDoNotFaxBool; }
            set { this.ProleDoNotFaxBool = (System.Boolean)value; }
        }

        System.Boolean ISaqQueryModel.ProleDoNotSwapBool
        {
            get { return this.ProleDoNotSwapBool; }
            set { this.ProleDoNotSwapBool = (System.Boolean)value; }
        }

        System.Boolean ISaqQueryModel.ProleDoNotCallBool
        {
            get { return this.ProleDoNotCallBool; }
            set { this.ProleDoNotCallBool = (System.Boolean)value; }
        }

        System.Boolean ISaqQueryModel.ProleExcludeDisabledBool
        {
            get { return this.ProleExcludeDisabledBool; }
            set { this.ProleExcludeDisabledBool = (System.Boolean)value; }
        }

        System.Boolean ISaqQueryModel.OrgDoNotEmailBool
        {
            get { return this.OrgDoNotEmailBool; }
            set { this.OrgDoNotEmailBool = (System.Boolean)value; }
        }

        System.Boolean ISaqQueryModel.OrgDoNotMailBool
        {
            get { return this.OrgDoNotMailBool; }
            set { this.OrgDoNotMailBool = (System.Boolean)value; }
        }

        System.Boolean ISaqQueryModel.OrgDoNotFaxBool
        {
            get { return this.OrgDoNotFaxBool; }
            set { this.OrgDoNotFaxBool = (System.Boolean)value; }
        }

        System.Boolean ISaqQueryModel.OrgDoNotRentBool
        {
            get { return this.OrgDoNotRentBool; }
            set { this.OrgDoNotRentBool = (System.Boolean)value; }
        }

        System.Byte ISaqQueryModel.Dedupe
        {
            get { return this.Dedupe; }
            set { this.Dedupe = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_NAME" field.
        /// </summary>
        System.String ISaqQueryModel.Name
        {
            get { return this.Name; }
            set { this.Name = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_DESC" field.
        /// </summary>
        System.String ISaqQueryModel.Desc
        {
            get { return this.Desc; }
            set { this.Desc = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "QRY_STATUS" field.
        /// </summary>
        Consensus.Common.ICodeModel ISaqQueryModel.Status
        {
            get { return this.Status; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "QRY_STATUS" field.
        /// </summary>
        System.String ISaqQueryModel.StatusCode
        {
            get { return this.StatusCode; }
            set { this.StatusCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "QRY_PM_ID" field.
        /// </summary>
        Consensus.Marketing.IPromotionModel ISaqQueryModel.SourceCode
        {
            get { return this.SourceCode; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "QRY_PM_ID" field.
        /// </summary>
        System.String ISaqQueryModel.SourceCodeId
        {
            get { return this.SourceCodeId; }
            set { this.SourceCodeId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "QRY_COURSE_ID" field.
        /// </summary>
        Consensus.Learning.IEventModel ISaqQueryModel.Event
        {
            get { return this.Event; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "QRY_COURSE_ID" field.
        /// </summary>
        System.String ISaqQueryModel.EventId
        {
            get { return this.EventId; }
            set { this.EventId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "QRY_CHANNEL" field.
        /// </summary>
        Consensus.Common.ICodeModel ISaqQueryModel.Channel
        {
            get { return this.Channel; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "QRY_CHANNEL" field.
        /// </summary>
        System.String ISaqQueryModel.ChannelCode
        {
            get { return this.ChannelCode; }
            set { this.ChannelCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "QRY_MGR_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel ISaqQueryModel.Manager
        {
            get { return this.Manager; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "QRY_MGR_PROLE_ID" field.
        /// </summary>
        System.String ISaqQueryModel.ManagerId
        {
            get { return this.ManagerId; }
            set { this.ManagerId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "QRY_APP_BY_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel ISaqQueryModel.Approver
        {
            get { return this.Approver; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "QRY_APP_BY_PROLE_ID" field.
        /// </summary>
        System.String ISaqQueryModel.ApproverId
        {
            get { return this.ApproverId; }
            set { this.ApproverId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_TITLE_SLUG" field.
        /// </summary>
        System.String ISaqQueryModel.TitleSlug
        {
            get { return this.TitleSlug; }
            set { this.TitleSlug = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_ORG_ONLY" field.
        /// </summary>
        System.Byte ISaqQueryModel.OrgOnly
        {
            get { return this.OrgOnly; }
            set { this.OrgOnly = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_ORG_DEDUPE" field.
        /// </summary>
        System.Byte ISaqQueryModel.OrgDedupe
        {
            get { return this.OrgDedupe; }
            set { this.OrgDedupe = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PN_DEDUPE" field.
        /// </summary>
        System.Byte ISaqQueryModel.PnDedupe
        {
            get { return this.PnDedupe; }
            set { this.PnDedupe = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_SAVE_MAIL_SAMPLE" field.
        /// </summary>
        System.Byte ISaqQueryModel.SaveMailSample
        {
            get { return this.SaveMailSample; }
            set { this.SaveMailSample = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_LOCKED" field.
        /// </summary>
        System.Byte ISaqQueryModel.Locked
        {
            get { return this.Locked; }
            set { this.Locked = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PEOPLE_PER_ORG" field.
        /// </summary>
        System.Int32 ISaqQueryModel.PeoplePerOrg
        {
            get { return this.PeoplePerOrg; }
            set { this.PeoplePerOrg = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PN_DONOTMAIL" field.
        /// </summary>
        System.Byte ISaqQueryModel.PnDonotmail
        {
            get { return this.PnDonotmail; }
            set { this.PnDonotmail = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PN_DONOTMAIL2" field.
        /// </summary>
        System.Byte ISaqQueryModel.PnDonotmail2
        {
            get { return this.PnDonotmail2; }
            set { this.PnDonotmail2 = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PN_DONOTMAIL3" field.
        /// </summary>
        System.Byte ISaqQueryModel.PnDonotmail3
        {
            get { return this.PnDonotmail3; }
            set { this.PnDonotmail3 = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PROLE_DO_NOT_FAX" field.
        /// </summary>
        System.Byte ISaqQueryModel.ProleDoNotFax
        {
            get { return this.ProleDoNotFax; }
            set { this.ProleDoNotFax = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PROLE_DO_NOT_MAIL" field.
        /// </summary>
        System.Byte ISaqQueryModel.ProleDoNotMail
        {
            get { return this.ProleDoNotMail; }
            set { this.ProleDoNotMail = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PN_FLAG_3" field.
        /// </summary>
        System.Byte ISaqQueryModel.PnFlag3
        {
            get { return this.PnFlag3; }
            set { this.PnFlag3 = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PROLE_DIS_FLAG" field.
        /// </summary>
        System.Byte ISaqQueryModel.ProleDisFlag
        {
            get { return this.ProleDisFlag; }
            set { this.ProleDisFlag = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PROLE_USERNUM_1" field.
        /// </summary>
        System.Byte ISaqQueryModel.ProleUsernum1
        {
            get { return this.ProleUsernum1; }
            set { this.ProleUsernum1 = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PN_FLAG_2" field.
        /// </summary>
        System.Byte ISaqQueryModel.PnFlag2
        {
            get { return this.PnFlag2; }
            set { this.PnFlag2 = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_RESULTS_SIZE_OPT" field.
        /// </summary>
        System.Byte ISaqQueryModel.ResultsSizeOpt
        {
            get { return this.ResultsSizeOpt; }
            set { this.ResultsSizeOpt = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_RESULTS_SIZE" field.
        /// </summary>
        System.Int64 ISaqQueryModel.ResultsSize
        {
            get { return this.ResultsSize; }
            set { this.ResultsSize = (System.Int64)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_SCHED_RUN_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> ISaqQueryModel.SchedRunDate
        {
            get { return this.SchedRunDate; }
            set { this.SchedRunDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_SCHED_RUN_TIME" field.
        /// </summary>
        System.Nullable<System.DateTime> ISaqQueryModel.SchedRunTime
        {
            get { return this.SchedRunTime; }
            set { this.SchedRunTime = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_CALCULATED_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> ISaqQueryModel.CalculatedDate
        {
            get { return this.CalculatedDate; }
            set { this.CalculatedDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_OUTPUT_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> ISaqQueryModel.OutputDate
        {
            get { return this.OutputDate; }
            set { this.OutputDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_TOTAL_RECORDS" field.
        /// </summary>
        System.Int64 ISaqQueryModel.TotalRecords
        {
            get { return this.TotalRecords; }
            set { this.TotalRecords = (System.Int64)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_SAMPLE" field.
        /// </summary>
        System.Int64 ISaqQueryModel.Sample
        {
            get { return this.Sample; }
            set { this.Sample = (System.Int64)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_SEEDS" field.
        /// </summary>
        System.Int64 ISaqQueryModel.Seeds
        {
            get { return this.Seeds; }
            set { this.Seeds = (System.Int64)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_IN_USE" field.
        /// </summary>
        System.Byte ISaqQueryModel.InUse
        {
            get { return this.InUse; }
            set { this.InUse = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_LAST_RESULT_FILE" field.
        /// </summary>
        System.String ISaqQueryModel.LastResultFile
        {
            get { return this.LastResultFile; }
            set { this.LastResultFile = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_APP_STATUS" field.
        /// </summary>
        System.Byte ISaqQueryModel.AppStatus
        {
            get { return this.AppStatus; }
            set { this.AppStatus = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PROLE_DO_NOT_SWAP" field.
        /// </summary>
        System.Byte ISaqQueryModel.ProleDoNotSwap
        {
            get { return this.ProleDoNotSwap; }
            set { this.ProleDoNotSwap = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PN_FLAG_1" field.
        /// </summary>
        System.Byte ISaqQueryModel.PnFlag1
        {
            get { return this.PnFlag1; }
            set { this.PnFlag1 = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PROLE_DO_NOT_EMAIL" field.
        /// </summary>
        System.Byte ISaqQueryModel.ProleDoNotEmail
        {
            get { return this.ProleDoNotEmail; }
            set { this.ProleDoNotEmail = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PROLE_DO_NOT_SPARE" field.
        /// </summary>
        System.Byte ISaqQueryModel.ProleDoNotSpare
        {
            get { return this.ProleDoNotSpare; }
            set { this.ProleDoNotSpare = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_ORG_DONOTMAIL" field.
        /// </summary>
        System.Byte ISaqQueryModel.OrgDonotmail
        {
            get { return this.OrgDonotmail; }
            set { this.OrgDonotmail = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_ORG_USERNUM_1" field.
        /// </summary>
        System.Byte ISaqQueryModel.OrgUsernum1
        {
            get { return this.OrgUsernum1; }
            set { this.OrgUsernum1 = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_ORG_FLAG_1" field.
        /// </summary>
        System.Byte ISaqQueryModel.OrgFlag1
        {
            get { return this.OrgFlag1; }
            set { this.OrgFlag1 = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_ORG_DONOTFAX" field.
        /// </summary>
        System.Byte ISaqQueryModel.OrgDonotfax
        {
            get { return this.OrgDonotfax; }
            set { this.OrgDonotfax = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PROLE_DO_NOT_SPARE1" field.
        /// </summary>
        System.Nullable<System.Byte> ISaqQueryModel.ProleDoNotSpare1
        {
            get { return this.ProleDoNotSpare1; }
            set { this.ProleDoNotSpare1 = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PROLE_DO_NOT_SPARE2" field.
        /// </summary>
        System.Nullable<System.Byte> ISaqQueryModel.ProleDoNotSpare2
        {
            get { return this.ProleDoNotSpare2; }
            set { this.ProleDoNotSpare2 = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PROLE_DO_NOT_SPARE3" field.
        /// </summary>
        System.Nullable<System.Byte> ISaqQueryModel.ProleDoNotSpare3
        {
            get { return this.ProleDoNotSpare3; }
            set { this.ProleDoNotSpare3 = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PROLE_DO_NOT_SPARE4" field.
        /// </summary>
        System.Nullable<System.Byte> ISaqQueryModel.ProleDoNotSpare4
        {
            get { return this.ProleDoNotSpare4; }
            set { this.ProleDoNotSpare4 = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PN_DO_NOT_SPARE1" field.
        /// </summary>
        System.Nullable<System.Byte> ISaqQueryModel.PnDoNotSpare1
        {
            get { return this.PnDoNotSpare1; }
            set { this.PnDoNotSpare1 = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PN_DO_NOT_SPARE2" field.
        /// </summary>
        System.Nullable<System.Byte> ISaqQueryModel.PnDoNotSpare2
        {
            get { return this.PnDoNotSpare2; }
            set { this.PnDoNotSpare2 = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PN_DO_NOT_SPARE3" field.
        /// </summary>
        System.Nullable<System.Byte> ISaqQueryModel.PnDoNotSpare3
        {
            get { return this.PnDoNotSpare3; }
            set { this.PnDoNotSpare3 = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_PN_DO_NOT_SPARE4" field.
        /// </summary>
        System.Nullable<System.Byte> ISaqQueryModel.PnDoNotSpare4
        {
            get { return this.PnDoNotSpare4; }
            set { this.PnDoNotSpare4 = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_ORG_DO_NOT_SPARE1" field.
        /// </summary>
        System.Nullable<System.Byte> ISaqQueryModel.OrgDoNotSpare1
        {
            get { return this.OrgDoNotSpare1; }
            set { this.OrgDoNotSpare1 = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_ORG_DO_NOT_SPARE2" field.
        /// </summary>
        System.Nullable<System.Byte> ISaqQueryModel.OrgDoNotSpare2
        {
            get { return this.OrgDoNotSpare2; }
            set { this.OrgDoNotSpare2 = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_ORG_DO_NOT_SPARE3" field.
        /// </summary>
        System.Nullable<System.Byte> ISaqQueryModel.OrgDoNotSpare3
        {
            get { return this.OrgDoNotSpare3; }
            set { this.OrgDoNotSpare3 = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QRY_ORG_DO_NOT_SPARE4" field.
        /// </summary>
        System.Nullable<System.Byte> ISaqQueryModel.OrgDoNotSpare4
        {
            get { return this.OrgDoNotSpare4; }
            set { this.OrgDoNotSpare4 = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SaqQueryStepModel" /> instances that reference this <see cref="!:SaqQueryModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Marketing.ISaqQueryStepModel> ISaqQueryModel.SaqQueryStepQuery
        {
            get { return this.SaqQueryStepQuery; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SaqQueueModel" /> instances that reference this <see cref="!:SaqQueryModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Marketing.ISaqQueueModel> ISaqQueryModel.SaqQueueQuery
        {
            get { return this.SaqQueueQuery; }
        }

        #endregion
    }
}
