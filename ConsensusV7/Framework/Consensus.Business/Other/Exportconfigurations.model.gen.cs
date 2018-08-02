using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Other
{
    /// <summary>
    ///     Encapsulates the <see cref="ExportconfigurationsRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IExportconfigurationsModel : IModel<Int32>
    {
        /// <summary>
        ///     Gets or sets the value of the "EC_TITLE" field.
        /// </summary>
        System.String Title
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BatchModel" /> instances that reference this <see cref="!:ExportconfigurationsModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Other.IBatchModel> BatchesExportConfigID
        {
            get;
        }
    }
}
