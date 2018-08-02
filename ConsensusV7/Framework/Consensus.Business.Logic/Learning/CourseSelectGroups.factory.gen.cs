using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="CourseSelectGroupsModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalCourseSelectGroupsFactory : LocalFactory<LocalCourseSelectGroupsModel, CourseselectgroupsRecord, Int32>, ICourseSelectGroupsFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='CourseSelectGroupsModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='CourseSelectGroupsModel' /> instance.
        /// </returns>
        public LocalCourseSelectGroupsModel Create()
        {
            return new LocalCourseSelectGroupsModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='CourseSelectGroupsModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='CourseSelectGroupsModel' /> instances.
        /// </returns>
        public IEnumerable<LocalCourseSelectGroupsModel> FetchAll()
        {
            IEnumerable<CourseselectgroupsRecord> recordCollection = this.Provider.DataProvider.Learning.CourseSelectGroups.FetchAll();
            foreach (CourseselectgroupsRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalCourseSelectGroupsModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='CourseSelectGroupsModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='CourseSelectGroupsModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='CourseSelectGroupsModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalCourseSelectGroupsModel FetchById(Int32 id)
        {
            CourseselectgroupsRecord record = this.Provider.DataProvider.Learning.CourseSelectGroups.FetchById(id);
            if (record == null)
                return null;
            return new LocalCourseSelectGroupsModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='CourseSelectGroups/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Learning.CourseSelectGroups.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='CourseSelectGroupsModel' /> instances.
        /// </summary>
        /// <param name="prodSelectionGroupId">
        ///     The value which identifies the <see cref='CourseSelectGroupsModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='CourseSelectGroupsModel' /> instances that match the specified <paramref name='prodSelectionGroupId' />.
        /// </returns>
        public IEnumerable<LocalCourseSelectGroupsModel> FetchAllByProdSelectionGroupId(Int32? prodSelectionGroupId)
        {
            IEnumerable<CourseselectgroupsRecord> recordCollection = this.Provider.DataProvider.Learning.CourseSelectGroups.FetchAllByPsgId(prodSelectionGroupId);
            foreach (CourseselectgroupsRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalCourseSelectGroupsModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='CourseSelectGroupsModel' /> instances.
        /// </summary>
        /// <param name="eventId">
        ///     The value which identifies the <see cref='CourseSelectGroupsModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='CourseSelectGroupsModel' /> instances that match the specified <paramref name='eventId' />.
        /// </returns>
        public IEnumerable<LocalCourseSelectGroupsModel> FetchAllByEventId(String eventId)
        {
            IEnumerable<CourseselectgroupsRecord> recordCollection = this.Provider.DataProvider.Learning.CourseSelectGroups.FetchAllByEventId(eventId);
            foreach (CourseselectgroupsRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalCourseSelectGroupsModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:CourseSelectGroupsModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:CourseSelectGroupsModel" /> instance.
        /// </returns>
        Consensus.Learning.ICourseSelectGroupsModel ICourseSelectGroupsFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:CourseSelectGroupsModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:CourseSelectGroupsModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ICourseSelectGroupsModel> ICourseSelectGroupsFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:CourseSelectGroupsModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:CourseSelectGroupsModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CourseSelectGroupsModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Learning.ICourseSelectGroupsModel ICourseSelectGroupsFactory.FetchById(System.Int32 id)
        {
            return this.FetchById(id);
        }

        System.String ICourseSelectGroupsFactory.GetTableName()
        {
            return this.GetTableName();
        }

        System.Collections.Generic.IEnumerable<Consensus.Learning.ICourseSelectGroupsModel> ICourseSelectGroupsFactory.FetchAllByProdSelectionGroupId(System.Nullable<System.Int32> prodSelectionGroupId)
        {
            return this.FetchAllByProdSelectionGroupId(prodSelectionGroupId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:CourseSelectGroupsModel" /> instances.
        /// </summary>
        /// <param name="eventId">
        ///     The value which identifies the <see cref="!:CourseSelectGroupsModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CourseSelectGroupsModel" /> instances that match the specified <paramref name="eventId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ICourseSelectGroupsModel> ICourseSelectGroupsFactory.FetchAllByEventId(System.String eventId)
        {
            return this.FetchAllByEventId(eventId);
        }

        #endregion
    }
}
