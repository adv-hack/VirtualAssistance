using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Encapsulates the <see cref="PacktypeRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IPacktypeModel : IModel<Int32>
    {
        /// <summary>
        ///     Gets or sets the value of the "PACKTYP_TYPE" field.
        /// </summary>
        System.Byte Type
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PACKTYP_DESC" field.
        /// </summary>
        System.String Desc
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PACKTYP_STORED_PROC" field.
        /// </summary>
        System.String StoredProc
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PACKTYP_URL" field.
        /// </summary>
        System.String Url
        {
            get;
            set;
        }
    }
}
