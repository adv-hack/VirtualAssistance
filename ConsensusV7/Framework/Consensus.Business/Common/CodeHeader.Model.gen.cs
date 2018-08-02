using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Encapsulates the <see cref="CodeHeaderRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ICodeHeaderModel : IModel<String>
    {
        /// <summary>
        ///     Gets or sets the value of the "CDHDR_NAME" field.
        /// </summary>
        System.String Name
        {
            get;
            set;
        }
    }
}
