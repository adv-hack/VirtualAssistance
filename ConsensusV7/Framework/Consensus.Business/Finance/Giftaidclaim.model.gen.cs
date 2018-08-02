using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Contact;

namespace Consensus.Finance
{
    /// <summary>
    ///     Encapsulates the <see cref="GiftaidclaimRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IGiftaidclaimModel : IModel<Int32>
    {
        /// <summary>
        ///     Gets the The value of the "GAC_SUBMITTER_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel Submitter
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "GAC_SUBMITTER_PROLE_ID" field.
        /// </summary>
        System.String SubmitterId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "GAC_TRUSTEE_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel Trustee
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "GAC_TRUSTEE_PROLE_ID" field.
        /// </summary>
        System.String TrusteeId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "GAC_ORG_ID" field.
        /// </summary>
        Consensus.Contact.IOrganisationModel Organisation
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "GAC_ORG_ID" field.
        /// </summary>
        System.String OrganisationId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "GAC_CLAIM_DATE" field.
        /// </summary>
        System.DateTime ClaimDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "GAC_DONATIONS_FROM" field.
        /// </summary>
        System.DateTime DonationsFrom
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "GAC_DONATIONS_TO" field.
        /// </summary>
        System.DateTime DonationsTo
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "GAC_ACCOUNTING_PERIOD_END" field.
        /// </summary>
        System.DateTime AccountingPeriodEnd
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "GAC_HMRC_REFERENCE" field.
        /// </summary>
        System.String HmrcReference
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "GAC_REGULATOR_NAME" field.
        /// </summary>
        System.String RegulatorName
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "GAC_REGULATOR_NUMBER" field.
        /// </summary>
        System.String RegulatorNumber
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "GAC_ADJUSTMENT" field.
        /// </summary>
        System.Nullable<System.Decimal> Adjustment
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "GAC_PROCESS" field.
        /// </summary>
        System.Byte Process
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "GAC_SELCO_SP_ID" field.
        /// </summary>
        Consensus.Common.ISellingCompanyModel SellingCompany
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "GAC_SELCO_SP_ID" field.
        /// </summary>
        System.String SellingCompanyId
        {
            get;
            set;
        }
    }
}
