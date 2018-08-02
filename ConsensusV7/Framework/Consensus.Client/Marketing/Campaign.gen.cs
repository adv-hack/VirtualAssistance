using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Contact;
using Consensus.Logistics;

namespace Consensus.Marketing
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class Campaign : Proxy<ICampaignModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Project" /> member.
        /// </summary>
        private Consensus.Logistics.Project _project;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="SellingCompany" /> member.
        /// </summary>
        private Consensus.Common.SellingCompany _sellingCompany;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Manager" /> member.
        /// </summary>
        private Consensus.Contact.Role _manager;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Approver" /> member.
        /// </summary>
        private Consensus.Contact.Role _approver;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="PromotionMasterCampaign" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Marketing.PromotionMaster, Consensus.Marketing.IPromotionMasterModel> _promotionMasterCampaign;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the value of the "CMP_NAME" field.
        /// </summary>
        public System.String Name
        {
            get { return this.Model.Name; }
            set { this.Model.Name = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_START_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> StartDate
        {
            get { return this.Model.StartDate; }
            set { this.Model.StartDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_END_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> EndDate
        {
            get { return this.Model.EndDate; }
            set { this.Model.EndDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_REGION" field.
        /// </summary>
        public System.String Region
        {
            get { return this.Model.Region; }
            set { this.Model.Region = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_OBJ_TEXT_ID" field.
        /// </summary>
        public System.String ObjTextId
        {
            get { return this.Model.ObjTextId; }
            set { this.Model.ObjTextId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_SEL_TEXT_ID" field.
        /// </summary>
        public System.String SelTextId
        {
            get { return this.Model.SelTextId; }
            set { this.Model.SelTextId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_RVW_TEXT_ID" field.
        /// </summary>
        public System.String RvwTextId
        {
            get { return this.Model.RvwTextId; }
            set { this.Model.RvwTextId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_BUDGET_COSTS" field.
        /// </summary>
        public System.Nullable<System.Double> BudgetCosts
        {
            get { return this.Model.BudgetCosts; }
            set { this.Model.BudgetCosts = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_ACTUAL_COSTS" field.
        /// </summary>
        public System.Nullable<System.Double> ActualCosts
        {
            get { return this.Model.ActualCosts; }
            set { this.Model.ActualCosts = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_REPLIES" field.
        /// </summary>
        public System.Nullable<System.Double> ActualReplies
        {
            get { return this.Model.ActualReplies; }
            set { this.Model.ActualReplies = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_ORDERS" field.
        /// </summary>
        public System.Nullable<System.Double> SoldOpp
        {
            get { return this.Model.SoldOpp; }
            set { this.Model.SoldOpp = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_ORDER_VALUE" field.
        /// </summary>
        public System.Nullable<System.Double> OppVal
        {
            get { return this.Model.OppVal; }
            set { this.Model.OppVal = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_UPDATED" field.
        /// </summary>
        public System.Nullable<System.DateTime> Updated
        {
            get { return this.Model.Updated; }
            set { this.Model.Updated = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_MAILINGS" field.
        /// </summary>
        public System.Nullable<System.Int32> Mailings
        {
            get { return this.Model.Mailings; }
            set { this.Model.Mailings = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_BOOKINGS" field.
        /// </summary>
        public System.Nullable<System.Int32> ActualBook
        {
            get { return this.Model.ActualBook; }
            set { this.Model.ActualBook = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_BOOK_VALUE" field.
        /// </summary>
        public System.Nullable<System.Double> ActualBookValue
        {
            get { return this.Model.ActualBookValue; }
            set { this.Model.ActualBookValue = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_QUOTES" field.
        /// </summary>
        public System.Nullable<System.Int32> ActualQuotes
        {
            get { return this.Model.ActualQuotes; }
            set { this.Model.ActualQuotes = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_QUO_VALUE" field.
        /// </summary>
        public System.Nullable<System.Double> ActualQuotesVal
        {
            get { return this.Model.ActualQuotesVal; }
            set { this.Model.ActualQuotesVal = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_CALC_ACT" field.
        /// </summary>
        public System.Nullable<System.Double> CalcAct
        {
            get { return this.Model.CalcAct; }
            set { this.Model.CalcAct = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_CALC_EST" field.
        /// </summary>
        public System.Nullable<System.Double> CalcEst
        {
            get { return this.Model.CalcEst; }
            set { this.Model.CalcEst = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_OPP_TOT" field.
        /// </summary>
        public System.Nullable<System.Int32> ActualOpp
        {
            get { return this.Model.ActualOpp; }
            set { this.Model.ActualOpp = value; }
        }

        /// <summary>
        ///     Gets the The value of the "CMP_PROJ_ID" field.
        /// </summary>
        public Consensus.Logistics.Project Project
        {
            get
            {
                if (_project == null && this.Model.Project != null)
                    _project = new Consensus.Logistics.Project(this.Model.Project);
                if (_project == null)
                    _project = Consensus.Logistics.Project.Create();
                return _project;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CMP_PROJ_ID" field.
        /// </summary>
        public System.String ProjectId
        {
            get { return this.Model.ProjectId; }
            set { this.Model.ProjectId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "CMP_SELCO_SP_ID" field.
        /// </summary>
        public Consensus.Common.SellingCompany SellingCompany
        {
            get
            {
                if (_sellingCompany == null && this.Model.SellingCompany != null)
                    _sellingCompany = new Consensus.Common.SellingCompany(this.Model.SellingCompany);
                if (_sellingCompany == null)
                    _sellingCompany = Consensus.Common.SellingCompany.Create();
                return _sellingCompany;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CMP_SELCO_SP_ID" field.
        /// </summary>
        public System.String SellingCompanyId
        {
            get { return this.Model.SellingCompanyId; }
            set { this.Model.SellingCompanyId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_TARGET_OPP" field.
        /// </summary>
        public System.Nullable<System.Int32> TargetOpp
        {
            get { return this.Model.TargetOpp; }
            set { this.Model.TargetOpp = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_TARGET_REPLIES" field.
        /// </summary>
        public System.Nullable<System.Int32> TargetReplies
        {
            get { return this.Model.TargetReplies; }
            set { this.Model.TargetReplies = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_TARGET_OPP_VAL" field.
        /// </summary>
        public System.Nullable<System.Double> TargetOppVal
        {
            get { return this.Model.TargetOppVal; }
            set { this.Model.TargetOppVal = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_TARGET_BOOK_VAL" field.
        /// </summary>
        public System.Nullable<System.Double> TargetBookVal
        {
            get { return this.Model.TargetBookVal; }
            set { this.Model.TargetBookVal = value; }
        }

        /// <summary>
        ///     Gets the The value of the "CMP_PROLE_ID" field.
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
        ///     Gets or sets the unique code for the value of the "CMP_PROLE_ID" field.
        /// </summary>
        public System.String ManagerId
        {
            get { return this.Model.ManagerId; }
            set { this.Model.ManagerId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "CMP_APP_PROLE_ID" field.
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
        ///     Gets or sets the unique code for the value of the "CMP_APP_PROLE_ID" field.
        /// </summary>
        public System.String ApproverId
        {
            get { return this.Model.ApproverId; }
            set { this.Model.ApproverId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_EMAILS_SENT" field.
        /// </summary>
        public System.Int32 EmailsSentActual
        {
            get { return this.Model.EmailsSentActual; }
            set { this.Model.EmailsSentActual = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_EMAILS_OPENED" field.
        /// </summary>
        public System.Int32 EmailsOpenedActual
        {
            get { return this.Model.EmailsOpenedActual; }
            set { this.Model.EmailsOpenedActual = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_LINKS_CLICKED" field.
        /// </summary>
        public System.Int32 LinksClickedActual
        {
            get { return this.Model.LinksClickedActual; }
            set { this.Model.LinksClickedActual = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_LZ_CLICKED" field.
        /// </summary>
        public System.Int32 LzClickedActual
        {
            get { return this.Model.LzClickedActual; }
            set { this.Model.LzClickedActual = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_SURVEYS_COMPLETED" field.
        /// </summary>
        public System.Int32 SurveysCompletedActual
        {
            get { return this.Model.SurveysCompletedActual; }
            set { this.Model.SurveysCompletedActual = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_GLOBAL_UNSUBSCRIBES" field.
        /// </summary>
        public System.Int32 GlobalUnsubscribesActual
        {
            get { return this.Model.GlobalUnsubscribesActual; }
            set { this.Model.GlobalUnsubscribesActual = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_LIST_UNSUBSCRIBES" field.
        /// </summary>
        public System.Int32 ListUnsubscribesActual
        {
            get { return this.Model.ListUnsubscribesActual; }
            set { this.Model.ListUnsubscribesActual = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_DOCS_DOWNLOADS" field.
        /// </summary>
        public System.Int32 DocsDownloadsActual
        {
            get { return this.Model.DocsDownloadsActual; }
            set { this.Model.DocsDownloadsActual = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_BOUNCE_BACKS" field.
        /// </summary>
        public System.Int32 BounceBacksActual
        {
            get { return this.Model.BounceBacksActual; }
            set { this.Model.BounceBacksActual = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_EMAILS_SENT_TARGET" field.
        /// </summary>
        public System.Int32 EmailsSentTarget
        {
            get { return this.Model.EmailsSentTarget; }
            set { this.Model.EmailsSentTarget = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_EMAILS_OPENED_TARGET" field.
        /// </summary>
        public System.Int32 EmailsOpenedTarget
        {
            get { return this.Model.EmailsOpenedTarget; }
            set { this.Model.EmailsOpenedTarget = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_LINKS_CLICKED_TARGET" field.
        /// </summary>
        public System.Int32 LinksClickedTarget
        {
            get { return this.Model.LinksClickedTarget; }
            set { this.Model.LinksClickedTarget = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_LZ_CLICKED_TARGET" field.
        /// </summary>
        public System.Int32 LzClickedTarget
        {
            get { return this.Model.LzClickedTarget; }
            set { this.Model.LzClickedTarget = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_SURVEYS_COMPLETED_TARGET" field.
        /// </summary>
        public System.Int32 SurveysCompletedTarget
        {
            get { return this.Model.SurveysCompletedTarget; }
            set { this.Model.SurveysCompletedTarget = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_GLOBAL_UNSUBSCRIBES_TARGET" field.
        /// </summary>
        public System.Int32 GlobalUnsubscribesTarget
        {
            get { return this.Model.GlobalUnsubscribesTarget; }
            set { this.Model.GlobalUnsubscribesTarget = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_LIST_UNSUBSCRIBES_TARGET" field.
        /// </summary>
        public System.Int32 ListUnsubscribesTarget
        {
            get { return this.Model.ListUnsubscribesTarget; }
            set { this.Model.ListUnsubscribesTarget = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_DOCS_DOWNLOADS_TARGET" field.
        /// </summary>
        public System.Int32 DocsDownloadsTarget
        {
            get { return this.Model.DocsDownloadsTarget; }
            set { this.Model.DocsDownloadsTarget = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_BOUNCE_BACKS_TARGET" field.
        /// </summary>
        public System.Int32 BounceBacksTarget
        {
            get { return this.Model.BounceBacksTarget; }
            set { this.Model.BounceBacksTarget = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_QCODE" field.
        /// </summary>
        public System.String Qcode
        {
            get { return this.Model.Qcode; }
            set { this.Model.Qcode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_CURRENT" field.
        /// </summary>
        public System.Nullable<System.Byte> Current
        {
            get { return this.Model.Current; }
            set { this.Model.Current = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PromotionMasterModel" /> instances that reference this <see cref="!:CampaignModel" />.
        /// </summary>
        public Collection<Consensus.Marketing.PromotionMaster> PromotionMasterCampaign
        {
            get
            {
                if (_promotionMasterCampaign == null)
                    _promotionMasterCampaign = new ProxyCollection<Consensus.Marketing.PromotionMaster, Consensus.Marketing.IPromotionMasterModel>(this.Model.PromotionMasterCampaign, model => new Consensus.Marketing.PromotionMaster(model));
                return _promotionMasterCampaign;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal Campaign(ICampaignModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:CampaignModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:CampaignModel" /> instance.
        /// </returns>
        public static Consensus.Marketing.Campaign Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Campaign.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:CampaignModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:CampaignModel" /> instance.
        /// </returns>
        public static Consensus.Marketing.Campaign Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Marketing.ICampaignModel model = provider.Marketing.Campaign.Create();
            return model == null ? null : new Consensus.Marketing.Campaign(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:CampaignModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:CampaignModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.Campaign> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Campaign.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:CampaignModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:CampaignModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.Campaign> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Marketing.ICampaignModel> collection = provider.Marketing.Campaign.FetchAll();
            return collection.Select(model => new Consensus.Marketing.Campaign(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:CampaignModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:CampaignModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CampaignModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Marketing.Campaign FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Campaign.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:CampaignModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:CampaignModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CampaignModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Marketing.Campaign FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Marketing.ICampaignModel model = provider.Marketing.Campaign.FetchById(id);
            return model == null ? null : new Consensus.Marketing.Campaign(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Campaign.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Marketing.Campaign.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:CampaignModel" /> instances.
        /// </summary>
        /// <param name="projectId">
        ///     The value which identifies the <see cref="!:CampaignModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CampaignModel" /> instances that match the specified <paramref name="projectId" />.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.Campaign> FetchAllByProjectId(System.String projectId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Campaign.FetchAllByProjectId(site,projectId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:CampaignModel" /> instances.
        /// </summary>
        /// <param name="projectId">
        ///     The value which identifies the <see cref="!:CampaignModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CampaignModel" /> instances that match the specified <paramref name="projectId" />.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.Campaign> FetchAllByProjectId(ConsensusSite site, System.String projectId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Marketing.ICampaignModel> collection = provider.Marketing.Campaign.FetchAllByProjectId(projectId);
            return collection.Select(model => new Consensus.Marketing.Campaign(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:CampaignModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:CampaignModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CampaignModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.Campaign> FetchAllBySellingCompanyId(System.String sellingCompanyId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Campaign.FetchAllBySellingCompanyId(site,sellingCompanyId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:CampaignModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:CampaignModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CampaignModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.Campaign> FetchAllBySellingCompanyId(ConsensusSite site, System.String sellingCompanyId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Marketing.ICampaignModel> collection = provider.Marketing.Campaign.FetchAllBySellingCompanyId(sellingCompanyId);
            return collection.Select(model => new Consensus.Marketing.Campaign(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:CampaignModel" /> instances.
        /// </summary>
        /// <param name="managerId">
        ///     The value which identifies the <see cref="!:CampaignModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CampaignModel" /> instances that match the specified <paramref name="managerId" />.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.Campaign> FetchAllByManagerId(System.String managerId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Campaign.FetchAllByManagerId(site,managerId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:CampaignModel" /> instances.
        /// </summary>
        /// <param name="managerId">
        ///     The value which identifies the <see cref="!:CampaignModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CampaignModel" /> instances that match the specified <paramref name="managerId" />.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.Campaign> FetchAllByManagerId(ConsensusSite site, System.String managerId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Marketing.ICampaignModel> collection = provider.Marketing.Campaign.FetchAllByManagerId(managerId);
            return collection.Select(model => new Consensus.Marketing.Campaign(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:CampaignModel" /> instances.
        /// </summary>
        /// <param name="approverId">
        ///     The value which identifies the <see cref="!:CampaignModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CampaignModel" /> instances that match the specified <paramref name="approverId" />.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.Campaign> FetchAllByApproverId(System.String approverId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Campaign.FetchAllByApproverId(site,approverId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:CampaignModel" /> instances.
        /// </summary>
        /// <param name="approverId">
        ///     The value which identifies the <see cref="!:CampaignModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CampaignModel" /> instances that match the specified <paramref name="approverId" />.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.Campaign> FetchAllByApproverId(ConsensusSite site, System.String approverId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Marketing.ICampaignModel> collection = provider.Marketing.Campaign.FetchAllByApproverId(approverId);
            return collection.Select(model => new Consensus.Marketing.Campaign(model));
        }

        #endregion
    }
}
