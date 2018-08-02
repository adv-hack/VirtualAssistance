using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="RoleModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IRoleFactory : IFactory<IRoleModel, String>
    {
        /// <summary>
        ///     Creates a new <see cref="!:RoleModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:RoleModel" /> instance.
        /// </returns>
        Consensus.Contact.IRoleModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:RoleModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:RoleModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.IRoleModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:RoleModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:RoleModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:RoleModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Contact.IRoleModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:RoleModel" /> instances.
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref="!:RoleModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:RoleModel" /> instances that match the specified <paramref name="personId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.IRoleModel> FetchAllByPersonId(System.String personId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:RoleModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:RoleModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:RoleModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.IRoleModel> FetchAllByOrganisationId(System.String organisationId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:RoleModel" /> instances.
        /// </summary>
        /// <param name="addressId">
        ///     The value which identifies the <see cref="!:RoleModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:RoleModel" /> instances that match the specified <paramref name="addressId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.IRoleModel> FetchAllByAddressId(System.String addressId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:RoleModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:RoleModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:RoleModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.IRoleModel> FetchAllBySellingCompanyId(System.String sellingCompanyId);
    }
}
