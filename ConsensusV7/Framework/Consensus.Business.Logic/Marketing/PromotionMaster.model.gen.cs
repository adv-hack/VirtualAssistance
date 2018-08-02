using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Contact;
using Consensus.Learning;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Encapsulates the <see cref="PromotionMasterRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalPromotionMasterModel : LocalModel<PromotionMasterRecord, String>, IPromotionMasterModel
    {
        #region fields

        /// <summary>
        ///     The value of the "PM_MST_REGION" field.
        /// </summary>
        private LocalCodeModel _region;

        /// <summary>
        ///     The value of the "PM_MST_CMP_ID" field.
        /// </summary>
        private LocalCampaignModel _cmpId;

        /// <summary>
        ///     The value of the "PM_MST_COURSE_ID" field.
        /// </summary>
        private LocalEventModel _courseId;

        /// <summary>
        ///     The value of the "PM_MST_PROLE_ID" field.
        /// </summary>
        private LocalRoleModel _manager;

        /// <summary>
        ///     The value of the "PM_MST_APP_PROLE_ID" field.
        /// </summary>
        private LocalRoleModel _approver;

        /// <summary>
        ///     The collection of <see cref="PromotionModel" /> instances that reference this <see cref="PromotionMasterModel" />.
        /// </summary>
        private LocalCollection<LocalPromotionModel, IPromotionModel> _promotionPromotionMaster;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<PromotionMasterRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Marketing.PromotionMaster.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<PromotionMasterRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Marketing.PromotionMaster.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<PromotionMasterRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Marketing.PromotionMaster.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_NAME" field.
        /// </summary>
        public String Name
        {
            get { return this.ModifiedData.Name; }
            set { this.ModifiedData.Name = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_START_DATE" field.
        /// </summary>
        public DateTime? StartDate
        {
            get { return this.ModifiedData.StartDate; }
            set { this.ModifiedData.StartDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_END_DATE" field.
        /// </summary>
        public DateTime? EndDate
        {
            get { return this.ModifiedData.EndDate; }
            set { this.ModifiedData.EndDate = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PM_MST_REGION" field.
        /// </summary>
        public LocalCodeModel Region
        {
            get
            {
                if (_region == null && !String.IsNullOrEmpty(this.RegionCode))
                    _region = this.Provider.Common.Code.FetchByTypeAndCode("CAMR", this.RegionCode);
                if (_region == null)
                    _region = this.Provider.Common.Code.Create("CAMR");
                return _region;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PM_MST_REGION" field.
        /// </summary>
        public String RegionCode
        {
            get { return this.ModifiedData.Region; }
            set
            {
                if (this.ModifiedData.Region != value)
                     _region = null;
                this.ModifiedData.Region = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_BUDGET_COST" field.
        /// </summary>
        public Double? BudgetCost
        {
            get { return this.ModifiedData.BudgetCost; }
            set { this.ModifiedData.BudgetCost = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_ACTUAL_COST" field.
        /// </summary>
        public Double? ActualCost
        {
            get { return this.ModifiedData.ActualCost; }
            set { this.ModifiedData.ActualCost = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_REPLIES" field.
        /// </summary>
        public Double? ActualReplies
        {
            get { return this.ModifiedData.Replies; }
            set { this.ModifiedData.Replies = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_ORDERS" field.
        /// </summary>
        public Double? SoldOpp
        {
            get { return this.ModifiedData.Orders; }
            set { this.ModifiedData.Orders = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_ORDER_VALUE" field.
        /// </summary>
        public Double? OppVal
        {
            get { return this.ModifiedData.OrderValue; }
            set { this.ModifiedData.OrderValue = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_UPDATED" field.
        /// </summary>
        public DateTime? Updated
        {
            get { return this.ModifiedData.Updated; }
            set { this.ModifiedData.Updated = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PM_MST_CMP_ID" field.
        /// </summary>
        public LocalCampaignModel CmpId
        {
            get
            {
                if (_cmpId == null && this.CmpIdId != null)
                    _cmpId = this.Provider.Marketing.Campaign.FetchById(this.CmpIdId);
                if (_cmpId == null)
                    _cmpId = this.Provider.Marketing.Campaign.Create();
                
                return _cmpId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PM_MST_CMP_ID" field.
        /// </summary>
        public String CmpIdId
        {
            get { return this.ModifiedData.CmpId; }
            set
            {
                if (this.ModifiedData.CmpId != value)
                     _cmpId = null;
                this.ModifiedData.CmpId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_MAILINGS" field.
        /// </summary>
        public Int32? Mailings
        {
            get { return this.ModifiedData.Mailings; }
            set { this.ModifiedData.Mailings = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_BOOKINGS" field.
        /// </summary>
        public Int32? ActualBook
        {
            get { return this.ModifiedData.Bookings; }
            set { this.ModifiedData.Bookings = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_OPP_TOT" field.
        /// </summary>
        public Int32? ActualOpp
        {
            get { return this.ModifiedData.OppTot; }
            set { this.ModifiedData.OppTot = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_QUOTES" field.
        /// </summary>
        public Int32? ActualQuotes
        {
            get { return this.ModifiedData.Quotes; }
            set { this.ModifiedData.Quotes = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_QUO_VAL" field.
        /// </summary>
        public Double? ActualQuotesVal
        {
            get { return this.ModifiedData.QuoVal; }
            set { this.ModifiedData.QuoVal = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_CALC_ACT" field.
        /// </summary>
        public Double? CalculatedActualCost
        {
            get { return this.ModifiedData.CalcAct; }
            set { this.ModifiedData.CalcAct = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_CALC_EST" field.
        /// </summary>
        public Double? CalculatedBudgetCost
        {
            get { return this.ModifiedData.CalcEst; }
            set { this.ModifiedData.CalcEst = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_BOOK_VAL" field.
        /// </summary>
        public Double? ActualBookVal
        {
            get { return this.ModifiedData.BookVal; }
            set { this.ModifiedData.BookVal = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PM_MST_COURSE_ID" field.
        /// </summary>
        public LocalEventModel CourseId
        {
            get
            {
                if (_courseId == null && this.CourseIdId != null)
                    _courseId = this.Provider.Learning.Event.FetchById(this.CourseIdId);
                if (_courseId == null)
                    _courseId = this.Provider.Learning.Event.Create();
                
                return _courseId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PM_MST_COURSE_ID" field.
        /// </summary>
        public String CourseIdId
        {
            get { return this.ModifiedData.CourseId; }
            set
            {
                if (this.ModifiedData.CourseId != value)
                     _courseId = null;
                this.ModifiedData.CourseId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_TYPE" field.
        /// </summary>
        public Byte? Type
        {
            get { return this.ModifiedData.Type; }
            set { this.ModifiedData.Type = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_TARGET_OPP" field.
        /// </summary>
        public Int32? TargetOpp
        {
            get { return this.ModifiedData.TargetOpp; }
            set { this.ModifiedData.TargetOpp = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_TARGET_REPLIES" field.
        /// </summary>
        public Int32? TargetReplies
        {
            get { return this.ModifiedData.TargetReplies; }
            set { this.ModifiedData.TargetReplies = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_TARGET_OPP_VAL" field.
        /// </summary>
        public Double? TargetOppVal
        {
            get { return this.ModifiedData.TargetOppVal; }
            set { this.ModifiedData.TargetOppVal = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_TARGET_BOOK_VAL" field.
        /// </summary>
        public Double? TargetBookVal
        {
            get { return this.ModifiedData.TargetBookVal; }
            set { this.ModifiedData.TargetBookVal = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PM_MST_PROLE_ID" field.
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
        ///     Gets or sets the unique code for the value of the "PM_MST_PROLE_ID" field.
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
        ///     Gets the The value of the "PM_MST_APP_PROLE_ID" field.
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
        ///     Gets or sets the unique code for the value of the "PM_MST_APP_PROLE_ID" field.
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
        ///     Gets or sets the value of the "PM_MST_EMAILS_SENT" field.
        /// </summary>
        public Int32 EmailsSentActual
        {
            get { return this.ModifiedData.EmailsSent; }
            set { this.ModifiedData.EmailsSent = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_EMAILS_OPENED" field.
        /// </summary>
        public Int32 EmailsOpenedActual
        {
            get { return this.ModifiedData.EmailsOpened; }
            set { this.ModifiedData.EmailsOpened = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_LINKS_CLICKED" field.
        /// </summary>
        public Int32 LinksClickedActual
        {
            get { return this.ModifiedData.LinksClicked; }
            set { this.ModifiedData.LinksClicked = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_LZ_CLICKED" field.
        /// </summary>
        public Int32 LzClickedActual
        {
            get { return this.ModifiedData.LzClicked; }
            set { this.ModifiedData.LzClicked = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_SURVEYS_COMPLETED" field.
        /// </summary>
        public Int32 SurveysCompletedActual
        {
            get { return this.ModifiedData.SurveysCompleted; }
            set { this.ModifiedData.SurveysCompleted = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_GLOBAL_UNSUBSCRIBES" field.
        /// </summary>
        public Int32 GlobalUnsubscribesActual
        {
            get { return this.ModifiedData.GlobalUnsubscribes; }
            set { this.ModifiedData.GlobalUnsubscribes = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_LIST_UNSUBSCRIBES" field.
        /// </summary>
        public Int32 ListUnsubscribesActual
        {
            get { return this.ModifiedData.ListUnsubscribes; }
            set { this.ModifiedData.ListUnsubscribes = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_DOCS_DOWNLOADS" field.
        /// </summary>
        public Int32 DocsDownloadsActual
        {
            get { return this.ModifiedData.DocsDownloads; }
            set { this.ModifiedData.DocsDownloads = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_BOUNCE_BACKS" field.
        /// </summary>
        public Int32 BounceBacksActual
        {
            get { return this.ModifiedData.BounceBacks; }
            set { this.ModifiedData.BounceBacks = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_EMAILS_SENT_TARGET" field.
        /// </summary>
        public Int32 EmailsSentTarget
        {
            get { return this.ModifiedData.EmailsSentTarget; }
            set { this.ModifiedData.EmailsSentTarget = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_EMAILS_OPENED_TARGET" field.
        /// </summary>
        public Int32 EmailsOpenedTarget
        {
            get { return this.ModifiedData.EmailsOpenedTarget; }
            set { this.ModifiedData.EmailsOpenedTarget = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_LINKS_CLICKED_TARGET" field.
        /// </summary>
        public Int32 LinksClickedTarget
        {
            get { return this.ModifiedData.LinksClickedTarget; }
            set { this.ModifiedData.LinksClickedTarget = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_LZ_CLICKED_TARGET" field.
        /// </summary>
        public Int32 LzClickedTarget
        {
            get { return this.ModifiedData.LzClickedTarget; }
            set { this.ModifiedData.LzClickedTarget = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_SURVEYS_COMPLETED_TARGET" field.
        /// </summary>
        public Int32 SurveysCompletedTarget
        {
            get { return this.ModifiedData.SurveysCompletedTarget; }
            set { this.ModifiedData.SurveysCompletedTarget = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_GLOBAL_UNSUBSCRIBES_TARGET" field.
        /// </summary>
        public Int32 GlobalUnsubscribesTarget
        {
            get { return this.ModifiedData.GlobalUnsubscribesTarget; }
            set { this.ModifiedData.GlobalUnsubscribesTarget = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_LIST_UNSUBSCRIBES_TARGET" field.
        /// </summary>
        public Int32 ListUnsubscribesTarget
        {
            get { return this.ModifiedData.ListUnsubscribesTarget; }
            set { this.ModifiedData.ListUnsubscribesTarget = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_DOCS_DOWNLOADS_TARGET" field.
        /// </summary>
        public Int32 DocsDownloadsTarget
        {
            get { return this.ModifiedData.DocsDownloadsTarget; }
            set { this.ModifiedData.DocsDownloadsTarget = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_BOUNCE_BACKS_TARGET" field.
        /// </summary>
        public Int32 BounceBacksTarget
        {
            get { return this.ModifiedData.BounceBacksTarget; }
            set { this.ModifiedData.BounceBacksTarget = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_QCODE" field.
        /// </summary>
        public String Qcode
        {
            get { return this.ModifiedData.Qcode; }
            set { this.ModifiedData.Qcode = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="PromotionModel" /> instances that reference this <see cref="PromotionMasterModel" />.
        /// </summary>
        public LocalCollection<LocalPromotionModel, IPromotionModel> PromotionPromotionMaster
        {
            get
            {
                if (_promotionPromotionMaster == null)
                    _promotionPromotionMaster = new LocalCollection<LocalPromotionModel, IPromotionModel>(this.Provider.Marketing.Promotion.FetchAllByPromotionMasterId(this.Id));
                
                return _promotionPromotionMaster;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalPromotionMasterModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalPromotionMasterModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalPromotionMasterModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalPromotionMasterModel(LocalProvider provider, PromotionMasterRecord record) : base(provider, record)
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
            if (_region != null)
            {
                _region.Save();
                this.ModifiedData.Region = _region.Value1;
            }
            if (_cmpId != null)
            {
                _cmpId.Save();
                this.ModifiedData.CmpId = _cmpId.Id == null && this.ModifiedData.CmpId != null ? "" : _cmpId.Id;
            }
            if (_courseId != null)
            {
                _courseId.Save();
                this.ModifiedData.CourseId = _courseId.Id == null && this.ModifiedData.CourseId != null ? "" : _courseId.Id;
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
            if (_promotionPromotionMaster != null)
                _promotionPromotionMaster.Execute(obj => obj.PromotionMasterId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_NAME" field.
        /// </summary>
        System.String IPromotionMasterModel.Name
        {
            get { return this.Name; }
            set { this.Name = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_START_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IPromotionMasterModel.StartDate
        {
            get { return this.StartDate; }
            set { this.StartDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_END_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IPromotionMasterModel.EndDate
        {
            get { return this.EndDate; }
            set { this.EndDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PM_MST_REGION" field.
        /// </summary>
        Consensus.Common.ICodeModel IPromotionMasterModel.Region
        {
            get { return this.Region; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PM_MST_REGION" field.
        /// </summary>
        System.String IPromotionMasterModel.RegionCode
        {
            get { return this.RegionCode; }
            set { this.RegionCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_BUDGET_COST" field.
        /// </summary>
        System.Nullable<System.Double> IPromotionMasterModel.BudgetCost
        {
            get { return this.BudgetCost; }
            set { this.BudgetCost = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_ACTUAL_COST" field.
        /// </summary>
        System.Nullable<System.Double> IPromotionMasterModel.ActualCost
        {
            get { return this.ActualCost; }
            set { this.ActualCost = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_REPLIES" field.
        /// </summary>
        System.Nullable<System.Double> IPromotionMasterModel.ActualReplies
        {
            get { return this.ActualReplies; }
            set { this.ActualReplies = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_ORDERS" field.
        /// </summary>
        System.Nullable<System.Double> IPromotionMasterModel.SoldOpp
        {
            get { return this.SoldOpp; }
            set { this.SoldOpp = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_ORDER_VALUE" field.
        /// </summary>
        System.Nullable<System.Double> IPromotionMasterModel.OppVal
        {
            get { return this.OppVal; }
            set { this.OppVal = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_UPDATED" field.
        /// </summary>
        System.Nullable<System.DateTime> IPromotionMasterModel.Updated
        {
            get { return this.Updated; }
            set { this.Updated = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PM_MST_CMP_ID" field.
        /// </summary>
        Consensus.Marketing.ICampaignModel IPromotionMasterModel.CmpId
        {
            get { return this.CmpId; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PM_MST_CMP_ID" field.
        /// </summary>
        System.String IPromotionMasterModel.CmpIdId
        {
            get { return this.CmpIdId; }
            set { this.CmpIdId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_MAILINGS" field.
        /// </summary>
        System.Nullable<System.Int32> IPromotionMasterModel.Mailings
        {
            get { return this.Mailings; }
            set { this.Mailings = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_BOOKINGS" field.
        /// </summary>
        System.Nullable<System.Int32> IPromotionMasterModel.ActualBook
        {
            get { return this.ActualBook; }
            set { this.ActualBook = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_OPP_TOT" field.
        /// </summary>
        System.Nullable<System.Int32> IPromotionMasterModel.ActualOpp
        {
            get { return this.ActualOpp; }
            set { this.ActualOpp = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_QUOTES" field.
        /// </summary>
        System.Nullable<System.Int32> IPromotionMasterModel.ActualQuotes
        {
            get { return this.ActualQuotes; }
            set { this.ActualQuotes = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_QUO_VAL" field.
        /// </summary>
        System.Nullable<System.Double> IPromotionMasterModel.ActualQuotesVal
        {
            get { return this.ActualQuotesVal; }
            set { this.ActualQuotesVal = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_CALC_ACT" field.
        /// </summary>
        System.Nullable<System.Double> IPromotionMasterModel.CalculatedActualCost
        {
            get { return this.CalculatedActualCost; }
            set { this.CalculatedActualCost = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_CALC_EST" field.
        /// </summary>
        System.Nullable<System.Double> IPromotionMasterModel.CalculatedBudgetCost
        {
            get { return this.CalculatedBudgetCost; }
            set { this.CalculatedBudgetCost = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_BOOK_VAL" field.
        /// </summary>
        System.Nullable<System.Double> IPromotionMasterModel.ActualBookVal
        {
            get { return this.ActualBookVal; }
            set { this.ActualBookVal = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PM_MST_COURSE_ID" field.
        /// </summary>
        Consensus.Learning.IEventModel IPromotionMasterModel.CourseId
        {
            get { return this.CourseId; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PM_MST_COURSE_ID" field.
        /// </summary>
        System.String IPromotionMasterModel.CourseIdId
        {
            get { return this.CourseIdId; }
            set { this.CourseIdId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_TYPE" field.
        /// </summary>
        System.Nullable<System.Byte> IPromotionMasterModel.Type
        {
            get { return this.Type; }
            set { this.Type = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_TARGET_OPP" field.
        /// </summary>
        System.Nullable<System.Int32> IPromotionMasterModel.TargetOpp
        {
            get { return this.TargetOpp; }
            set { this.TargetOpp = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_TARGET_REPLIES" field.
        /// </summary>
        System.Nullable<System.Int32> IPromotionMasterModel.TargetReplies
        {
            get { return this.TargetReplies; }
            set { this.TargetReplies = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_TARGET_OPP_VAL" field.
        /// </summary>
        System.Nullable<System.Double> IPromotionMasterModel.TargetOppVal
        {
            get { return this.TargetOppVal; }
            set { this.TargetOppVal = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_TARGET_BOOK_VAL" field.
        /// </summary>
        System.Nullable<System.Double> IPromotionMasterModel.TargetBookVal
        {
            get { return this.TargetBookVal; }
            set { this.TargetBookVal = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PM_MST_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel IPromotionMasterModel.Manager
        {
            get { return this.Manager; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PM_MST_PROLE_ID" field.
        /// </summary>
        System.String IPromotionMasterModel.ManagerId
        {
            get { return this.ManagerId; }
            set { this.ManagerId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PM_MST_APP_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel IPromotionMasterModel.Approver
        {
            get { return this.Approver; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PM_MST_APP_PROLE_ID" field.
        /// </summary>
        System.String IPromotionMasterModel.ApproverId
        {
            get { return this.ApproverId; }
            set { this.ApproverId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_EMAILS_SENT" field.
        /// </summary>
        System.Int32 IPromotionMasterModel.EmailsSentActual
        {
            get { return this.EmailsSentActual; }
            set { this.EmailsSentActual = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_EMAILS_OPENED" field.
        /// </summary>
        System.Int32 IPromotionMasterModel.EmailsOpenedActual
        {
            get { return this.EmailsOpenedActual; }
            set { this.EmailsOpenedActual = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_LINKS_CLICKED" field.
        /// </summary>
        System.Int32 IPromotionMasterModel.LinksClickedActual
        {
            get { return this.LinksClickedActual; }
            set { this.LinksClickedActual = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_LZ_CLICKED" field.
        /// </summary>
        System.Int32 IPromotionMasterModel.LzClickedActual
        {
            get { return this.LzClickedActual; }
            set { this.LzClickedActual = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_SURVEYS_COMPLETED" field.
        /// </summary>
        System.Int32 IPromotionMasterModel.SurveysCompletedActual
        {
            get { return this.SurveysCompletedActual; }
            set { this.SurveysCompletedActual = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_GLOBAL_UNSUBSCRIBES" field.
        /// </summary>
        System.Int32 IPromotionMasterModel.GlobalUnsubscribesActual
        {
            get { return this.GlobalUnsubscribesActual; }
            set { this.GlobalUnsubscribesActual = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_LIST_UNSUBSCRIBES" field.
        /// </summary>
        System.Int32 IPromotionMasterModel.ListUnsubscribesActual
        {
            get { return this.ListUnsubscribesActual; }
            set { this.ListUnsubscribesActual = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_DOCS_DOWNLOADS" field.
        /// </summary>
        System.Int32 IPromotionMasterModel.DocsDownloadsActual
        {
            get { return this.DocsDownloadsActual; }
            set { this.DocsDownloadsActual = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_BOUNCE_BACKS" field.
        /// </summary>
        System.Int32 IPromotionMasterModel.BounceBacksActual
        {
            get { return this.BounceBacksActual; }
            set { this.BounceBacksActual = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_EMAILS_SENT_TARGET" field.
        /// </summary>
        System.Int32 IPromotionMasterModel.EmailsSentTarget
        {
            get { return this.EmailsSentTarget; }
            set { this.EmailsSentTarget = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_EMAILS_OPENED_TARGET" field.
        /// </summary>
        System.Int32 IPromotionMasterModel.EmailsOpenedTarget
        {
            get { return this.EmailsOpenedTarget; }
            set { this.EmailsOpenedTarget = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_LINKS_CLICKED_TARGET" field.
        /// </summary>
        System.Int32 IPromotionMasterModel.LinksClickedTarget
        {
            get { return this.LinksClickedTarget; }
            set { this.LinksClickedTarget = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_LZ_CLICKED_TARGET" field.
        /// </summary>
        System.Int32 IPromotionMasterModel.LzClickedTarget
        {
            get { return this.LzClickedTarget; }
            set { this.LzClickedTarget = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_SURVEYS_COMPLETED_TARGET" field.
        /// </summary>
        System.Int32 IPromotionMasterModel.SurveysCompletedTarget
        {
            get { return this.SurveysCompletedTarget; }
            set { this.SurveysCompletedTarget = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_GLOBAL_UNSUBSCRIBES_TARGET" field.
        /// </summary>
        System.Int32 IPromotionMasterModel.GlobalUnsubscribesTarget
        {
            get { return this.GlobalUnsubscribesTarget; }
            set { this.GlobalUnsubscribesTarget = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_LIST_UNSUBSCRIBES_TARGET" field.
        /// </summary>
        System.Int32 IPromotionMasterModel.ListUnsubscribesTarget
        {
            get { return this.ListUnsubscribesTarget; }
            set { this.ListUnsubscribesTarget = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_DOCS_DOWNLOADS_TARGET" field.
        /// </summary>
        System.Int32 IPromotionMasterModel.DocsDownloadsTarget
        {
            get { return this.DocsDownloadsTarget; }
            set { this.DocsDownloadsTarget = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_BOUNCE_BACKS_TARGET" field.
        /// </summary>
        System.Int32 IPromotionMasterModel.BounceBacksTarget
        {
            get { return this.BounceBacksTarget; }
            set { this.BounceBacksTarget = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_QCODE" field.
        /// </summary>
        System.String IPromotionMasterModel.Qcode
        {
            get { return this.Qcode; }
            set { this.Qcode = (System.String)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PromotionModel" /> instances that reference this <see cref="!:PromotionMasterModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Marketing.IPromotionModel> IPromotionMasterModel.PromotionPromotionMaster
        {
            get { return this.PromotionPromotionMaster; }
        }

        #endregion
    }
}
