using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Document;

namespace Consensus.Contact
{
    /// <summary>
    ///     Encapsulates the <see cref="CustomerPackRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ICustomerPackModel : IModel<Int32>
    {
        /// <summary>
        ///     Gets the The value of the "CPA_ORG_ID" field.
        /// </summary>
        Consensus.Contact.IOrganisationModel Organisation
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CPA_ORG_ID" field.
        /// </summary>
        System.String OrganisationId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "CPA_PACK_ID" field.
        /// </summary>
        Consensus.Document.IPackModel Pack
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CPA_PACK_ID" field.
        /// </summary>
        System.String PackId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CPA_TYPE" field.
        /// </summary>
        System.String Type
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CPA_SUPPRESS" field.
        /// </summary>
        System.Byte Suppress
        {
            get;
            set;
        }
    }
}
