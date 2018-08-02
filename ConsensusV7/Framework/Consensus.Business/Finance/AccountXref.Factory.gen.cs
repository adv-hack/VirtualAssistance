using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="AccountXrefModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IAccountXrefFactory : IFactory<IAccountXrefModel, String>
    {
        /// <summary>
        ///     Checks if a contact already exist for that account in database.
        /// </summary>
        /// <param name="accountId">
        ///     accountId.
        /// </param>
        /// <param name="roleId">
        ///     RoleId.
        /// </param>
        /// <param name="accounteexrefid">
        ///     accounteexrefid.
        /// </param>
        /// <returns>
        ///     Whether that person already exist for that committee in database.
        /// </returns>
        System.Boolean CheckIfSameContactAlreadyExists(System.String accountId, System.String roleId, System.String accounteexrefid);

        /// <summary>
        ///     Checks if a contact already exist for that account in database.
        /// </summary>
        /// <param name="accountId">
        ///     accountId.
        /// </param>
        /// <param name="personId">
        ///     PersonId.
        /// </param>
        /// <param name="orgId">
        ///     Organisation Id.
        /// </param>
        /// <param name="accounteexrefid">
        ///     accounteexrefid.
        /// </param>
        /// <returns>
        ///     Whether that person already exist for that committee in database.
        /// </returns>
        System.Boolean CheckIfSameOrganisationAlreadyExists(System.String accountId, System.String personId, System.String orgId, System.String accounteexrefid);

        /// <summary>
        ///     Checks if a contact or organization exists while the data is saved.
        /// </summary>
        /// <param name="orgId">
        ///     Organization Id.
        /// </param>
        /// <param name="personid">
        ///     PersonId.
        /// </param>
        /// <returns>
        ///     Whether that person already exist for that committee in database.
        /// </returns>
        System.Boolean CheckIfContactOrOrganizationExists(System.String orgId, System.String personid);

        /// <summary>
        ///     Creates a new <see cref="!:AccountXrefModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:AccountXrefModel" /> instance.
        /// </returns>
        Consensus.Finance.IAccountXrefModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:AccountXrefModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:AccountXrefModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IAccountXrefModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:AccountXrefModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:AccountXrefModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AccountXrefModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Finance.IAccountXrefModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AccountXrefModel" /> instances.
        /// </summary>
        /// <param name="accountId">
        ///     The value which identifies the <see cref="!:AccountXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AccountXrefModel" /> instances that match the specified <paramref name="accountId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IAccountXrefModel> FetchAllByAccountId(System.String accountId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AccountXrefModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:AccountXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AccountXrefModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IAccountXrefModel> FetchAllByOrganisationId(System.String organisationId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AccountXrefModel" /> instances.
        /// </summary>
        /// <param name="addressId">
        ///     The value which identifies the <see cref="!:AccountXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AccountXrefModel" /> instances that match the specified <paramref name="addressId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IAccountXrefModel> FetchAllByAddressId(System.String addressId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AccountXrefModel" /> instances.
        /// </summary>
        /// <param name="roleId">
        ///     The value which identifies the <see cref="!:AccountXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AccountXrefModel" /> instances that match the specified <paramref name="roleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IAccountXrefModel> FetchAllByRoleId(System.String roleId);
    }
}
