using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Document;

namespace Consensus.Marketing
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SaqQueue : Proxy<ISaqQueueModel, Int64>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Query" /> member.
        /// </summary>
        private Consensus.Marketing.SaqQuery _query;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="ActType" /> member.
        /// </summary>
        private Consensus.Common.Code _actType;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="MailingList" /> member.
        /// </summary>
        private Consensus.Marketing.MailingList _mailingList;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="ProfilePerson" /> member.
        /// </summary>
        private Consensus.Common.ProfilePerson _profilePerson;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="ProfileOrg" /> member.
        /// </summary>
        private Consensus.Common.ProfileOrganisation _profileOrg;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Pack" /> member.
        /// </summary>
        private Consensus.Document.Pack _pack;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the value of the "QQ_PRIORITY" field.
        /// </summary>
        public System.Byte Priority
        {
            get { return this.Model.Priority; }
            set { this.Model.Priority = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_PROCESSED" field.
        /// </summary>
        public System.Byte Processed
        {
            get { return this.Model.Processed; }
            set { this.Model.Processed = value; }
        }

        /// <summary>
        ///     Gets the The value of the "QQ_QRY_ID" field.
        /// </summary>
        public Consensus.Marketing.SaqQuery Query
        {
            get
            {
                if (_query == null && this.Model.Query != null)
                    _query = new Consensus.Marketing.SaqQuery(this.Model.Query);
                if (_query == null)
                    _query = Consensus.Marketing.SaqQuery.Create();
                return _query;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "QQ_QRY_ID" field.
        /// </summary>
        public System.Int64 QueryId
        {
            get { return this.Model.QueryId; }
            set { this.Model.QueryId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_OUTPUT_OPTION" field.
        /// </summary>
        public System.Nullable<System.Byte> OutputOption
        {
            get { return this.Model.OutputOption; }
            set { this.Model.OutputOption = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_PROCESS_OPTION" field.
        /// </summary>
        public System.Nullable<System.Byte> ProcessOption
        {
            get { return this.Model.ProcessOption; }
            set { this.Model.ProcessOption = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_EMAIL_WHEN_DONE" field.
        /// </summary>
        public System.Byte EmailWhenDone
        {
            get { return this.Model.EmailWhenDone; }
            set { this.Model.EmailWhenDone = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_REDO_RESULTS_IF_EXIST" field.
        /// </summary>
        public System.Byte RedoResultsIfExist
        {
            get { return this.Model.RedoResultsIfExist; }
            set { this.Model.RedoResultsIfExist = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_EMAIL_ADDRESS" field.
        /// </summary>
        public System.String EmailAddress
        {
            get { return this.Model.EmailAddress; }
            set { this.Model.EmailAddress = value; }
        }

        /// <summary>
        ///     Gets the The value of the "QQ_ACT_TYPE" field.
        /// </summary>
        public Consensus.Common.Code ActType
        {
            get
            {
                if (_actType == null && this.Model.ActType != null)
                    _actType = new Consensus.Common.Code(this.Model.ActType);
                if (_actType == null)
                    _actType = Consensus.Common.Code.Create();
                return _actType;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "QQ_ACT_TYPE" field.
        /// </summary>
        public System.String ActTypeCode
        {
            get { return this.Model.ActTypeCode; }
            set { this.Model.ActTypeCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_ACT_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> ActDate
        {
            get { return this.Model.ActDate; }
            set { this.Model.ActDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_ACT_NOTE" field.
        /// </summary>
        public System.String ActNote
        {
            get { return this.Model.ActNote; }
            set { this.Model.ActNote = value; }
        }

        /// <summary>
        ///     Gets the The value of the "QQ_LIST_ID" field.
        /// </summary>
        public Consensus.Marketing.MailingList MailingList
        {
            get
            {
                if (_mailingList == null && this.Model.MailingList != null)
                    _mailingList = new Consensus.Marketing.MailingList(this.Model.MailingList);
                if (_mailingList == null)
                    _mailingList = Consensus.Marketing.MailingList.Create();
                return _mailingList;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "QQ_LIST_ID" field.
        /// </summary>
        public System.String MailingListId
        {
            get { return this.Model.MailingListId; }
            set { this.Model.MailingListId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "QQ_PROF_KEY" field.
        /// </summary>
        public Consensus.Common.ProfilePerson ProfilePerson
        {
            get
            {
                if (_profilePerson == null && this.Model.ProfilePerson != null)
                    _profilePerson = new Consensus.Common.ProfilePerson(this.Model.ProfilePerson);
                if (_profilePerson == null)
                    _profilePerson = Consensus.Common.ProfilePerson.Create();
                return _profilePerson;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "QQ_PROF_KEY" field.
        /// </summary>
        public System.String ProfilePersonId
        {
            get { return this.Model.ProfilePersonId; }
            set { this.Model.ProfilePersonId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_PROF_VALUE" field.
        /// </summary>
        public System.String ProfValue
        {
            get { return this.Model.ProfValue; }
            set { this.Model.ProfValue = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_PROF_VALUE2" field.
        /// </summary>
        public System.String ProfValue2
        {
            get { return this.Model.ProfValue2; }
            set { this.Model.ProfValue2 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_PROF_VALUE3" field.
        /// </summary>
        public System.String ProfValue3
        {
            get { return this.Model.ProfValue3; }
            set { this.Model.ProfValue3 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_FILE_TYPE" field.
        /// </summary>
        public System.String FileType
        {
            get { return this.Model.FileType; }
            set { this.Model.FileType = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_DATE_SELECTED" field.
        /// </summary>
        public System.Nullable<System.DateTime> DateSelected
        {
            get { return this.Model.DateSelected; }
            set { this.Model.DateSelected = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_STATUS" field.
        /// </summary>
        public System.String Status
        {
            get { return this.Model.Status; }
            set { this.Model.Status = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_ERROR" field.
        /// </summary>
        public System.String Error
        {
            get { return this.Model.Error; }
            set { this.Model.Error = value; }
        }

        /// <summary>
        ///     Gets the The value of the "QQ_PROF_KEY_ORG" field.
        /// </summary>
        public Consensus.Common.ProfileOrganisation ProfileOrg
        {
            get
            {
                if (_profileOrg == null && this.Model.ProfileOrg != null)
                    _profileOrg = new Consensus.Common.ProfileOrganisation(this.Model.ProfileOrg);
                if (_profileOrg == null)
                    _profileOrg = Consensus.Common.ProfileOrganisation.Create();
                return _profileOrg;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "QQ_PROF_KEY_ORG" field.
        /// </summary>
        public System.String ProfileOrgId
        {
            get { return this.Model.ProfileOrgId; }
            set { this.Model.ProfileOrgId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_PROF_VALUE_ORG" field.
        /// </summary>
        public System.String ProfValueOrg
        {
            get { return this.Model.ProfValueOrg; }
            set { this.Model.ProfValueOrg = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_PROF_VALUE2_ORG" field.
        /// </summary>
        public System.String ProfValue2Org
        {
            get { return this.Model.ProfValue2Org; }
            set { this.Model.ProfValue2Org = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QQ_RESULTS_TYPE" field.
        /// </summary>
        public System.String ResultsType
        {
            get { return this.Model.ResultsType; }
            set { this.Model.ResultsType = value; }
        }

        /// <summary>
        ///     Gets the The value of the "QQ_PACK_ID" field.
        /// </summary>
        public Consensus.Document.Pack Pack
        {
            get
            {
                if (_pack == null && this.Model.Pack != null)
                    _pack = new Consensus.Document.Pack(this.Model.Pack);
                if (_pack == null)
                    _pack = Consensus.Document.Pack.Create();
                return _pack;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "QQ_PACK_ID" field.
        /// </summary>
        public System.String PackId
        {
            get { return this.Model.PackId; }
            set { this.Model.PackId = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal SaqQueue(ISaqQueueModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:SaqQueueModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SaqQueueModel" /> instance.
        /// </returns>
        public static Consensus.Marketing.SaqQueue Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SaqQueue.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:SaqQueueModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SaqQueueModel" /> instance.
        /// </returns>
        public static Consensus.Marketing.SaqQueue Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Marketing.ISaqQueueModel model = provider.Marketing.SaqQueue.Create();
            return model == null ? null : new Consensus.Marketing.SaqQueue(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SaqQueueModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SaqQueueModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.SaqQueue> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SaqQueue.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SaqQueueModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SaqQueueModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.SaqQueue> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Marketing.ISaqQueueModel> collection = provider.Marketing.SaqQueue.FetchAll();
            return collection.Select(model => new Consensus.Marketing.SaqQueue(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:SaqQueueModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SaqQueueModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqQueueModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Marketing.SaqQueue FetchById(System.Int64 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SaqQueue.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:SaqQueueModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SaqQueueModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqQueueModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Marketing.SaqQueue FetchById(ConsensusSite site, System.Int64 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Marketing.ISaqQueueModel model = provider.Marketing.SaqQueue.FetchById(id);
            return model == null ? null : new Consensus.Marketing.SaqQueue(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SaqQueue.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Marketing.SaqQueue.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SaqQueueModel" /> instances.
        /// </summary>
        /// <param name="queryId">
        ///     The value which identifies the <see cref="!:SaqQueueModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqQueueModel" /> instances that match the specified <paramref name="queryId" />.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.SaqQueue> FetchAllByQueryId(System.Int64 queryId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SaqQueue.FetchAllByQueryId(site,queryId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SaqQueueModel" /> instances.
        /// </summary>
        /// <param name="queryId">
        ///     The value which identifies the <see cref="!:SaqQueueModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqQueueModel" /> instances that match the specified <paramref name="queryId" />.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.SaqQueue> FetchAllByQueryId(ConsensusSite site, System.Int64 queryId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Marketing.ISaqQueueModel> collection = provider.Marketing.SaqQueue.FetchAllByQueryId(queryId);
            return collection.Select(model => new Consensus.Marketing.SaqQueue(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SaqQueueModel" /> instances.
        /// </summary>
        /// <param name="mailingListId">
        ///     The value which identifies the <see cref="!:SaqQueueModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqQueueModel" /> instances that match the specified <paramref name="mailingListId" />.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.SaqQueue> FetchAllByMailingListId(System.String mailingListId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SaqQueue.FetchAllByMailingListId(site,mailingListId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SaqQueueModel" /> instances.
        /// </summary>
        /// <param name="mailingListId">
        ///     The value which identifies the <see cref="!:SaqQueueModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqQueueModel" /> instances that match the specified <paramref name="mailingListId" />.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.SaqQueue> FetchAllByMailingListId(ConsensusSite site, System.String mailingListId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Marketing.ISaqQueueModel> collection = provider.Marketing.SaqQueue.FetchAllByMailingListId(mailingListId);
            return collection.Select(model => new Consensus.Marketing.SaqQueue(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SaqQueueModel" /> instances.
        /// </summary>
        /// <param name="profilePersonId">
        ///     The value which identifies the <see cref="!:SaqQueueModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqQueueModel" /> instances that match the specified <paramref name="profilePersonId" />.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.SaqQueue> FetchAllByProfilePersonId(System.String profilePersonId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SaqQueue.FetchAllByProfilePersonId(site,profilePersonId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SaqQueueModel" /> instances.
        /// </summary>
        /// <param name="profilePersonId">
        ///     The value which identifies the <see cref="!:SaqQueueModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqQueueModel" /> instances that match the specified <paramref name="profilePersonId" />.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.SaqQueue> FetchAllByProfilePersonId(ConsensusSite site, System.String profilePersonId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Marketing.ISaqQueueModel> collection = provider.Marketing.SaqQueue.FetchAllByProfilePersonId(profilePersonId);
            return collection.Select(model => new Consensus.Marketing.SaqQueue(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SaqQueueModel" /> instances.
        /// </summary>
        /// <param name="profileOrgId">
        ///     The value which identifies the <see cref="!:SaqQueueModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqQueueModel" /> instances that match the specified <paramref name="profileOrgId" />.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.SaqQueue> FetchAllByProfileOrgId(System.String profileOrgId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SaqQueue.FetchAllByProfileOrgId(site,profileOrgId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SaqQueueModel" /> instances.
        /// </summary>
        /// <param name="profileOrgId">
        ///     The value which identifies the <see cref="!:SaqQueueModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqQueueModel" /> instances that match the specified <paramref name="profileOrgId" />.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.SaqQueue> FetchAllByProfileOrgId(ConsensusSite site, System.String profileOrgId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Marketing.ISaqQueueModel> collection = provider.Marketing.SaqQueue.FetchAllByProfileOrgId(profileOrgId);
            return collection.Select(model => new Consensus.Marketing.SaqQueue(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SaqQueueModel" /> instances.
        /// </summary>
        /// <param name="packId">
        ///     The value which identifies the <see cref="!:SaqQueueModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqQueueModel" /> instances that match the specified <paramref name="packId" />.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.SaqQueue> FetchAllByPackId(System.String packId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SaqQueue.FetchAllByPackId(site,packId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SaqQueueModel" /> instances.
        /// </summary>
        /// <param name="packId">
        ///     The value which identifies the <see cref="!:SaqQueueModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqQueueModel" /> instances that match the specified <paramref name="packId" />.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.SaqQueue> FetchAllByPackId(ConsensusSite site, System.String packId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Marketing.ISaqQueueModel> collection = provider.Marketing.SaqQueue.FetchAllByPackId(packId);
            return collection.Select(model => new Consensus.Marketing.SaqQueue(model));
        }

        #endregion
    }
}
