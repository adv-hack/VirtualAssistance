using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Contact;
using Consensus.Marketing;

namespace Consensus.Activities
{
    /// <summary>
    ///     Encapsulates the <see cref="ComplaintRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IComplaintModel : IModel<String>
    {
        /// <summary>
        ///     Gets or sets the value of the "CMPL_TITLE" field.
        /// </summary>
        System.String Title
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "CMPL_FROM_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel FromProleId
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CMPL_FROM_PROLE_ID" field.
        /// </summary>
        System.String FromProleIdId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "CMPL_RE_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel ReProleId
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CMPL_RE_PROLE_ID" field.
        /// </summary>
        System.String ReProleIdId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "CMPL_MGR_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel MgrProleId
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CMPL_MGR_PROLE_ID" field.
        /// </summary>
        System.String MgrProleIdId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "CMPL_MEDTR_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel MedtrProleId
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CMPL_MEDTR_PROLE_ID" field.
        /// </summary>
        System.String MedtrProleIdId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "CMPL_STATUS_1" field.
        /// </summary>
        Consensus.Common.ICodeModel Status
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CMPL_STATUS_1" field.
        /// </summary>
        System.String StatusCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "CMPL_STATUS_2" field.
        /// </summary>
        Consensus.Common.ICodeModel Resolution
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CMPL_STATUS_2" field.
        /// </summary>
        System.String ResolutionCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "CMPL_TYPE_1" field.
        /// </summary>
        Consensus.Common.ICodeModel Category
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CMPL_TYPE_1" field.
        /// </summary>
        System.String CategoryCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "CMPL_SCHEME" field.
        /// </summary>
        Consensus.Common.ICodeModel Scheme
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CMPL_SCHEME" field.
        /// </summary>
        System.String SchemeCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CMPL_DATE_OF_COMPL" field.
        /// </summary>
        System.Nullable<System.DateTime> DateOfCompl
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CMPL_DATE_RCVD" field.
        /// </summary>
        System.Nullable<System.DateTime> DateRcvd
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CMPL_DATE_END" field.
        /// </summary>
        System.Nullable<System.DateTime> DateEnd
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CMPL_DATE_NEXT_ACT" field.
        /// </summary>
        System.Nullable<System.DateTime> DateNextAct
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CMPL_NOTES" field.
        /// </summary>
        System.String Notes
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "CMPL_PM_ID" field.
        /// </summary>
        Consensus.Marketing.IPromotionModel PromotionID
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CMPL_PM_ID" field.
        /// </summary>
        System.String PromotionIDId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "CMPL_DETAILS_ID" field.
        /// </summary>
        Consensus.Activities.IC4textModel DetailsId
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CMPL_DETAILS_ID" field.
        /// </summary>
        System.String DetailsIdId
        {
            get;
            set;
        }
    }
}
