using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Encapsulates the <see cref="CommunicationsXrefRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ICommunications_XrefModel : IModel<Int64>
    {
        /// <summary>
        ///     Gets the The value of the "COMMXREF_COMM_ID" field.
        /// </summary>
        Consensus.Contact.ICommunicationsModel Communication
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COMMXREF_COMM_ID" field.
        /// </summary>
        System.Int64 CommunicationId
        {
            get;
            set;
        }
    }
}
