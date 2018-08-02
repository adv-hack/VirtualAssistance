using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Contact;
using Consensus.Marketing;

namespace Consensus.Common
{
    /// <summary>
    ///     Encapsulates the <see cref="ProfileRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalProfileOrganisationModel : LocalProfileModel, IProfileOrganisationModel
    {
        #region fields

        /// <summary>
        ///     The value of the "PROF_ORG_ID" field.
        /// </summary>
        private LocalOrganisationModel _organisation;

        /// <summary>
        ///     The collection of <see cref="SaqQueueModel" /> instances that reference this <see cref="ProfileOrganisationModel" />.
        /// </summary>
        private LocalCollection<LocalSaqQueueModel, ISaqQueueModel> _saqQueueProfileOrg;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ProfileRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Common.Profile.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ProfileRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Common.Profile.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<ProfileRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Common.Profile.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "PROF_ORG_ID" field.
        /// </summary>
        public LocalOrganisationModel Organisation
        {
            get
            {
                if (_organisation == null && this.OrganisationId != null)
                    _organisation = this.Provider.Contact.Organisation.FetchById(this.OrganisationId);
                if (_organisation == null)
                    _organisation = this.Provider.Contact.Organisation.Create();
                
                return _organisation;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROF_ORG_ID" field.
        /// </summary>
        public String OrganisationId
        {
            get { return this.ModifiedData.OrgId; }
            set
            {
                if (this.ModifiedData.OrgId != value)
                     _organisation = null;
                this.ModifiedData.OrgId = value;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="SaqQueueModel" /> instances that reference this <see cref="ProfileOrganisationModel" />.
        /// </summary>
        public LocalCollection<LocalSaqQueueModel, ISaqQueueModel> SaqQueueProfileOrg
        {
            get
            {
                if (_saqQueueProfileOrg == null)
                    _saqQueueProfileOrg = new LocalCollection<LocalSaqQueueModel, ISaqQueueModel>(this.Provider.Marketing.SaqQueue.FetchAllByProfileOrgId(this.Id));
                
                return _saqQueueProfileOrg;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalProfileOrganisationModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalProfileOrganisationModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalProfileOrganisationModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalProfileOrganisationModel(LocalProvider provider, ProfileRecord record) : base(provider, record)
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
            if (_organisation != null)
            {
                _organisation.Save();
                this.ModifiedData.OrgId = _organisation.Id == null && this.ModifiedData.OrgId != null ? "" : _organisation.Id;
            }
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
            if (_saqQueueProfileOrg != null)
                _saqQueueProfileOrg.Execute(obj => obj.ProfileOrgId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the The value of the "PROF_ORG_ID" field.
        /// </summary>
        Consensus.Contact.IOrganisationModel IProfileOrganisationModel.Organisation
        {
            get { return this.Organisation; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROF_ORG_ID" field.
        /// </summary>
        System.String IProfileOrganisationModel.OrganisationId
        {
            get { return this.OrganisationId; }
            set { this.OrganisationId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SaqQueueModel" /> instances that reference this <see cref="!:ProfileOrganisationModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Marketing.ISaqQueueModel> IProfileOrganisationModel.SaqQueueProfileOrg
        {
            get { return this.SaqQueueProfileOrg; }
        }

        #endregion
    }
}
