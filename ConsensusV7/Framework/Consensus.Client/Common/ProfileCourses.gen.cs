using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Learning;

namespace Consensus.Common
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class ProfileCourses : Proxy<IProfileCoursesModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Courses" /> member.
        /// </summary>
        private Consensus.Learning.ProductCourse _courses;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Status" /> member.
        /// </summary>
        private Consensus.Common.Code _status;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the The value of the "PROF_COURSE_ID" field.
        /// </summary>
        public Consensus.Learning.ProductCourse Courses
        {
            get
            {
                if (_courses == null && this.Model.Courses != null)
                    _courses = new Consensus.Learning.ProductCourse(this.Model.Courses);
                if (_courses == null)
                    _courses = Consensus.Learning.ProductCourse.Create();
                return _courses;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROF_COURSE_ID" field.
        /// </summary>
        public System.String CoursesId
        {
            get { return this.Model.CoursesId; }
            set { this.Model.CoursesId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROF_KEY" field.
        /// </summary>
        public System.String Key
        {
            get { return this.Model.Key; }
            set { this.Model.Key = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROF_VALUE" field.
        /// </summary>
        public System.String Value
        {
            get { return this.Model.Value; }
            set { this.Model.Value = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROF_NOTES" field.
        /// </summary>
        public System.String Notes
        {
            get { return this.Model.Notes; }
            set { this.Model.Notes = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROF_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> Date
        {
            get { return this.Model.Date; }
            set { this.Model.Date = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROF_VALUE3" field.
        /// </summary>
        public System.String Value3
        {
            get { return this.Model.Value3; }
            set { this.Model.Value3 = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROF_STATUS" field.
        /// </summary>
        public Consensus.Common.Code Status
        {
            get
            {
                if (_status == null && this.Model.Status != null)
                    _status = new Consensus.Common.Code(this.Model.Status);
                if (_status == null)
                    _status = Consensus.Common.Code.Create();
                return _status;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROF_STATUS" field.
        /// </summary>
        public System.String StatusCode
        {
            get { return this.Model.StatusCode; }
            set { this.Model.StatusCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROF_VALUE2" field.
        /// </summary>
        public System.String Value2
        {
            get { return this.Model.Value2; }
            set { this.Model.Value2 = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal ProfileCourses(IProfileCoursesModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:ProfileCoursesModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ProfileCoursesModel" /> instance.
        /// </returns>
        public static Consensus.Common.ProfileCourses Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProfileCourses.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:ProfileCoursesModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ProfileCoursesModel" /> instance.
        /// </returns>
        public static Consensus.Common.ProfileCourses Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Common.IProfileCoursesModel model = provider.Common.ProfileCourses.Create();
            return model == null ? null : new Consensus.Common.ProfileCourses(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ProfileCoursesModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ProfileCoursesModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Common.ProfileCourses> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProfileCourses.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ProfileCoursesModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ProfileCoursesModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Common.ProfileCourses> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Common.IProfileCoursesModel> collection = provider.Common.ProfileCourses.FetchAll();
            return collection.Select(model => new Consensus.Common.ProfileCourses(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ProfileCoursesModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ProfileCoursesModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProfileCoursesModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Common.ProfileCourses FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProfileCourses.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ProfileCoursesModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ProfileCoursesModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProfileCoursesModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Common.ProfileCourses FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Common.IProfileCoursesModel model = provider.Common.ProfileCourses.FetchById(id);
            return model == null ? null : new Consensus.Common.ProfileCourses(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProfileCourses.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Common.ProfileCourses.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProfileCoursesModel" /> instances.
        /// </summary>
        /// <param name="coursesId">
        ///     The value which identifies the <see cref="!:ProfileCoursesModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProfileCoursesModel" /> instances that match the specified <paramref name="coursesId" />.
        /// </returns>
        public static IEnumerable<Consensus.Common.ProfileCourses> FetchAllByCoursesId(System.String coursesId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProfileCourses.FetchAllByCoursesId(site,coursesId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProfileCoursesModel" /> instances.
        /// </summary>
        /// <param name="coursesId">
        ///     The value which identifies the <see cref="!:ProfileCoursesModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProfileCoursesModel" /> instances that match the specified <paramref name="coursesId" />.
        /// </returns>
        public static IEnumerable<Consensus.Common.ProfileCourses> FetchAllByCoursesId(ConsensusSite site, System.String coursesId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Common.IProfileCoursesModel> collection = provider.Common.ProfileCourses.FetchAllByCoursesId(coursesId);
            return collection.Select(model => new Consensus.Common.ProfileCourses(model));
        }

        #endregion
    }
}
