using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Represents a collection of factory instances which are responsible for the instantiation of the business models in the Security namespace.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalSecurityFactoryCollection : LocalFactoryCollection, ISecurityFactoryCollection
    {
        #region fields

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="LicenseModel" /> objects.
        /// </summary>
        private LocalLicenseFactory _license;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="LicenseLimitModel" /> objects.
        /// </summary>
        private LocalLicenseLimitFactory _licenseLimit;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="LicenseModuleModel" /> objects.
        /// </summary>
        private LocalLicenseModuleFactory _licenseModule;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="UserAccountModel" /> objects.
        /// </summary>
        private LocalUserAccountFactory _userAccount;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="UserCredentialModel" /> objects.
        /// </summary>
        private LocalUserCredentialFactory _userCredential;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="UserGroupModel" /> objects.
        /// </summary>
        private LocalUserGroupFactory _userGroup;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="UserGroupMemberModel" /> objects.
        /// </summary>
        private LocalUserGroupMemberFactory _userGroupMember;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="UserPermissionModel" /> objects.
        /// </summary>
        private LocalUserPermissionFactory _userPermission;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="UserSessionModel" /> objects.
        /// </summary>
        private LocalUserSessionFactory _userSession;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="UserPrincipalModel" /> objects.
        /// </summary>
        private LocalUserPrincipalFactory _userPrincipal;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="LicenseModel" /> objects.
        /// </summary>
        public LocalLicenseFactory License
        {
            get { return LocalFactory.Create(this.Provider, ref _license); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="LicenseLimitModel" /> objects.
        /// </summary>
        public LocalLicenseLimitFactory LicenseLimit
        {
            get { return LocalFactory.Create(this.Provider, ref _licenseLimit); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="LicenseModuleModel" /> objects.
        /// </summary>
        public LocalLicenseModuleFactory LicenseModule
        {
            get { return LocalFactory.Create(this.Provider, ref _licenseModule); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="UserAccountModel" /> objects.
        /// </summary>
        public LocalUserAccountFactory UserAccount
        {
            get { return LocalFactory.Create(this.Provider, ref _userAccount); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="UserCredentialModel" /> objects.
        /// </summary>
        public LocalUserCredentialFactory UserCredential
        {
            get { return LocalFactory.Create(this.Provider, ref _userCredential); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="UserGroupModel" /> objects.
        /// </summary>
        public LocalUserGroupFactory UserGroup
        {
            get { return LocalFactory.Create(this.Provider, ref _userGroup); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="UserGroupMemberModel" /> objects.
        /// </summary>
        public LocalUserGroupMemberFactory UserGroupMember
        {
            get { return LocalFactory.Create(this.Provider, ref _userGroupMember); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="UserPermissionModel" /> objects.
        /// </summary>
        public LocalUserPermissionFactory UserPermission
        {
            get { return LocalFactory.Create(this.Provider, ref _userPermission); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="UserSessionModel" /> objects.
        /// </summary>
        public LocalUserSessionFactory UserSession
        {
            get { return LocalFactory.Create(this.Provider, ref _userSession); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="UserPrincipalModel" /> objects.
        /// </summary>
        public LocalUserPrincipalFactory UserPrincipal
        {
            get { return LocalFactory.Create(this.Provider, ref _userPrincipal); }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:LicenseModel" /> objects.
        /// </summary>
        Consensus.Security.ILicenseFactory ISecurityFactoryCollection.License
        {
            get { return this.License; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:LicenseLimitModel" /> objects.
        /// </summary>
        Consensus.Security.ILicenseLimitFactory ISecurityFactoryCollection.LicenseLimit
        {
            get { return this.LicenseLimit; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:LicenseModuleModel" /> objects.
        /// </summary>
        Consensus.Security.ILicenseModuleFactory ISecurityFactoryCollection.LicenseModule
        {
            get { return this.LicenseModule; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:UserAccountModel" /> objects.
        /// </summary>
        Consensus.Security.IUserAccountFactory ISecurityFactoryCollection.UserAccount
        {
            get { return this.UserAccount; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:UserCredentialModel" /> objects.
        /// </summary>
        Consensus.Security.IUserCredentialFactory ISecurityFactoryCollection.UserCredential
        {
            get { return this.UserCredential; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:UserGroupModel" /> objects.
        /// </summary>
        Consensus.Security.IUserGroupFactory ISecurityFactoryCollection.UserGroup
        {
            get { return this.UserGroup; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:UserGroupMemberModel" /> objects.
        /// </summary>
        Consensus.Security.IUserGroupMemberFactory ISecurityFactoryCollection.UserGroupMember
        {
            get { return this.UserGroupMember; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:UserPermissionModel" /> objects.
        /// </summary>
        Consensus.Security.IUserPermissionFactory ISecurityFactoryCollection.UserPermission
        {
            get { return this.UserPermission; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:UserSessionModel" /> objects.
        /// </summary>
        Consensus.Security.IUserSessionFactory ISecurityFactoryCollection.UserSession
        {
            get { return this.UserSession; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:UserPrincipalModel" /> objects.
        /// </summary>
        Consensus.Security.IUserPrincipalFactory ISecurityFactoryCollection.UserPrincipal
        {
            get { return this.UserPrincipal; }
        }

        #endregion
    }
}
