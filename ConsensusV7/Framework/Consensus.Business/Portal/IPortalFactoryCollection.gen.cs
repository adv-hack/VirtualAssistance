using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Portal
{
    /// <summary>
    ///     Represents a collection of factory instances which are responsible for the instantiation of the business models in the Portal namespace.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IPortalFactoryCollection : IFactoryCollection
    {
        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:PortalUserModel" /> objects.
        /// </summary>
        Consensus.Portal.IPortalUserFactory PortalUser
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:PortalSetupModel" /> objects.
        /// </summary>
        Consensus.Portal.IPortalSetupFactory PortalSetup
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:PortalUserSiteModel" /> objects.
        /// </summary>
        Consensus.Portal.IPortalUserSiteFactory PortalUserSite
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:PortalRoleModel" /> objects.
        /// </summary>
        Consensus.Portal.IPortalRoleFactory PortalRole
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:PortalUserRoleModel" /> objects.
        /// </summary>
        Consensus.Portal.IPortalUserRoleFactory PortalUserRole
        {
            get;
        }
    }
}
