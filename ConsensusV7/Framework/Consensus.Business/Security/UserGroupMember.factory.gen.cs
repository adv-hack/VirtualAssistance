using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="UserGroupMemberModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IUserGroupMemberFactory : IFactory<IUserGroupMemberModel, Int32>
    {
        /// <summary>
        ///     Creates a new <see cref="!:UserGroupMemberModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:UserGroupMemberModel" /> instance.
        /// </returns>
        Consensus.Security.IUserGroupMemberModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:UserGroupMemberModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:UserGroupMemberModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Security.IUserGroupMemberModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:UserGroupMemberModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:UserGroupMemberModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:UserGroupMemberModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Security.IUserGroupMemberModel FetchById(System.Int32 id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:UserGroupMemberModel" /> instances.
        /// </summary>
        /// <param name="principalId">
        ///     The value which identifies the <see cref="!:UserGroupMemberModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:UserGroupMemberModel" /> instances that match the specified <paramref name="principalId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Security.IUserGroupMemberModel> FetchAllByPrincipalId(System.Int32 principalId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:UserGroupMemberModel" /> instances.
        /// </summary>
        /// <param name="groupId">
        ///     The value which identifies the <see cref="!:UserGroupMemberModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:UserGroupMemberModel" /> instances that match the specified <paramref name="groupId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Security.IUserGroupMemberModel> FetchAllByGroupId(System.Int32 groupId);
    }
}
