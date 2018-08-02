using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Encapsulates the <see cref="SmsTypeRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ISmsTypeModel : IModel<Int32>
    {
        /// <summary>
        ///     Gets or sets the value of the "SMT_NAME" field.
        /// </summary>
        System.String Name
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SMT_VIEW" field.
        /// </summary>
        System.String View
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SMT_STORED_PROC" field.
        /// </summary>
        System.String StoredProc
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SmsMessageModel" /> instances that reference this <see cref="!:SmsTypeModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Document.ISmsMessageModel> SmsMessages
        {
            get;
        }
    }
}
