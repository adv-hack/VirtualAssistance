using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Learning;

namespace Consensus.Common
{
    /// <summary>
    ///     Encapsulates the <see cref="ProfileRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalProfileCoursesModel : LocalProfileModel, IProfileCoursesModel
    {
        #region fields

        /// <summary>
        ///     The value of the "PROF_COURSE_ID" field.
        /// </summary>
        private LocalProductCourseModel _courses;

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
        ///     Gets the The value of the "PROF_COURSE_ID" field.
        /// </summary>
        public LocalProductCourseModel Courses
        {
            get
            {
                if (_courses == null && this.CoursesId != null)
                    _courses = this.Provider.Learning.ProductCourse.FetchById(this.CoursesId);
                if (_courses == null)
                    _courses = this.Provider.Learning.ProductCourse.Create();
                
                return _courses;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROF_COURSE_ID" field.
        /// </summary>
        public String CoursesId
        {
            get { return this.ModifiedData.CourseId; }
            set
            {
                if (this.ModifiedData.CourseId != value)
                     _courses = null;
                this.ModifiedData.CourseId = value;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalProfileCoursesModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalProfileCoursesModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalProfileCoursesModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalProfileCoursesModel(LocalProvider provider, ProfileRecord record) : base(provider, record)
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
            if (_courses != null)
            {
                _courses.Save();
                this.ModifiedData.CourseId = _courses.Id == null && this.ModifiedData.CourseId != null ? "" : _courses.Id;
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
        ///     Gets the The value of the "PROF_COURSE_ID" field.
        /// </summary>
        Consensus.Learning.IProductCourseModel IProfileCoursesModel.Courses
        {
            get { return this.Courses; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROF_COURSE_ID" field.
        /// </summary>
        System.String IProfileCoursesModel.CoursesId
        {
            get { return this.CoursesId; }
            set { this.CoursesId = (System.String)value; }
        }

        #endregion
    }
}
