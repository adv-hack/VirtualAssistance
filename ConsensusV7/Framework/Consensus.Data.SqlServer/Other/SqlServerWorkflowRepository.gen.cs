using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Other
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="WorkflowRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerWorkflowRepository : SqlServerRepository<WorkflowRecord, String>, IWorkflowRepository
    {
        #region properties

        /// <summary>
        ///     Gets the namespace in which the data type is contained.
        /// </summary>
        protected override String TypeNamespace
        {
            get { return "Other"; }
        }

        /// <summary>
        ///     Gets the name of the data type which is persisted by this repository.
        /// </summary>
        protected override String TypeName
        {
            get { return "Workflow"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="WorkflowRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_WF_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Workflow"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="WorkflowRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="WorkflowRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, WorkflowRecord record)
        {
            record.Id = dataRecord["WF_ID"].ConvertTo<String>();
            record.Lock = dataRecord["WF_LOCK"].ConvertTo<String>();
            record.AddDate = dataRecord["WF_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["WF_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["WF_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["WF_MOD_BY"].ConvertTo<String>();
            record.RcvDate = dataRecord["WF_RCV_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["WF_RCV_FROM"].ConvertTo<String>();
            record.Name = dataRecord["WF_NAME"].ConvertTo<String>();
            record.Desc = dataRecord["WF_DESC"].ConvertTo<String>();
            record.RecType = dataRecord["WF_REC_TYPE"].ConvertTo<String>();
            record.AutoLink = dataRecord["WF_AUTO_LINK"].ConvertTo<Byte?>();
            record.FirstWfrId = dataRecord["WF_FIRST_WFR_ID"].ConvertTo<String>();
            record.Delay = dataRecord["WF_DELAY"].ConvertTo<Int32?>();
            record.Occurs = dataRecord["WF_OCCURS"].ConvertTo<Byte?>();
            record.DayOfWeek = dataRecord["WF_DAY_OF_WEEK"].ConvertTo<Byte?>();
            record.DailyFreq = dataRecord["WF_DAILY_FREQ"].ConvertTo<Byte?>();
            record.NormalTime = dataRecord["WF_NORMAL_TIME"].ConvertTo<DateTime?>();
            record.Frequency = dataRecord["WF_FREQUENCY"].ConvertTo<Int32?>();
            record.ValidFromDate = dataRecord["WF_VALID_FROM_DATE"].ConvertTo<DateTime?>();
            record.ValidToDate = dataRecord["WF_VALID_TO_DATE"].ConvertTo<DateTime?>();
            record.Disabled = dataRecord["WF_DISABLED"].ConvertTo<Byte?>();
            record.RunDatetime = dataRecord["WF_RUN_DATETIME"].ConvertTo<DateTime?>();
            record.LastRunDttime = dataRecord["WF_LAST_RUN_DTTIME"].ConvertTo<DateTime?>();
            record.CreatedByV1 = dataRecord["WF_CREATED_BY_V1"].ConvertTo<Boolean>();
            record.Group = dataRecord["WF_GROUP"].ConvertTo<String>();
            record.UniqueSysName = dataRecord["WF_UNIQUE_SYS_NAME"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="WorkflowRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, WorkflowRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_WF_ID", record.Id);
            this.MapParameterIn(command, "@PA_WF_LOCK", record.Lock);
            this.MapParameterIn(command, "@PA_WF_NAME", record.Name);
            this.MapParameterIn(command, "@PA_WF_DESC", record.Desc);
            this.MapParameterIn(command, "@PA_WF_REC_TYPE", record.RecType);
            this.MapParameterIn(command, "@PA_WF_AUTO_LINK", record.AutoLink);
            this.MapParameterIn(command, "@PA_WF_FIRST_WFR_ID", record.FirstWfrId);
            this.MapParameterIn(command, "@PA_WF_DELAY", record.Delay == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Delay);
            this.MapParameterIn(command, "@PA_WF_OCCURS", record.Occurs);
            this.MapParameterIn(command, "@PA_WF_DAY_OF_WEEK", record.DayOfWeek);
            this.MapParameterIn(command, "@PA_WF_DAILY_FREQ", record.DailyFreq);
            this.MapParameterIn(command, "@PA_WF_NORMAL_TIME", record.NormalTime == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.NormalTime);
            this.MapParameterIn(command, "@PA_WF_FREQUENCY", record.Frequency == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Frequency);
            this.MapParameterIn(command, "@PA_WF_VALID_FROM_DATE", record.ValidFromDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.ValidFromDate);
            this.MapParameterIn(command, "@PA_WF_VALID_TO_DATE", record.ValidToDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.ValidToDate);
            this.MapParameterIn(command, "@PA_WF_DISABLED", record.Disabled);
            this.MapParameterIn(command, "@PA_WF_RUN_DATETIME", record.RunDatetime == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.RunDatetime);
            this.MapParameterIn(command, "@PA_WF_LAST_RUN_DTTIME", record.LastRunDttime == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.LastRunDttime);
            this.MapParameterIn(command, "@PA_WF_CREATED_BY_V1", record.CreatedByV1);
            this.MapParameterIn(command, "@PA_WF_GROUP", record.Group);
            this.MapParameterIn(command, "@PA_WF_UNIQUE_SYS_NAME", record.UniqueSysName);
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
        ///     The <see cref="WorkflowRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, WorkflowRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_WF_ID", record.Id);
            record.Lock = this.MapParameterOut(command, "@PA_WF_LOCK", record.Lock);
            record.Name = this.MapParameterOut(command, "@PA_WF_NAME", record.Name);
            record.Desc = this.MapParameterOut(command, "@PA_WF_DESC", record.Desc);
            record.RecType = this.MapParameterOut(command, "@PA_WF_REC_TYPE", record.RecType);
            record.AutoLink = this.MapParameterOut(command, "@PA_WF_AUTO_LINK", record.AutoLink);
            record.FirstWfrId = this.MapParameterOut(command, "@PA_WF_FIRST_WFR_ID", record.FirstWfrId);
            record.Delay = this.MapParameterOut(command, "@PA_WF_DELAY", record.Delay);
            record.Occurs = this.MapParameterOut(command, "@PA_WF_OCCURS", record.Occurs);
            record.DayOfWeek = this.MapParameterOut(command, "@PA_WF_DAY_OF_WEEK", record.DayOfWeek);
            record.DailyFreq = this.MapParameterOut(command, "@PA_WF_DAILY_FREQ", record.DailyFreq);
            record.NormalTime = this.MapParameterOut(command, "@PA_WF_NORMAL_TIME", record.NormalTime);
            record.Frequency = this.MapParameterOut(command, "@PA_WF_FREQUENCY", record.Frequency);
            record.ValidFromDate = this.MapParameterOut(command, "@PA_WF_VALID_FROM_DATE", record.ValidFromDate);
            record.ValidToDate = this.MapParameterOut(command, "@PA_WF_VALID_TO_DATE", record.ValidToDate);
            record.Disabled = this.MapParameterOut(command, "@PA_WF_DISABLED", record.Disabled);
            record.RunDatetime = this.MapParameterOut(command, "@PA_WF_RUN_DATETIME", record.RunDatetime);
            record.LastRunDttime = this.MapParameterOut(command, "@PA_WF_LAST_RUN_DTTIME", record.LastRunDttime);
            record.CreatedByV1 = this.MapParameterOut(command, "@PA_WF_CREATED_BY_V1", record.CreatedByV1);
            record.Group = this.MapParameterOut(command, "@PA_WF_GROUP", record.Group);
            record.UniqueSysName = this.MapParameterOut(command, "@PA_WF_UNIQUE_SYS_NAME", record.UniqueSysName);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IWorkflowRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a single <typeparamref name="TRecord" /> instance from the data store.
        /// </summary>
        /// <param name="recType">
        ///     The unique value which distinctly identifies the <typeparamref name="TRecord" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <typeparamref name="TRecord" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Other.WorkflowRecord> IWorkflowRepository.FetchByRecType(System.String recType)
        {
            return this.FetchByRecType(recType);
        }

        #endregion
    }
}
