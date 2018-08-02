using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Represents Specifies a permission that is held or withheld for a user or group.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalUserPermissionModel : LocalModel<UserPermissionRecord, Int32>, IUserPermissionModel
    {
        #region fields

        /// <summary>
        ///     The security principal to whom the permission is applied.
        /// </summary>
        private LocalUserPrincipalModel _principal;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<UserPermissionRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Security.UserPermission.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<UserPermissionRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Security.UserPermission.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<UserPermissionRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Security.UserPermission.RemoveById; }
        }

        /// <summary>
        ///     Gets the The security principal to whom the permission is applied.
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
        ///     Gets or sets the unique code for The security principal to whom the permission is applied.
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
        ///     Gets or sets The data type to which the permission is applied.
        /// </summary>
        public String DataType
        {
            get { return this.ModifiedData.DataType; }
            set { this.ModifiedData.DataType = value; }
        }

        /// <summary>
        ///     Gets or sets The type of action that is either permitted or prohibited.
        /// </summary>
        public Int32 Action
        {
            get { return this.ModifiedData.Action; }
            set { this.ModifiedData.Action = value; }
        }

        /// <summary>
        ///     Gets or sets The value which indicates if the permission is granted (true) or denied (false).
        /// </summary>
        public Boolean Allow
        {
            get { return this.ModifiedData.Allow; }
            set { this.ModifiedData.Allow = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalUserPermissionModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalUserPermissionModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalUserPermissionModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalUserPermissionModel(LocalProvider provider, UserPermissionRecord record) : base(provider, record)
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
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the The security principal to whom the permission is applied.
        /// </summary>
        Consensus.Security.IUserPrincipalModel IUserPermissionModel.Principal
        {
            get { return this.Principal; }
        }

        /// <summary>
        ///     Gets or sets the unique code for The security principal to whom the permission is applied.
        /// </summary>
        System.Int32 IUserPermissionModel.PrincipalId
        {
            get { return this.PrincipalId; }
            set { this.PrincipalId = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets The data type to which the permission is applied.
        /// </summary>
        System.String IUserPermissionModel.DataType
        {
            get { return this.DataType; }
            set { this.DataType = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets The type of action that is either permitted or prohibited.
        /// </summary>
        System.Int32 IUserPermissionModel.Action
        {
            get { return this.Action; }
            set { this.Action = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets The value which indicates if the permission is granted (true) or denied (false).
        /// </summary>
        System.Boolean IUserPermissionModel.Allow
        {
            get { return this.Allow; }
            set { this.Allow = (System.Boolean)value; }
        }

        #endregion
    }
}
