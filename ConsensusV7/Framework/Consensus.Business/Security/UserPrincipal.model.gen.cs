using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.UserInterface;

namespace Consensus.Security
{
    /// <summary>
    ///     Represents represents a user identity.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IUserPrincipalModel : IModel<Int32>
    {
        #region properties

        /// <summary>
        ///     Gets the display name for the principal.
        /// </summary>
        System.String DisplayName
        {
            get;
        }

        /// <summary>
        ///     Gets the type of security principal.
        /// </summary>
        Consensus.Security.UserPrincipalTypes PrincipalType
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of runtime type permissions.
        /// </summary>
        Consensus.Security.UserPermissionSet[] PermissionSets
        {
            get;
        }

        /// <summary>
        ///     Gets or sets The name of the security principal.
        /// </summary>
        System.String Name
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ScreenObjectDisplayModel" /> instances that reference this <see cref="!:UserPrincipalModel" />.
        /// </summary>
        Consensus.Collection<Consensus.UserInterface.IScreenObjectDisplayModel> ScreenObjectDisplayRules
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:UserAccountModel" /> instances that reference this <see cref="!:UserPrincipalModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Security.IUserAccountModel> UserAccounts
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:UserGroupModel" /> instances that reference this <see cref="!:UserPrincipalModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Security.IUserGroupModel> UserGroups
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:UserGroupMemberModel" /> instances that reference this <see cref="!:UserPrincipalModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Security.IUserGroupMemberModel> UserGroupMemberships
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:UserPermissionModel" /> instances that reference this <see cref="!:UserPrincipalModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Security.IUserPermissionModel> Permissions
        {
            get;
        }

        #endregion

        #region methods

        void SetPermissions(System.Collections.ArrayList permissionSets);

        #endregion
    }
}
