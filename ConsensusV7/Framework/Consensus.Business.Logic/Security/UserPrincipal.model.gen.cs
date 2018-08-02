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
    public partial class LocalUserPrincipalModel : LocalModel<UserPrincipalRecord, Int32>, IUserPrincipalModel
    {
        #region fields

        /// <summary>
        ///     The collection of <see cref="ScreenObjectDisplayModel" /> instances that reference this <see cref="UserPrincipalModel" />.
        /// </summary>
        private LocalCollection<LocalScreenObjectDisplayModel, IScreenObjectDisplayModel> _screenObjectDisplayRules;

        /// <summary>
        ///     The collection of <see cref="UserAccountModel" /> instances that reference this <see cref="UserPrincipalModel" />.
        /// </summary>
        private LocalCollection<LocalUserAccountModel, IUserAccountModel> _userAccounts;

        /// <summary>
        ///     The collection of <see cref="UserGroupModel" /> instances that reference this <see cref="UserPrincipalModel" />.
        /// </summary>
        private LocalCollection<LocalUserGroupModel, IUserGroupModel> _userGroups;

        /// <summary>
        ///     The collection of <see cref="UserGroupMemberModel" /> instances that reference this <see cref="UserPrincipalModel" />.
        /// </summary>
        private LocalCollection<LocalUserGroupMemberModel, IUserGroupMemberModel> _userGroupMemberships;

        /// <summary>
        ///     The collection of <see cref="UserPermissionModel" /> instances that reference this <see cref="UserPrincipalModel" />.
        /// </summary>
        private LocalCollection<LocalUserPermissionModel, IUserPermissionModel> _permissions;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<UserPrincipalRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Security.UserPrincipal.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<UserPrincipalRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Security.UserPrincipal.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<UserPrincipalRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Security.UserPrincipal.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets The name of the security principal.
        /// </summary>
        public String Name
        {
            get { return this.ModifiedData.Name; }
            set { this.ModifiedData.Name = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ScreenObjectDisplayModel" /> instances that reference this <see cref="UserPrincipalModel" />.
        /// </summary>
        public LocalCollection<LocalScreenObjectDisplayModel, IScreenObjectDisplayModel> ScreenObjectDisplayRules
        {
            get
            {
                if (_screenObjectDisplayRules == null)
                    _screenObjectDisplayRules = new LocalCollection<LocalScreenObjectDisplayModel, IScreenObjectDisplayModel>(this.Provider.UserInterface.ScreenObjectDisplay.FetchAllByPrincipalId(this.Id));
                
                return _screenObjectDisplayRules;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="UserAccountModel" /> instances that reference this <see cref="UserPrincipalModel" />.
        /// </summary>
        public LocalCollection<LocalUserAccountModel, IUserAccountModel> UserAccounts
        {
            get
            {
                if (_userAccounts == null)
                    _userAccounts = new LocalCollection<LocalUserAccountModel, IUserAccountModel>(this.Provider.Security.UserAccount.FetchAllByPrincipalId(this.Id));
                
                return _userAccounts;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="UserGroupModel" /> instances that reference this <see cref="UserPrincipalModel" />.
        /// </summary>
        public LocalCollection<LocalUserGroupModel, IUserGroupModel> UserGroups
        {
            get
            {
                if (_userGroups == null)
                    _userGroups = new LocalCollection<LocalUserGroupModel, IUserGroupModel>(this.Provider.Security.UserGroup.FetchAllByPrincipalId(this.Id));
                
                return _userGroups;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="UserGroupMemberModel" /> instances that reference this <see cref="UserPrincipalModel" />.
        /// </summary>
        public LocalCollection<LocalUserGroupMemberModel, IUserGroupMemberModel> UserGroupMemberships
        {
            get
            {
                if (_userGroupMemberships == null)
                    _userGroupMemberships = new LocalCollection<LocalUserGroupMemberModel, IUserGroupMemberModel>(this.Provider.Security.UserGroupMember.FetchAllByPrincipalId(this.Id));
                
                return _userGroupMemberships;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="UserPermissionModel" /> instances that reference this <see cref="UserPrincipalModel" />.
        /// </summary>
        public LocalCollection<LocalUserPermissionModel, IUserPermissionModel> Permissions
        {
            get
            {
                if (_permissions == null)
                    _permissions = new LocalCollection<LocalUserPermissionModel, IUserPermissionModel>(this.Provider.Security.UserPermission.FetchAllByPrincipalId(this.Id));
                
                return _permissions;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalUserPrincipalModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalUserPrincipalModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalUserPrincipalModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalUserPrincipalModel(LocalProvider provider, UserPrincipalRecord record) : base(provider, record)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Resolves the dependencies by means of persisting all models that this model is referencing.
        /// </summary>
        protected override void ResolveGeneratedDependency()
        {
            base.ResolveGeneratedDependency();
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
            if (_screenObjectDisplayRules != null)
                _screenObjectDisplayRules.Execute(obj => obj.PrincipalId = this.Id).Execute(obj => obj.Save());
            if (_userAccounts != null)
                _userAccounts.Execute(obj => obj.PrincipalId = this.Id).Execute(obj => obj.Save());
            if (_userGroups != null)
                _userGroups.Execute(obj => obj.PrincipalId = this.Id).Execute(obj => obj.Save());
            if (_userGroupMemberships != null)
                _userGroupMemberships.Execute(obj => obj.PrincipalId = this.Id).Execute(obj => obj.Save());
            if (_permissions != null)
                _permissions.Execute(obj => obj.PrincipalId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the display name for the principal.
        /// </summary>
        System.String IUserPrincipalModel.DisplayName
        {
            get { return this.DisplayName; }
        }

        /// <summary>
        ///     Gets the type of security principal.
        /// </summary>
        Consensus.Security.UserPrincipalTypes IUserPrincipalModel.PrincipalType
        {
            get { return this.PrincipalType; }
        }

        /// <summary>
        ///     Gets the collection of runtime type permissions.
        /// </summary>
        Consensus.Security.UserPermissionSet[] IUserPrincipalModel.PermissionSets
        {
            get { return this.PermissionSets; }
        }

        /// <summary>
        ///     Gets or sets The name of the security principal.
        /// </summary>
        System.String IUserPrincipalModel.Name
        {
            get { return this.Name; }
            set { this.Name = (System.String)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ScreenObjectDisplayModel" /> instances that reference this <see cref="!:UserPrincipalModel" />.
        /// </summary>
        Consensus.Collection<Consensus.UserInterface.IScreenObjectDisplayModel> IUserPrincipalModel.ScreenObjectDisplayRules
        {
            get { return this.ScreenObjectDisplayRules; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:UserAccountModel" /> instances that reference this <see cref="!:UserPrincipalModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Security.IUserAccountModel> IUserPrincipalModel.UserAccounts
        {
            get { return this.UserAccounts; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:UserGroupModel" /> instances that reference this <see cref="!:UserPrincipalModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Security.IUserGroupModel> IUserPrincipalModel.UserGroups
        {
            get { return this.UserGroups; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:UserGroupMemberModel" /> instances that reference this <see cref="!:UserPrincipalModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Security.IUserGroupMemberModel> IUserPrincipalModel.UserGroupMemberships
        {
            get { return this.UserGroupMemberships; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:UserPermissionModel" /> instances that reference this <see cref="!:UserPrincipalModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Security.IUserPermissionModel> IUserPrincipalModel.Permissions
        {
            get { return this.Permissions; }
        }

        void IUserPrincipalModel.SetPermissions(System.Collections.ArrayList permissionSets)
        {
            this.SetPermissions(permissionSets);
        }

        #endregion
    }
}
