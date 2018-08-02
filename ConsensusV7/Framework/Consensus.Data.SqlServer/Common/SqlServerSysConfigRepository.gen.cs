using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="SysConfigRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerSysConfigRepository : SqlServerRepository<SysConfigRecord, Int32>, ISysConfigRepository
    {
        #region properties

        /// <summary>
        ///     Gets the namespace in which the data type is contained.
        /// </summary>
        protected override String TypeNamespace
        {
            get { return "Common"; }
        }

        /// <summary>
        ///     Gets the name of the data type which is persisted by this repository.
        /// </summary>
        protected override String TypeName
        {
            get { return "SysConfig"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="SysConfigRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_SC_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "SYS_CONFIG"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="SysConfigRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="SysConfigRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, SysConfigRecord record)
        {
            record.Id = dataRecord["SC_ID"].ConvertTo<Int32>();
            record.AddDate = dataRecord["SC_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["SC_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["SC_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["SC_MOD_BY"].ConvertTo<String>();
            record.RcvDate = dataRecord["SC_RCV_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["SC_RCV_FROM"].ConvertTo<String>();
            record.SpId = dataRecord["SC_SP_ID"].ConvertTo<String>();
            record.KeyName = dataRecord["SC_KEY_NAME"].ConvertTo<String>();
            record.ValueToUse = dataRecord["SC_VALUE_TO_USE"].ConvertTo<Byte?>();
            record.LabelName = dataRecord["SC_LABEL_NAME"].ConvertTo<String>();
            record.CharValue = dataRecord["SC_CHAR_VALUE"].ConvertTo<String>();
            record.RecordId = dataRecord["SC_RECORD_ID"].ConvertTo<String>();
            record.IntValue = dataRecord["SC_INT_VALUE"].ConvertTo<Int32?>();
            record.DatetimeValue = dataRecord["SC_DATETIME_VALUE"].ConvertTo<DateTime?>();
            record.DecimalValue = dataRecord["SC_DECIMAL_VALUE"].ConvertTo<Decimal?>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="SysConfigRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, SysConfigRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_SC_ID", record.Id == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Id);
            this.MapParameterIn(command, "@PA_SC_SP_ID", record.SpId);
            this.MapParameterIn(command, "@PA_SC_KEY_NAME", record.KeyName);
            this.MapParameterIn(command, "@PA_SC_VALUE_TO_USE", record.ValueToUse);
            this.MapParameterIn(command, "@PA_SC_LABEL_NAME", record.LabelName);
            this.MapParameterIn(command, "@PA_SC_CHAR_VALUE", record.CharValue);
            this.MapParameterIn(command, "@PA_SC_RECORD_ID", record.RecordId);
            this.MapParameterIn(command, "@PA_SC_INT_VALUE", record.IntValue == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.IntValue);
            this.MapParameterIn(command, "@PA_SC_DATETIME_VALUE", record.DatetimeValue == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.DatetimeValue);
            this.MapParameterIn(command, "@PA_SC_DECIMAL_VALUE", record.DecimalValue == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.DecimalValue);
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
        ///     The <see cref="SysConfigRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, SysConfigRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_SC_ID", record.Id);
            record.SpId = this.MapParameterOut(command, "@PA_SC_SP_ID", record.SpId);
            record.KeyName = this.MapParameterOut(command, "@PA_SC_KEY_NAME", record.KeyName);
            record.ValueToUse = this.MapParameterOut(command, "@PA_SC_VALUE_TO_USE", record.ValueToUse);
            record.LabelName = this.MapParameterOut(command, "@PA_SC_LABEL_NAME", record.LabelName);
            record.CharValue = this.MapParameterOut(command, "@PA_SC_CHAR_VALUE", record.CharValue);
            record.RecordId = this.MapParameterOut(command, "@PA_SC_RECORD_ID", record.RecordId);
            record.IntValue = this.MapParameterOut(command, "@PA_SC_INT_VALUE", record.IntValue);
            record.DatetimeValue = this.MapParameterOut(command, "@PA_SC_DATETIME_VALUE", record.DatetimeValue);
            record.DecimalValue = this.MapParameterOut(command, "@PA_SC_DECIMAL_VALUE", record.DecimalValue);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="SysConfigRecord" /> instances from the data store.
        /// </summary>
        /// <param name="spId">
        ///     The value which identifies the <see cref='SysConfigModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="SysConfigRecord" /> instances that match the specified <paramref name='spId' />.
        /// </returns>
        public IEnumerable<SysConfigRecord> FetchAllBySpId(String spId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "SpId");
            this.MapParameterIn(command, "@PA_SC_SP_ID", spId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String ISysConfigRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Common.SysConfigRecord" /> instances from the data store.
        /// </summary>
        /// <param name="spId">
        ///     The value which identifies the <see cref="!:SysConfigModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Common.SysConfigRecord" /> instances that match the specified <paramref name="spId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.SysConfigRecord> ISysConfigRepository.FetchAllBySpId(System.String spId)
        {
            return this.FetchAllBySpId(spId);
        }

        #endregion
    }
}
