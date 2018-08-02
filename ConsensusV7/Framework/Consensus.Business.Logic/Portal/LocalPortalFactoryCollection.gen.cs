using System;
using System.Collections.Generic;
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
    public partial class LocalPortalFactoryCollection : LocalFactoryCollection, IPortalFactoryCollection
    {
        #region fields

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="PortalUserModel" /> objects.
        /// </summary>
        private LocalPortalUserFactory _portalUser;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="PortalSetupModel" /> objects.
        /// </summary>
        private LocalPortalSetupFactory _portalSetup;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="PortalUserSiteModel" /> objects.
        /// </summary>
        private LocalPortalUserSiteFactory _portalUserSite;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="PortalRoleModel" /> objects.
        /// </summary>
        private LocalPortalRoleFactory _portalRole;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="PortalUserRoleModel" /> objects.
        /// </summary>
        private LocalPortalUserRoleFactory _portalUserRole;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="PortalUserModel" /> objects.
        /// </summary>
        public LocalPortalUserFactory PortalUser
        {
            get { return LocalFactory.Create(this.Provider, ref _portalUser); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="PortalSetupModel" /> objects.
        /// </summary>
        public LocalPortalSetupFactory PortalSetup
        {
            get { return LocalFactory.Create(this.Provider, ref _portalSetup); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="PortalUserSiteModel" /> objects.
        /// </summary>
        public LocalPortalUserSiteFactory PortalUserSite
        {
            get { return LocalFactory.Create(this.Provider, ref _portalUserSite); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="PortalRoleModel" /> objects.
        /// </summary>
        public LocalPortalRoleFactory PortalRole
        {
            get { return LocalFactory.Create(this.Provider, ref _portalRole); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="PortalUserRoleModel" /> objects.
        /// </summary>
        public LocalPortalUserRoleFactory PortalUserRole
        {
            get { return LocalFactory.Create(this.Provider, ref _portalUserRole); }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:PortalUserModel" /> objects.
        /// </summary>
        Consensus.Portal.IPortalUserFactory IPortalFactoryCollection.PortalUser
        {
            get { return this.PortalUser; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:PortalSetupModel" /> objects.
        /// </summary>
        Consensus.Portal.IPortalSetupFactory IPortalFactoryCollection.PortalSetup
        {
            get { return this.PortalSetup; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:PortalUserSiteModel" /> objects.
        /// </summary>
        Consensus.Portal.IPortalUserSiteFactory IPortalFactoryCollection.PortalUserSite
        {
            get { return this.PortalUserSite; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:PortalRoleModel" /> objects.
        /// </summary>
        Consensus.Portal.IPortalRoleFactory IPortalFactoryCollection.PortalRole
        {
            get { return this.PortalRole; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:PortalUserRoleModel" /> objects.
        /// </summary>
        Consensus.Portal.IPortalUserRoleFactory IPortalFactoryCollection.PortalUserRole
        {
            get { return this.PortalUserRole; }
        }

        #endregion
    }
}
