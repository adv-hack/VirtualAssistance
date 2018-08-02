using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Portal
{
    /// <summary>
    ///     Encapsulates the <see cref="PortalRoleRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalPortalRoleModel : LocalModel<PortalRoleRecord, Int32>, IPortalRoleModel
    {
        #region fields

        /// <summary>
        ///     The collection of <see cref="PortalUserRoleModel" /> instances that reference this <see cref="PortalRoleModel" />.
        /// </summary>
        private LocalCollection<LocalPortalUserRoleModel, IPortalUserRoleModel> _portalUserRoles;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<PortalRoleRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Portal.PortalRole.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<PortalRoleRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Portal.PortalRole.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<PortalRoleRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Portal.PortalRole.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PR_TITLE" field.
        /// </summary>
        public String Title
        {
            get { return this.ModifiedData.Title; }
            set { this.ModifiedData.Title = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="PortalUserRoleModel" /> instances that reference this <see cref="PortalRoleModel" />.
        /// </summary>
        public LocalCollection<LocalPortalUserRoleModel, IPortalUserRoleModel> PortalUserRoles
        {
            get
            {
                if (_portalUserRoles == null)
                    _portalUserRoles = new LocalCollection<LocalPortalUserRoleModel, IPortalUserRoleModel>(this.Provider.Portal.PortalUserRole.FetchAllByPortalRoleId(this.Id));
                
                return _portalUserRoles;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalPortalRoleModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalPortalRoleModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalPortalRoleModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalPortalRoleModel(LocalProvider provider, PortalRoleRecord record) : base(provider, record)
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
            if (_portalUserRoles != null)
                _portalUserRoles.Execute(obj => obj.PortalRoleId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets or sets the value of the "PR_TITLE" field.
        /// </summary>
        System.String IPortalRoleModel.Title
        {
            get { return this.Title; }
            set { this.Title = (System.String)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PortalUserRoleModel" /> instances that reference this <see cref="!:PortalRoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Portal.IPortalUserRoleModel> IPortalRoleModel.PortalUserRoles
        {
            get { return this.PortalUserRoles; }
        }

        #endregion
    }
}
