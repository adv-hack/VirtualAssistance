using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Portal
{
    /// <summary>
    ///     Encapsulates the <see cref="PuSiteRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalPortalUserSiteModel : LocalModel<PuSiteRecord, Int32>, IPortalUserSiteModel
    {
        #region fields

        /// <summary>
        ///     The value of the "PUSTE_PU_ID" field.
        /// </summary>
        private LocalPortalUserModel _portalUser;

        /// <summary>
        ///     The value of the "PUSTE_PS_ID" field.
        /// </summary>
        private LocalPortalSetupModel _portalSetup;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<PuSiteRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Portal.PortalUserSite.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<PuSiteRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Portal.PortalUserSite.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<PuSiteRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Portal.PortalUserSite.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "PUSTE_PU_ID" field.
        /// </summary>
        public LocalPortalUserModel PortalUser
        {
            get
            {
                if (_portalUser == null && this.PortalUserId != null)
                    _portalUser = this.Provider.Portal.PortalUser.FetchById(this.PortalUserId.Value);
                if (_portalUser == null)
                    _portalUser = this.Provider.Portal.PortalUser.Create();
                
                return _portalUser;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PUSTE_PU_ID" field.
        /// </summary>
        public Int32? PortalUserId
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
        ///     Gets the The value of the "PUSTE_PS_ID" field.
        /// </summary>
        public LocalPortalSetupModel PortalSetup
        {
            get
            {
                if (_portalSetup == null && this.PortalSetupId != null)
                    _portalSetup = this.Provider.Portal.PortalSetup.FetchById(this.PortalSetupId.Value);
                if (_portalSetup == null)
                    _portalSetup = this.Provider.Portal.PortalSetup.Create();
                
                return _portalSetup;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PUSTE_PS_ID" field.
        /// </summary>
        public Int32? PortalSetupId
        {
            get { return this.ModifiedData.PsId; }
            set
            {
                if (this.ModifiedData.PsId != value)
                     _portalSetup = null;
                this.ModifiedData.PsId = value;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalPortalUserSiteModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalPortalUserSiteModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalPortalUserSiteModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalPortalUserSiteModel(LocalProvider provider, PuSiteRecord record) : base(provider, record)
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
            if (_portalSetup != null)
            {
                _portalSetup.Save();
                this.ModifiedData.PsId = _portalSetup.Id;
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
        ///     Gets the The value of the "PUSTE_PU_ID" field.
        /// </summary>
        Consensus.Portal.IPortalUserModel IPortalUserSiteModel.PortalUser
        {
            get { return this.PortalUser; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PUSTE_PU_ID" field.
        /// </summary>
        System.Nullable<System.Int32> IPortalUserSiteModel.PortalUserId
        {
            get { return this.PortalUserId; }
            set { this.PortalUserId = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PUSTE_PS_ID" field.
        /// </summary>
        Consensus.Portal.IPortalSetupModel IPortalUserSiteModel.PortalSetup
        {
            get { return this.PortalSetup; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PUSTE_PS_ID" field.
        /// </summary>
        System.Nullable<System.Int32> IPortalUserSiteModel.PortalSetupId
        {
            get { return this.PortalSetupId; }
            set { this.PortalSetupId = (System.Nullable<System.Int32>)value; }
        }

        #endregion
    }
}
