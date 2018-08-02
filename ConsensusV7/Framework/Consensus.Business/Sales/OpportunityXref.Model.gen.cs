using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Contact;

namespace Consensus.Sales
{
    /// <summary>
    ///     Encapsulates the <see cref="OpportunityXrefRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IOpportunityXrefModel : IModel<String>
    {
        /// <summary>
        ///     Gets or sets the type of person that is linked to the opportunity.
        /// </summary>
        Consensus.Sales.OpportunityPersonType PersonType
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "OPPXREF_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel Role
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OPPXREF_PROLE_ID" field.
        /// </summary>
        System.String RoleId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "OPPXREF_OPP_ID" field.
        /// </summary>
        Consensus.Sales.IOpportunityModel Opportunity
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OPPXREF_OPP_ID" field.
        /// </summary>
        System.String OpportunityId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "OPPXREF_PRINCIPAL" field.
        /// </summary>
        System.Nullable<System.Byte> Principal
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "OPPXREF_ORG_NAME" field.
        /// </summary>
        System.String OrgName
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "OPPXREF_PN_NAME" field.
        /// </summary>
        System.String SalesPerson
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "OPPXREF_ORG_ID" field.
        /// </summary>
        Consensus.Contact.IOrganisationModel Organisation
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OPPXREF_ORG_ID" field.
        /// </summary>
        System.String OrganisationId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "OPPXREF_ORG_PHONE" field.
        /// </summary>
        System.String OrgPhone
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "OPPXREF_PN_PHONE" field.
        /// </summary>
        System.String PnPhone
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "OPPXREF_VALUE" field.
        /// </summary>
        System.Nullable<System.Decimal> Value
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "OPPXREF_SHARE" field.
        /// </summary>
        System.Nullable<System.Decimal> Share
        {
            get;
            set;
        }
    }
}
