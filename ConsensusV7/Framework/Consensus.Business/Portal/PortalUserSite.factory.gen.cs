using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Portal
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="PortalUserSiteModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IPortalUserSiteFactory : IFactory<IPortalUserSiteModel, Int32>
    {
        /// <summary>
        ///     Creates a new <see cref="!:PortalUserSiteModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PortalUserSiteModel" /> instance.
        /// </returns>
        Consensus.Portal.IPortalUserSiteModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PortalUserSiteModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PortalUserSiteModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Portal.IPortalUserSiteModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:PortalUserSiteModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PortalUserSiteModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PortalUserSiteModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Portal.IPortalUserSiteModel FetchById(System.Int32 id);

        System.String GetTableName();

        System.Collections.Generic.IEnumerable<Consensus.Portal.IPortalUserSiteModel> FetchAllByPortalUserId(System.Nullable<System.Int32> portalUserId);

        System.Collections.Generic.IEnumerable<Consensus.Portal.IPortalUserSiteModel> FetchAllByPortalSetupId(System.Nullable<System.Int32> portalSetupId);
    }
}
