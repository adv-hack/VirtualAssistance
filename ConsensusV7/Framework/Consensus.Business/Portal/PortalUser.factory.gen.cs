using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Portal
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="PortalUserModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IPortalUserFactory : IFactory<IPortalUserModel, Int32>
    {
        System.Boolean CheckIfUsernameExist(System.String name, System.String userId);

        /// <summary>
        ///     Creates a new <see cref="!:PortalUserModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PortalUserModel" /> instance.
        /// </returns>
        Consensus.Portal.IPortalUserModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PortalUserModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PortalUserModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Portal.IPortalUserModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:PortalUserModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PortalUserModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PortalUserModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Portal.IPortalUserModel FetchById(System.Int32 id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PortalUserModel" /> instances.
        /// </summary>
        /// <param name="personRoleId">
        ///     The value which identifies the <see cref="!:PortalUserModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PortalUserModel" /> instances that match the specified <paramref name="personRoleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Portal.IPortalUserModel> FetchAllByPersonRoleId(System.String personRoleId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PortalUserModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:PortalUserModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PortalUserModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Portal.IPortalUserModel> FetchAllBySellingCompanyId(System.String sellingCompanyId);
    }
}
