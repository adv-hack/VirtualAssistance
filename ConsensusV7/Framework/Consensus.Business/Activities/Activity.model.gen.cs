using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Learning;
using Consensus.Sales;

namespace Consensus.Activities
{
    /// <summary>
    ///     Encapsulates the <see cref="ActivityRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IActivityModel : IModel<String>
    {
        /// <summary>
        ///     Gets the instance of the LocalActivityXrefModel which represents the activity salesperson.
        /// </summary>
        Consensus.Activities.IActivityXrefModel EndUser
        {
            get;
        }

        /// <summary>
        ///     Gets the instance of the LocalActivityXrefModel which represents the activity salesperson.
        /// </summary>
        Consensus.Activities.IActivityXrefModel SalesPerson
        {
            get;
        }

        System.String EndUserId
        {
            get;
            set;
        }

        System.String EndUserPersonId
        {
            get;
            set;
        }

        System.String EndUserOrganisationId
        {
            get;
            set;
        }

        System.String SalesPersonId
        {
            get;
            set;
        }

        /// <summary>
        ///     List of attachments for an activity. Created here to aid saving from the activity dialog.
        /// </summary>
        Consensus.Collection<Consensus.Common.IAttachmentModel> Attachments
        {
            get;
        }

        /// <summary>
        ///     Gets the The value of the "ACT_TYPE" field.
        /// </summary>
        Consensus.Common.ICodeModel Type
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACT_TYPE" field.
        /// </summary>
        System.String TypeCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_ACTION_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> ActionDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_TIME" field.
        /// </summary>
        System.Nullable<System.DateTime> Time
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_END_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> EndDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_END_TIME" field.
        /// </summary>
        System.Nullable<System.DateTime> EndTime
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "ACT_RESULT" field.
        /// </summary>
        Consensus.Common.ICodeModel Result
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACT_RESULT" field.
        /// </summary>
        System.String ResultCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_NOTE" field.
        /// </summary>
        System.String Note
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "ACT_OPP_ID" field.
        /// </summary>
        Consensus.Sales.IOpportunityModel Opportunity
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACT_OPP_ID" field.
        /// </summary>
        System.String OpportunityId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_SESSION_NAME" field.
        /// </summary>
        System.String Name
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_NOTE_HTML" field.
        /// </summary>
        System.String NoteHtml
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "ACT_SELCO_SP_ID" field.
        /// </summary>
        Consensus.Common.ISellingCompanyModel SellingCompany
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACT_SELCO_SP_ID" field.
        /// </summary>
        System.String SellingCompanyId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ElementModel" /> instances that reference this <see cref="!:ActivityModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IElementModel> Elements
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:OpportunityModel" /> instances that reference this <see cref="!:ActivityModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Sales.IOpportunityModel> Opportunities
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ActivityXrefModel" /> instances that reference this <see cref="!:ActivityModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Activities.IActivityXrefModel> ActivityXRefs
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ActLinkXrefModel" /> instances that reference this <see cref="!:ActivityModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Activities.IActLinkXrefModel> ActivityLinkXrefs
        {
            get;
        }
    }
}
