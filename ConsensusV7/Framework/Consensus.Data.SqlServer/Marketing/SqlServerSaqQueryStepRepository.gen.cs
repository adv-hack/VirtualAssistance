using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="SaqQueryStepsRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerSaqQueryStepRepository : SqlServerRepository<SaqQueryStepsRecord, Int32>, ISaqQueryStepRepository
    {
        #region properties

        /// <summary>
        ///     Gets the namespace in which the data type is contained.
        /// </summary>
        protected override String TypeNamespace
        {
            get { return "Marketing"; }
        }

        /// <summary>
        ///     Gets the name of the data type which is persisted by this repository.
        /// </summary>
        protected override String TypeName
        {
            get { return "SaqQuerySteps"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="SaqQueryStepsRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_QSTEP_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "SAQ_QUERY_STEPS"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="SaqQueryStepsRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="SaqQueryStepsRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, SaqQueryStepsRecord record)
        {
            record.Id = dataRecord["QSTEP_ID"].ConvertTo<Int32>();
            record.AddBy = dataRecord["QSTEP_ADD_BY"].ConvertTo<String>();
            record.AddDate = dataRecord["QSTEP_ADD_DATE"].ConvertTo<DateTime>();
            record.ModBy = dataRecord["QSTEP_MOD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["QSTEP_MOD_DATE"].ConvertTo<DateTime>();
            record.QryId = dataRecord["QSTEP_QRY_ID"].ConvertTo<Int64>();
            record.StepId = dataRecord["QSTEP_STEP_ID"].ConvertTo<Int64>();
            record.Link = dataRecord["QSTEP_LINK"].ConvertTo<String>();
            record.Order = dataRecord["QSTEP_ORDER"].ConvertTo<Int16>();
            record.ResultCount = dataRecord["QSTEP_RESULT_COUNT"].ConvertTo<Int64>();
            record.OrgTotal = dataRecord["QSTEP_ORG_TOTAL"].ConvertTo<Int64>();
            record.RoleTotal = dataRecord["QSTEP_ROLE_TOTAL"].ConvertTo<Int64>();
            record.PersonTotal = dataRecord["QSTEP_PERSON_TOTAL"].ConvertTo<Int64>();
            record.RunTime = dataRecord["QSTEP_RUN_TIME"].ConvertTo<DateTime?>();
            record.LinkChange = dataRecord["QSTEP_LINK_CHANGE"].ConvertTo<Int64?>();
            record.SchedRunDate = dataRecord["QSTEP_SCHED_RUN_DATE"].ConvertTo<DateTime?>();
            record.SchedRunTime = dataRecord["QSTEP_SCHED_RUN_TIME"].ConvertTo<DateTime?>();
            record.CalculatedDate = dataRecord["QSTEP_CALCULATED_DATE"].ConvertTo<DateTime?>();
            record.OutputDate = dataRecord["QSTEP_OUTPUT_DATE"].ConvertTo<DateTime?>();
            record.Locked = dataRecord["QSTEP_LOCKED"].ConvertTo<Byte>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="SaqQueryStepsRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, SaqQueryStepsRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_QSTEP_ID", record.Id == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Id);
            this.MapParameterIn(command, "@PA_QSTEP_QRY_ID", record.QryId == Int64.MinValue ? ( useV6Logic ? new Int64?(0) : null ) : record.QryId);
            this.MapParameterIn(command, "@PA_QSTEP_STEP_ID", record.StepId == Int64.MinValue ? ( useV6Logic ? new Int64?(0) : null ) : record.StepId);
            this.MapParameterIn(command, "@PA_QSTEP_LINK", record.Link);
            this.MapParameterIn(command, "@PA_QSTEP_ORDER", record.Order == Int16.MinValue ? 0 : record.Order);
            this.MapParameterIn(command, "@PA_QSTEP_RESULT_COUNT", record.ResultCount == Int64.MinValue ? 0 : record.ResultCount);
            this.MapParameterIn(command, "@PA_QSTEP_ORG_TOTAL", record.OrgTotal == Int64.MinValue ? 0 : record.OrgTotal);
            this.MapParameterIn(command, "@PA_QSTEP_ROLE_TOTAL", record.RoleTotal == Int64.MinValue ? 0 : record.RoleTotal);
            this.MapParameterIn(command, "@PA_QSTEP_PERSON_TOTAL", record.PersonTotal == Int64.MinValue ? 0 : record.PersonTotal);
            this.MapParameterIn(command, "@PA_QSTEP_RUN_TIME", record.RunTime == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.RunTime);
            this.MapParameterIn(command, "@PA_QSTEP_LINK_CHANGE", record.LinkChange == Int64.MinValue ? ( useV6Logic ? new Int64?(0) : null ) : record.LinkChange);
            this.MapParameterIn(command, "@PA_QSTEP_SCHED_RUN_DATE", record.SchedRunDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.SchedRunDate);
            this.MapParameterIn(command, "@PA_QSTEP_SCHED_RUN_TIME", record.SchedRunTime == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.SchedRunTime);
            this.MapParameterIn(command, "@PA_QSTEP_CALCULATED_DATE", record.CalculatedDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.CalculatedDate);
            this.MapParameterIn(command, "@PA_QSTEP_OUTPUT_DATE", record.OutputDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.OutputDate);
            this.MapParameterIn(command, "@PA_QSTEP_LOCKED", record.Locked);
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
        ///     The <see cref="SaqQueryStepsRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, SaqQueryStepsRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_QSTEP_ID", record.Id);
            record.QryId = this.MapParameterOut(command, "@PA_QSTEP_QRY_ID", record.QryId);
            record.StepId = this.MapParameterOut(command, "@PA_QSTEP_STEP_ID", record.StepId);
            record.Link = this.MapParameterOut(command, "@PA_QSTEP_LINK", record.Link);
            record.Order = this.MapParameterOut(command, "@PA_QSTEP_ORDER", record.Order);
            record.ResultCount = this.MapParameterOut(command, "@PA_QSTEP_RESULT_COUNT", record.ResultCount);
            record.OrgTotal = this.MapParameterOut(command, "@PA_QSTEP_ORG_TOTAL", record.OrgTotal);
            record.RoleTotal = this.MapParameterOut(command, "@PA_QSTEP_ROLE_TOTAL", record.RoleTotal);
            record.PersonTotal = this.MapParameterOut(command, "@PA_QSTEP_PERSON_TOTAL", record.PersonTotal);
            record.RunTime = this.MapParameterOut(command, "@PA_QSTEP_RUN_TIME", record.RunTime);
            record.LinkChange = this.MapParameterOut(command, "@PA_QSTEP_LINK_CHANGE", record.LinkChange);
            record.SchedRunDate = this.MapParameterOut(command, "@PA_QSTEP_SCHED_RUN_DATE", record.SchedRunDate);
            record.SchedRunTime = this.MapParameterOut(command, "@PA_QSTEP_SCHED_RUN_TIME", record.SchedRunTime);
            record.CalculatedDate = this.MapParameterOut(command, "@PA_QSTEP_CALCULATED_DATE", record.CalculatedDate);
            record.OutputDate = this.MapParameterOut(command, "@PA_QSTEP_OUTPUT_DATE", record.OutputDate);
            record.Locked = this.MapParameterOut(command, "@PA_QSTEP_LOCKED", record.Locked);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="SaqQueryStepsRecord" /> instances from the data store.
        /// </summary>
        /// <param name="qryId">
        ///     The value which identifies the <see cref='SaqQueryStepModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="SaqQueryStepsRecord" /> instances that match the specified <paramref name='qryId' />.
        /// </returns>
        public IEnumerable<SaqQueryStepsRecord> FetchAllByQryId(Int64 qryId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "QryId");
            this.MapParameterIn(command, "@PA_QSTEP_QRY_ID", qryId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="SaqQueryStepsRecord" /> instances from the data store.
        /// </summary>
        /// <param name="stepId">
        ///     The value which identifies the <see cref='SaqQueryStepModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="SaqQueryStepsRecord" /> instances that match the specified <paramref name='stepId' />.
        /// </returns>
        public IEnumerable<SaqQueryStepsRecord> FetchAllByStepId(Int64 stepId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "StepId");
            this.MapParameterIn(command, "@PA_QSTEP_STEP_ID", stepId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String ISaqQueryStepRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Marketing.SaqQueryStepsRecord" /> instances from the data store.
        /// </summary>
        /// <param name="qryId">
        ///     The value which identifies the <see cref="!:SaqQueryStepModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Marketing.SaqQueryStepsRecord" /> instances that match the specified <paramref name="qryId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.SaqQueryStepsRecord> ISaqQueryStepRepository.FetchAllByQryId(System.Int64 qryId)
        {
            return this.FetchAllByQryId(qryId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Marketing.SaqQueryStepsRecord" /> instances from the data store.
        /// </summary>
        /// <param name="stepId">
        ///     The value which identifies the <see cref="!:SaqQueryStepModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Marketing.SaqQueryStepsRecord" /> instances that match the specified <paramref name="stepId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.SaqQueryStepsRecord> ISaqQueryStepRepository.FetchAllByStepId(System.Int64 stepId)
        {
            return this.FetchAllByStepId(stepId);
        }

        #endregion
    }
}
