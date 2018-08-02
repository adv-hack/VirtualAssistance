using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="CourseRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    public partial class SqlServerEventRepository
    {
        public override void Modify(CourseRecord record)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spInsertUpdateEvent");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapParametersIn(command, record, true);
            this.Execute(command);
            this.MapParametersOut(command, record);
        }

        public override void Create(CourseRecord record)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spInsertUpdateEvent");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapParametersIn(command, record, true);
            this.Execute(command);
            this.MapParametersOut(command, record);
        }

        /// <summary>
        ///     Retrieves a single <see cref="CourseRecord" /> instance from the data store.
        /// </summary>
        /// <param name="courseParentId">
        ///     The value which identifies the <see cref='CourseRecord' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="CourseRecord" /> instance which matches the specified <paramref name="courseParentId"/>.
        /// </returns>
        public CourseRecord FetchByCourseParentId(String courseParentId)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spConsensusLearningCourseFetchByCourseParentid");
            this.MapParameterIn(command, "@PA_COURSE_PRODUCT_ID", courseParentId);
            return this.Execute(command).FirstOrDefault();
        }


        public void CalculateCourseNumbers(String courseId)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spCalculateCourseNumbers");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapParameterIn(command, "@PA_COURSE_ID", courseId);
            this.Execute(command);
        }

        public void CalculateCourseStartEnd(String courseId)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spCalculateCourseStartEnd");
            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapParameterIn(command, "@PA_COURSE_ID", courseId);
            this.Execute(command);
        }
    }
}
