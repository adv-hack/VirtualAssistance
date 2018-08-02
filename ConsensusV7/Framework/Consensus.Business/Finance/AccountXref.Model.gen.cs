using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Contact;

namespace Consensus.Finance
{
    /// <summary>
    ///     Encapsulates the <see cref="AccountXrefRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IAccountXrefModel : IModel<String>
    {
        /// <summary>
        ///     Gets the The value of the "ACXREF_ACC_ID" field.
        /// </summary>
        Consensus.Finance.IAccountModel Account
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACXREF_ACC_ID" field.
        /// </summary>
        System.String AccountId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "ACXREF_ORG_ID" field.
        /// </summary>
        Consensus.Contact.IOrganisationModel Organisation
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACXREF_ORG_ID" field.
        /// </summary>
        System.String OrganisationId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "ACXREF_ADD_ID" field.
        /// </summary>
        Consensus.Contact.IAddressModel Address
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACXREF_ADD_ID" field.
        /// </summary>
        System.String AddressId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ACXREF_MAIN" field.
        /// </summary>
        System.Nullable<System.Byte> Main
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ACXREF_INVOICE" field.
        /// </summary>
        System.Nullable<System.Byte> Invoice
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ACXREF_STATEMENT" field.
        /// </summary>
        System.Nullable<System.Byte> Statement
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ACXREF_NO_ADD_CHANGE" field.
        /// </summary>
        System.Nullable<System.Byte> MustUse
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "ACXREF_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel Role
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACXREF_PROLE_ID" field.
        /// </summary>
        System.String RoleId
        {
            get;
            set;
        }
    }
}
