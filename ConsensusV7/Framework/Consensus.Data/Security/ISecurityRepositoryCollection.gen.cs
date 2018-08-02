using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     The repository collection which pertains to the Security namespace.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ISecurityRepositoryCollection : IRepositoryCollection
    {
        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Security.LicenseRecord" /> data structure.
        /// </summary>
        Consensus.Security.ILicenseRepository License
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Security.LicenseLimitRecord" /> data structure.
        /// </summary>
        Consensus.Security.ILicenseLimitRepository LicenseLimit
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Security.LicenseModuleRecord" /> data structure.
        /// </summary>
        Consensus.Security.ILicenseModuleRepository LicenseModule
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Security.UserAccountRecord" /> data structure.
        /// </summary>
        Consensus.Security.IUserAccountRepository UserAccount
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Security.UserCredentialRecord" /> data structure.
        /// </summary>
        Consensus.Security.IUserCredentialRepository UserCredential
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Security.UserGroupRecord" /> data structure.
        /// </summary>
        Consensus.Security.IUserGroupRepository UserGroup
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Security.UserGroupMemberRecord" /> data structure.
        /// </summary>
        Consensus.Security.IUserGroupMemberRepository UserGroupMember
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Security.UserPermissionRecord" /> data structure.
        /// </summary>
        Consensus.Security.IUserPermissionRepository UserPermission
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Security.UserSessionRecord" /> data structure.
        /// </summary>
        Consensus.Security.IUserSessionRepository UserSession
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Security.UserPrincipalRecord" /> data structure.
        /// </summary>
        Consensus.Security.IUserPrincipalRepository UserPrincipal
        {
            get;
        }
    }
}
