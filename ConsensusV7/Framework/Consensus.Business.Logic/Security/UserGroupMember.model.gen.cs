using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Represents Represents a membership to a user group.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalUserGroupMemberModel : LocalModel<UserGroupMemberRecord, Int32>, IUserGroupMemberModel
    {
        #region fields

        /// <summary>
        ///     The security principal that is a member of the group.
        /// </summary>
        private LocalUserPrincipalModel _principal;

        /// <summary>
        ///     The user group in which the member is included.
        /// </summary>
        private LocalUserGroupModel _group;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<UserGroupMemberRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Security.UserGroupMember.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<UserGroupMemberRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Security.UserGroupMember.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<UserGroupMemberRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Security.UserGroupMember.RemoveById; }
        }

        /// <summary>
        ///     Gets the The security principal that is a member of the group.
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
        ///     Gets or sets the unique code for The security principal that is a member of the group.
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
        ///     Gets the The user group in which the member is included.
        /// </summary>
        public LocalUserGroupModel Group
        {
            get
            {
                if (_group == null)
                    _group = this.Provider.Security.UserGroup.FetchById(this.GroupId);
                if (_group == null)
                    _group = this.Provider.Security.UserGroup.Create();
                
                return _group;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for The user group in which the member is included.
        /// </summary>
        public Int32 GroupId
        {
            get { return this.ModifiedData.GroupId; }
            set
            {
                if (this.ModifiedData.GroupId != value)
                     _group = null;
                this.ModifiedData.GroupId = value;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalUserGroupMemberModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalUserGroupMemberModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalUserGroupMemberModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalUserGroupMemberModel(LocalProvider provider, UserGroupMemberRecord record) : base(provider, record)
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
            if (_group != null)
            {
                _group.Save();
                this.ModifiedData.GroupId = _group.Id;
            }
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the The security principal that is a member of the group.
        /// </summary>
        Consensus.Security.IUserPrincipalModel IUserGroupMemberModel.Principal
        {
            get { return this.Principal; }
        }

        /// <summary>
        ///     Gets or sets the unique code for The security principal that is a member of the group.
        /// </summary>
        System.Int32 IUserGroupMemberModel.PrincipalId
        {
            get { return this.PrincipalId; }
            set { this.PrincipalId = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets the The user group in which the member is included.
        /// </summary>
        Consensus.Security.IUserGroupModel IUserGroupMemberModel.Group
        {
            get { return this.Group; }
        }

        /// <summary>
        ///     Gets or sets the unique code for The user group in which the member is included.
        /// </summary>
        System.Int32 IUserGroupMemberModel.GroupId
        {
            get { return this.GroupId; }
            set { this.GroupId = (System.Int32)value; }
        }

        #endregion
    }
}
