using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Represents Represents a collection of users.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalUserGroupModel : LocalModel<UserGroupRecord, Int32>, IUserGroupModel
    {
        #region fields

        /// <summary>
        ///     The security principal referenced by the group.
        /// </summary>
        private LocalUserPrincipalModel _principal;

        /// <summary>
        ///     The collection of <see cref="UserGroupMemberModel" /> instances that reference this <see cref="UserGroupModel" />.
        /// </summary>
        private LocalCollection<LocalUserGroupMemberModel, IUserGroupMemberModel> _userGroupMemberships;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<UserGroupRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Security.UserGroup.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<UserGroupRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Security.UserGroup.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<UserGroupRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Security.UserGroup.RemoveById; }
        }

        /// <summary>
        ///     Gets the The security principal referenced by the group.
        /// </summary>
        public LocalUserPrincipalModel Principal
        {
            get
            {
                if (_principal == null)
                    _principal = this.Provider.Security.UserPrincipal.FetchById(this.PrincipalId);
                if (_principal == null)
                    _principal = this.Provider.Security.UserPrincipal.Create();
                
                return _principal;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for The security principal referenced by the group.
        /// </summary>
        public Int32 PrincipalId
        {
            get { return this.ModifiedData.PrincipalId; }
            set
            {
                if (this.ModifiedData.PrincipalId != value)
                     _principal = null;
                this.ModifiedData.PrincipalId = value;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="UserGroupMemberModel" /> instances that reference this <see cref="UserGroupModel" />.
        /// </summary>
        public LocalCollection<LocalUserGroupMemberModel, IUserGroupMemberModel> UserGroupMemberships
        {
            get
            {
                if (_userGroupMemberships == null)
                    _userGroupMemberships = new LocalCollection<LocalUserGroupMemberModel, IUserGroupMemberModel>(this.Provider.Security.UserGroupMember.FetchAllByGroupId(this.Id));
                
                return _userGroupMemberships;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalUserGroupModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalUserGroupModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalUserGroupModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalUserGroupModel(LocalProvider provider, UserGroupRecord record) : base(provider, record)
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
            if (_principal != null)
            {
                _principal.Save();
                this.ModifiedData.PrincipalId = _principal.Id;
            }
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
            if (_userGroupMemberships != null)
                _userGroupMemberships.Execute(obj => obj.GroupId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the The security principal referenced by the group.
        /// </summary>
        Consensus.Security.IUserPrincipalModel IUserGroupModel.Principal
        {
            get { return this.Principal; }
        }

        /// <summary>
        ///     Gets or sets the unique code for The security principal referenced by the group.
        /// </summary>
        System.Int32 IUserGroupModel.PrincipalId
        {
            get { return this.PrincipalId; }
            set { this.PrincipalId = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:UserGroupMemberModel" /> instances that reference this <see cref="!:UserGroupModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Security.IUserGroupMemberModel> IUserGroupModel.UserGroupMemberships
        {
            get { return this.UserGroupMemberships; }
        }

        #endregion
    }
}
