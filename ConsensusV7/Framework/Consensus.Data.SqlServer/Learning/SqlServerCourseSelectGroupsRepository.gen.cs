using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="CourseselectgroupsRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerCourseSelectGroupsRepository : SqlServerRepository<CourseselectgroupsRecord, Int32>, ICourseSelectGroupsRepository
    {
        #region properties

        /// <summary>
        ///     Gets the namespace in which the data type is contained.
        /// </summary>
        protected override String TypeNamespace
        {
            get { return "Learning"; }
        }

        /// <summary>
        ///     Gets the name of the data type which is persisted by this repository.
        /// </summary>
        protected override String TypeName
        {
            get { return "Courseselectgroups"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="CourseselectgroupsRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_CSG_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "CourseSelectGroups"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="CourseselectgroupsRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="CourseselectgroupsRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, CourseselectgroupsRecord record)
        {
            record.Id = dataRecord["CSG_ID"].ConvertTo<Int32>();
            record.AddDate = dataRecord["CSG_ADD_DATE"].ConvertTo<DateTime>();
            record.AddBy = dataRecord["CSG_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["CSG_MOD_DATE"].ConvertTo<DateTime>();
            record.ModBy = dataRecord["CSG_MOD_BY"].ConvertTo<String>();
            record.PsgId = dataRecord["CSG_PSG_ID"].ConvertTo<Int32?>();
            record.EventId = dataRecord["CSG_COURSE_ID"].ConvertTo<String>();
            record.Type = dataRecord["CSG_TYPE"].ConvertTo<Byte>();
            record.Name = dataRecord["CSG_NAME"].ConvertTo<String>();
            record.Description = dataRecord["CSG_DESCRIPTION"].ConvertTo<String>();
            record.Min = dataRecord["CSG_MIN"].ConvertTo<Byte>();
            record.Max = dataRecord["CSG_MAX"].ConvertTo<Byte>();
            record.Order = dataRecord["CSG_ORDER"].ConvertTo<Byte>();
            record.ErrorMessage = dataRecord["CSG_ERROR_MESSAGE"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="CourseselectgroupsRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, CourseselectgroupsRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_CSG_ID", record.Id == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Id);
            this.MapParameterIn(command, "@PA_CSG_PSG_ID", record.PsgId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.PsgId);
            this.MapParameterIn(command, "@PA_CSG_COURSE_ID", record.EventId);
            this.MapParameterIn(command, "@PA_CSG_TYPE", record.Type);
            this.MapParameterIn(command, "@PA_CSG_NAME", record.Name);
            this.MapParameterIn(command, "@PA_CSG_DESCRIPTION", record.Description);
            this.MapParameterIn(command, "@PA_CSG_MIN", record.Min);
            this.MapParameterIn(command, "@PA_CSG_MAX", record.Max);
            this.MapParameterIn(command, "@PA_CSG_ORDER", record.Order);
            this.MapParameterIn(command, "@PA_CSG_ERROR_MESSAGE", record.ErrorMessage);
            this.MapParameterIn(command, "@_AUDIT_USER_ID", UserId);
            this.MapParameterIn(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Extracts the parameter values for the specified <paramref name="command" /> and applies the values to the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="CourseselectgroupsRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, CourseselectgroupsRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_CSG_ID", record.Id);
            record.PsgId = this.MapParameterOut(command, "@PA_CSG_PSG_ID", record.PsgId);
            record.EventId = this.MapParameterOut(command, "@PA_CSG_COURSE_ID", record.EventId);
            record.Type = this.MapParameterOut(command, "@PA_CSG_TYPE", record.Type);
            record.Name = this.MapParameterOut(command, "@PA_CSG_NAME", record.Name);
            record.Description = this.MapParameterOut(command, "@PA_CSG_DESCRIPTION", record.Description);
            record.Min = this.MapParameterOut(command, "@PA_CSG_MIN", record.Min);
            record.Max = this.MapParameterOut(command, "@PA_CSG_MAX", record.Max);
            record.Order = this.MapParameterOut(command, "@PA_CSG_ORDER", record.Order);
            record.ErrorMessage = this.MapParameterOut(command, "@PA_CSG_ERROR_MESSAGE", record.ErrorMessage);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="CourseselectgroupsRecord" /> instances from the data store.
        /// </summary>
        /// <param name="psgId">
        ///     The value which identifies the <see cref='CourseSelectGroupsModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="CourseselectgroupsRecord" /> instances that match the specified <paramref name='psgId' />.
        /// </returns>
        public IEnumerable<CourseselectgroupsRecord> FetchAllByPsgId(Int32? psgId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "PsgId");
            this.MapParameterIn(command, "@PA_CSG_PSG_ID", psgId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="CourseselectgroupsRecord" /> instances from the data store.
        /// </summary>
        /// <param name="eventId">
        ///     The value which identifies the <see cref='CourseSelectGroupsModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="CourseselectgroupsRecord" /> instances that match the specified <paramref name='eventId' />.
        /// </returns>
        public IEnumerable<CourseselectgroupsRecord> FetchAllByEventId(String eventId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "EventId");
            this.MapParameterIn(command, "@PA_CSG_COURSE_ID", eventId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String ICourseSelectGroupsRepository.TableName
        {
            get { return this.TableName; }
        }

        System.Collections.Generic.IEnumerable<Consensus.Learning.CourseselectgroupsRecord> ICourseSelectGroupsRepository.FetchAllByPsgId(System.Nullable<System.Int32> psgId)
        {
            return this.FetchAllByPsgId(psgId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.CourseselectgroupsRecord" /> instances from the data store.
        /// </summary>
        /// <param name="eventId">
        ///     The value which identifies the <see cref="!:CourseSelectGroupsModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.CourseselectgroupsRecord" /> instances that match the specified <paramref name="eventId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.CourseselectgroupsRecord> ICourseSelectGroupsRepository.FetchAllByEventId(System.String eventId)
        {
            return this.FetchAllByEventId(eventId);
        }

        #endregion
    }
}
