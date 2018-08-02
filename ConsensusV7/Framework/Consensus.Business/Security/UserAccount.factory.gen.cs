using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="UserAccountModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IUserAccountFactory : IFactory<IUserAccountModel, Int32>
    {
        /// <summary>
        ///     Retrieves a specific <see cref="!:UserAccountModel" /> instance.
        /// </summary>
        /// <param name="username">
        ///     The unique username which distinctly identifies the <see cref="!:UserAccountModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:UserAccountModel" /> instance that matches the specified <paramref name="username" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Security.IUserAccountModel FetchByUsername(System.String username);

        /// <summary>
        ///     Gets the reporting URL.
        /// </summary>
        /// <returns>
        ///     A <see cref="T:System.String" /> containing a URL.
        /// </returns>
        System.String ReportingURL(System.String portalPage);

        /// <summary>
        ///     Checks whether Pool B user is allowed to create account.
        /// </summary>
        /// <param name="userAccountId">
        ///     Id of UserAccount.
        /// </param>
        /// <param name="licenseType">
        ///     Type of License whether its Pool A or Pool B.
        /// </param>
        /// <param name="status">
        ///     Determins whether status is Active.
        /// </param>
        /// <returns>
        ///     Whether PoolB account can be created or not.
        /// </returns>
        System.Boolean CheckPoolBUserAllowed(System.String userAccountId, System.String licenseType, System.String status);

        /// <summary>
        ///     Checks if user is allowed to create Pool B license.
        /// </summary>
        /// <param name="isUserAllowed">
        ///     Whether PoolB account can be created or not.
        /// </param>
        /// <param name="userAccountId">
        ///     Id of User account.
        /// </param>
        /// <returns>
        ///     Whether PoolB account can be created or not.
        /// </returns>
        System.Boolean CheckIsUserAllowed(System.Boolean isUserAllowed, System.String userAccountId);

        /// <summary>
        ///     Checks if username already exist in database.
        /// </summary>
        /// <param name="username">
        ///     Username of User account.
        /// </param>
        /// <param name="userId">
        ///     Id of User.
        /// </param>
        /// <returns>
        ///     Whether username already exist in database.
        /// </returns>
        System.Boolean CheckIfUsernameExist(System.String username, System.String userId);

        /// <summary>
        ///     Creates a new <see cref="!:UserAccountModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:UserAccountModel" /> instance.
        /// </returns>
        Consensus.Security.IUserAccountModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:UserAccountModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:UserAccountModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Security.IUserAccountModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:UserAccountModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:UserAccountModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:UserAccountModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Security.IUserAccountModel FetchById(System.Int32 id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:UserAccountModel" /> instances.
        /// </summary>
        /// <param name="principalId">
        ///     The value which identifies the <see cref="!:UserAccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:UserAccountModel" /> instances that match the specified <paramref name="principalId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Security.IUserAccountModel> FetchAllByPrincipalId(System.Int32 principalId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:UserAccountModel" /> instances.
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref="!:UserAccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:UserAccountModel" /> instances that match the specified <paramref name="personId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Security.IUserAccountModel> FetchAllByPersonId(System.String personId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:UserAccountModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:UserAccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:UserAccountModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Security.IUserAccountModel> FetchAllBySellingCompanyId(System.String sellingCompanyId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:UserAccountModel" /> instances.
        /// </summary>
        /// <param name="reportIdId">
        ///     The value which identifies the <see cref="!:UserAccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:UserAccountModel" /> instances that match the specified <paramref name="reportIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Security.IUserAccountModel> FetchAllByReportIdId(System.String reportIdId);
    }
}
