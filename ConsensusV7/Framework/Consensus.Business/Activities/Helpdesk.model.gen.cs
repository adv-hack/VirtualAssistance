using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Contact;
using Consensus.Marketing;

namespace Consensus.Activities
{
    /// <summary>
    ///     Encapsulates the <see cref="HelpdeskRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IHelpdeskModel : IModel<String>
    {
        /// <summary>
        ///     Gets the The value of the "HD_ORG_ID" field.
        /// </summary>
        Consensus.Contact.IOrganisationModel OrgId
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "HD_ORG_ID" field.
        /// </summary>
        System.String OrgIdId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "HD_ORG_NAME" field.
        /// </summary>
        System.String OrgName
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "HD_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel ProleId
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "HD_PROLE_ID" field.
        /// </summary>
        System.String ProleIdId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "HD_PN_NAME" field.
        /// </summary>
        System.String PnName
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "HD_GIVEN_TO" field.
        /// </summary>
        System.String GivenTo
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "HD_GIVEN_TO_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel GivenToId
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "HD_GIVEN_TO_ID" field.
        /// </summary>
        System.String GivenToIdId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "HD_STATUS" field.
        /// </summary>
        System.String Status
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "HD_DETAILS_ID" field.
        /// </summary>
        Consensus.Activities.IC4textModel DetailsId
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "HD_DETAILS_ID" field.
        /// </summary>
        System.String DetailsIdId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "HD_FIX_ID" field.
        /// </summary>
        Consensus.Activities.IC4textModel FixId
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "HD_FIX_ID" field.
        /// </summary>
        System.String FixIdId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "HD_CATEGORY" field.
        /// </summary>
        System.String Category
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "HD_FIX_CAT" field.
        /// </summary>
        System.String FixCat
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "HD_CALL_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> CallDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "HD_SEVERITY" field.
        /// </summary>
        System.String Severity
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "HD_TITLE" field.
        /// </summary>
        System.String Title
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "HD_TYPE" field.
        /// </summary>
        System.Nullable<System.Byte> Type
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "HD_WIP_ID" field.
        /// </summary>
        Consensus.Activities.IC4textModel WipId
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "HD_WIP_ID" field.
        /// </summary>
        System.String WipIdId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "HD_RES_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> ResDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "HD_SELCO_SP_ID" field.
        /// </summary>
        Consensus.Common.ISellingCompanyModel SelcoSpId
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "HD_SELCO_SP_ID" field.
        /// </summary>
        System.String SelcoSpIdId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "HD_PM_ID" field.
        /// </summary>
        Consensus.Marketing.IPromotionModel PmId
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "HD_PM_ID" field.
        /// </summary>
        System.String PmIdId
        {
            get;
            set;
        }
    }
}
