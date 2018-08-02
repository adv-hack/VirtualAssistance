using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="AssociateModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IAssociateFactory : IFactory<IAssociateModel, Int32>
    {
        /// <summary>
        ///     Creates a new <see cref="!:AssociateModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:AssociateModel" /> instance.
        /// </returns>
        Consensus.Contact.IAssociateModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:AssociateModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:AssociateModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.IAssociateModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:AssociateModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:AssociateModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AssociateModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Contact.IAssociateModel FetchById(System.Int32 id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AssociateModel" /> instances.
        /// </summary>
        /// <param name="associatedRoleId">
        ///     The value which identifies the <see cref="!:AssociateModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AssociateModel" /> instances that match the specified <paramref name="associatedRoleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.IAssociateModel> FetchAllByAssociatedRoleId(System.String associatedRoleId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AssociateModel" /> instances.
        /// </summary>
        /// <param name="roleId">
        ///     The value which identifies the <see cref="!:AssociateModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AssociateModel" /> instances that match the specified <paramref name="roleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.IAssociateModel> FetchAllByRoleId(System.String roleId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AssociateModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:AssociateModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AssociateModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.IAssociateModel> FetchAllByOrganisationId(System.String organisationId);
    }
}
