using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Marketing;

namespace Consensus.Logistics
{
    /// <summary>
    ///     Encapsulates the <see cref="ProjectRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalProjectModel : LocalModel<ProjectRecord, String>, IProjectModel
    {
        #region fields

        /// <summary>
        ///     The collection of <see cref="CampaignModel" /> instances that reference this <see cref="ProjectModel" />.
        /// </summary>
        private LocalCollection<LocalCampaignModel, ICampaignModel> _campaignProject;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ProjectRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Logistics.Project.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ProjectRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Logistics.Project.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<ProjectRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Logistics.Project.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROJ_STATUS" field.
        /// </summary>
        public String Status
        {
            get { return this.ModifiedData.Status; }
            set { this.ModifiedData.Status = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROJ_ORG_ID" field.
        /// </summary>
        public String OrgId
        {
            get { return this.ModifiedData.OrgId; }
            set { this.ModifiedData.OrgId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROJ_NAME" field.
        /// </summary>
        public String Name
        {
            get { return this.ModifiedData.Name; }
            set { this.ModifiedData.Name = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROJ_SELCO_SP_ID" field.
        /// </summary>
        public String SelcoSpId
        {
            get { return this.ModifiedData.SelcoSpId; }
            set { this.ModifiedData.SelcoSpId = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="CampaignModel" /> instances that reference this <see cref="ProjectModel" />.
        /// </summary>
        public LocalCollection<LocalCampaignModel, ICampaignModel> CampaignProject
        {
            get
            {
                if (_campaignProject == null)
                    _campaignProject = new LocalCollection<LocalCampaignModel, ICampaignModel>(this.Provider.Marketing.Campaign.FetchAllByProjectId(this.Id));
                
                return _campaignProject;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalProjectModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalProjectModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalProjectModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalProjectModel(LocalProvider provider, ProjectRecord record) : base(provider, record)
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
            if (_campaignProject != null)
                _campaignProject.Execute(obj => obj.ProjectId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets or sets the value of the "PROJ_STATUS" field.
        /// </summary>
        System.String IProjectModel.Status
        {
            get { return this.Status; }
            set { this.Status = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROJ_ORG_ID" field.
        /// </summary>
        System.String IProjectModel.OrgId
        {
            get { return this.OrgId; }
            set { this.OrgId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROJ_NAME" field.
        /// </summary>
        System.String IProjectModel.Name
        {
            get { return this.Name; }
            set { this.Name = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROJ_SELCO_SP_ID" field.
        /// </summary>
        System.String IProjectModel.SelcoSpId
        {
            get { return this.SelcoSpId; }
            set { this.SelcoSpId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:CampaignModel" /> instances that reference this <see cref="!:ProjectModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Marketing.ICampaignModel> IProjectModel.CampaignProject
        {
            get { return this.CampaignProject; }
        }

        #endregion
    }
}
