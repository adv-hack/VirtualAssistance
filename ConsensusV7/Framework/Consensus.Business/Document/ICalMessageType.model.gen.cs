using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Encapsulates the <see cref="IcalmessagetypeRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IICalMessageTypeModel : IModel<Int32>
    {
        /// <summary>
        ///     Gets or sets the value of the "ICMT_NAME" field.
        /// </summary>
        System.String Name
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ICMT_VIEW" field.
        /// </summary>
        System.String View
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ICMT_PROC" field.
        /// </summary>
        System.String Proc
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ICalMessageModel" /> instances that reference this <see cref="!:ICalMessageTypeModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Document.IICalMessageModel> ICalendarMessages
        {
            get;
        }
    }
}
