using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Portal
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="PortalSetupModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IPortalSetupFactory : IFactory<IPortalSetupModel, Int32>
    {
        /// <summary>
        ///     Creates a new <see cref="!:PortalSetupModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PortalSetupModel" /> instance.
        /// </returns>
        Consensus.Portal.IPortalSetupModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PortalSetupModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PortalSetupModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Portal.IPortalSetupModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:PortalSetupModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PortalSetupModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PortalSetupModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Portal.IPortalSetupModel FetchById(System.Int32 id);

        System.String GetTableName();
    }
}
