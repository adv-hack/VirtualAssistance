using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Logistics
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ProjectModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IProjectFactory : IFactory<IProjectModel, String>
    {
        /// <summary>
        ///     Creates a new <see cref="!:ProjectModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ProjectModel" /> instance.
        /// </returns>
        Consensus.Logistics.IProjectModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ProjectModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ProjectModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Logistics.IProjectModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:ProjectModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ProjectModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProjectModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Logistics.IProjectModel FetchById(System.String id);

        System.String GetTableName();
    }
}
