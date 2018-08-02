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
    public interface IProfilePersonModel : IProfileModel
    {
        /// <summary>
        ///     Gets the The value of the "PROF_PERSON_ID" field.
        /// </summary>
        Consensus.Contact.IPersonModel Person
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROF_PERSON_ID" field.
        /// </summary>
        System.String PersonId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SaqQueueModel" /> instances that reference this <see cref="!:ProfilePersonModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Marketing.ISaqQueueModel> SaqQueueProfilePerson
        {
            get;
        }
    }
}
