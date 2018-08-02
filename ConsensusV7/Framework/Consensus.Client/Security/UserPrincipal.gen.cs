using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.UserInterface;

namespace Consensus.Security
{
    /// <summary>
    ///     Represents Represents a user identity.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class UserPrincipal : Proxy<IUserPrincipalModel, Int32>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="ScreenObjectDisplayRules" /> member.
        /// </summary>
        private ProxyCollection<Consensus.UserInterface.ScreenObjectDisplay, Consensus.UserInterface.IScreenObjectDisplayModel> _screenObjectDisplayRules;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="UserAccounts" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Security.UserAccount, Consensus.Security.IUserAccountModel> _userAccounts;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="UserGroups" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Security.UserGroup, Consensus.Security.IUserGroupModel> _userGroups;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="UserGroupMemberships" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Security.UserGroupMember, Consensus.Security.IUserGroupMemberModel> _userGroupMemberships;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Permissions" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Security.UserPermission, Consensus.Security.IUserPermissionModel> _permissions;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the display name for the principal.
        /// </summary>
        public System.String DisplayName
        {
            get { return this.Model.DisplayName; }
        }

        /// <summary>
        ///     Gets the type of security principal.
        /// </summary>
        public Consensus.Security.UserPrincipalTypes PrincipalType
        {
            get { return this.Model.PrincipalType; }
        }

        /// <summary>
        ///     Gets the collection of runtime type permissions.
        /// </summary>
        public Consensus.Security.UserPermissionSet[] PermissionSets
        {
            get { return this.Model.PermissionSets; }
        }

        /// <summary>
        ///     Gets or sets The name of the security principal.
        /// </summary>
        public System.String Name
        {
            get { return this.Model.Name; }
            set { this.Model.Name = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ScreenObjectDisplayModel" /> instances that reference this <see cref="!:UserPrincipalModel" />.
        /// </summary>
        public Collection<Consensus.UserInterface.ScreenObjectDisplay> ScreenObjectDisplayRules
        {
            get
            {
                if (_screenObjectDisplayRules == null)
                    _screenObjectDisplayRules = new ProxyCollection<Consensus.UserInterface.ScreenObjectDisplay, Consensus.UserInterface.IScreenObjectDisplayModel>(this.Model.ScreenObjectDisplayRules, model => new Consensus.UserInterface.ScreenObjectDisplay(model));
                return _screenObjectDisplayRules;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:UserAccountModel" /> instances that reference this <see cref="!:UserPrincipalModel" />.
        /// </summary>
        public Collection<Consensus.Security.UserAccount> UserAccounts
        {
            get
            {
                if (_userAccounts == null)
                    _userAccounts = new ProxyCollection<Consensus.Security.UserAccount, Consensus.Security.IUserAccountModel>(this.Model.UserAccounts, model => new Consensus.Security.UserAccount(model));
                return _userAccounts;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:UserGroupModel" /> instances that reference this <see cref="!:UserPrincipalModel" />.
        /// </summary>
        public Collection<Consensus.Security.UserGroup> UserGroups
        {
            get
            {
                if (_userGroups == null)
                    _userGroups = new ProxyCollection<Consensus.Security.UserGroup, Consensus.Security.IUserGroupModel>(this.Model.UserGroups, model => new Consensus.Security.UserGroup(model));
                return _userGroups;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:UserGroupMemberModel" /> instances that reference this <see cref="!:UserPrincipalModel" />.
        /// </summary>
        public Collection<Consensus.Security.UserGroupMember> UserGroupMemberships
        {
            get
            {
                if (_userGroupMemberships == null)
                    _userGroupMemberships = new ProxyCollection<Consensus.Security.UserGroupMember, Consensus.Security.IUserGroupMemberModel>(this.Model.UserGroupMemberships, model => new Consensus.Security.UserGroupMember(model));
                return _userGroupMemberships;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:UserPermissionModel" /> instances that reference this <see cref="!:UserPrincipalModel" />.
        /// </summary>
        public Collection<Consensus.Security.UserPermission> Permissions
        {
            get
            {
                if (_permissions == null)
                    _permissions = new ProxyCollection<Consensus.Security.UserPermission, Consensus.Security.IUserPermissionModel>(this.Model.Permissions, model => new Consensus.Security.UserPermission(model));
                return _permissions;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal UserPrincipal(IUserPrincipalModel model) : base(model)
        {
        }

        #endregion

        #region methods

        public void SetPermissions(System.Collections.ArrayList permissionSets)
        {
            this.Model.SetPermissions(permissionSets);
        }

        /// <summary>
        ///     Creates a new <see cref="!:UserPrincipalModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:UserPrincipalModel" /> instance.
        /// </returns>
        public static Consensus.Security.UserPrincipal Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return UserPrincipal.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:UserPrincipalModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:UserPrincipalModel" /> instance.
        /// </returns>
        public static Consensus.Security.UserPrincipal Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Security.IUserPrincipalModel model = provider.Security.UserPrincipal.Create();
            return model == null ? null : new Consensus.Security.UserPrincipal(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:UserPrincipalModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:UserPrincipalModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Security.UserPrincipal> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return UserPrincipal.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:UserPrincipalModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:UserPrincipalModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Security.UserPrincipal> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Security.IUserPrincipalModel> collection = provider.Security.UserPrincipal.FetchAll();
            return collection.Select(model => new Consensus.Security.UserPrincipal(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:UserPrincipalModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:UserPrincipalModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:UserPrincipalModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Security.UserPrincipal FetchById(System.Int32 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return UserPrincipal.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:UserPrincipalModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:UserPrincipalModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:UserPrincipalModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Security.UserPrincipal FetchById(ConsensusSite site, System.Int32 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Security.IUserPrincipalModel model = provider.Security.UserPrincipal.FetchById(id);
            return model == null ? null : new Consensus.Security.UserPrincipal(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return UserPrincipal.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Security.UserPrincipal.GetTableName();
        }

        #endregion
    }
}
