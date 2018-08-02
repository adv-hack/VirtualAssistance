using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="EventModel" /> object.
    /// </summary>
    public partial class LocalEventFactory
    {
        /// <summary>
        ///     Retrieves a single <see cref='EventModel' /> instance.
        /// </summary>
        /// <param name="courseParentId">
        ///     The value which identifies the <see cref='EventModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='EventModel' /> instance that match the specified <paramref name='courseParentId' />.
        /// </returns>
        public LocalEventModel FetchByCourseParentId(String courseParentId)
        {
            CourseRecord record = this.Provider.DataProvider.Learning.Event.FetchByCourseParentId(courseParentId);
            LocalEventModel model = record == null ? null : new LocalEventModel(this.Provider, record);
            return model;
        }

        public void CalculateCourseNumbers(String courseId)
        {
            this.Provider.DataProvider.Learning.Event.CalculateCourseNumbers(courseId);
        }

        public void CalculateCourseStartEnd(String courseId)
        {
            this.Provider.DataProvider.Learning.Event.CalculateCourseStartEnd(courseId);
        }
    }
}
