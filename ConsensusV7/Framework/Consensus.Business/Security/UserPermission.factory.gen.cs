using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="UserPermissionModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IUserPermissionFactory : IFactory<IUserPermissionModel, Int32>
    {
        /// <summary>
        ///     Creates a new <see cref="!:UserPermissionModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:UserPermissionModel" /> instance.
        /// </returns>
        Consensus.Security.IUserPermissionModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:UserPermissionModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:UserPermissionModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Security.IUserPermissionModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:UserPermissionModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:UserPermissionModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:UserPermissionModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Security.IUserPermissionModel FetchById(System.Int32 id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:UserPermissionModel" /> instances.
        /// </summary>
        /// <param name="principalId">
        ///     The value which identifies the <see cref="!:UserPermissionModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:UserPermissionModel" /> instances that match the specified <paramref name="principalId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Security.IUserPermissionModel> FetchAllByPrincipalId(System.Int32 principalId);
    }
}
