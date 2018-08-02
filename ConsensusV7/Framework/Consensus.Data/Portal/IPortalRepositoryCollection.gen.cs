using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Portal
{
    /// <summary>
    ///     The repository collection which pertains to the Portal namespace.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IPortalRepositoryCollection : IRepositoryCollection
    {
        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Portal.PortalUserRecord" /> data structure.
        /// </summary>
        Consensus.Portal.IPortalUserRepository PortalUser
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Portal.PortalSetupRecord" /> data structure.
        /// </summary>
        Consensus.Portal.IPortalSetupRepository PortalSetup
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Portal.PuSiteRecord" /> data structure.
        /// </summary>
        Consensus.Portal.IPortalUserSiteRepository PortalUserSite
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Portal.PortalRoleRecord" /> data structure.
        /// </summary>
        Consensus.Portal.IPortalRoleRepository PortalRole
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Portal.PortaluserroleRecord" /> data structure.
        /// </summary>
        Consensus.Portal.IPortalUserRoleRepository PortalUserRole
        {
            get;
        }
    }
}
