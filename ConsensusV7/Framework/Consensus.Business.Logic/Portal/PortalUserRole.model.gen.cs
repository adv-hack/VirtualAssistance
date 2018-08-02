using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Portal
{
    /// <summary>
    ///     Encapsulates the <see cref="PortaluserroleRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalPortalUserRoleModel : LocalModel<PortaluserroleRecord, Int32>, IPortalUserRoleModel
    {
        #region fields

        /// <summary>
        ///     The value of the "PUR_PU_ID" field.
        /// </summary>
        private LocalPortalUserModel _portalUser;

        /// <summary>
        ///     The value of the "PUR_PR_ID" field.
        /// </summary>
        private LocalPortalRoleModel _portalRole;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<PortaluserroleRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Portal.PortalUserRole.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<PortaluserroleRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Portal.PortalUserRole.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<PortaluserroleRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Portal.PortalUserRole.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "PUR_PU_ID" field.
        /// </summary>
        public LocalPortalUserModel PortalUser
        {
            get
            {
                if (_portalUser == null)
                    _portalUser = this.Provider.Portal.PortalUser.FetchById(this.PortalUserId);
                if (_portalUser == null)
                    _portalUser = this.Provider.Portal.PortalUser.Create();
                
                return _portalUser;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PUR_PU_ID" field.
        /// </summary>
        public Int32 PortalUserId
        {
            get { return this.ModifiedData.PuId; }
            set
            {
                if (this.ModifiedData.PuId != value)
                     _portalUser = null;
                this.ModifiedData.PuId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "PUR_PR_ID" field.
        /// </summary>
        public LocalPortalRoleModel PortalRole
        {
            get
            {
                if (_portalRole == null)
                    _portalRole = this.Provider.Portal.PortalRole.FetchById(this.PortalRoleId);
                if (_portalRole == null)
                    _portalRole = this.Provider.Portal.PortalRole.Create();
                
                return _portalRole;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PUR_PR_ID" field.
        /// </summary>
        public Int32 PortalRoleId
        {
            get { return this.ModifiedData.PrId; }
            set
            {
                if (this.ModifiedData.PrId != value)
                     _portalRole = null;
                this.ModifiedData.PrId = value;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalPortalUserRoleModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalPortalUserRoleModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalPortalUserRoleModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalPortalUserRoleModel(LocalProvider provider, PortaluserroleRecord record) : base(provider, record)
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
            if (_portalUser != null)
            {
                _portalUser.Save();
                this.ModifiedData.PuId = _portalUser.Id;
            }
            if (_portalRole != null)
            {
                _portalRole.Save();
                this.ModifiedData.PrId = _portalRole.Id;
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
        ///     Gets the The value of the "PUR_PU_ID" field.
        /// </summary>
        Consensus.Portal.IPortalUserModel IPortalUserRoleModel.PortalUser
        {
            get { return this.PortalUser; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PUR_PU_ID" field.
        /// </summary>
        System.Int32 IPortalUserRoleModel.PortalUserId
        {
            get { return this.PortalUserId; }
            set { this.PortalUserId = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PUR_PR_ID" field.
        /// </summary>
        Consensus.Portal.IPortalRoleModel IPortalUserRoleModel.PortalRole
        {
            get { return this.PortalRole; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PUR_PR_ID" field.
        /// </summary>
        System.Int32 IPortalUserRoleModel.PortalRoleId
        {
            get { return this.PortalRoleId; }
            set { this.PortalRoleId = (System.Int32)value; }
        }

        #endregion
    }
}
