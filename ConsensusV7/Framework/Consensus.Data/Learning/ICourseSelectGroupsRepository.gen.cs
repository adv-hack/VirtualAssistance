using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="CourseselectgroupsRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ICourseSelectGroupsRepository : IRepository<CourseselectgroupsRecord, Int32>
    {
        #region properties

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String TableName
        {
            get;
        }

        #endregion

        #region methods

        System.Collections.Generic.IEnumerable<Consensus.Learning.CourseselectgroupsRecord> FetchAllByPsgId(System.Nullable<System.Int32> psgId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.CourseselectgroupsRecord" /> instances from the data store.
        /// </summary>
        /// <param name="eventId">
        ///     The value which identifies the <see cref="!:CourseSelectGroupsModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.CourseselectgroupsRecord" /> instances that match the specified <paramref name="eventId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.CourseselectgroupsRecord> FetchAllByEventId(System.String eventId);

        #endregion
    }
}
