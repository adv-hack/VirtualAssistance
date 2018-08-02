using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
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
    public interface ICommonFactoryCollection : IFactoryCollection
    {
        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:CodeModel" /> objects.
        /// </summary>
        Consensus.Common.ICodeFactory Code
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:CodeHeaderModel" /> objects.
        /// </summary>
        Consensus.Common.ICodeHeaderFactory CodeHeader
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ProfileModel" /> objects.
        /// </summary>
        Consensus.Common.IProfileFactory Profile
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:SellingCompanyModel" /> objects.
        /// </summary>
        Consensus.Common.ISellingCompanyFactory SellingCompany
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:NotesModel" /> objects.
        /// </summary>
        Consensus.Common.INotesFactory Notes
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:SellingCompanyConfigModel" /> objects.
        /// </summary>
        Consensus.Common.ISellingCompanyConfigFactory SellingCompanyConfig
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:GenericModelModel" /> objects.
        /// </summary>
        Consensus.Common.IGenericModelFactory GenericModel
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:AttachmentModel" /> objects.
        /// </summary>
        Consensus.Common.IAttachmentFactory Attachment
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:AttachmentDataModel" /> objects.
        /// </summary>
        Consensus.Common.IAttachmentDataFactory AttachmentData
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:LearningZoneCategoriesModel" /> objects.
        /// </summary>
        Consensus.Common.ILearningZoneCategoriesFactory LearningZoneCategories
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:AttachLearningZoneCategoriesModel" /> objects.
        /// </summary>
        Consensus.Common.IAttachLearningZoneCategoriesFactory AttachLearningZoneCategories
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ViewLogModel" /> objects.
        /// </summary>
        Consensus.Common.IViewLogFactory ViewLog
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ProfileTrainerModel" /> objects.
        /// </summary>
        Consensus.Common.IProfileTrainerFactory ProfileTrainer
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ProfileVolunteerModel" /> objects.
        /// </summary>
        Consensus.Common.IProfileVolunteerFactory ProfileVolunteer
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:SysConfigModel" /> objects.
        /// </summary>
        Consensus.Common.ISysConfigFactory SysConfig
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ProfileOrganisationModel" /> objects.
        /// </summary>
        Consensus.Common.IProfileOrganisationFactory ProfileOrganisation
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ProfilePersonModel" /> objects.
        /// </summary>
        Consensus.Common.IProfilePersonFactory ProfilePerson
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ProfileProductModel" /> objects.
        /// </summary>
        Consensus.Common.IProfileProductFactory ProfileProduct
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ProfileCoursesModel" /> objects.
        /// </summary>
        Consensus.Common.IProfileCoursesFactory ProfileCourses
        {
            get;
        }
    }
}
