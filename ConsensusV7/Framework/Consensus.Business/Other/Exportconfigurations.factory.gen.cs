using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Other
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ExportconfigurationsModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IExportconfigurationsFactory : IFactory<IExportconfigurationsModel, Int32>
    {
        /// <summary>
        ///     Creates a new <see cref="!:ExportconfigurationsModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ExportconfigurationsModel" /> instance.
        /// </returns>
        Consensus.Other.IExportconfigurationsModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ExportconfigurationsModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ExportconfigurationsModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Other.IExportconfigurationsModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:ExportconfigurationsModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ExportconfigurationsModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ExportconfigurationsModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Other.IExportconfigurationsModel FetchById(System.Int32 id);

        System.String GetTableName();
    }
}
