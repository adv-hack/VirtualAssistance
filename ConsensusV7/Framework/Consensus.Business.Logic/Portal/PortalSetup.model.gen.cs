using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Portal
{
    /// <summary>
    ///     Encapsulates the <see cref="PortalSetupRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalPortalSetupModel : LocalModel<PortalSetupRecord, Int32>, IPortalSetupModel
    {
        #region fields

        /// <summary>
        ///     The collection of <see cref="PortalUserSiteModel" /> instances that reference this <see cref="PortalSetupModel" />.
        /// </summary>
        private LocalCollection<LocalPortalUserSiteModel, IPortalUserSiteModel> _portalUserSites;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<PortalSetupRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Portal.PortalSetup.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<PortalSetupRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Portal.PortalSetup.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<PortalSetupRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Portal.PortalSetup.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PS_PORTAL_TITLE" field.
        /// </summary>
        public String PortalTitle
        {
            get { return this.ModifiedData.PortalTitle; }
            set { this.ModifiedData.PortalTitle = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PS_PORTAL_URL" field.
        /// </summary>
        public String PortalUrl
        {
            get { return this.ModifiedData.PortalUrl; }
            set { this.ModifiedData.PortalUrl = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="PortalUserSiteModel" /> instances that reference this <see cref="PortalSetupModel" />.
        /// </summary>
        public LocalCollection<LocalPortalUserSiteModel, IPortalUserSiteModel> PortalUserSites
        {
            get
            {
                if (_portalUserSites == null)
                    _portalUserSites = new LocalCollection<LocalPortalUserSiteModel, IPortalUserSiteModel>(this.Provider.Portal.PortalUserSite.FetchAllByPortalSetupId(this.Id));
                
                return _portalUserSites;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalPortalSetupModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalPortalSetupModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalPortalSetupModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalPortalSetupModel(LocalProvider provider, PortalSetupRecord record) : base(provider, record)
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
            if (_portalUserSites != null)
                _portalUserSites.Execute(obj => obj.PortalSetupId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets or sets the value of the "PS_PORTAL_TITLE" field.
        /// </summary>
        System.String IPortalSetupModel.PortalTitle
        {
            get { return this.PortalTitle; }
            set { this.PortalTitle = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PS_PORTAL_URL" field.
        /// </summary>
        System.String IPortalSetupModel.PortalUrl
        {
            get { return this.PortalUrl; }
            set { this.PortalUrl = (System.String)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PortalUserSiteModel" /> instances that reference this <see cref="!:PortalSetupModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Portal.IPortalUserSiteModel> IPortalSetupModel.PortalUserSites
        {
            get { return this.PortalUserSites; }
        }

        #endregion
    }
}
