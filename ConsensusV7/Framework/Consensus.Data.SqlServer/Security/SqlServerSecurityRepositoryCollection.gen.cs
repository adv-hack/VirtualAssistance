using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Microsoft SQL Server repository collection which pertains to the Security namespace.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerSecurityRepositoryCollection : SqlServerRepositoryCollection, ISecurityRepositoryCollection
    {
        #region fields

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="LicenseRecord" /> data structure.
        /// </summary>
        private SqlServerLicenseRepository _license;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="LicenseLimitRecord" /> data structure.
        /// </summary>
        private SqlServerLicenseLimitRepository _licenseLimit;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="LicenseModuleRecord" /> data structure.
        /// </summary>
        private SqlServerLicenseModuleRepository _licenseModule;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="UserAccountRecord" /> data structure.
        /// </summary>
        private SqlServerUserAccountRepository _userAccount;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="UserCredentialRecord" /> data structure.
        /// </summary>
        private SqlServerUserCredentialRepository _userCredential;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="UserGroupRecord" /> data structure.
        /// </summary>
        private SqlServerUserGroupRepository _userGroup;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="UserGroupMemberRecord" /> data structure.
        /// </summary>
        private SqlServerUserGroupMemberRepository _userGroupMember;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="UserPermissionRecord" /> data structure.
        /// </summary>
        private SqlServerUserPermissionRepository _userPermission;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="UserSessionRecord" /> data structure.
        /// </summary>
        private SqlServerUserSessionRepository _userSession;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="UserPrincipalRecord" /> data structure.
        /// </summary>
        private SqlServerUserPrincipalRepository _userPrincipal;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="LicenseRecord" /> data structure.
        /// </summary>
        public SqlServerLicenseRepository License
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerLicenseRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _license);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="LicenseLimitRecord" /> data structure.
        /// </summary>
        public SqlServerLicenseLimitRepository LicenseLimit
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerLicenseLimitRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _licenseLimit);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="LicenseModuleRecord" /> data structure.
        /// </summary>
        public SqlServerLicenseModuleRepository LicenseModule
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerLicenseModuleRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _licenseModule);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="UserAccountRecord" /> data structure.
        /// </summary>
        public SqlServerUserAccountRepository UserAccount
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerUserAccountRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _userAccount);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="UserCredentialRecord" /> data structure.
        /// </summary>
        public SqlServerUserCredentialRepository UserCredential
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerUserCredentialRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _userCredential);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="UserGroupRecord" /> data structure.
        /// </summary>
        public SqlServerUserGroupRepository UserGroup
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerUserGroupRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _userGroup);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="UserGroupMemberRecord" /> data structure.
        /// </summary>
        public SqlServerUserGroupMemberRepository UserGroupMember
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerUserGroupMemberRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _userGroupMember);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="UserPermissionRecord" /> data structure.
        /// </summary>
        public SqlServerUserPermissionRepository UserPermission
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerUserPermissionRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _userPermission);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="UserSessionRecord" /> data structure.
        /// </summary>
        public SqlServerUserSessionRepository UserSession
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerUserSessionRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _userSession);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="UserPrincipalRecord" /> data structure.
        /// </summary>
        public SqlServerUserPrincipalRepository UserPrincipal
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerUserPrincipalRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _userPrincipal);
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
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Security.LicenseRecord" /> data structure.
        /// </summary>
        Consensus.Security.ILicenseRepository ISecurityRepositoryCollection.License
        {
            get { return this.License; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Security.LicenseLimitRecord" /> data structure.
        /// </summary>
        Consensus.Security.ILicenseLimitRepository ISecurityRepositoryCollection.LicenseLimit
        {
            get { return this.LicenseLimit; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Security.LicenseModuleRecord" /> data structure.
        /// </summary>
        Consensus.Security.ILicenseModuleRepository ISecurityRepositoryCollection.LicenseModule
        {
            get { return this.LicenseModule; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Security.UserAccountRecord" /> data structure.
        /// </summary>
        Consensus.Security.IUserAccountRepository ISecurityRepositoryCollection.UserAccount
        {
            get { return this.UserAccount; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Security.UserCredentialRecord" /> data structure.
        /// </summary>
        Consensus.Security.IUserCredentialRepository ISecurityRepositoryCollection.UserCredential
        {
            get { return this.UserCredential; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Security.UserGroupRecord" /> data structure.
        /// </summary>
        Consensus.Security.IUserGroupRepository ISecurityRepositoryCollection.UserGroup
        {
            get { return this.UserGroup; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Security.UserGroupMemberRecord" /> data structure.
        /// </summary>
        Consensus.Security.IUserGroupMemberRepository ISecurityRepositoryCollection.UserGroupMember
        {
            get { return this.UserGroupMember; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Security.UserPermissionRecord" /> data structure.
        /// </summary>
        Consensus.Security.IUserPermissionRepository ISecurityRepositoryCollection.UserPermission
        {
            get { return this.UserPermission; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Security.UserSessionRecord" /> data structure.
        /// </summary>
        Consensus.Security.IUserSessionRepository ISecurityRepositoryCollection.UserSession
        {
            get { return this.UserSession; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Security.UserPrincipalRecord" /> data structure.
        /// </summary>
        Consensus.Security.IUserPrincipalRepository ISecurityRepositoryCollection.UserPrincipal
        {
            get { return this.UserPrincipal; }
        }

        #endregion
    }
}
