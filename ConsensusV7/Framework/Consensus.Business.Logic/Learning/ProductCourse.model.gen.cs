using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;

namespace Consensus.Learning
{
    /// <summary>
    ///     Encapsulates the <see cref="ProductRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalProductCourseModel : LocalProductModel, IProductCourseModel
    {
        #region fields

        /// <summary>
        ///     The collection of <see cref="ProfileCoursesModel" /> instances that reference this <see cref="ProductCourseModel" />.
        /// </summary>
        private LocalCollection<LocalProfileCoursesModel, IProfileCoursesModel> _profileProductCourse;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ProductRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Learning.Product.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ProductRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Learning.Product.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<ProductRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Learning.Product.RemoveById; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ProfileCoursesModel" /> instances that reference this <see cref="ProductCourseModel" />.
        /// </summary>
        public LocalCollection<LocalProfileCoursesModel, IProfileCoursesModel> ProfileProductCourse
        {
            get
            {
                if (_profileProductCourse == null)
                    _profileProductCourse = new LocalCollection<LocalProfileCoursesModel, IProfileCoursesModel>(this.Provider.Common.ProfileCourses.FetchAllByCoursesId(this.Id));
                
                return _profileProductCourse;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalProductCourseModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalProductCourseModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalProductCourseModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalProductCourseModel(LocalProvider provider, ProductRecord record) : base(provider, record)
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
            if (_profileProductCourse != null)
                _profileProductCourse.Execute(obj => obj.CoursesId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the collection of <see cref="!:ProfileCoursesModel" /> instances that reference this <see cref="!:ProductCourseModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Common.IProfileCoursesModel> IProductCourseModel.ProfileProductCourse
        {
            get { return this.ProfileProductCourse; }
        }

        #endregion
    }
}
