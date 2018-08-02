using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Portal
{
    /// <summary>
    ///     Microsoft SQL Server repository collection which pertains to the Portal namespace.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerPortalRepositoryCollection : SqlServerRepositoryCollection, IPortalRepositoryCollection
    {
        #region fields

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="PortalUserRecord" /> data structure.
        /// </summary>
        private SqlServerPortalUserRepository _portalUser;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="PortalSetupRecord" /> data structure.
        /// </summary>
        private SqlServerPortalSetupRepository _portalSetup;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="PuSiteRecord" /> data structure.
        /// </summary>
        private SqlServerPortalUserSiteRepository _portalUserSite;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="PortalRoleRecord" /> data structure.
        /// </summary>
        private SqlServerPortalRoleRepository _portalRole;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="PortaluserroleRecord" /> data structure.
        /// </summary>
        private SqlServerPortalUserRoleRepository _portalUserRole;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="PortalUserRecord" /> data structure.
        /// </summary>
        public SqlServerPortalUserRepository PortalUser
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerPortalUserRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _portalUser);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="PortalSetupRecord" /> data structure.
        /// </summary>
        public SqlServerPortalSetupRepository PortalSetup
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerPortalSetupRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _portalSetup);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="PuSiteRecord" /> data structure.
        /// </summary>
        public SqlServerPortalUserSiteRepository PortalUserSite
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerPortalUserSiteRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _portalUserSite);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="PortalRoleRecord" /> data structure.
        /// </summary>
        public SqlServerPortalRoleRepository PortalRole
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerPortalRoleRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _portalRole);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="PortaluserroleRecord" /> data structure.
        /// </summary>
        public SqlServerPortalUserRoleRepository PortalUserRole
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerPortalUserRoleRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _portalUserRole);
            }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Partial method that can be implemented elsewhere in the partial class to allow the provider to be amended for a particular instance.
        /// </summary>
        /// <param name="SqlServerDataRepositoryType">
        ///     The type of the SqlServerDataRepository instance being created.
        /// </param>
        /// <param name="provider">
        ///     The default provider. A new provider may be assigned to this parameter in an implementation, if required.
        /// </param>
        partial void OverrideProvider(Type SqlServerDataRepositoryType, ref SqlServerProvider provider);

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Portal.PortalUserRecord" /> data structure.
        /// </summary>
        Consensus.Portal.IPortalUserRepository IPortalRepositoryCollection.PortalUser
        {
            get { return this.PortalUser; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Portal.PortalSetupRecord" /> data structure.
        /// </summary>
        Consensus.Portal.IPortalSetupRepository IPortalRepositoryCollection.PortalSetup
        {
            get { return this.PortalSetup; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Portal.PuSiteRecord" /> data structure.
        /// </summary>
        Consensus.Portal.IPortalUserSiteRepository IPortalRepositoryCollection.PortalUserSite
        {
            get { return this.PortalUserSite; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Portal.PortalRoleRecord" /> data structure.
        /// </summary>
        Consensus.Portal.IPortalRoleRepository IPortalRepositoryCollection.PortalRole
        {
            get { return this.PortalRole; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Portal.PortaluserroleRecord" /> data structure.
        /// </summary>
        Consensus.Portal.IPortalUserRoleRepository IPortalRepositoryCollection.PortalUserRole
        {
            get { return this.PortalUserRole; }
        }

        #endregion
    }
}
