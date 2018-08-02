using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Activities;
using Consensus.Common;
using Consensus.Contact;
using Consensus.Learning;
using Consensus.Membership;
using Consensus.Sales;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Encapsulates the <see cref="PromotionRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalPromotionModel : LocalModel<PromotionRecord, String>, IPromotionModel
    {
        #region fields

        /// <summary>
        ///     The value of the "PM_CMP_ID" field.
        /// </summary>
        private LocalPromotionMasterModel _promotionMaster;

        /// <summary>
        ///     The value of the "PM_CHANNEL" field.
        /// </summary>
        private LocalCodeModel _channel;

        /// <summary>
        ///     The value of the "PM_MEDIA_NAME" field.
        /// </summary>
        private LocalCodeModel _mediaName;

        /// <summary>
        ///     The value of the "PM_TYPE" field.
        /// </summary>
        private LocalCodeModel _type;

        /// <summary>
        ///     The value of the "PM_PROLE_ID" field.
        /// </summary>
        private LocalRoleModel _manager;

        /// <summary>
        ///     The value of the "PM_APP_PROLE_ID" field.
        /// </summary>
        private LocalRoleModel _approver;

        /// <summary>
        ///     The collection of <see cref="PersonModel" /> instances that reference this <see cref="PromotionModel" />.
        /// </summary>
        private LocalCollection<LocalPersonModel, IPersonModel> _personPromotion;

        /// <summary>
        ///     The collection of <see cref="BookingModel" /> instances that reference this <see cref="PromotionModel" />.
        /// </summary>
        private LocalCollection<LocalBookingModel, IBookingModel> _bookings;

        /// <summary>
        ///     The collection of <see cref="OpportunityModel" /> instances that reference this <see cref="PromotionModel" />.
        /// </summary>
        private LocalCollection<LocalOpportunityModel, IOpportunityModel> _oppPromId;

        /// <summary>
        ///     The collection of <see cref="HelpdeskModel" /> instances that reference this <see cref="PromotionModel" />.
        /// </summary>
        private LocalCollection<LocalHelpdeskModel, IHelpdeskModel> _helpdeskPromotionId;

        /// <summary>
        ///     The collection of <see cref="ComplaintModel" /> instances that reference this <see cref="PromotionModel" />.
        /// </summary>
        private LocalCollection<LocalComplaintModel, IComplaintModel> _complaintPromotion;

        /// <summary>
        ///     The collection of <see cref="MemberPeriodModel" /> instances that reference this <see cref="PromotionModel" />.
        /// </summary>
        private LocalCollection<LocalMemberPeriodModel, IMemberPeriodModel> _memberPeriods;

        /// <summary>
        ///     The collection of <see cref="SaqQueryModel" /> instances that reference this <see cref="PromotionModel" />.
        /// </summary>
        private LocalCollection<LocalSaqQueryModel, ISaqQueryModel> _saqQuerySourceCode;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<PromotionRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Marketing.Promotion.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<PromotionRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Marketing.Promotion.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<PromotionRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Marketing.Promotion.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "PM_CMP_ID" field.
        /// </summary>
        public LocalPromotionMasterModel PromotionMaster
        {
            get
            {
                if (_promotionMaster == null && this.PromotionMasterId != null)
                    _promotionMaster = this.Provider.Marketing.PromotionMaster.FetchById(this.PromotionMasterId);
                if (_promotionMaster == null)
                    _promotionMaster = this.Provider.Marketing.PromotionMaster.Create();
                
                return _promotionMaster;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PM_CMP_ID" field.
        /// </summary>
        public String PromotionMasterId
        {
            get { return this.ModifiedData.CmpId; }
            set
            {
                if (this.ModifiedData.CmpId != value)
                     _promotionMaster = null;
                this.ModifiedData.CmpId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_NAME" field.
        /// </summary>
        public String Name
        {
            get { return this.ModifiedData.Name; }
            set { this.ModifiedData.Name = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_START_DATE" field.
        /// </summary>
        public DateTime? StartDate
        {
            get { return this.ModifiedData.StartDate; }
            set { this.ModifiedData.StartDate = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PM_CHANNEL" field.
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
        ///     Gets or sets the unique code for the value of the "PM_CHANNEL" field.
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
        ///     Gets or sets the value of the "PM_DM_NUMBER" field.
        /// </summary>
        public Double? MailingActivities
        {
            get { return this.ModifiedData.DmNumber; }
            set { this.ModifiedData.DmNumber = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_REPLIES" field.
        /// </summary>
        public Double? Responses
        {
            get { return this.ModifiedData.Replies; }
            set { this.ModifiedData.Replies = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_ORDERS" field.
        /// </summary>
        public Double? SoldOpportunities
        {
            get { return this.ModifiedData.Orders; }
            set { this.ModifiedData.Orders = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_ORDER_VAL" field.
        /// </summary>
        public Double? SoldOpportunitiesValue
        {
            get { return this.ModifiedData.OrderVal; }
            set { this.ModifiedData.OrderVal = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_BUDGET_COST" field.
        /// </summary>
        public Double? CalculatedBudgetCost
        {
            get { return this.ModifiedData.BudgetCost; }
            set { this.ModifiedData.BudgetCost = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_ACTUAL_COST" field.
        /// </summary>
        public Double? CalculatedeActualCost
        {
            get { return this.ModifiedData.ActualCost; }
            set { this.ModifiedData.ActualCost = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_UPDATED" field.
        /// </summary>
        public DateTime? Updated
        {
            get { return this.ModifiedData.Updated; }
            set { this.ModifiedData.Updated = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_CURRENT" field.
        /// </summary>
        public Byte? Current
        {
            get { return this.ModifiedData.Current; }
            set { this.ModifiedData.Current = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PM_MEDIA_NAME" field.
        /// </summary>
        public LocalCodeModel MediaName
        {
            get
            {
                if (_mediaName == null && !String.IsNullOrEmpty(this.MediaNameCode))
                    _mediaName = this.Provider.Common.Code.FetchByTypeAndCode("MDANM", this.MediaNameCode);
                if (_mediaName == null)
                    _mediaName = this.Provider.Common.Code.Create("MDANM");
                return _mediaName;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PM_MEDIA_NAME" field.
        /// </summary>
        public String MediaNameCode
        {
            get { return this.ModifiedData.MediaName; }
            set
            {
                if (this.ModifiedData.MediaName != value)
                     _mediaName = null;
                this.ModifiedData.MediaName = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_BOOKING" field.
        /// </summary>
        public Int32? BookingCount
        {
            get { return this.ModifiedData.Booking; }
            set { this.ModifiedData.Booking = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_BOOK_VALUE" field.
        /// </summary>
        public Double? BookingsValue
        {
            get { return this.ModifiedData.BookValue; }
            set { this.ModifiedData.BookValue = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_OPP_TOT" field.
        /// </summary>
        public Int32? Opportunities
        {
            get { return this.ModifiedData.OppTot; }
            set { this.ModifiedData.OppTot = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_QUOTES" field.
        /// </summary>
        public Int32? QuoteCount
        {
            get { return this.ModifiedData.Quotes; }
            set { this.ModifiedData.Quotes = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_QUO_VALUE" field.
        /// </summary>
        public Double? QuotesValue
        {
            get { return this.ModifiedData.QuoValue; }
            set { this.ModifiedData.QuoValue = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PM_TYPE" field.
        /// </summary>
        public LocalCodeModel Type
        {
            get
            {
                if (_type == null && !String.IsNullOrEmpty(this.TypeCode))
                    _type = this.Provider.Common.Code.FetchByTypeAndCode("PMTY", this.TypeCode);
                if (_type == null)
                    _type = this.Provider.Common.Code.Create("PMTY");
                return _type;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PM_TYPE" field.
        /// </summary>
        public String TypeCode
        {
            get { return this.ModifiedData.Type; }
            set
            {
                if (this.ModifiedData.Type != value)
                     _type = null;
                this.ModifiedData.Type = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "PM_PROLE_ID" field.
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
        ///     Gets or sets the unique code for the value of the "PM_PROLE_ID" field.
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
        ///     Gets the The value of the "PM_APP_PROLE_ID" field.
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
        ///     Gets or sets the unique code for the value of the "PM_APP_PROLE_ID" field.
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
        ///     Gets or sets the value of the "PM_ACTUAL_VAR_COST" field.
        /// </summary>
        public Double? ActualVarCost
        {
            get { return this.ModifiedData.ActualVarCost; }
            set { this.ModifiedData.ActualVarCost = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_ACTUAL_FIX_COST" field.
        /// </summary>
        public Double? ActualFixCost
        {
            get { return this.ModifiedData.ActualFixCost; }
            set { this.ModifiedData.ActualFixCost = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_BUDGET_VAR_COST" field.
        /// </summary>
        public Double? BudgetVarCost
        {
            get { return this.ModifiedData.BudgetVarCost; }
            set { this.ModifiedData.BudgetVarCost = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_BUDGET_FIX_COST" field.
        /// </summary>
        public Double? BudgetFixCost
        {
            get { return this.ModifiedData.BudgetFixCost; }
            set { this.ModifiedData.BudgetFixCost = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_TARGET_OPP" field.
        /// </summary>
        public Int32? TargetOpportunities
        {
            get { return this.ModifiedData.TargetOpp; }
            set { this.ModifiedData.TargetOpp = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_TARGET_REPLIES" field.
        /// </summary>
        public Int32? TargetResponses
        {
            get { return this.ModifiedData.TargetReplies; }
            set { this.ModifiedData.TargetReplies = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_TARGET_OPP_VAL" field.
        /// </summary>
        public Double? TargetOpportunitiesValue
        {
            get { return this.ModifiedData.TargetOppVal; }
            set { this.ModifiedData.TargetOppVal = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_TARGET_BOOK_VAL" field.
        /// </summary>
        public Double? TargetBookingsValue
        {
            get { return this.ModifiedData.TargetBookVal; }
            set { this.ModifiedData.TargetBookVal = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_TARGET_COMPLAINTS" field.
        /// </summary>
        public Int32? TargetComplaints
        {
            get { return this.ModifiedData.TargetComplaints; }
            set { this.ModifiedData.TargetComplaints = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_TARGET_INFO_REQ" field.
        /// </summary>
        public Int32? TargetInfoReq
        {
            get { return this.ModifiedData.TargetInfoReq; }
            set { this.ModifiedData.TargetInfoReq = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_TARGET_HELPCALLS" field.
        /// </summary>
        public Int32? TargetHelpcalls
        {
            get { return this.ModifiedData.TargetHelpcalls; }
            set { this.ModifiedData.TargetHelpcalls = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_TARGET_MEMBERSHIPS" field.
        /// </summary>
        public Int32? TargetMemberships
        {
            get { return this.ModifiedData.TargetMemberships; }
            set { this.ModifiedData.TargetMemberships = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_TARGET_MEMBERSHIPS_VAL" field.
        /// </summary>
        public Double? TargetMembershipsVal
        {
            get { return this.ModifiedData.TargetMembershipsVal; }
            set { this.ModifiedData.TargetMembershipsVal = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_TARGET_SUBSCRIPTIONS" field.
        /// </summary>
        public Int32? TargetSubscriptions
        {
            get { return this.ModifiedData.TargetSubscriptions; }
            set { this.ModifiedData.TargetSubscriptions = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_TARGET_SUBSCRIPTIONS_VAL" field.
        /// </summary>
        public Double? TargetSubscriptionsVal
        {
            get { return this.ModifiedData.TargetSubscriptionsVal; }
            set { this.ModifiedData.TargetSubscriptionsVal = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_ACTUAL_COMPLAINTS" field.
        /// </summary>
        public Int32? ActualComplaints
        {
            get { return this.ModifiedData.ActualComplaints; }
            set { this.ModifiedData.ActualComplaints = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_ACTUAL_INFO_REQ" field.
        /// </summary>
        public Int32? ActualInfoReq
        {
            get { return this.ModifiedData.ActualInfoReq; }
            set { this.ModifiedData.ActualInfoReq = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_ACTUAL_HELPCALLS" field.
        /// </summary>
        public Int32? ActualHelpcalls
        {
            get { return this.ModifiedData.ActualHelpcalls; }
            set { this.ModifiedData.ActualHelpcalls = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_ACTUAL_MEMBERSHIPS" field.
        /// </summary>
        public Int32? ActualMemberships
        {
            get { return this.ModifiedData.ActualMemberships; }
            set { this.ModifiedData.ActualMemberships = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_ACTUAL_MEMBERSHIPS_VAL" field.
        /// </summary>
        public Double? ActualMembershipsVal
        {
            get { return this.ModifiedData.ActualMembershipsVal; }
            set { this.ModifiedData.ActualMembershipsVal = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_ACTUAL_SUBSCRIPTIONS" field.
        /// </summary>
        public Int32? ActualSubscriptions
        {
            get { return this.ModifiedData.ActualSubscriptions; }
            set { this.ModifiedData.ActualSubscriptions = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_ACTUAL_SUBSCRIPTIONS_VAL" field.
        /// </summary>
        public Double? ActualSubscriptionsVal
        {
            get { return this.ModifiedData.ActualSubscriptionsVal; }
            set { this.ModifiedData.ActualSubscriptionsVal = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_WEB" field.
        /// </summary>
        public Byte WebEnabled
        {
            get { return this.ModifiedData.Web; }
            set { this.ModifiedData.Web = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_EMAIL_CAMPAIGN" field.
        /// </summary>
        public Byte EmailEnabled
        {
            get { return this.ModifiedData.EmailCampaign; }
            set { this.ModifiedData.EmailCampaign = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_QCODE" field.
        /// </summary>
        public String Qcode
        {
            get { return this.ModifiedData.Qcode; }
            set { this.ModifiedData.Qcode = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="PersonModel" /> instances that reference this <see cref="PromotionModel" />.
        /// </summary>
        public LocalCollection<LocalPersonModel, IPersonModel> PersonPromotion
        {
            get
            {
                if (_personPromotion == null)
                    _personPromotion = new LocalCollection<LocalPersonModel, IPersonModel>(this.Provider.Contact.Person.FetchAllByPersonPromoIdId(this.Id));
                
                return _personPromotion;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="BookingModel" /> instances that reference this <see cref="PromotionModel" />.
        /// </summary>
        public LocalCollection<LocalBookingModel, IBookingModel> Bookings
        {
            get
            {
                if (_bookings == null)
                    _bookings = new LocalCollection<LocalBookingModel, IBookingModel>(this.Provider.Learning.Booking.FetchAllBySourceCodeId(this.Id));
                
                return _bookings;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="OpportunityModel" /> instances that reference this <see cref="PromotionModel" />.
        /// </summary>
        public LocalCollection<LocalOpportunityModel, IOpportunityModel> OppPromId
        {
            get
            {
                if (_oppPromId == null)
                    _oppPromId = new LocalCollection<LocalOpportunityModel, IOpportunityModel>(this.Provider.Sales.Opportunity.FetchAllByPromIdId(this.Id));
                
                return _oppPromId;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="HelpdeskModel" /> instances that reference this <see cref="PromotionModel" />.
        /// </summary>
        public LocalCollection<LocalHelpdeskModel, IHelpdeskModel> HelpdeskPromotionId
        {
            get
            {
                if (_helpdeskPromotionId == null)
                    _helpdeskPromotionId = new LocalCollection<LocalHelpdeskModel, IHelpdeskModel>(this.Provider.Activities.Helpdesk.FetchAllByPmIdId(this.Id));
                
                return _helpdeskPromotionId;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ComplaintModel" /> instances that reference this <see cref="PromotionModel" />.
        /// </summary>
        public LocalCollection<LocalComplaintModel, IComplaintModel> ComplaintPromotion
        {
            get
            {
                if (_complaintPromotion == null)
                    _complaintPromotion = new LocalCollection<LocalComplaintModel, IComplaintModel>(this.Provider.Activities.Complaint.FetchAllByPromotionIDId(this.Id));
                
                return _complaintPromotion;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="MemberPeriodModel" /> instances that reference this <see cref="PromotionModel" />.
        /// </summary>
        public LocalCollection<LocalMemberPeriodModel, IMemberPeriodModel> MemberPeriods
        {
            get
            {
                if (_memberPeriods == null)
                    _memberPeriods = new LocalCollection<LocalMemberPeriodModel, IMemberPeriodModel>(this.Provider.Membership.MemberPeriod.FetchAllBySourceCodeId(this.Id));
                
                return _memberPeriods;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="SaqQueryModel" /> instances that reference this <see cref="PromotionModel" />.
        /// </summary>
        public LocalCollection<LocalSaqQueryModel, ISaqQueryModel> SaqQuerySourceCode
        {
            get
            {
                if (_saqQuerySourceCode == null)
                    _saqQuerySourceCode = new LocalCollection<LocalSaqQueryModel, ISaqQueryModel>(this.Provider.Marketing.SaqQuery.FetchAllBySourceCodeId(this.Id));
                
                return _saqQuerySourceCode;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalPromotionModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalPromotionModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalPromotionModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalPromotionModel(LocalProvider provider, PromotionRecord record) : base(provider, record)
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
            if (_channel != null)
            {
                _channel.Save();
                this.ModifiedData.Channel = _channel.Value1;
            }
            if (_mediaName != null)
            {
                _mediaName.Save();
                this.ModifiedData.MediaName = _mediaName.Value1;
            }
            if (_type != null)
            {
                _type.Save();
                this.ModifiedData.Type = _type.Value1;
            }
            if (_promotionMaster != null)
            {
                _promotionMaster.Save();
                this.ModifiedData.CmpId = _promotionMaster.Id == null && this.ModifiedData.CmpId != null ? "" : _promotionMaster.Id;
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
            if (_personPromotion != null)
                _personPromotion.Execute(obj => obj.PersonPromoIdId = this.Id).Execute(obj => obj.Save());
            if (_bookings != null)
                _bookings.Execute(obj => obj.SourceCodeId = this.Id).Execute(obj => obj.Save());
            if (_oppPromId != null)
                _oppPromId.Execute(obj => obj.PromIdId = this.Id).Execute(obj => obj.Save());
            if (_helpdeskPromotionId != null)
                _helpdeskPromotionId.Execute(obj => obj.PmIdId = this.Id).Execute(obj => obj.Save());
            if (_complaintPromotion != null)
                _complaintPromotion.Execute(obj => obj.PromotionIDId = this.Id).Execute(obj => obj.Save());
            if (_memberPeriods != null)
                _memberPeriods.Execute(obj => obj.SourceCodeId = this.Id).Execute(obj => obj.Save());
            if (_saqQuerySourceCode != null)
                _saqQuerySourceCode.Execute(obj => obj.SourceCodeId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the The value of the "PM_CMP_ID" field.
        /// </summary>
        Consensus.Marketing.IPromotionMasterModel IPromotionModel.PromotionMaster
        {
            get { return this.PromotionMaster; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PM_CMP_ID" field.
        /// </summary>
        System.String IPromotionModel.PromotionMasterId
        {
            get { return this.PromotionMasterId; }
            set { this.PromotionMasterId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_NAME" field.
        /// </summary>
        System.String IPromotionModel.Name
        {
            get { return this.Name; }
            set { this.Name = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_START_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IPromotionModel.StartDate
        {
            get { return this.StartDate; }
            set { this.StartDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PM_CHANNEL" field.
        /// </summary>
        Consensus.Common.ICodeModel IPromotionModel.Channel
        {
            get { return this.Channel; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PM_CHANNEL" field.
        /// </summary>
        System.String IPromotionModel.ChannelCode
        {
            get { return this.ChannelCode; }
            set { this.ChannelCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_DM_NUMBER" field.
        /// </summary>
        System.Nullable<System.Double> IPromotionModel.MailingActivities
        {
            get { return this.MailingActivities; }
            set { this.MailingActivities = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_REPLIES" field.
        /// </summary>
        System.Nullable<System.Double> IPromotionModel.Responses
        {
            get { return this.Responses; }
            set { this.Responses = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_ORDERS" field.
        /// </summary>
        System.Nullable<System.Double> IPromotionModel.SoldOpportunities
        {
            get { return this.SoldOpportunities; }
            set { this.SoldOpportunities = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_ORDER_VAL" field.
        /// </summary>
        System.Nullable<System.Double> IPromotionModel.SoldOpportunitiesValue
        {
            get { return this.SoldOpportunitiesValue; }
            set { this.SoldOpportunitiesValue = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_BUDGET_COST" field.
        /// </summary>
        System.Nullable<System.Double> IPromotionModel.CalculatedBudgetCost
        {
            get { return this.CalculatedBudgetCost; }
            set { this.CalculatedBudgetCost = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_ACTUAL_COST" field.
        /// </summary>
        System.Nullable<System.Double> IPromotionModel.CalculatedeActualCost
        {
            get { return this.CalculatedeActualCost; }
            set { this.CalculatedeActualCost = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_UPDATED" field.
        /// </summary>
        System.Nullable<System.DateTime> IPromotionModel.Updated
        {
            get { return this.Updated; }
            set { this.Updated = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_CURRENT" field.
        /// </summary>
        System.Nullable<System.Byte> IPromotionModel.Current
        {
            get { return this.Current; }
            set { this.Current = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PM_MEDIA_NAME" field.
        /// </summary>
        Consensus.Common.ICodeModel IPromotionModel.MediaName
        {
            get { return this.MediaName; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PM_MEDIA_NAME" field.
        /// </summary>
        System.String IPromotionModel.MediaNameCode
        {
            get { return this.MediaNameCode; }
            set { this.MediaNameCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_BOOKING" field.
        /// </summary>
        System.Nullable<System.Int32> IPromotionModel.BookingCount
        {
            get { return this.BookingCount; }
            set { this.BookingCount = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_BOOK_VALUE" field.
        /// </summary>
        System.Nullable<System.Double> IPromotionModel.BookingsValue
        {
            get { return this.BookingsValue; }
            set { this.BookingsValue = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_OPP_TOT" field.
        /// </summary>
        System.Nullable<System.Int32> IPromotionModel.Opportunities
        {
            get { return this.Opportunities; }
            set { this.Opportunities = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_QUOTES" field.
        /// </summary>
        System.Nullable<System.Int32> IPromotionModel.QuoteCount
        {
            get { return this.QuoteCount; }
            set { this.QuoteCount = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_QUO_VALUE" field.
        /// </summary>
        System.Nullable<System.Double> IPromotionModel.QuotesValue
        {
            get { return this.QuotesValue; }
            set { this.QuotesValue = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PM_TYPE" field.
        /// </summary>
        Consensus.Common.ICodeModel IPromotionModel.Type
        {
            get { return this.Type; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PM_TYPE" field.
        /// </summary>
        System.String IPromotionModel.TypeCode
        {
            get { return this.TypeCode; }
            set { this.TypeCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PM_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel IPromotionModel.Manager
        {
            get { return this.Manager; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PM_PROLE_ID" field.
        /// </summary>
        System.String IPromotionModel.ManagerId
        {
            get { return this.ManagerId; }
            set { this.ManagerId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PM_APP_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel IPromotionModel.Approver
        {
            get { return this.Approver; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PM_APP_PROLE_ID" field.
        /// </summary>
        System.String IPromotionModel.ApproverId
        {
            get { return this.ApproverId; }
            set { this.ApproverId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_ACTUAL_VAR_COST" field.
        /// </summary>
        System.Nullable<System.Double> IPromotionModel.ActualVarCost
        {
            get { return this.ActualVarCost; }
            set { this.ActualVarCost = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_ACTUAL_FIX_COST" field.
        /// </summary>
        System.Nullable<System.Double> IPromotionModel.ActualFixCost
        {
            get { return this.ActualFixCost; }
            set { this.ActualFixCost = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_BUDGET_VAR_COST" field.
        /// </summary>
        System.Nullable<System.Double> IPromotionModel.BudgetVarCost
        {
            get { return this.BudgetVarCost; }
            set { this.BudgetVarCost = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_BUDGET_FIX_COST" field.
        /// </summary>
        System.Nullable<System.Double> IPromotionModel.BudgetFixCost
        {
            get { return this.BudgetFixCost; }
            set { this.BudgetFixCost = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_TARGET_OPP" field.
        /// </summary>
        System.Nullable<System.Int32> IPromotionModel.TargetOpportunities
        {
            get { return this.TargetOpportunities; }
            set { this.TargetOpportunities = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_TARGET_REPLIES" field.
        /// </summary>
        System.Nullable<System.Int32> IPromotionModel.TargetResponses
        {
            get { return this.TargetResponses; }
            set { this.TargetResponses = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_TARGET_OPP_VAL" field.
        /// </summary>
        System.Nullable<System.Double> IPromotionModel.TargetOpportunitiesValue
        {
            get { return this.TargetOpportunitiesValue; }
            set { this.TargetOpportunitiesValue = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_TARGET_BOOK_VAL" field.
        /// </summary>
        System.Nullable<System.Double> IPromotionModel.TargetBookingsValue
        {
            get { return this.TargetBookingsValue; }
            set { this.TargetBookingsValue = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_TARGET_COMPLAINTS" field.
        /// </summary>
        System.Nullable<System.Int32> IPromotionModel.TargetComplaints
        {
            get { return this.TargetComplaints; }
            set { this.TargetComplaints = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_TARGET_INFO_REQ" field.
        /// </summary>
        System.Nullable<System.Int32> IPromotionModel.TargetInfoReq
        {
            get { return this.TargetInfoReq; }
            set { this.TargetInfoReq = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_TARGET_HELPCALLS" field.
        /// </summary>
        System.Nullable<System.Int32> IPromotionModel.TargetHelpcalls
        {
            get { return this.TargetHelpcalls; }
            set { this.TargetHelpcalls = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_TARGET_MEMBERSHIPS" field.
        /// </summary>
        System.Nullable<System.Int32> IPromotionModel.TargetMemberships
        {
            get { return this.TargetMemberships; }
            set { this.TargetMemberships = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_TARGET_MEMBERSHIPS_VAL" field.
        /// </summary>
        System.Nullable<System.Double> IPromotionModel.TargetMembershipsVal
        {
            get { return this.TargetMembershipsVal; }
            set { this.TargetMembershipsVal = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_TARGET_SUBSCRIPTIONS" field.
        /// </summary>
        System.Nullable<System.Int32> IPromotionModel.TargetSubscriptions
        {
            get { return this.TargetSubscriptions; }
            set { this.TargetSubscriptions = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_TARGET_SUBSCRIPTIONS_VAL" field.
        /// </summary>
        System.Nullable<System.Double> IPromotionModel.TargetSubscriptionsVal
        {
            get { return this.TargetSubscriptionsVal; }
            set { this.TargetSubscriptionsVal = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_ACTUAL_COMPLAINTS" field.
        /// </summary>
        System.Nullable<System.Int32> IPromotionModel.ActualComplaints
        {
            get { return this.ActualComplaints; }
            set { this.ActualComplaints = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_ACTUAL_INFO_REQ" field.
        /// </summary>
        System.Nullable<System.Int32> IPromotionModel.ActualInfoReq
        {
            get { return this.ActualInfoReq; }
            set { this.ActualInfoReq = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_ACTUAL_HELPCALLS" field.
        /// </summary>
        System.Nullable<System.Int32> IPromotionModel.ActualHelpcalls
        {
            get { return this.ActualHelpcalls; }
            set { this.ActualHelpcalls = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_ACTUAL_MEMBERSHIPS" field.
        /// </summary>
        System.Nullable<System.Int32> IPromotionModel.ActualMemberships
        {
            get { return this.ActualMemberships; }
            set { this.ActualMemberships = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_ACTUAL_MEMBERSHIPS_VAL" field.
        /// </summary>
        System.Nullable<System.Double> IPromotionModel.ActualMembershipsVal
        {
            get { return this.ActualMembershipsVal; }
            set { this.ActualMembershipsVal = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_ACTUAL_SUBSCRIPTIONS" field.
        /// </summary>
        System.Nullable<System.Int32> IPromotionModel.ActualSubscriptions
        {
            get { return this.ActualSubscriptions; }
            set { this.ActualSubscriptions = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_ACTUAL_SUBSCRIPTIONS_VAL" field.
        /// </summary>
        System.Nullable<System.Double> IPromotionModel.ActualSubscriptionsVal
        {
            get { return this.ActualSubscriptionsVal; }
            set { this.ActualSubscriptionsVal = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_WEB" field.
        /// </summary>
        System.Byte IPromotionModel.WebEnabled
        {
            get { return this.WebEnabled; }
            set { this.WebEnabled = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_EMAIL_CAMPAIGN" field.
        /// </summary>
        System.Byte IPromotionModel.EmailEnabled
        {
            get { return this.EmailEnabled; }
            set { this.EmailEnabled = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_QCODE" field.
        /// </summary>
        System.String IPromotionModel.Qcode
        {
            get { return this.Qcode; }
            set { this.Qcode = (System.String)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PersonModel" /> instances that reference this <see cref="!:PromotionModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Contact.IPersonModel> IPromotionModel.PersonPromotion
        {
            get { return this.PersonPromotion; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BookingModel" /> instances that reference this <see cref="!:PromotionModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IBookingModel> IPromotionModel.Bookings
        {
            get { return this.Bookings; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:OpportunityModel" /> instances that reference this <see cref="!:PromotionModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Sales.IOpportunityModel> IPromotionModel.OppPromId
        {
            get { return this.OppPromId; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:HelpdeskModel" /> instances that reference this <see cref="!:PromotionModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Activities.IHelpdeskModel> IPromotionModel.HelpdeskPromotionId
        {
            get { return this.HelpdeskPromotionId; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ComplaintModel" /> instances that reference this <see cref="!:PromotionModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Activities.IComplaintModel> IPromotionModel.ComplaintPromotion
        {
            get { return this.ComplaintPromotion; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MemberPeriodModel" /> instances that reference this <see cref="!:PromotionModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Membership.IMemberPeriodModel> IPromotionModel.MemberPeriods
        {
            get { return this.MemberPeriods; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SaqQueryModel" /> instances that reference this <see cref="!:PromotionModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Marketing.ISaqQueryModel> IPromotionModel.SaqQuerySourceCode
        {
            get { return this.SaqQuerySourceCode; }
        }

        #endregion
    }
}
