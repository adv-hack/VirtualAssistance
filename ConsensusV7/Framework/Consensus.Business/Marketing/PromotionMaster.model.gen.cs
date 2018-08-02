using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Contact;
using Consensus.Learning;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Encapsulates the <see cref="PromotionMasterRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IPromotionMasterModel : IModel<String>
    {
        /// <summary>
        ///     Gets or sets the value of the "PM_MST_NAME" field.
        /// </summary>
        System.String Name
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_START_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> StartDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_END_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> EndDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PM_MST_REGION" field.
        /// </summary>
        Consensus.Common.ICodeModel Region
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PM_MST_REGION" field.
        /// </summary>
        System.String RegionCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_BUDGET_COST" field.
        /// </summary>
        System.Nullable<System.Double> BudgetCost
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_ACTUAL_COST" field.
        /// </summary>
        System.Nullable<System.Double> ActualCost
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_REPLIES" field.
        /// </summary>
        System.Nullable<System.Double> ActualReplies
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_ORDERS" field.
        /// </summary>
        System.Nullable<System.Double> SoldOpp
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_ORDER_VALUE" field.
        /// </summary>
        System.Nullable<System.Double> OppVal
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_UPDATED" field.
        /// </summary>
        System.Nullable<System.DateTime> Updated
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PM_MST_CMP_ID" field.
        /// </summary>
        Consensus.Marketing.ICampaignModel CmpId
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PM_MST_CMP_ID" field.
        /// </summary>
        System.String CmpIdId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_MAILINGS" field.
        /// </summary>
        System.Nullable<System.Int32> Mailings
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_BOOKINGS" field.
        /// </summary>
        System.Nullable<System.Int32> ActualBook
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_OPP_TOT" field.
        /// </summary>
        System.Nullable<System.Int32> ActualOpp
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_QUOTES" field.
        /// </summary>
        System.Nullable<System.Int32> ActualQuotes
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_QUO_VAL" field.
        /// </summary>
        System.Nullable<System.Double> ActualQuotesVal
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_CALC_ACT" field.
        /// </summary>
        System.Nullable<System.Double> CalculatedActualCost
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_CALC_EST" field.
        /// </summary>
        System.Nullable<System.Double> CalculatedBudgetCost
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_BOOK_VAL" field.
        /// </summary>
        System.Nullable<System.Double> ActualBookVal
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PM_MST_COURSE_ID" field.
        /// </summary>
        Consensus.Learning.IEventModel CourseId
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PM_MST_COURSE_ID" field.
        /// </summary>
        System.String CourseIdId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_TYPE" field.
        /// </summary>
        System.Nullable<System.Byte> Type
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_TARGET_OPP" field.
        /// </summary>
        System.Nullable<System.Int32> TargetOpp
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_TARGET_REPLIES" field.
        /// </summary>
        System.Nullable<System.Int32> TargetReplies
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_TARGET_OPP_VAL" field.
        /// </summary>
        System.Nullable<System.Double> TargetOppVal
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_TARGET_BOOK_VAL" field.
        /// </summary>
        System.Nullable<System.Double> TargetBookVal
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PM_MST_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel Manager
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PM_MST_PROLE_ID" field.
        /// </summary>
        System.String ManagerId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PM_MST_APP_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel Approver
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PM_MST_APP_PROLE_ID" field.
        /// </summary>
        System.String ApproverId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_EMAILS_SENT" field.
        /// </summary>
        System.Int32 EmailsSentActual
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_EMAILS_OPENED" field.
        /// </summary>
        System.Int32 EmailsOpenedActual
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_LINKS_CLICKED" field.
        /// </summary>
        System.Int32 LinksClickedActual
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_LZ_CLICKED" field.
        /// </summary>
        System.Int32 LzClickedActual
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_SURVEYS_COMPLETED" field.
        /// </summary>
        System.Int32 SurveysCompletedActual
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_GLOBAL_UNSUBSCRIBES" field.
        /// </summary>
        System.Int32 GlobalUnsubscribesActual
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_LIST_UNSUBSCRIBES" field.
        /// </summary>
        System.Int32 ListUnsubscribesActual
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_DOCS_DOWNLOADS" field.
        /// </summary>
        System.Int32 DocsDownloadsActual
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_BOUNCE_BACKS" field.
        /// </summary>
        System.Int32 BounceBacksActual
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_EMAILS_SENT_TARGET" field.
        /// </summary>
        System.Int32 EmailsSentTarget
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_EMAILS_OPENED_TARGET" field.
        /// </summary>
        System.Int32 EmailsOpenedTarget
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_LINKS_CLICKED_TARGET" field.
        /// </summary>
        System.Int32 LinksClickedTarget
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_LZ_CLICKED_TARGET" field.
        /// </summary>
        System.Int32 LzClickedTarget
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_SURVEYS_COMPLETED_TARGET" field.
        /// </summary>
        System.Int32 SurveysCompletedTarget
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_GLOBAL_UNSUBSCRIBES_TARGET" field.
        /// </summary>
        System.Int32 GlobalUnsubscribesTarget
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_LIST_UNSUBSCRIBES_TARGET" field.
        /// </summary>
        System.Int32 ListUnsubscribesTarget
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_DOCS_DOWNLOADS_TARGET" field.
        /// </summary>
        System.Int32 DocsDownloadsTarget
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_BOUNCE_BACKS_TARGET" field.
        /// </summary>
        System.Int32 BounceBacksTarget
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PM_MST_QCODE" field.
        /// </summary>
        System.String Qcode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PromotionModel" /> instances that reference this <see cref="!:PromotionMasterModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Marketing.IPromotionModel> PromotionPromotionMaster
        {
            get;
        }
    }
}
