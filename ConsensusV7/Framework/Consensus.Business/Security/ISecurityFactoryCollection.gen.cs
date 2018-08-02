using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
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
    public interface ISecurityFactoryCollection : IFactoryCollection
    {
        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:LicenseModel" /> objects.
        /// </summary>
        Consensus.Security.ILicenseFactory License
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:LicenseLimitModel" /> objects.
        /// </summary>
        Consensus.Security.ILicenseLimitFactory LicenseLimit
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:LicenseModuleModel" /> objects.
        /// </summary>
        Consensus.Security.ILicenseModuleFactory LicenseModule
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:UserAccountModel" /> objects.
        /// </summary>
        Consensus.Security.IUserAccountFactory UserAccount
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:UserCredentialModel" /> objects.
        /// </summary>
        Consensus.Security.IUserCredentialFactory UserCredential
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:UserGroupModel" /> objects.
        /// </summary>
        Consensus.Security.IUserGroupFactory UserGroup
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:UserGroupMemberModel" /> objects.
        /// </summary>
        Consensus.Security.IUserGroupMemberFactory UserGroupMember
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:UserPermissionModel" /> objects.
        /// </summary>
        Consensus.Security.IUserPermissionFactory UserPermission
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:UserSessionModel" /> objects.
        /// </summary>
        Consensus.Security.IUserSessionFactory UserSession
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:UserPrincipalModel" /> objects.
        /// </summary>
        Consensus.Security.IUserPrincipalFactory UserPrincipal
        {
            get;
        }
    }
}
