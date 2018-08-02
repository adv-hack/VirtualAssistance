using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="CommunicationsRoleModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ICommunicationsRoleFactory : IFactory<ICommunicationsRoleModel, Int64>
    {
        /// <summary>
        ///     Creates a new <see cref="!:CommunicationsRoleModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:CommunicationsRoleModel" /> instance.
        /// </returns>
        Consensus.Contact.ICommunicationsRoleModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:CommunicationsRoleModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:CommunicationsRoleModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.ICommunicationsRoleModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:CommunicationsRoleModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:CommunicationsRoleModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CommunicationsRoleModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Contact.ICommunicationsRoleModel FetchById(System.Int64 id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:CommunicationsRoleModel" /> instances.
        /// </summary>
        /// <param name="roleId">
        ///     The value which identifies the <see cref="!:CommunicationsRoleModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CommunicationsRoleModel" /> instances that match the specified <paramref name="roleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.ICommunicationsRoleModel> FetchAllByRoleId(System.String roleId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:CommunicationsRoleModel" /> instances.
        /// </summary>
        /// <param name="communicationId">
        ///     The value which identifies the <see cref="!:CommunicationsRoleModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CommunicationsRoleModel" /> instances that match the specified <paramref name="communicationId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.ICommunicationsRoleModel> FetchAllByCommunicationId(System.Int64 communicationId);
    }
}
