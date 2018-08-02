using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Document;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Encapsulates the <see cref="SaqQueryQueueRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalSaqQueueModel : LocalModel<SaqQueryQueueRecord, Int64>, ISaqQueueModel
    {
        #region fields

        /// <summary>
        ///     The value of the "QQ_QRY_ID" field.
        /// </summary>
        private LocalSaqQueryModel _query;

        /// <summary>
        ///     The value of the "QQ_ACT_TYPE" field.
        /// </summary>
        private LocalCodeModel _actType;

        /// <summary>
        ///     The value of the "QQ_LIST_ID" field.
        /// </summary>
        private LocalMailingListModel _mailingList;

        /// <summary>
        ///     The value of the "QQ_PROF_KEY" field.
        /// </summary>
        private LocalProfilePersonModel _profilePerson;

        /// <summary>
        ///     The value of the "QQ_PROF_KEY_ORG" field.
        /// </summary>
        private LocalProfileOrganisationModel _profileOrg;

        /// <summary>
        ///     The value of the "QQ_PACK_ID" field.
        /// </summary>
        private LocalPackModel _pack;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<SaqQueryQueueRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Marketing.SaqQueue.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<SaqQueryQueueRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Marketing.SaqQueue.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<SaqQueryQueueRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Marketing.SaqQueue.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_PRIORITY" field.
        /// </summary>
        public Byte Priority
        {
            get { return this.ModifiedData.Priority; }
            set { this.ModifiedData.Priority = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_PROCESSED" field.
        /// </summary>
        public Byte Processed
        {
            get { return this.ModifiedData.Processed; }
            set { this.ModifiedData.Processed = value; }
        }

        /// <summary>
        ///     Gets the The value of the "QQ_QRY_ID" field.
        /// </summary>
        public LocalSaqQueryModel Query
        {
            get
            {
                if (_query == null)
                    _query = this.Provider.Marketing.SaqQuery.FetchById(this.QueryId);
                if (_query == null)
                    _query = this.Provider.Marketing.SaqQuery.Create();
                
                return _query;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "QQ_QRY_ID" field.
        /// </summary>
        public Int64 QueryId
        {
            get { return this.ModifiedData.QryId; }
            set
            {
                if (this.ModifiedData.QryId != value)
                     _query = null;
                this.ModifiedData.QryId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_OUTPUT_OPTION" field.
        /// </summary>
        public Byte? OutputOption
        {
            get { return this.ModifiedData.OutputOption; }
            set { this.ModifiedData.OutputOption = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_PROCESS_OPTION" field.
        /// </summary>
        public Byte? ProcessOption
        {
            get { return this.ModifiedData.ProcessOption; }
            set { this.ModifiedData.ProcessOption = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_EMAIL_WHEN_DONE" field.
        /// </summary>
        public Byte EmailWhenDone
        {
            get { return this.ModifiedData.EmailWhenDone; }
            set { this.ModifiedData.EmailWhenDone = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_REDO_RESULTS_IF_EXIST" field.
        /// </summary>
        public Byte RedoResultsIfExist
        {
            get { return this.ModifiedData.RedoResultsIfExist; }
            set { this.ModifiedData.RedoResultsIfExist = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_EMAIL_ADDRESS" field.
        /// </summary>
        public String EmailAddress
        {
            get { return this.ModifiedData.EmailAddress; }
            set { this.ModifiedData.EmailAddress = value; }
        }

        /// <summary>
        ///     Gets the The value of the "QQ_ACT_TYPE" field.
        /// </summary>
        public LocalCodeModel ActType
        {
            get
            {
                if (_actType == null && !String.IsNullOrEmpty(this.ActTypeCode))
                    _actType = this.Provider.Common.Code.FetchByTypeAndCode("ACT", this.ActTypeCode);
                if (_actType == null)
                    _actType = this.Provider.Common.Code.Create("ACT");
                return _actType;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "QQ_ACT_TYPE" field.
        /// </summary>
        public String ActTypeCode
        {
            get { return this.ModifiedData.ActType; }
            set
            {
                if (this.ModifiedData.ActType != value)
                     _actType = null;
                this.ModifiedData.ActType = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_ACT_DATE" field.
        /// </summary>
        public DateTime? ActDate
        {
            get { return this.ModifiedData.ActDate; }
            set { this.ModifiedData.ActDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_ACT_NOTE" field.
        /// </summary>
        public String ActNote
        {
            get { return this.ModifiedData.ActNote; }
            set { this.ModifiedData.ActNote = value; }
        }

        /// <summary>
        ///     Gets the The value of the "QQ_LIST_ID" field.
        /// </summary>
        public LocalMailingListModel MailingList
        {
            get
            {
                if (_mailingList == null && this.MailingListId != null)
                    _mailingList = this.Provider.Marketing.MailingList.FetchById(this.MailingListId);
                if (_mailingList == null)
                    _mailingList = this.Provider.Marketing.MailingList.Create();
                
                return _mailingList;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "QQ_LIST_ID" field.
        /// </summary>
        public String MailingListId
        {
            get { return this.ModifiedData.ListId; }
            set
            {
                if (this.ModifiedData.ListId != value)
                     _mailingList = null;
                this.ModifiedData.ListId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "QQ_PROF_KEY" field.
        /// </summary>
        public LocalProfilePersonModel ProfilePerson
        {
            get
            {
                if (_profilePerson == null && this.ProfilePersonId != null)
                    _profilePerson = this.Provider.Common.ProfilePerson.FetchById(this.ProfilePersonId);
                if (_profilePerson == null)
                    _profilePerson = this.Provider.Common.ProfilePerson.Create();
                
                return _profilePerson;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "QQ_PROF_KEY" field.
        /// </summary>
        public String ProfilePersonId
        {
            get { return this.ModifiedData.ProfKey; }
            set
            {
                if (this.ModifiedData.ProfKey != value)
                     _profilePerson = null;
                this.ModifiedData.ProfKey = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_PROF_VALUE" field.
        /// </summary>
        public String ProfValue
        {
            get { return this.ModifiedData.ProfValue; }
            set { this.ModifiedData.ProfValue = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_PROF_VALUE2" field.
        /// </summary>
        public String ProfValue2
        {
            get { return this.ModifiedData.ProfValue2; }
            set { this.ModifiedData.ProfValue2 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_PROF_VALUE3" field.
        /// </summary>
        public String ProfValue3
        {
            get { return this.ModifiedData.ProfValue3; }
            set { this.ModifiedData.ProfValue3 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_FILE_TYPE" field.
        /// </summary>
        public String FileType
        {
            get { return this.ModifiedData.FileType; }
            set { this.ModifiedData.FileType = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_DATE_SELECTED" field.
        /// </summary>
        public DateTime? DateSelected
        {
            get { return this.ModifiedData.DateSelected; }
            set { this.ModifiedData.DateSelected = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_STATUS" field.
        /// </summary>
        public String Status
        {
            get { return this.ModifiedData.Status; }
            set { this.ModifiedData.Status = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_ERROR" field.
        /// </summary>
        public String Error
        {
            get { return this.ModifiedData.Error; }
            set { this.ModifiedData.Error = value; }
        }

        /// <summary>
        ///     Gets the The value of the "QQ_PROF_KEY_ORG" field.
        /// </summary>
        public LocalProfileOrganisationModel ProfileOrg
        {
            get
            {
                if (_profileOrg == null && this.ProfileOrgId != null)
                    _profileOrg = this.Provider.Common.ProfileOrganisation.FetchById(this.ProfileOrgId);
                if (_profileOrg == null)
                    _profileOrg = this.Provider.Common.ProfileOrganisation.Create();
                
                return _profileOrg;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "QQ_PROF_KEY_ORG" field.
        /// </summary>
        public String ProfileOrgId
        {
            get { return this.ModifiedData.ProfKeyOrg; }
            set
            {
                if (this.ModifiedData.ProfKeyOrg != value)
                     _profileOrg = null;
                this.ModifiedData.ProfKeyOrg = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_PROF_VALUE_ORG" field.
        /// </summary>
        public String ProfValueOrg
        {
            get { return this.ModifiedData.ProfValueOrg; }
            set { this.ModifiedData.ProfValueOrg = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_PROF_VALUE2_ORG" field.
        /// </summary>
        public String ProfValue2Org
        {
            get { return this.ModifiedData.ProfValue2Org; }
            set { this.ModifiedData.ProfValue2Org = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_RESULTS_TYPE" field.
        /// </summary>
        public String ResultsType
        {
            get { return this.ModifiedData.ResultsType; }
            set { this.ModifiedData.ResultsType = value; }
        }

        /// <summary>
        ///     Gets the The value of the "QQ_PACK_ID" field.
        /// </summary>
        public LocalPackModel Pack
        {
            get
            {
                if (_pack == null && this.PackId != null)
                    _pack = this.Provider.Document.Pack.FetchById(this.PackId);
                if (_pack == null)
                    _pack = this.Provider.Document.Pack.Create();
                
                return _pack;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "QQ_PACK_ID" field.
        /// </summary>
        public String PackId
        {
            get { return this.ModifiedData.PackId; }
            set
            {
                if (this.ModifiedData.PackId != value)
                     _pack = null;
                this.ModifiedData.PackId = value;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalSaqQueueModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalSaqQueueModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalSaqQueueModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalSaqQueueModel(LocalProvider provider, SaqQueryQueueRecord record) : base(provider, record)
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
            if (_actType != null)
            {
                _actType.Save();
                this.ModifiedData.ActType = _actType.Value1;
            }
            if (_query != null)
            {
                _query.Save();
                this.ModifiedData.QryId = _query.Id;
            }
            if (_mailingList != null)
            {
                _mailingList.Save();
                this.ModifiedData.ListId = _mailingList.Id == null && this.ModifiedData.ListId != null ? "" : _mailingList.Id;
            }
            if (_profilePerson != null)
            {
                _profilePerson.Save();
                this.ModifiedData.ProfKey = _profilePerson.Id == null && this.ModifiedData.ProfKey != null ? "" : _profilePerson.Id;
            }
            if (_profileOrg != null)
            {
                _profileOrg.Save();
                this.ModifiedData.ProfKeyOrg = _profileOrg.Id == null && this.ModifiedData.ProfKeyOrg != null ? "" : _profileOrg.Id;
            }
            if (_pack != null)
            {
                _pack.Save();
                this.ModifiedData.PackId = _pack.Id == null && this.ModifiedData.PackId != null ? "" : _pack.Id;
            }
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets or sets the value of the "QQ_PRIORITY" field.
        /// </summary>
        System.Byte ISaqQueueModel.Priority
        {
            get { return this.Priority; }
            set { this.Priority = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_PROCESSED" field.
        /// </summary>
        System.Byte ISaqQueueModel.Processed
        {
            get { return this.Processed; }
            set { this.Processed = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets the The value of the "QQ_QRY_ID" field.
        /// </summary>
        Consensus.Marketing.ISaqQueryModel ISaqQueueModel.Query
        {
            get { return this.Query; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "QQ_QRY_ID" field.
        /// </summary>
        System.Int64 ISaqQueueModel.QueryId
        {
            get { return this.QueryId; }
            set { this.QueryId = (System.Int64)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_OUTPUT_OPTION" field.
        /// </summary>
        System.Nullable<System.Byte> ISaqQueueModel.OutputOption
        {
            get { return this.OutputOption; }
            set { this.OutputOption = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_PROCESS_OPTION" field.
        /// </summary>
        System.Nullable<System.Byte> ISaqQueueModel.ProcessOption
        {
            get { return this.ProcessOption; }
            set { this.ProcessOption = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_EMAIL_WHEN_DONE" field.
        /// </summary>
        System.Byte ISaqQueueModel.EmailWhenDone
        {
            get { return this.EmailWhenDone; }
            set { this.EmailWhenDone = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_REDO_RESULTS_IF_EXIST" field.
        /// </summary>
        System.Byte ISaqQueueModel.RedoResultsIfExist
        {
            get { return this.RedoResultsIfExist; }
            set { this.RedoResultsIfExist = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_EMAIL_ADDRESS" field.
        /// </summary>
        System.String ISaqQueueModel.EmailAddress
        {
            get { return this.EmailAddress; }
            set { this.EmailAddress = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "QQ_ACT_TYPE" field.
        /// </summary>
        Consensus.Common.ICodeModel ISaqQueueModel.ActType
        {
            get { return this.ActType; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "QQ_ACT_TYPE" field.
        /// </summary>
        System.String ISaqQueueModel.ActTypeCode
        {
            get { return this.ActTypeCode; }
            set { this.ActTypeCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_ACT_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> ISaqQueueModel.ActDate
        {
            get { return this.ActDate; }
            set { this.ActDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_ACT_NOTE" field.
        /// </summary>
        System.String ISaqQueueModel.ActNote
        {
            get { return this.ActNote; }
            set { this.ActNote = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "QQ_LIST_ID" field.
        /// </summary>
        Consensus.Marketing.IMailingListModel ISaqQueueModel.MailingList
        {
            get { return this.MailingList; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "QQ_LIST_ID" field.
        /// </summary>
        System.String ISaqQueueModel.MailingListId
        {
            get { return this.MailingListId; }
            set { this.MailingListId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "QQ_PROF_KEY" field.
        /// </summary>
        Consensus.Common.IProfilePersonModel ISaqQueueModel.ProfilePerson
        {
            get { return this.ProfilePerson; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "QQ_PROF_KEY" field.
        /// </summary>
        System.String ISaqQueueModel.ProfilePersonId
        {
            get { return this.ProfilePersonId; }
            set { this.ProfilePersonId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_PROF_VALUE" field.
        /// </summary>
        System.String ISaqQueueModel.ProfValue
        {
            get { return this.ProfValue; }
            set { this.ProfValue = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_PROF_VALUE2" field.
        /// </summary>
        System.String ISaqQueueModel.ProfValue2
        {
            get { return this.ProfValue2; }
            set { this.ProfValue2 = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_PROF_VALUE3" field.
        /// </summary>
        System.String ISaqQueueModel.ProfValue3
        {
            get { return this.ProfValue3; }
            set { this.ProfValue3 = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_FILE_TYPE" field.
        /// </summary>
        System.String ISaqQueueModel.FileType
        {
            get { return this.FileType; }
            set { this.FileType = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_DATE_SELECTED" field.
        /// </summary>
        System.Nullable<System.DateTime> ISaqQueueModel.DateSelected
        {
            get { return this.DateSelected; }
            set { this.DateSelected = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_STATUS" field.
        /// </summary>
        System.String ISaqQueueModel.Status
        {
            get { return this.Status; }
            set { this.Status = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_ERROR" field.
        /// </summary>
        System.String ISaqQueueModel.Error
        {
            get { return this.Error; }
            set { this.Error = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "QQ_PROF_KEY_ORG" field.
        /// </summary>
        Consensus.Common.IProfileOrganisationModel ISaqQueueModel.ProfileOrg
        {
            get { return this.ProfileOrg; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "QQ_PROF_KEY_ORG" field.
        /// </summary>
        System.String ISaqQueueModel.ProfileOrgId
        {
            get { return this.ProfileOrgId; }
            set { this.ProfileOrgId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_PROF_VALUE_ORG" field.
        /// </summary>
        System.String ISaqQueueModel.ProfValueOrg
        {
            get { return this.ProfValueOrg; }
            set { this.ProfValueOrg = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_PROF_VALUE2_ORG" field.
        /// </summary>
        System.String ISaqQueueModel.ProfValue2Org
        {
            get { return this.ProfValue2Org; }
            set { this.ProfValue2Org = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_RESULTS_TYPE" field.
        /// </summary>
        System.String ISaqQueueModel.ResultsType
        {
            get { return this.ResultsType; }
            set { this.ResultsType = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "QQ_PACK_ID" field.
        /// </summary>
        Consensus.Document.IPackModel ISaqQueueModel.Pack
        {
            get { return this.Pack; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "QQ_PACK_ID" field.
        /// </summary>
        System.String ISaqQueueModel.PackId
        {
            get { return this.PackId; }
            set { this.PackId = (System.String)value; }
        }

        #endregion
    }
}
