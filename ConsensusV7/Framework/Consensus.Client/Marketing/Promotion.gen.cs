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
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class Promotion : Proxy<IPromotionModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="PromotionMaster" /> member.
        /// </summary>
        private Consensus.Marketing.PromotionMaster _promotionMaster;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Channel" /> member.
        /// </summary>
        private Consensus.Common.Code _channel;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="MediaName" /> member.
        /// </summary>
        private Consensus.Common.Code _mediaName;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Type" /> member.
        /// </summary>
        private Consensus.Common.Code _type;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Manager" /> member.
        /// </summary>
        private Consensus.Contact.Role _manager;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Approver" /> member.
        /// </summary>
        private Consensus.Contact.Role _approver;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="PersonPromotion" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Contact.Person, Consensus.Contact.IPersonModel> _personPromotion;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Bookings" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Booking, Consensus.Learning.IBookingModel> _bookings;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="OppPromId" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Sales.Opportunity, Consensus.Sales.IOpportunityModel> _oppPromId;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="HelpdeskPromotionId" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Activities.Helpdesk, Consensus.Activities.IHelpdeskModel> _helpdeskPromotionId;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="ComplaintPromotion" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Activities.Complaint, Consensus.Activities.IComplaintModel> _complaintPromotion;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="MemberPeriods" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Membership.MemberPeriod, Consensus.Membership.IMemberPeriodModel> _memberPeriods;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="SaqQuerySourceCode" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Marketing.SaqQuery, Consensus.Marketing.ISaqQueryModel> _saqQuerySourceCode;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the The value of the "PM_CMP_ID" field.
        /// </summary>
        public Consensus.Marketing.PromotionMaster PromotionMaster
        {
            get
            {
                if (_promotionMaster == null && this.Model.PromotionMaster != null)
                    _promotionMaster = new Consensus.Marketing.PromotionMaster(this.Model.PromotionMaster);
                if (_promotionMaster == null)
                    _promotionMaster = Consensus.Marketing.PromotionMaster.Create();
                return _promotionMaster;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PM_CMP_ID" field.
        /// </summary>
        public System.String PromotionMasterId
        {
            get { return this.Model.PromotionMasterId; }
            set { this.Model.PromotionMasterId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_NAME" field.
        /// </summary>
        public System.String Name
        {
            get { return this.Model.Name; }
            set { this.Model.Name = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_START_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> StartDate
        {
            get { return this.Model.StartDate; }
            set { this.Model.StartDate = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PM_CHANNEL" field.
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
        ///     Gets or sets the unique code for the value of the "PM_CHANNEL" field.
        /// </summary>
        public System.String ChannelCode
        {
            get { return this.Model.ChannelCode; }
            set { this.Model.ChannelCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_DM_NUMBER" field.
        /// </summary>
        public System.Nullable<System.Double> MailingActivities
        {
            get { return this.Model.MailingActivities; }
            set { this.Model.MailingActivities = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_REPLIES" field.
        /// </summary>
        public System.Nullable<System.Double> Responses
        {
            get { return this.Model.Responses; }
            set { this.Model.Responses = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_ORDERS" field.
        /// </summary>
        public System.Nullable<System.Double> SoldOpportunities
        {
            get { return this.Model.SoldOpportunities; }
            set { this.Model.SoldOpportunities = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_ORDER_VAL" field.
        /// </summary>
        public System.Nullable<System.Double> SoldOpportunitiesValue
        {
            get { return this.Model.SoldOpportunitiesValue; }
            set { this.Model.SoldOpportunitiesValue = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_BUDGET_COST" field.
        /// </summary>
        public System.Nullable<System.Double> CalculatedBudgetCost
        {
            get { return this.Model.CalculatedBudgetCost; }
            set { this.Model.CalculatedBudgetCost = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_ACTUAL_COST" field.
        /// </summary>
        public System.Nullable<System.Double> CalculatedeActualCost
        {
            get { return this.Model.CalculatedeActualCost; }
            set { this.Model.CalculatedeActualCost = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_UPDATED" field.
        /// </summary>
        public System.Nullable<System.DateTime> Updated
        {
            get { return this.Model.Updated; }
            set { this.Model.Updated = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_CURRENT" field.
        /// </summary>
        public System.Nullable<System.Byte> Current
        {
            get { return this.Model.Current; }
            set { this.Model.Current = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PM_MEDIA_NAME" field.
        /// </summary>
        public Consensus.Common.Code MediaName
        {
            get
            {
                if (_mediaName == null && this.Model.MediaName != null)
                    _mediaName = new Consensus.Common.Code(this.Model.MediaName);
                if (_mediaName == null)
                    _mediaName = Consensus.Common.Code.Create();
                return _mediaName;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PM_MEDIA_NAME" field.
        /// </summary>
        public System.String MediaNameCode
        {
            get { return this.Model.MediaNameCode; }
            set { this.Model.MediaNameCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_BOOKING" field.
        /// </summary>
        public System.Nullable<System.Int32> BookingCount
        {
            get { return this.Model.BookingCount; }
            set { this.Model.BookingCount = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_BOOK_VALUE" field.
        /// </summary>
        public System.Nullable<System.Double> BookingsValue
        {
            get { return this.Model.BookingsValue; }
            set { this.Model.BookingsValue = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_OPP_TOT" field.
        /// </summary>
        public System.Nullable<System.Int32> Opportunities
        {
            get { return this.Model.Opportunities; }
            set { this.Model.Opportunities = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_QUOTES" field.
        /// </summary>
        public System.Nullable<System.Int32> QuoteCount
        {
            get { return this.Model.QuoteCount; }
            set { this.Model.QuoteCount = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_QUO_VALUE" field.
        /// </summary>
        public System.Nullable<System.Double> QuotesValue
        {
            get { return this.Model.QuotesValue; }
            set { this.Model.QuotesValue = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PM_TYPE" field.
        /// </summary>
        public Consensus.Common.Code Type
        {
            get
            {
                if (_type == null && this.Model.Type != null)
                    _type = new Consensus.Common.Code(this.Model.Type);
                if (_type == null)
                    _type = Consensus.Common.Code.Create();
                return _type;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PM_TYPE" field.
        /// </summary>
        public System.String TypeCode
        {
            get { return this.Model.TypeCode; }
            set { this.Model.TypeCode = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PM_PROLE_ID" field.
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
        ///     Gets or sets the unique code for the value of the "PM_PROLE_ID" field.
        /// </summary>
        public System.String ManagerId
        {
            get { return this.Model.ManagerId; }
            set { this.Model.ManagerId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PM_APP_PROLE_ID" field.
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
        ///     Gets or sets the unique code for the value of the "PM_APP_PROLE_ID" field.
        /// </summary>
        public System.String ApproverId
        {
            get { return this.Model.ApproverId; }
            set { this.Model.ApproverId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_ACTUAL_VAR_COST" field.
        /// </summary>
        public System.Nullable<System.Double> ActualVarCost
        {
            get { return this.Model.ActualVarCost; }
            set { this.Model.ActualVarCost = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_ACTUAL_FIX_COST" field.
        /// </summary>
        public System.Nullable<System.Double> ActualFixCost
        {
            get { return this.Model.ActualFixCost; }
            set { this.Model.ActualFixCost = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_BUDGET_VAR_COST" field.
        /// </summary>
        public System.Nullable<System.Double> BudgetVarCost
        {
            get { return this.Model.BudgetVarCost; }
            set { this.Model.BudgetVarCost = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_BUDGET_FIX_COST" field.
        /// </summary>
        public System.Nullable<System.Double> BudgetFixCost
        {
            get { return this.Model.BudgetFixCost; }
            set { this.Model.BudgetFixCost = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_TARGET_OPP" field.
        /// </summary>
        public System.Nullable<System.Int32> TargetOpportunities
        {
            get { return this.Model.TargetOpportunities; }
            set { this.Model.TargetOpportunities = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_TARGET_REPLIES" field.
        /// </summary>
        public System.Nullable<System.Int32> TargetResponses
        {
            get { return this.Model.TargetResponses; }
            set { this.Model.TargetResponses = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_TARGET_OPP_VAL" field.
        /// </summary>
        public System.Nullable<System.Double> TargetOpportunitiesValue
        {
            get { return this.Model.TargetOpportunitiesValue; }
            set { this.Model.TargetOpportunitiesValue = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_TARGET_BOOK_VAL" field.
        /// </summary>
        public System.Nullable<System.Double> TargetBookingsValue
        {
            get { return this.Model.TargetBookingsValue; }
            set { this.Model.TargetBookingsValue = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_TARGET_COMPLAINTS" field.
        /// </summary>
        public System.Nullable<System.Int32> TargetComplaints
        {
            get { return this.Model.TargetComplaints; }
            set { this.Model.TargetComplaints = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_TARGET_INFO_REQ" field.
        /// </summary>
        public System.Nullable<System.Int32> TargetInfoReq
        {
            get { return this.Model.TargetInfoReq; }
            set { this.Model.TargetInfoReq = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_TARGET_HELPCALLS" field.
        /// </summary>
        public System.Nullable<System.Int32> TargetHelpcalls
        {
            get { return this.Model.TargetHelpcalls; }
            set { this.Model.TargetHelpcalls = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_TARGET_MEMBERSHIPS" field.
        /// </summary>
        public System.Nullable<System.Int32> TargetMemberships
        {
            get { return this.Model.TargetMemberships; }
            set { this.Model.TargetMemberships = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_TARGET_MEMBERSHIPS_VAL" field.
        /// </summary>
        public System.Nullable<System.Double> TargetMembershipsVal
        {
            get { return this.Model.TargetMembershipsVal; }
            set { this.Model.TargetMembershipsVal = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_TARGET_SUBSCRIPTIONS" field.
        /// </summary>
        public System.Nullable<System.Int32> TargetSubscriptions
        {
            get { return this.Model.TargetSubscriptions; }
            set { this.Model.TargetSubscriptions = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_TARGET_SUBSCRIPTIONS_VAL" field.
        /// </summary>
        public System.Nullable<System.Double> TargetSubscriptionsVal
        {
            get { return this.Model.TargetSubscriptionsVal; }
            set { this.Model.TargetSubscriptionsVal = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_ACTUAL_COMPLAINTS" field.
        /// </summary>
        public System.Nullable<System.Int32> ActualComplaints
        {
            get { return this.Model.ActualComplaints; }
            set { this.Model.ActualComplaints = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_ACTUAL_INFO_REQ" field.
        /// </summary>
        public System.Nullable<System.Int32> ActualInfoReq
        {
            get { return this.Model.ActualInfoReq; }
            set { this.Model.ActualInfoReq = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_ACTUAL_HELPCALLS" field.
        /// </summary>
        public System.Nullable<System.Int32> ActualHelpcalls
        {
            get { return this.Model.ActualHelpcalls; }
            set { this.Model.ActualHelpcalls = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_ACTUAL_MEMBERSHIPS" field.
        /// </summary>
        public System.Nullable<System.Int32> ActualMemberships
        {
            get { return this.Model.ActualMemberships; }
            set { this.Model.ActualMemberships = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_ACTUAL_MEMBERSHIPS_VAL" field.
        /// </summary>
        public System.Nullable<System.Double> ActualMembershipsVal
        {
            get { return this.Model.ActualMembershipsVal; }
            set { this.Model.ActualMembershipsVal = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_ACTUAL_SUBSCRIPTIONS" field.
        /// </summary>
        public System.Nullable<System.Int32> ActualSubscriptions
        {
            get { return this.Model.ActualSubscriptions; }
            set { this.Model.ActualSubscriptions = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_ACTUAL_SUBSCRIPTIONS_VAL" field.
        /// </summary>
        public System.Nullable<System.Double> ActualSubscriptionsVal
        {
            get { return this.Model.ActualSubscriptionsVal; }
            set { this.Model.ActualSubscriptionsVal = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_WEB" field.
        /// </summary>
        public System.Byte WebEnabled
        {
            get { return this.Model.WebEnabled; }
            set { this.Model.WebEnabled = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_EMAIL_CAMPAIGN" field.
        /// </summary>
        public System.Byte EmailEnabled
        {
            get { return this.Model.EmailEnabled; }
            set { this.Model.EmailEnabled = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_QCODE" field.
        /// </summary>
        public System.String Qcode
        {
            get { return this.Model.Qcode; }
            set { this.Model.Qcode = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PersonModel" /> instances that reference this <see cref="!:PromotionModel" />.
        /// </summary>
        public Collection<Consensus.Contact.Person> PersonPromotion
        {
            get
            {
                if (_personPromotion == null)
                    _personPromotion = new ProxyCollection<Consensus.Contact.Person, Consensus.Contact.IPersonModel>(this.Model.PersonPromotion, model => new Consensus.Contact.Person(model));
                return _personPromotion;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BookingModel" /> instances that reference this <see cref="!:PromotionModel" />.
        /// </summary>
        public Collection<Consensus.Learning.Booking> Bookings
        {
            get
            {
                if (_bookings == null)
                    _bookings = new ProxyCollection<Consensus.Learning.Booking, Consensus.Learning.IBookingModel>(this.Model.Bookings, model => new Consensus.Learning.Booking(model));
                return _bookings;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:OpportunityModel" /> instances that reference this <see cref="!:PromotionModel" />.
        /// </summary>
        public Collection<Consensus.Sales.Opportunity> OppPromId
        {
            get
            {
                if (_oppPromId == null)
                    _oppPromId = new ProxyCollection<Consensus.Sales.Opportunity, Consensus.Sales.IOpportunityModel>(this.Model.OppPromId, model => new Consensus.Sales.Opportunity(model));
                return _oppPromId;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:HelpdeskModel" /> instances that reference this <see cref="!:PromotionModel" />.
        /// </summary>
        public Collection<Consensus.Activities.Helpdesk> HelpdeskPromotionId
        {
            get
            {
                if (_helpdeskPromotionId == null)
                    _helpdeskPromotionId = new ProxyCollection<Consensus.Activities.Helpdesk, Consensus.Activities.IHelpdeskModel>(this.Model.HelpdeskPromotionId, model => new Consensus.Activities.Helpdesk(model));
                return _helpdeskPromotionId;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ComplaintModel" /> instances that reference this <see cref="!:PromotionModel" />.
        /// </summary>
        public Collection<Consensus.Activities.Complaint> ComplaintPromotion
        {
            get
            {
                if (_complaintPromotion == null)
                    _complaintPromotion = new ProxyCollection<Consensus.Activities.Complaint, Consensus.Activities.IComplaintModel>(this.Model.ComplaintPromotion, model => new Consensus.Activities.Complaint(model));
                return _complaintPromotion;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MemberPeriodModel" /> instances that reference this <see cref="!:PromotionModel" />.
        /// </summary>
        public Collection<Consensus.Membership.MemberPeriod> MemberPeriods
        {
            get
            {
                if (_memberPeriods == null)
                    _memberPeriods = new ProxyCollection<Consensus.Membership.MemberPeriod, Consensus.Membership.IMemberPeriodModel>(this.Model.MemberPeriods, model => new Consensus.Membership.MemberPeriod(model));
                return _memberPeriods;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SaqQueryModel" /> instances that reference this <see cref="!:PromotionModel" />.
        /// </summary>
        public Collection<Consensus.Marketing.SaqQuery> SaqQuerySourceCode
        {
            get
            {
                if (_saqQuerySourceCode == null)
                    _saqQuerySourceCode = new ProxyCollection<Consensus.Marketing.SaqQuery, Consensus.Marketing.ISaqQueryModel>(this.Model.SaqQuerySourceCode, model => new Consensus.Marketing.SaqQuery(model));
                return _saqQuerySourceCode;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal Promotion(IPromotionModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:PromotionModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PromotionModel" /> instance.
        /// </returns>
        public static Consensus.Marketing.Promotion Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Promotion.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:PromotionModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PromotionModel" /> instance.
        /// </returns>
        public static Consensus.Marketing.Promotion Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Marketing.IPromotionModel model = provider.Marketing.Promotion.Create();
            return model == null ? null : new Consensus.Marketing.Promotion(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PromotionModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PromotionModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.Promotion> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Promotion.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PromotionModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PromotionModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.Promotion> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Marketing.IPromotionModel> collection = provider.Marketing.Promotion.FetchAll();
            return collection.Select(model => new Consensus.Marketing.Promotion(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:PromotionModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PromotionModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PromotionModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Marketing.Promotion FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Promotion.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:PromotionModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PromotionModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PromotionModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Marketing.Promotion FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Marketing.IPromotionModel model = provider.Marketing.Promotion.FetchById(id);
            return model == null ? null : new Consensus.Marketing.Promotion(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Promotion.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Marketing.Promotion.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PromotionModel" /> instances.
        /// </summary>
        /// <param name="promotionMasterId">
        ///     The value which identifies the <see cref="!:PromotionModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PromotionModel" /> instances that match the specified <paramref name="promotionMasterId" />.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.Promotion> FetchAllByPromotionMasterId(System.String promotionMasterId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Promotion.FetchAllByPromotionMasterId(site,promotionMasterId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PromotionModel" /> instances.
        /// </summary>
        /// <param name="promotionMasterId">
        ///     The value which identifies the <see cref="!:PromotionModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PromotionModel" /> instances that match the specified <paramref name="promotionMasterId" />.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.Promotion> FetchAllByPromotionMasterId(ConsensusSite site, System.String promotionMasterId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Marketing.IPromotionModel> collection = provider.Marketing.Promotion.FetchAllByPromotionMasterId(promotionMasterId);
            return collection.Select(model => new Consensus.Marketing.Promotion(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PromotionModel" /> instances.
        /// </summary>
        /// <param name="managerId">
        ///     The value which identifies the <see cref="!:PromotionModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PromotionModel" /> instances that match the specified <paramref name="managerId" />.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.Promotion> FetchAllByManagerId(System.String managerId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Promotion.FetchAllByManagerId(site,managerId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PromotionModel" /> instances.
        /// </summary>
        /// <param name="managerId">
        ///     The value which identifies the <see cref="!:PromotionModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PromotionModel" /> instances that match the specified <paramref name="managerId" />.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.Promotion> FetchAllByManagerId(ConsensusSite site, System.String managerId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Marketing.IPromotionModel> collection = provider.Marketing.Promotion.FetchAllByManagerId(managerId);
            return collection.Select(model => new Consensus.Marketing.Promotion(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PromotionModel" /> instances.
        /// </summary>
        /// <param name="approverId">
        ///     The value which identifies the <see cref="!:PromotionModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PromotionModel" /> instances that match the specified <paramref name="approverId" />.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.Promotion> FetchAllByApproverId(System.String approverId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Promotion.FetchAllByApproverId(site,approverId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PromotionModel" /> instances.
        /// </summary>
        /// <param name="approverId">
        ///     The value which identifies the <see cref="!:PromotionModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PromotionModel" /> instances that match the specified <paramref name="approverId" />.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.Promotion> FetchAllByApproverId(ConsensusSite site, System.String approverId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Marketing.IPromotionModel> collection = provider.Marketing.Promotion.FetchAllByApproverId(approverId);
            return collection.Select(model => new Consensus.Marketing.Promotion(model));
        }

        #endregion
    }
}
