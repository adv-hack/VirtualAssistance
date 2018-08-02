using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Contact;
using Consensus.Logistics;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Encapsulates the <see cref="CampaignRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ICampaignModel : IModel<String>
    {
        /// <summary>
        ///     Gets or sets the value of the "CMP_NAME" field.
        /// </summary>
        System.String Name
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_START_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> StartDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_END_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> EndDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_REGION" field.
        /// </summary>
        System.String Region
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_OBJ_TEXT_ID" field.
        /// </summary>
        System.String ObjTextId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_SEL_TEXT_ID" field.
        /// </summary>
        System.String SelTextId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_RVW_TEXT_ID" field.
        /// </summary>
        System.String RvwTextId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_BUDGET_COSTS" field.
        /// </summary>
        System.Nullable<System.Double> BudgetCosts
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_ACTUAL_COSTS" field.
        /// </summary>
        System.Nullable<System.Double> ActualCosts
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_REPLIES" field.
        /// </summary>
        System.Nullable<System.Double> ActualReplies
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_ORDERS" field.
        /// </summary>
        System.Nullable<System.Double> SoldOpp
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_ORDER_VALUE" field.
        /// </summary>
        System.Nullable<System.Double> OppVal
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_UPDATED" field.
        /// </summary>
        System.Nullable<System.DateTime> Updated
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_MAILINGS" field.
        /// </summary>
        System.Nullable<System.Int32> Mailings
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_BOOKINGS" field.
        /// </summary>
        System.Nullable<System.Int32> ActualBook
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_BOOK_VALUE" field.
        /// </summary>
        System.Nullable<System.Double> ActualBookValue
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_QUOTES" field.
        /// </summary>
        System.Nullable<System.Int32> ActualQuotes
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_QUO_VALUE" field.
        /// </summary>
        System.Nullable<System.Double> ActualQuotesVal
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_CALC_ACT" field.
        /// </summary>
        System.Nullable<System.Double> CalcAct
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_CALC_EST" field.
        /// </summary>
        System.Nullable<System.Double> CalcEst
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_OPP_TOT" field.
        /// </summary>
        System.Nullable<System.Int32> ActualOpp
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "CMP_PROJ_ID" field.
        /// </summary>
        Consensus.Logistics.IProjectModel Project
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CMP_PROJ_ID" field.
        /// </summary>
        System.String ProjectId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "CMP_SELCO_SP_ID" field.
        /// </summary>
        Consensus.Common.ISellingCompanyModel SellingCompany
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CMP_SELCO_SP_ID" field.
        /// </summary>
        System.String SellingCompanyId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_TARGET_OPP" field.
        /// </summary>
        System.Nullable<System.Int32> TargetOpp
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_TARGET_REPLIES" field.
        /// </summary>
        System.Nullable<System.Int32> TargetReplies
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_TARGET_OPP_VAL" field.
        /// </summary>
        System.Nullable<System.Double> TargetOppVal
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_TARGET_BOOK_VAL" field.
        /// </summary>
        System.Nullable<System.Double> TargetBookVal
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "CMP_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel Manager
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CMP_PROLE_ID" field.
        /// </summary>
        System.String ManagerId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "CMP_APP_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel Approver
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CMP_APP_PROLE_ID" field.
        /// </summary>
        System.String ApproverId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_EMAILS_SENT" field.
        /// </summary>
        System.Int32 EmailsSentActual
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_EMAILS_OPENED" field.
        /// </summary>
        System.Int32 EmailsOpenedActual
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_LINKS_CLICKED" field.
        /// </summary>
        System.Int32 LinksClickedActual
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_LZ_CLICKED" field.
        /// </summary>
        System.Int32 LzClickedActual
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_SURVEYS_COMPLETED" field.
        /// </summary>
        System.Int32 SurveysCompletedActual
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_GLOBAL_UNSUBSCRIBES" field.
        /// </summary>
        System.Int32 GlobalUnsubscribesActual
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_LIST_UNSUBSCRIBES" field.
        /// </summary>
        System.Int32 ListUnsubscribesActual
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_DOCS_DOWNLOADS" field.
        /// </summary>
        System.Int32 DocsDownloadsActual
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_BOUNCE_BACKS" field.
        /// </summary>
        System.Int32 BounceBacksActual
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_EMAILS_SENT_TARGET" field.
        /// </summary>
        System.Int32 EmailsSentTarget
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_EMAILS_OPENED_TARGET" field.
        /// </summary>
        System.Int32 EmailsOpenedTarget
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_LINKS_CLICKED_TARGET" field.
        /// </summary>
        System.Int32 LinksClickedTarget
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_LZ_CLICKED_TARGET" field.
        /// </summary>
        System.Int32 LzClickedTarget
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_SURVEYS_COMPLETED_TARGET" field.
        /// </summary>
        System.Int32 SurveysCompletedTarget
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_GLOBAL_UNSUBSCRIBES_TARGET" field.
        /// </summary>
        System.Int32 GlobalUnsubscribesTarget
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_LIST_UNSUBSCRIBES_TARGET" field.
        /// </summary>
        System.Int32 ListUnsubscribesTarget
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_DOCS_DOWNLOADS_TARGET" field.
        /// </summary>
        System.Int32 DocsDownloadsTarget
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_BOUNCE_BACKS_TARGET" field.
        /// </summary>
        System.Int32 BounceBacksTarget
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_QCODE" field.
        /// </summary>
        System.String Qcode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CMP_CURRENT" field.
        /// </summary>
        System.Nullable<System.Byte> Current
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PromotionMasterModel" /> instances that reference this <see cref="!:CampaignModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Marketing.IPromotionMasterModel> PromotionMasterCampaign
        {
            get;
        }
    }
}
