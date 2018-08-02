using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Contact;
using Consensus.Marketing;

namespace Consensus.Common
{
    /// <summary>
    ///     Encapsulates the <see cref="ProfileRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IProfileOrganisationModel : IProfileModel
    {
        /// <summary>
        ///     Gets the The value of the "PROF_ORG_ID" field.
        /// </summary>
        Consensus.Contact.IOrganisationModel Organisation
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROF_ORG_ID" field.
        /// </summary>
        System.String OrganisationId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SaqQueueModel" /> instances that reference this <see cref="!:ProfileOrganisationModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Marketing.ISaqQueueModel> SaqQueueProfileOrg
        {
            get;
        }
    }
}
