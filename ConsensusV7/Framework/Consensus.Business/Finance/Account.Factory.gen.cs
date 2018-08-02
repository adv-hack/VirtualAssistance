using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="AccountModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IAccountFactory : IFactory<IAccountModel, String>
    {
        /// <summary>
        ///     Retrieves a specific <see cref="!:AccountModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The <see cref="!:AccountModel" /> instance that matches the specified <paramref name="roleId" />; or null, if no matching instance can be found.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IAccountModel> FetchByXrefRoleIdandOrgId(System.String roleId, System.String orgId, System.String spId);

        /// <summary>
        ///     Checks if ARNumber exist.
        /// </summary>
        /// <param name="arNumber">
        ///     ARNumber of Account.
        /// </param>
        /// <param name="sellingCompId">
        ///     Id of Selling Company.
        /// </param>
        /// <param name="accountId">
        ///     Id of the Account.
        /// </param>
        /// <returns>
        ///     Whether ARNumber exist in database.
        /// </returns>
        System.Boolean CheckIfARNumberExist(System.String arNumber, System.String sellingCompId, System.String accountId);

        /// <summary>
        ///     Creates a new <see cref="!:AccountModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:AccountModel" /> instance.
        /// </returns>
        Consensus.Finance.IAccountModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:AccountModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:AccountModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IAccountModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:AccountModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:AccountModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AccountModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Finance.IAccountModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AccountModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:AccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AccountModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IAccountModel> FetchAllByOrganisationId(System.String organisationId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AccountModel" /> instances.
        /// </summary>
        /// <param name="roleId">
        ///     The value which identifies the <see cref="!:AccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AccountModel" /> instances that match the specified <paramref name="roleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IAccountModel> FetchAllByRoleId(System.String roleId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AccountModel" /> instances.
        /// </summary>
        /// <param name="addressId">
        ///     The value which identifies the <see cref="!:AccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AccountModel" /> instances that match the specified <paramref name="addressId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IAccountModel> FetchAllByAddressId(System.String addressId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AccountModel" /> instances.
        /// </summary>
        /// <param name="sellingComanpyId">
        ///     The value which identifies the <see cref="!:AccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AccountModel" /> instances that match the specified <paramref name="sellingComanpyId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IAccountModel> FetchAllBySellingComanpyId(System.String sellingComanpyId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AccountModel" /> instances.
        /// </summary>
        /// <param name="invPackIdId">
        ///     The value which identifies the <see cref="!:AccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AccountModel" /> instances that match the specified <paramref name="invPackIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IAccountModel> FetchAllByInvPackIdId(System.String invPackIdId);
    }
}
