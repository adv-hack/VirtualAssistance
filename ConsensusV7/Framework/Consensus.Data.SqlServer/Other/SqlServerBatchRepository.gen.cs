using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Other
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="BatchRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerBatchRepository : SqlServerRepository<BatchRecord, String>, IBatchRepository
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
            get { return "Batch"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="BatchRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_BAT_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Batch"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="BatchRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="BatchRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, BatchRecord record)
        {
            record.Id = dataRecord["BAT_ID"].ConvertTo<String>();
            record.Lock = dataRecord["BAT_LOCK"].ConvertTo<String>();
            record.AddDate = dataRecord["BAT_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["BAT_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["BAT_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["BAT_MOD_BY"].ConvertTo<String>();
            record.RcvDate = dataRecord["BAT_RCV_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["BAT_RCV_FROM"].ConvertTo<String>();
            record.Type = dataRecord["BAT_TYPE"].ConvertTo<String>();
            record.Proc = dataRecord["BAT_PROC"].ConvertTo<String>();
            record.Status = dataRecord["BAT_STATUS"].ConvertTo<String>();
            record.Path = dataRecord["BAT_PATH"].ConvertTo<String>();
            record.Select = dataRecord["BAT_SELECT"].ConvertTo<String>();
            record.Count = dataRecord["BAT_COUNT"].ConvertTo<Int32?>();
            record.StartDT = dataRecord["BAT_START_D_T"].ConvertTo<DateTime?>();
            record.RunDT = dataRecord["BAT_RUN_D_T"].ConvertTo<DateTime?>();
            record.RunBy = dataRecord["BAT_RUN_BY"].ConvertTo<String>();
            record.Note = dataRecord["BAT_NOTE"].ConvertTo<String>();
            record.CrtNextBatch = dataRecord["BAT_CRT_NEXT_BATCH"].ConvertTo<Byte?>();
            record.DelayNxtBtch = dataRecord["BAT_DELAY_NXT_BTCH"].ConvertTo<Double?>();
            record.RunDate = dataRecord["BAT_RUN_DATE"].ConvertTo<DateTime?>();
            record.SelcoSpId = dataRecord["BAT_SELCO_SP_ID"].ConvertTo<String>();
            record.Proc1 = dataRecord["BAT_PROC1"].ConvertTo<String>();
            record.LastDate = dataRecord["BAT_LAST_DATE"].ConvertTo<DateTime?>();
            record.ErrorNote = dataRecord["BAT_ERROR_NOTE"].ConvertTo<String>();
            record.ExtFlag = dataRecord["BAT_EXT_FLAG"].ConvertTo<Byte?>();
            record.DdStatus = dataRecord["BAT_DD_STATUS"].ConvertTo<Byte?>();
            record.RecId = dataRecord["BAT_REC_ID"].ConvertTo<String>();
            record.Opt1 = dataRecord["BAT_OPT_1"].ConvertTo<Byte?>();
            record.Opt2 = dataRecord["BAT_OPT_2"].ConvertTo<Byte?>();
            record.Opt3 = dataRecord["BAT_OPT_3"].ConvertTo<Byte?>();
            record.Opt4 = dataRecord["BAT_OPT_4"].ConvertTo<Byte?>();
            record.ExtFile1 = dataRecord["BAT_EXT_FILE_1"].ConvertTo<String>();
            record.UserTint1 = dataRecord["BAT_USER_TINT_1"].ConvertTo<Byte?>();
            record.FromDate = dataRecord["BAT_FROM_DATE"].ConvertTo<DateTime?>();
            record.ToDate = dataRecord["BAT_TO_DATE"].ConvertTo<DateTime?>();
            record.ExtDate = dataRecord["BAT_EXT_DATE"].ConvertTo<DateTime?>();
            record.ExtRef = dataRecord["BAT_EXT_REF"].ConvertTo<String>();
            record.Rerun = dataRecord["BAT_RERUN"].ConvertTo<Byte>();
            record.EcId = dataRecord["BAT_EC_ID"].ConvertTo<Int32?>();
            record.ArgId = dataRecord["BAT_ARG_ID"].ConvertTo<String>();
            record.DiId = dataRecord["BAT_DI_ID"].ConvertTo<Int32?>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="BatchRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, BatchRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_BAT_ID", record.Id);
            this.MapParameterIn(command, "@PA_BAT_LOCK", record.Lock);
            this.MapParameterIn(command, "@PA_BAT_TYPE", record.Type);
            this.MapParameterIn(command, "@PA_BAT_PROC", record.Proc);
            this.MapParameterIn(command, "@PA_BAT_STATUS", record.Status);
            this.MapParameterIn(command, "@PA_BAT_PATH", record.Path);
            this.MapParameterIn(command, "@PA_BAT_SELECT", record.Select);
            this.MapParameterIn(command, "@PA_BAT_COUNT", record.Count == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Count);
            this.MapParameterIn(command, "@PA_BAT_START_D_T", record.StartDT == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.StartDT);
            this.MapParameterIn(command, "@PA_BAT_RUN_D_T", record.RunDT == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.RunDT);
            this.MapParameterIn(command, "@PA_BAT_RUN_BY", record.RunBy);
            this.MapParameterIn(command, "@PA_BAT_NOTE", record.Note);
            this.MapParameterIn(command, "@PA_BAT_CRT_NEXT_BATCH", record.CrtNextBatch);
            this.MapParameterIn(command, "@PA_BAT_DELAY_NXT_BTCH", record.DelayNxtBtch == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.DelayNxtBtch);
            this.MapParameterIn(command, "@PA_BAT_RUN_DATE", record.RunDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.RunDate);
            this.MapParameterIn(command, "@PA_BAT_SELCO_SP_ID", record.SelcoSpId);
            this.MapParameterIn(command, "@PA_BAT_PROC1", record.Proc1);
            this.MapParameterIn(command, "@PA_BAT_LAST_DATE", record.LastDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.LastDate);
            this.MapParameterIn(command, "@PA_BAT_ERROR_NOTE", record.ErrorNote);
            this.MapParameterIn(command, "@PA_BAT_EXT_FLAG", record.ExtFlag);
            this.MapParameterIn(command, "@PA_BAT_DD_STATUS", record.DdStatus);
            this.MapParameterIn(command, "@PA_BAT_REC_ID", record.RecId);
            this.MapParameterIn(command, "@PA_BAT_OPT_1", record.Opt1);
            this.MapParameterIn(command, "@PA_BAT_OPT_2", record.Opt2);
            this.MapParameterIn(command, "@PA_BAT_OPT_3", record.Opt3);
            this.MapParameterIn(command, "@PA_BAT_OPT_4", record.Opt4);
            this.MapParameterIn(command, "@PA_BAT_EXT_FILE_1", record.ExtFile1);
            this.MapParameterIn(command, "@PA_BAT_USER_TINT_1", record.UserTint1);
            this.MapParameterIn(command, "@PA_BAT_FROM_DATE", record.FromDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.FromDate);
            this.MapParameterIn(command, "@PA_BAT_TO_DATE", record.ToDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.ToDate);
            this.MapParameterIn(command, "@PA_BAT_EXT_DATE", record.ExtDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.ExtDate);
            this.MapParameterIn(command, "@PA_BAT_EXT_REF", record.ExtRef);
            this.MapParameterIn(command, "@PA_BAT_RERUN", record.Rerun);
            this.MapParameterIn(command, "@PA_BAT_EC_ID", record.EcId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.EcId);
            this.MapParameterIn(command, "@PA_BAT_ARG_ID", record.ArgId);
            this.MapParameterIn(command, "@PA_BAT_DI_ID", record.DiId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.DiId);
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
        ///     The <see cref="BatchRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, BatchRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_BAT_ID", record.Id);
            record.Lock = this.MapParameterOut(command, "@PA_BAT_LOCK", record.Lock);
            record.Type = this.MapParameterOut(command, "@PA_BAT_TYPE", record.Type);
            record.Proc = this.MapParameterOut(command, "@PA_BAT_PROC", record.Proc);
            record.Status = this.MapParameterOut(command, "@PA_BAT_STATUS", record.Status);
            record.Path = this.MapParameterOut(command, "@PA_BAT_PATH", record.Path);
            record.Select = this.MapParameterOut(command, "@PA_BAT_SELECT", record.Select);
            record.Count = this.MapParameterOut(command, "@PA_BAT_COUNT", record.Count);
            record.StartDT = this.MapParameterOut(command, "@PA_BAT_START_D_T", record.StartDT);
            record.RunDT = this.MapParameterOut(command, "@PA_BAT_RUN_D_T", record.RunDT);
            record.RunBy = this.MapParameterOut(command, "@PA_BAT_RUN_BY", record.RunBy);
            record.Note = this.MapParameterOut(command, "@PA_BAT_NOTE", record.Note);
            record.CrtNextBatch = this.MapParameterOut(command, "@PA_BAT_CRT_NEXT_BATCH", record.CrtNextBatch);
            record.DelayNxtBtch = this.MapParameterOut(command, "@PA_BAT_DELAY_NXT_BTCH", record.DelayNxtBtch);
            record.RunDate = this.MapParameterOut(command, "@PA_BAT_RUN_DATE", record.RunDate);
            record.SelcoSpId = this.MapParameterOut(command, "@PA_BAT_SELCO_SP_ID", record.SelcoSpId);
            record.Proc1 = this.MapParameterOut(command, "@PA_BAT_PROC1", record.Proc1);
            record.LastDate = this.MapParameterOut(command, "@PA_BAT_LAST_DATE", record.LastDate);
            record.ErrorNote = this.MapParameterOut(command, "@PA_BAT_ERROR_NOTE", record.ErrorNote);
            record.ExtFlag = this.MapParameterOut(command, "@PA_BAT_EXT_FLAG", record.ExtFlag);
            record.DdStatus = this.MapParameterOut(command, "@PA_BAT_DD_STATUS", record.DdStatus);
            record.RecId = this.MapParameterOut(command, "@PA_BAT_REC_ID", record.RecId);
            record.Opt1 = this.MapParameterOut(command, "@PA_BAT_OPT_1", record.Opt1);
            record.Opt2 = this.MapParameterOut(command, "@PA_BAT_OPT_2", record.Opt2);
            record.Opt3 = this.MapParameterOut(command, "@PA_BAT_OPT_3", record.Opt3);
            record.Opt4 = this.MapParameterOut(command, "@PA_BAT_OPT_4", record.Opt4);
            record.ExtFile1 = this.MapParameterOut(command, "@PA_BAT_EXT_FILE_1", record.ExtFile1);
            record.UserTint1 = this.MapParameterOut(command, "@PA_BAT_USER_TINT_1", record.UserTint1);
            record.FromDate = this.MapParameterOut(command, "@PA_BAT_FROM_DATE", record.FromDate);
            record.ToDate = this.MapParameterOut(command, "@PA_BAT_TO_DATE", record.ToDate);
            record.ExtDate = this.MapParameterOut(command, "@PA_BAT_EXT_DATE", record.ExtDate);
            record.ExtRef = this.MapParameterOut(command, "@PA_BAT_EXT_REF", record.ExtRef);
            record.Rerun = this.MapParameterOut(command, "@PA_BAT_RERUN", record.Rerun);
            record.EcId = this.MapParameterOut(command, "@PA_BAT_EC_ID", record.EcId);
            record.ArgId = this.MapParameterOut(command, "@PA_BAT_ARG_ID", record.ArgId);
            record.DiId = this.MapParameterOut(command, "@PA_BAT_DI_ID", record.DiId);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="BatchRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref='BatchModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="BatchRecord" /> instances that match the specified <paramref name='selcoSpId' />.
        /// </returns>
        public IEnumerable<BatchRecord> FetchAllBySelcoSpId(String selcoSpId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "SelcoSpId");
            this.MapParameterIn(command, "@PA_BAT_SELCO_SP_ID", selcoSpId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="BatchRecord" /> instances from the data store.
        /// </summary>
        /// <param name="ecId">
        ///     The value which identifies the <see cref='BatchModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="BatchRecord" /> instances that match the specified <paramref name='ecId' />.
        /// </returns>
        public IEnumerable<BatchRecord> FetchAllByEcId(Int32? ecId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "EcId");
            this.MapParameterIn(command, "@PA_BAT_EC_ID", ecId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="BatchRecord" /> instances from the data store.
        /// </summary>
        /// <param name="diId">
        ///     The value which identifies the <see cref='BatchModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="BatchRecord" /> instances that match the specified <paramref name='diId' />.
        /// </returns>
        public IEnumerable<BatchRecord> FetchAllByDiId(Int32? diId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "DiId");
            this.MapParameterIn(command, "@PA_BAT_DI_ID", diId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IBatchRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Other.BatchRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref="!:BatchModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Other.BatchRecord" /> instances that match the specified <paramref name="selcoSpId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Other.BatchRecord> IBatchRepository.FetchAllBySelcoSpId(System.String selcoSpId)
        {
            return this.FetchAllBySelcoSpId(selcoSpId);
        }

        System.Collections.Generic.IEnumerable<Consensus.Other.BatchRecord> IBatchRepository.FetchAllByEcId(System.Nullable<System.Int32> ecId)
        {
            return this.FetchAllByEcId(ecId);
        }

        System.Collections.Generic.IEnumerable<Consensus.Other.BatchRecord> IBatchRepository.FetchAllByDiId(System.Nullable<System.Int32> diId)
        {
            return this.FetchAllByDiId(diId);
        }

        #endregion
    }
}
