using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Portal
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="PortalRoleModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IPortalRoleFactory : IFactory<IPortalRoleModel, Int32>
    {
        /// <summary>
        ///     Creates a new <see cref="!:PortalRoleModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PortalRoleModel" /> instance.
        /// </returns>
        Consensus.Portal.IPortalRoleModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PortalRoleModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PortalRoleModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Portal.IPortalRoleModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:PortalRoleModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PortalRoleModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PortalRoleModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Portal.IPortalRoleModel FetchById(System.Int32 id);

        System.String GetTableName();
    }
}
