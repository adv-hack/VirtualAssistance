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
    ///     Encapsulates the <see cref="PromotionRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IPromotionModel : IModel<String>
    {
        /// <summary>
        ///     Gets the The value of the "PM_CMP_ID" field.
        /// </summary>
        Consensus.Marketing.IPromotionMasterModel PromotionMaster
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PM_CMP_ID" field.
        /// </summary>
        System.String PromotionMasterId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_NAME" field.
        /// </summary>
        System.String Name
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_START_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> StartDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PM_CHANNEL" field.
        /// </summary>
        Consensus.Common.ICodeModel Channel
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PM_CHANNEL" field.
        /// </summary>
        System.String ChannelCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_DM_NUMBER" field.
        /// </summary>
        System.Nullable<System.Double> MailingActivities
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_REPLIES" field.
        /// </summary>
        System.Nullable<System.Double> Responses
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_ORDERS" field.
        /// </summary>
        System.Nullable<System.Double> SoldOpportunities
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_ORDER_VAL" field.
        /// </summary>
        System.Nullable<System.Double> SoldOpportunitiesValue
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_BUDGET_COST" field.
        /// </summary>
        System.Nullable<System.Double> CalculatedBudgetCost
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_ACTUAL_COST" field.
        /// </summary>
        System.Nullable<System.Double> CalculatedeActualCost
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_UPDATED" field.
        /// </summary>
        System.Nullable<System.DateTime> Updated
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_CURRENT" field.
        /// </summary>
        System.Nullable<System.Byte> Current
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PM_MEDIA_NAME" field.
        /// </summary>
        Consensus.Common.ICodeModel MediaName
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PM_MEDIA_NAME" field.
        /// </summary>
        System.String MediaNameCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_BOOKING" field.
        /// </summary>
        System.Nullable<System.Int32> BookingCount
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_BOOK_VALUE" field.
        /// </summary>
        System.Nullable<System.Double> BookingsValue
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_OPP_TOT" field.
        /// </summary>
        System.Nullable<System.Int32> Opportunities
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_QUOTES" field.
        /// </summary>
        System.Nullable<System.Int32> QuoteCount
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_QUO_VALUE" field.
        /// </summary>
        System.Nullable<System.Double> QuotesValue
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PM_TYPE" field.
        /// </summary>
        Consensus.Common.ICodeModel Type
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PM_TYPE" field.
        /// </summary>
        System.String TypeCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PM_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel Manager
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PM_PROLE_ID" field.
        /// </summary>
        System.String ManagerId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PM_APP_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel Approver
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PM_APP_PROLE_ID" field.
        /// </summary>
        System.String ApproverId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_ACTUAL_VAR_COST" field.
        /// </summary>
        System.Nullable<System.Double> ActualVarCost
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_ACTUAL_FIX_COST" field.
        /// </summary>
        System.Nullable<System.Double> ActualFixCost
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_BUDGET_VAR_COST" field.
        /// </summary>
        System.Nullable<System.Double> BudgetVarCost
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_BUDGET_FIX_COST" field.
        /// </summary>
        System.Nullable<System.Double> BudgetFixCost
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_TARGET_OPP" field.
        /// </summary>
        System.Nullable<System.Int32> TargetOpportunities
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_TARGET_REPLIES" field.
        /// </summary>
        System.Nullable<System.Int32> TargetResponses
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_TARGET_OPP_VAL" field.
        /// </summary>
        System.Nullable<System.Double> TargetOpportunitiesValue
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_TARGET_BOOK_VAL" field.
        /// </summary>
        System.Nullable<System.Double> TargetBookingsValue
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_TARGET_COMPLAINTS" field.
        /// </summary>
        System.Nullable<System.Int32> TargetComplaints
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_TARGET_INFO_REQ" field.
        /// </summary>
        System.Nullable<System.Int32> TargetInfoReq
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_TARGET_HELPCALLS" field.
        /// </summary>
        System.Nullable<System.Int32> TargetHelpcalls
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_TARGET_MEMBERSHIPS" field.
        /// </summary>
        System.Nullable<System.Int32> TargetMemberships
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_TARGET_MEMBERSHIPS_VAL" field.
        /// </summary>
        System.Nullable<System.Double> TargetMembershipsVal
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_TARGET_SUBSCRIPTIONS" field.
        /// </summary>
        System.Nullable<System.Int32> TargetSubscriptions
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_TARGET_SUBSCRIPTIONS_VAL" field.
        /// </summary>
        System.Nullable<System.Double> TargetSubscriptionsVal
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_ACTUAL_COMPLAINTS" field.
        /// </summary>
        System.Nullable<System.Int32> ActualComplaints
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_ACTUAL_INFO_REQ" field.
        /// </summary>
        System.Nullable<System.Int32> ActualInfoReq
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_ACTUAL_HELPCALLS" field.
        /// </summary>
        System.Nullable<System.Int32> ActualHelpcalls
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_ACTUAL_MEMBERSHIPS" field.
        /// </summary>
        System.Nullable<System.Int32> ActualMemberships
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_ACTUAL_MEMBERSHIPS_VAL" field.
        /// </summary>
        System.Nullable<System.Double> ActualMembershipsVal
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_ACTUAL_SUBSCRIPTIONS" field.
        /// </summary>
        System.Nullable<System.Int32> ActualSubscriptions
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_ACTUAL_SUBSCRIPTIONS_VAL" field.
        /// </summary>
        System.Nullable<System.Double> ActualSubscriptionsVal
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_WEB" field.
        /// </summary>
        System.Byte WebEnabled
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_EMAIL_CAMPAIGN" field.
        /// </summary>
        System.Byte EmailEnabled
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_QCODE" field.
        /// </summary>
        System.String Qcode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PersonModel" /> instances that reference this <see cref="!:PromotionModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Contact.IPersonModel> PersonPromotion
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BookingModel" /> instances that reference this <see cref="!:PromotionModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IBookingModel> Bookings
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:OpportunityModel" /> instances that reference this <see cref="!:PromotionModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Sales.IOpportunityModel> OppPromId
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:HelpdeskModel" /> instances that reference this <see cref="!:PromotionModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Activities.IHelpdeskModel> HelpdeskPromotionId
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ComplaintModel" /> instances that reference this <see cref="!:PromotionModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Activities.IComplaintModel> ComplaintPromotion
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MemberPeriodModel" /> instances that reference this <see cref="!:PromotionModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Membership.IMemberPeriodModel> MemberPeriods
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SaqQueryModel" /> instances that reference this <see cref="!:PromotionModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Marketing.ISaqQueryModel> SaqQuerySourceCode
        {
            get;
        }
    }
}
