using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Contact;
using Consensus.Logistics;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Encapsulates the <see cref="CampaignRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalCampaignModel : LocalModel<CampaignRecord, String>, ICampaignModel
    {
        #region fields

        /// <summary>
        ///     The value of the "CMP_PROJ_ID" field.
        /// </summary>
        private LocalProjectModel _project;

        /// <summary>
        ///     The value of the "CMP_SELCO_SP_ID" field.
        /// </summary>
        private LocalSellingCompanyModel _sellingCompany;

        /// <summary>
        ///     The value of the "CMP_PROLE_ID" field.
        /// </summary>
        private LocalRoleModel _manager;

        /// <summary>
        ///     The value of the "CMP_APP_PROLE_ID" field.
        /// </summary>
        private LocalRoleModel _approver;

        /// <summary>
        ///     The collection of <see cref="PromotionMasterModel" /> instances that reference this <see cref="CampaignModel" />.
        /// </summary>
        private LocalCollection<LocalPromotionMasterModel, IPromotionMasterModel> _promotionMasterCampaign;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<CampaignRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Marketing.Campaign.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<CampaignRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Marketing.Campaign.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<CampaignRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Marketing.Campaign.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_NAME" field.
        /// </summary>
        public String Name
        {
            get { return this.ModifiedData.Name; }
            set { this.ModifiedData.Name = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_START_DATE" field.
        /// </summary>
        public DateTime? StartDate
        {
            get { return this.ModifiedData.StartDate; }
            set { this.ModifiedData.StartDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_END_DATE" field.
        /// </summary>
        public DateTime? EndDate
        {
            get { return this.ModifiedData.EndDate; }
            set { this.ModifiedData.EndDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_REGION" field.
        /// </summary>
        public String Region
        {
            get { return this.ModifiedData.Region; }
            set { this.ModifiedData.Region = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_OBJ_TEXT_ID" field.
        /// </summary>
        public String ObjTextId
        {
            get { return this.ModifiedData.ObjTextId; }
            set { this.ModifiedData.ObjTextId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_SEL_TEXT_ID" field.
        /// </summary>
        public String SelTextId
        {
            get { return this.ModifiedData.SelTextId; }
            set { this.ModifiedData.SelTextId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_RVW_TEXT_ID" field.
        /// </summary>
        public String RvwTextId
        {
            get { return this.ModifiedData.RvwTextId; }
            set { this.ModifiedData.RvwTextId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_BUDGET_COSTS" field.
        /// </summary>
        public Double? BudgetCosts
        {
            get { return this.ModifiedData.BudgetCosts; }
            set { this.ModifiedData.BudgetCosts = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_ACTUAL_COSTS" field.
        /// </summary>
        public Double? ActualCosts
        {
            get { return this.ModifiedData.ActualCosts; }
            set { this.ModifiedData.ActualCosts = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_REPLIES" field.
        /// </summary>
        public Double? ActualReplies
        {
            get { return this.ModifiedData.Replies; }
            set { this.ModifiedData.Replies = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_ORDERS" field.
        /// </summary>
        public Double? SoldOpp
        {
            get { return this.ModifiedData.Orders; }
            set { this.ModifiedData.Orders = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_ORDER_VALUE" field.
        /// </summary>
        public Double? OppVal
        {
            get { return this.ModifiedData.OrderValue; }
            set { this.ModifiedData.OrderValue = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_UPDATED" field.
        /// </summary>
        public DateTime? Updated
        {
            get { return this.ModifiedData.Updated; }
            set { this.ModifiedData.Updated = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_MAILINGS" field.
        /// </summary>
        public Int32? Mailings
        {
            get { return this.ModifiedData.Mailings; }
            set { this.ModifiedData.Mailings = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_BOOKINGS" field.
        /// </summary>
        public Int32? ActualBook
        {
            get { return this.ModifiedData.Bookings; }
            set { this.ModifiedData.Bookings = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_BOOK_VALUE" field.
        /// </summary>
        public Double? ActualBookValue
        {
            get { return this.ModifiedData.BookValue; }
            set { this.ModifiedData.BookValue = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_QUOTES" field.
        /// </summary>
        public Int32? ActualQuotes
        {
            get { return this.ModifiedData.Quotes; }
            set { this.ModifiedData.Quotes = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_QUO_VALUE" field.
        /// </summary>
        public Double? ActualQuotesVal
        {
            get { return this.ModifiedData.QuoValue; }
            set { this.ModifiedData.QuoValue = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_CALC_ACT" field.
        /// </summary>
        public Double? CalcAct
        {
            get { return this.ModifiedData.CalcAct; }
            set { this.ModifiedData.CalcAct = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_CALC_EST" field.
        /// </summary>
        public Double? CalcEst
        {
            get { return this.ModifiedData.CalcEst; }
            set { this.ModifiedData.CalcEst = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_OPP_TOT" field.
        /// </summary>
        public Int32? ActualOpp
        {
            get { return this.ModifiedData.OppTot; }
            set { this.ModifiedData.OppTot = value; }
        }

        /// <summary>
        ///     Gets the The value of the "CMP_PROJ_ID" field.
        /// </summary>
        public LocalProjectModel Project
        {
            get
            {
                if (_project == null && this.ProjectId != null)
                    _project = this.Provider.Logistics.Project.FetchById(this.ProjectId);
                if (_project == null)
                    _project = this.Provider.Logistics.Project.Create();
                
                return _project;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CMP_PROJ_ID" field.
        /// </summary>
        public String ProjectId
        {
            get { return this.ModifiedData.ProjId; }
            set
            {
                if (this.ModifiedData.ProjId != value)
                     _project = null;
                this.ModifiedData.ProjId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "CMP_SELCO_SP_ID" field.
        /// </summary>
        public LocalSellingCompanyModel SellingCompany
        {
            get
            {
                if (_sellingCompany == null && this.SellingCompanyId != null)
                    _sellingCompany = this.Provider.Common.SellingCompany.FetchById(this.SellingCompanyId);
                if (_sellingCompany == null)
                    _sellingCompany = this.Provider.Common.SellingCompany.Create();
                
                return _sellingCompany;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CMP_SELCO_SP_ID" field.
        /// </summary>
        public String SellingCompanyId
        {
            get { return this.ModifiedData.SelcoSpId; }
            set
            {
                if (this.ModifiedData.SelcoSpId != value)
                     _sellingCompany = null;
                this.ModifiedData.SelcoSpId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_TARGET_OPP" field.
        /// </summary>
        public Int32? TargetOpp
        {
            get { return this.ModifiedData.TargetOpp; }
            set { this.ModifiedData.TargetOpp = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_TARGET_REPLIES" field.
        /// </summary>
        public Int32? TargetReplies
        {
            get { return this.ModifiedData.TargetReplies; }
            set { this.ModifiedData.TargetReplies = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_TARGET_OPP_VAL" field.
        /// </summary>
        public Double? TargetOppVal
        {
            get { return this.ModifiedData.TargetOppVal; }
            set { this.ModifiedData.TargetOppVal = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_TARGET_BOOK_VAL" field.
        /// </summary>
        public Double? TargetBookVal
        {
            get { return this.ModifiedData.TargetBookVal; }
            set { this.ModifiedData.TargetBookVal = value; }
        }

        /// <summary>
        ///     Gets the The value of the "CMP_PROLE_ID" field.
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
        ///     Gets or sets the unique code for the value of the "CMP_PROLE_ID" field.
        /// </summary>
        public String ManagerId
        {
            get { return this.ModifiedData.ProleId; }
            set
            {
                if (this.ModifiedData.ProleId != value)
                     _manager = null;
                this.ModifiedData.ProleId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "CMP_APP_PROLE_ID" field.
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
        ///     Gets or sets the unique code for the value of the "CMP_APP_PROLE_ID" field.
        /// </summary>
        public String ApproverId
        {
            get { return this.ModifiedData.AppProleId; }
            set
            {
                if (this.ModifiedData.AppProleId != value)
                     _approver = null;
                this.ModifiedData.AppProleId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_EMAILS_SENT" field.
        /// </summary>
        public Int32 EmailsSentActual
        {
            get { return this.ModifiedData.EmailsSent; }
            set { this.ModifiedData.EmailsSent = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_EMAILS_OPENED" field.
        /// </summary>
        public Int32 EmailsOpenedActual
        {
            get { return this.ModifiedData.EmailsOpened; }
            set { this.ModifiedData.EmailsOpened = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_LINKS_CLICKED" field.
        /// </summary>
        public Int32 LinksClickedActual
        {
            get { return this.ModifiedData.LinksClicked; }
            set { this.ModifiedData.LinksClicked = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_LZ_CLICKED" field.
        /// </summary>
        public Int32 LzClickedActual
        {
            get { return this.ModifiedData.LzClicked; }
            set { this.ModifiedData.LzClicked = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_SURVEYS_COMPLETED" field.
        /// </summary>
        public Int32 SurveysCompletedActual
        {
            get { return this.ModifiedData.SurveysCompleted; }
            set { this.ModifiedData.SurveysCompleted = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_GLOBAL_UNSUBSCRIBES" field.
        /// </summary>
        public Int32 GlobalUnsubscribesActual
        {
            get { return this.ModifiedData.GlobalUnsubscribes; }
            set { this.ModifiedData.GlobalUnsubscribes = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_LIST_UNSUBSCRIBES" field.
        /// </summary>
        public Int32 ListUnsubscribesActual
        {
            get { return this.ModifiedData.ListUnsubscribes; }
            set { this.ModifiedData.ListUnsubscribes = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_DOCS_DOWNLOADS" field.
        /// </summary>
        public Int32 DocsDownloadsActual
        {
            get { return this.ModifiedData.DocsDownloads; }
            set { this.ModifiedData.DocsDownloads = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_BOUNCE_BACKS" field.
        /// </summary>
        public Int32 BounceBacksActual
        {
            get { return this.ModifiedData.BounceBacks; }
            set { this.ModifiedData.BounceBacks = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_EMAILS_SENT_TARGET" field.
        /// </summary>
        public Int32 EmailsSentTarget
        {
            get { return this.ModifiedData.EmailsSentTarget; }
            set { this.ModifiedData.EmailsSentTarget = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_EMAILS_OPENED_TARGET" field.
        /// </summary>
        public Int32 EmailsOpenedTarget
        {
            get { return this.ModifiedData.EmailsOpenedTarget; }
            set { this.ModifiedData.EmailsOpenedTarget = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_LINKS_CLICKED_TARGET" field.
        /// </summary>
        public Int32 LinksClickedTarget
        {
            get { return this.ModifiedData.LinksClickedTarget; }
            set { this.ModifiedData.LinksClickedTarget = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_LZ_CLICKED_TARGET" field.
        /// </summary>
        public Int32 LzClickedTarget
        {
            get { return this.ModifiedData.LzClickedTarget; }
            set { this.ModifiedData.LzClickedTarget = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_SURVEYS_COMPLETED_TARGET" field.
        /// </summary>
        public Int32 SurveysCompletedTarget
        {
            get { return this.ModifiedData.SurveysCompletedTarget; }
            set { this.ModifiedData.SurveysCompletedTarget = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_GLOBAL_UNSUBSCRIBES_TARGET" field.
        /// </summary>
        public Int32 GlobalUnsubscribesTarget
        {
            get { return this.ModifiedData.GlobalUnsubscribesTarget; }
            set { this.ModifiedData.GlobalUnsubscribesTarget = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_LIST_UNSUBSCRIBES_TARGET" field.
        /// </summary>
        public Int32 ListUnsubscribesTarget
        {
            get { return this.ModifiedData.ListUnsubscribesTarget; }
            set { this.ModifiedData.ListUnsubscribesTarget = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_DOCS_DOWNLOADS_TARGET" field.
        /// </summary>
        public Int32 DocsDownloadsTarget
        {
            get { return this.ModifiedData.DocsDownloadsTarget; }
            set { this.ModifiedData.DocsDownloadsTarget = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_BOUNCE_BACKS_TARGET" field.
        /// </summary>
        public Int32 BounceBacksTarget
        {
            get { return this.ModifiedData.BounceBacksTarget; }
            set { this.ModifiedData.BounceBacksTarget = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_QCODE" field.
        /// </summary>
        public String Qcode
        {
            get { return this.ModifiedData.Qcode; }
            set { this.ModifiedData.Qcode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_CURRENT" field.
        /// </summary>
        public Byte? Current
        {
            get { return this.ModifiedData.Current; }
            set { this.ModifiedData.Current = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="PromotionMasterModel" /> instances that reference this <see cref="CampaignModel" />.
        /// </summary>
        public LocalCollection<LocalPromotionMasterModel, IPromotionMasterModel> PromotionMasterCampaign
        {
            get
            {
                if (_promotionMasterCampaign == null)
                    _promotionMasterCampaign = new LocalCollection<LocalPromotionMasterModel, IPromotionMasterModel>(this.Provider.Marketing.PromotionMaster.FetchAllByCmpIdId(this.Id));
                
                return _promotionMasterCampaign;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalCampaignModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalCampaignModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalCampaignModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalCampaignModel(LocalProvider provider, CampaignRecord record) : base(provider, record)
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
            if (_project != null)
            {
                _project.Save();
                this.ModifiedData.ProjId = _project.Id == null && this.ModifiedData.ProjId != null ? "" : _project.Id;
            }
            if (_sellingCompany != null)
            {
                _sellingCompany.Save();
                this.ModifiedData.SelcoSpId = _sellingCompany.Id == null && this.ModifiedData.SelcoSpId != null ? "" : _sellingCompany.Id;
            }
            if (_manager != null)
            {
                _manager.Save();
                this.ModifiedData.ProleId = _manager.Id == null && this.ModifiedData.ProleId != null ? "" : _manager.Id;
            }
            if (_approver != null)
            {
                _approver.Save();
                this.ModifiedData.AppProleId = _approver.Id == null && this.ModifiedData.AppProleId != null ? "" : _approver.Id;
            }
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
            if (_promotionMasterCampaign != null)
                _promotionMasterCampaign.Execute(obj => obj.CmpIdId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets or sets the value of the "CMP_NAME" field.
        /// </summary>
        System.String ICampaignModel.Name
        {
            get { return this.Name; }
            set { this.Name = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_START_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> ICampaignModel.StartDate
        {
            get { return this.StartDate; }
            set { this.StartDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_END_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> ICampaignModel.EndDate
        {
            get { return this.EndDate; }
            set { this.EndDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_REGION" field.
        /// </summary>
        System.String ICampaignModel.Region
        {
            get { return this.Region; }
            set { this.Region = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_OBJ_TEXT_ID" field.
        /// </summary>
        System.String ICampaignModel.ObjTextId
        {
            get { return this.ObjTextId; }
            set { this.ObjTextId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_SEL_TEXT_ID" field.
        /// </summary>
        System.String ICampaignModel.SelTextId
        {
            get { return this.SelTextId; }
            set { this.SelTextId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_RVW_TEXT_ID" field.
        /// </summary>
        System.String ICampaignModel.RvwTextId
        {
            get { return this.RvwTextId; }
            set { this.RvwTextId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_BUDGET_COSTS" field.
        /// </summary>
        System.Nullable<System.Double> ICampaignModel.BudgetCosts
        {
            get { return this.BudgetCosts; }
            set { this.BudgetCosts = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_ACTUAL_COSTS" field.
        /// </summary>
        System.Nullable<System.Double> ICampaignModel.ActualCosts
        {
            get { return this.ActualCosts; }
            set { this.ActualCosts = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_REPLIES" field.
        /// </summary>
        System.Nullable<System.Double> ICampaignModel.ActualReplies
        {
            get { return this.ActualReplies; }
            set { this.ActualReplies = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_ORDERS" field.
        /// </summary>
        System.Nullable<System.Double> ICampaignModel.SoldOpp
        {
            get { return this.SoldOpp; }
            set { this.SoldOpp = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_ORDER_VALUE" field.
        /// </summary>
        System.Nullable<System.Double> ICampaignModel.OppVal
        {
            get { return this.OppVal; }
            set { this.OppVal = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_UPDATED" field.
        /// </summary>
        System.Nullable<System.DateTime> ICampaignModel.Updated
        {
            get { return this.Updated; }
            set { this.Updated = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_MAILINGS" field.
        /// </summary>
        System.Nullable<System.Int32> ICampaignModel.Mailings
        {
            get { return this.Mailings; }
            set { this.Mailings = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_BOOKINGS" field.
        /// </summary>
        System.Nullable<System.Int32> ICampaignModel.ActualBook
        {
            get { return this.ActualBook; }
            set { this.ActualBook = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_BOOK_VALUE" field.
        /// </summary>
        System.Nullable<System.Double> ICampaignModel.ActualBookValue
        {
            get { return this.ActualBookValue; }
            set { this.ActualBookValue = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_QUOTES" field.
        /// </summary>
        System.Nullable<System.Int32> ICampaignModel.ActualQuotes
        {
            get { return this.ActualQuotes; }
            set { this.ActualQuotes = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_QUO_VALUE" field.
        /// </summary>
        System.Nullable<System.Double> ICampaignModel.ActualQuotesVal
        {
            get { return this.ActualQuotesVal; }
            set { this.ActualQuotesVal = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_CALC_ACT" field.
        /// </summary>
        System.Nullable<System.Double> ICampaignModel.CalcAct
        {
            get { return this.CalcAct; }
            set { this.CalcAct = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_CALC_EST" field.
        /// </summary>
        System.Nullable<System.Double> ICampaignModel.CalcEst
        {
            get { return this.CalcEst; }
            set { this.CalcEst = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_OPP_TOT" field.
        /// </summary>
        System.Nullable<System.Int32> ICampaignModel.ActualOpp
        {
            get { return this.ActualOpp; }
            set { this.ActualOpp = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "CMP_PROJ_ID" field.
        /// </summary>
        Consensus.Logistics.IProjectModel ICampaignModel.Project
        {
            get { return this.Project; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CMP_PROJ_ID" field.
        /// </summary>
        System.String ICampaignModel.ProjectId
        {
            get { return this.ProjectId; }
            set { this.ProjectId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "CMP_SELCO_SP_ID" field.
        /// </summary>
        Consensus.Common.ISellingCompanyModel ICampaignModel.SellingCompany
        {
            get { return this.SellingCompany; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CMP_SELCO_SP_ID" field.
        /// </summary>
        System.String ICampaignModel.SellingCompanyId
        {
            get { return this.SellingCompanyId; }
            set { this.SellingCompanyId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_TARGET_OPP" field.
        /// </summary>
        System.Nullable<System.Int32> ICampaignModel.TargetOpp
        {
            get { return this.TargetOpp; }
            set { this.TargetOpp = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_TARGET_REPLIES" field.
        /// </summary>
        System.Nullable<System.Int32> ICampaignModel.TargetReplies
        {
            get { return this.TargetReplies; }
            set { this.TargetReplies = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_TARGET_OPP_VAL" field.
        /// </summary>
        System.Nullable<System.Double> ICampaignModel.TargetOppVal
        {
            get { return this.TargetOppVal; }
            set { this.TargetOppVal = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_TARGET_BOOK_VAL" field.
        /// </summary>
        System.Nullable<System.Double> ICampaignModel.TargetBookVal
        {
            get { return this.TargetBookVal; }
            set { this.TargetBookVal = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "CMP_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel ICampaignModel.Manager
        {
            get { return this.Manager; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CMP_PROLE_ID" field.
        /// </summary>
        System.String ICampaignModel.ManagerId
        {
            get { return this.ManagerId; }
            set { this.ManagerId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "CMP_APP_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel ICampaignModel.Approver
        {
            get { return this.Approver; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CMP_APP_PROLE_ID" field.
        /// </summary>
        System.String ICampaignModel.ApproverId
        {
            get { return this.ApproverId; }
            set { this.ApproverId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_EMAILS_SENT" field.
        /// </summary>
        System.Int32 ICampaignModel.EmailsSentActual
        {
            get { return this.EmailsSentActual; }
            set { this.EmailsSentActual = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_EMAILS_OPENED" field.
        /// </summary>
        System.Int32 ICampaignModel.EmailsOpenedActual
        {
            get { return this.EmailsOpenedActual; }
            set { this.EmailsOpenedActual = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_LINKS_CLICKED" field.
        /// </summary>
        System.Int32 ICampaignModel.LinksClickedActual
        {
            get { return this.LinksClickedActual; }
            set { this.LinksClickedActual = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_LZ_CLICKED" field.
        /// </summary>
        System.Int32 ICampaignModel.LzClickedActual
        {
            get { return this.LzClickedActual; }
            set { this.LzClickedActual = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_SURVEYS_COMPLETED" field.
        /// </summary>
        System.Int32 ICampaignModel.SurveysCompletedActual
        {
            get { return this.SurveysCompletedActual; }
            set { this.SurveysCompletedActual = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_GLOBAL_UNSUBSCRIBES" field.
        /// </summary>
        System.Int32 ICampaignModel.GlobalUnsubscribesActual
        {
            get { return this.GlobalUnsubscribesActual; }
            set { this.GlobalUnsubscribesActual = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_LIST_UNSUBSCRIBES" field.
        /// </summary>
        System.Int32 ICampaignModel.ListUnsubscribesActual
        {
            get { return this.ListUnsubscribesActual; }
            set { this.ListUnsubscribesActual = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_DOCS_DOWNLOADS" field.
        /// </summary>
        System.Int32 ICampaignModel.DocsDownloadsActual
        {
            get { return this.DocsDownloadsActual; }
            set { this.DocsDownloadsActual = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_BOUNCE_BACKS" field.
        /// </summary>
        System.Int32 ICampaignModel.BounceBacksActual
        {
            get { return this.BounceBacksActual; }
            set { this.BounceBacksActual = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_EMAILS_SENT_TARGET" field.
        /// </summary>
        System.Int32 ICampaignModel.EmailsSentTarget
        {
            get { return this.EmailsSentTarget; }
            set { this.EmailsSentTarget = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_EMAILS_OPENED_TARGET" field.
        /// </summary>
        System.Int32 ICampaignModel.EmailsOpenedTarget
        {
            get { return this.EmailsOpenedTarget; }
            set { this.EmailsOpenedTarget = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_LINKS_CLICKED_TARGET" field.
        /// </summary>
        System.Int32 ICampaignModel.LinksClickedTarget
        {
            get { return this.LinksClickedTarget; }
            set { this.LinksClickedTarget = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_LZ_CLICKED_TARGET" field.
        /// </summary>
        System.Int32 ICampaignModel.LzClickedTarget
        {
            get { return this.LzClickedTarget; }
            set { this.LzClickedTarget = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_SURVEYS_COMPLETED_TARGET" field.
        /// </summary>
        System.Int32 ICampaignModel.SurveysCompletedTarget
        {
            get { return this.SurveysCompletedTarget; }
            set { this.SurveysCompletedTarget = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_GLOBAL_UNSUBSCRIBES_TARGET" field.
        /// </summary>
        System.Int32 ICampaignModel.GlobalUnsubscribesTarget
        {
            get { return this.GlobalUnsubscribesTarget; }
            set { this.GlobalUnsubscribesTarget = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_LIST_UNSUBSCRIBES_TARGET" field.
        /// </summary>
        System.Int32 ICampaignModel.ListUnsubscribesTarget
        {
            get { return this.ListUnsubscribesTarget; }
            set { this.ListUnsubscribesTarget = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_DOCS_DOWNLOADS_TARGET" field.
        /// </summary>
        System.Int32 ICampaignModel.DocsDownloadsTarget
        {
            get { return this.DocsDownloadsTarget; }
            set { this.DocsDownloadsTarget = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_BOUNCE_BACKS_TARGET" field.
        /// </summary>
        System.Int32 ICampaignModel.BounceBacksTarget
        {
            get { return this.BounceBacksTarget; }
            set { this.BounceBacksTarget = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_QCODE" field.
        /// </summary>
        System.String ICampaignModel.Qcode
        {
            get { return this.Qcode; }
            set { this.Qcode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_CURRENT" field.
        /// </summary>
        System.Nullable<System.Byte> ICampaignModel.Current
        {
            get { return this.Current; }
            set { this.Current = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PromotionMasterModel" /> instances that reference this <see cref="!:CampaignModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Marketing.IPromotionMasterModel> ICampaignModel.PromotionMasterCampaign
        {
            get { return this.PromotionMasterCampaign; }
        }

        #endregion
    }
}
