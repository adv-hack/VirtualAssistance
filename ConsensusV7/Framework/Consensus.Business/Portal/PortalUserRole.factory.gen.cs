using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Portal
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="PortalUserRoleModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IPortalUserRoleFactory : IFactory<IPortalUserRoleModel, Int32>
    {
        /// <summary>
        ///     Creates a new <see cref="!:PortalUserRoleModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PortalUserRoleModel" /> instance.
        /// </returns>
        Consensus.Portal.IPortalUserRoleModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PortalUserRoleModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PortalUserRoleModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Portal.IPortalUserRoleModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:PortalUserRoleModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PortalUserRoleModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PortalUserRoleModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Portal.IPortalUserRoleModel FetchById(System.Int32 id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PortalUserRoleModel" /> instances.
        /// </summary>
        /// <param name="portalUserId">
        ///     The value which identifies the <see cref="!:PortalUserRoleModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PortalUserRoleModel" /> instances that match the specified <paramref name="portalUserId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Portal.IPortalUserRoleModel> FetchAllByPortalUserId(System.Int32 portalUserId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PortalUserRoleModel" /> instances.
        /// </summary>
        /// <param name="portalRoleId">
        ///     The value which identifies the <see cref="!:PortalUserRoleModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PortalUserRoleModel" /> instances that match the specified <paramref name="portalRoleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Portal.IPortalUserRoleModel> FetchAllByPortalRoleId(System.Int32 portalRoleId);
    }
}
