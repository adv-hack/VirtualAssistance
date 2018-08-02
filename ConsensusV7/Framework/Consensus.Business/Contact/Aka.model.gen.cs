using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Encapsulates the <see cref="AkaRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IAkaModel : IModel<Int32>
    {
        /// <summary>
        ///     Gets or sets the value of the "AKA_NAME" field.
        /// </summary>
        System.String Name
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "AKA_ORG_ID" field.
        /// </summary>
        Consensus.Contact.IOrganisationModel OrgId
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "AKA_ORG_ID" field.
        /// </summary>
        System.String OrgIdId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "AKA_PN_ID" field.
        /// </summary>
        Consensus.Contact.IPersonModel PnId
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "AKA_PN_ID" field.
        /// </summary>
        System.String PnIdId
        {
            get;
            set;
        }
    }
}
