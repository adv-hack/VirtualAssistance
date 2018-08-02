using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Represents a collection of factory instances which are responsible for the instantiation of the business models in the Common namespace.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalCommonFactoryCollection : LocalFactoryCollection, ICommonFactoryCollection
    {
        #region fields

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="CodeModel" /> objects.
        /// </summary>
        private LocalCodeFactory _code;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="CodeHeaderModel" /> objects.
        /// </summary>
        private LocalCodeHeaderFactory _codeHeader;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="ProfileModel" /> objects.
        /// </summary>
        private LocalProfileFactory _profile;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="SellingCompanyModel" /> objects.
        /// </summary>
        private LocalSellingCompanyFactory _sellingCompany;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="NotesModel" /> objects.
        /// </summary>
        private LocalNotesFactory _notes;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="SellingCompanyConfigModel" /> objects.
        /// </summary>
        private LocalSellingCompanyConfigFactory _sellingCompanyConfig;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="GenericModelModel" /> objects.
        /// </summary>
        private LocalGenericModelFactory _genericModel;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="AttachmentModel" /> objects.
        /// </summary>
        private LocalAttachmentFactory _attachment;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="AttachmentDataModel" /> objects.
        /// </summary>
        private LocalAttachmentDataFactory _attachmentData;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="LearningZoneCategoriesModel" /> objects.
        /// </summary>
        private LocalLearningZoneCategoriesFactory _learningZoneCategories;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="AttachLearningZoneCategoriesModel" /> objects.
        /// </summary>
        private LocalAttachLearningZoneCategoriesFactory _attachLearningZoneCategories;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="ViewLogModel" /> objects.
        /// </summary>
        private LocalViewLogFactory _viewLog;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="ProfileTrainerModel" /> objects.
        /// </summary>
        private LocalProfileTrainerFactory _profileTrainer;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="ProfileVolunteerModel" /> objects.
        /// </summary>
        private LocalProfileVolunteerFactory _profileVolunteer;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="SysConfigModel" /> objects.
        /// </summary>
        private LocalSysConfigFactory _sysConfig;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="ProfileOrganisationModel" /> objects.
        /// </summary>
        private LocalProfileOrganisationFactory _profileOrganisation;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="ProfilePersonModel" /> objects.
        /// </summary>
        private LocalProfilePersonFactory _profilePerson;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="ProfileProductModel" /> objects.
        /// </summary>
        private LocalProfileProductFactory _profileProduct;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="ProfileCoursesModel" /> objects.
        /// </summary>
        private LocalProfileCoursesFactory _profileCourses;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="CodeModel" /> objects.
        /// </summary>
        public LocalCodeFactory Code
        {
            get { return LocalFactory.Create(this.Provider, ref _code); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="CodeHeaderModel" /> objects.
        /// </summary>
        public LocalCodeHeaderFactory CodeHeader
        {
            get { return LocalFactory.Create(this.Provider, ref _codeHeader); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="ProfileModel" /> objects.
        /// </summary>
        public LocalProfileFactory Profile
        {
            get { return LocalFactory.Create(this.Provider, ref _profile); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="SellingCompanyModel" /> objects.
        /// </summary>
        public LocalSellingCompanyFactory SellingCompany
        {
            get { return LocalFactory.Create(this.Provider, ref _sellingCompany); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="NotesModel" /> objects.
        /// </summary>
        public LocalNotesFactory Notes
        {
            get { return LocalFactory.Create(this.Provider, ref _notes); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="SellingCompanyConfigModel" /> objects.
        /// </summary>
        public LocalSellingCompanyConfigFactory SellingCompanyConfig
        {
            get { return LocalFactory.Create(this.Provider, ref _sellingCompanyConfig); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="GenericModelModel" /> objects.
        /// </summary>
        public LocalGenericModelFactory GenericModel
        {
            get { return LocalFactory.Create(this.Provider, ref _genericModel); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="AttachmentModel" /> objects.
        /// </summary>
        public LocalAttachmentFactory Attachment
        {
            get { return LocalFactory.Create(this.Provider, ref _attachment); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="AttachmentDataModel" /> objects.
        /// </summary>
        public LocalAttachmentDataFactory AttachmentData
        {
            get { return LocalFactory.Create(this.Provider, ref _attachmentData); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="LearningZoneCategoriesModel" /> objects.
        /// </summary>
        public LocalLearningZoneCategoriesFactory LearningZoneCategories
        {
            get { return LocalFactory.Create(this.Provider, ref _learningZoneCategories); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="AttachLearningZoneCategoriesModel" /> objects.
        /// </summary>
        public LocalAttachLearningZoneCategoriesFactory AttachLearningZoneCategories
        {
            get { return LocalFactory.Create(this.Provider, ref _attachLearningZoneCategories); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="ViewLogModel" /> objects.
        /// </summary>
        public LocalViewLogFactory ViewLog
        {
            get { return LocalFactory.Create(this.Provider, ref _viewLog); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="ProfileTrainerModel" /> objects.
        /// </summary>
        public LocalProfileTrainerFactory ProfileTrainer
        {
            get { return LocalFactory.Create(this.Provider, ref _profileTrainer); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="ProfileVolunteerModel" /> objects.
        /// </summary>
        public LocalProfileVolunteerFactory ProfileVolunteer
        {
            get { return LocalFactory.Create(this.Provider, ref _profileVolunteer); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="SysConfigModel" /> objects.
        /// </summary>
        public LocalSysConfigFactory SysConfig
        {
            get { return LocalFactory.Create(this.Provider, ref _sysConfig); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="ProfileOrganisationModel" /> objects.
        /// </summary>
        public LocalProfileOrganisationFactory ProfileOrganisation
        {
            get { return LocalFactory.Create(this.Provider, ref _profileOrganisation); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="ProfilePersonModel" /> objects.
        /// </summary>
        public LocalProfilePersonFactory ProfilePerson
        {
            get { return LocalFactory.Create(this.Provider, ref _profilePerson); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="ProfileProductModel" /> objects.
        /// </summary>
        public LocalProfileProductFactory ProfileProduct
        {
            get { return LocalFactory.Create(this.Provider, ref _profileProduct); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="ProfileCoursesModel" /> objects.
        /// </summary>
        public LocalProfileCoursesFactory ProfileCourses
        {
            get { return LocalFactory.Create(this.Provider, ref _profileCourses); }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:CodeModel" /> objects.
        /// </summary>
        Consensus.Common.ICodeFactory ICommonFactoryCollection.Code
        {
            get { return this.Code; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:CodeHeaderModel" /> objects.
        /// </summary>
        Consensus.Common.ICodeHeaderFactory ICommonFactoryCollection.CodeHeader
        {
            get { return this.CodeHeader; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ProfileModel" /> objects.
        /// </summary>
        Consensus.Common.IProfileFactory ICommonFactoryCollection.Profile
        {
            get { return this.Profile; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:SellingCompanyModel" /> objects.
        /// </summary>
        Consensus.Common.ISellingCompanyFactory ICommonFactoryCollection.SellingCompany
        {
            get { return this.SellingCompany; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:NotesModel" /> objects.
        /// </summary>
        Consensus.Common.INotesFactory ICommonFactoryCollection.Notes
        {
            get { return this.Notes; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:SellingCompanyConfigModel" /> objects.
        /// </summary>
        Consensus.Common.ISellingCompanyConfigFactory ICommonFactoryCollection.SellingCompanyConfig
        {
            get { return this.SellingCompanyConfig; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:GenericModelModel" /> objects.
        /// </summary>
        Consensus.Common.IGenericModelFactory ICommonFactoryCollection.GenericModel
        {
            get { return this.GenericModel; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:AttachmentModel" /> objects.
        /// </summary>
        Consensus.Common.IAttachmentFactory ICommonFactoryCollection.Attachment
        {
            get { return this.Attachment; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:AttachmentDataModel" /> objects.
        /// </summary>
        Consensus.Common.IAttachmentDataFactory ICommonFactoryCollection.AttachmentData
        {
            get { return this.AttachmentData; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:LearningZoneCategoriesModel" /> objects.
        /// </summary>
        Consensus.Common.ILearningZoneCategoriesFactory ICommonFactoryCollection.LearningZoneCategories
        {
            get { return this.LearningZoneCategories; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:AttachLearningZoneCategoriesModel" /> objects.
        /// </summary>
        Consensus.Common.IAttachLearningZoneCategoriesFactory ICommonFactoryCollection.AttachLearningZoneCategories
        {
            get { return this.AttachLearningZoneCategories; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ViewLogModel" /> objects.
        /// </summary>
        Consensus.Common.IViewLogFactory ICommonFactoryCollection.ViewLog
        {
            get { return this.ViewLog; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ProfileTrainerModel" /> objects.
        /// </summary>
        Consensus.Common.IProfileTrainerFactory ICommonFactoryCollection.ProfileTrainer
        {
            get { return this.ProfileTrainer; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ProfileVolunteerModel" /> objects.
        /// </summary>
        Consensus.Common.IProfileVolunteerFactory ICommonFactoryCollection.ProfileVolunteer
        {
            get { return this.ProfileVolunteer; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:SysConfigModel" /> objects.
        /// </summary>
        Consensus.Common.ISysConfigFactory ICommonFactoryCollection.SysConfig
        {
            get { return this.SysConfig; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ProfileOrganisationModel" /> objects.
        /// </summary>
        Consensus.Common.IProfileOrganisationFactory ICommonFactoryCollection.ProfileOrganisation
        {
            get { return this.ProfileOrganisation; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ProfilePersonModel" /> objects.
        /// </summary>
        Consensus.Common.IProfilePersonFactory ICommonFactoryCollection.ProfilePerson
        {
            get { return this.ProfilePerson; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ProfileProductModel" /> objects.
        /// </summary>
        Consensus.Common.IProfileProductFactory ICommonFactoryCollection.ProfileProduct
        {
            get { return this.ProfileProduct; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ProfileCoursesModel" /> objects.
        /// </summary>
        Consensus.Common.IProfileCoursesFactory ICommonFactoryCollection.ProfileCourses
        {
            get { return this.ProfileCourses; }
        }

        #endregion
    }
}
