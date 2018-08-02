using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="ViewLogRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerViewLogRepository : SqlServerRepository<ViewLogRecord, Int32>, IViewLogRepository
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
            get { return "ViewLog"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="ViewLogRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_VIEW_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "VIEW_LOG"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="ViewLogRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="ViewLogRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, ViewLogRecord record)
        {
            record.Id = dataRecord["VIEW_ID"].ConvertTo<Int32>();
            record.AddDate = dataRecord["VIEW_ADD_DATE"].ConvertTo<DateTime>();
            record.AddBy = dataRecord["VIEW_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["VIEW_MOD_DATE"].ConvertTo<DateTime>();
            record.ModBy = dataRecord["VIEW_MOD_BY"].ConvertTo<String>();
            record.RcvDate = dataRecord["VIEW_RCV_DATE"].ConvertTo<DateTime>();
            record.RcvFrom = dataRecord["VIEW_RCV_FROM"].ConvertTo<String>();
            record.Table = dataRecord["VIEW_TABLE"].ConvertTo<String>();
            record.RecId = dataRecord["VIEW_REC_ID"].ConvertTo<String>();
            record.Source = dataRecord["VIEW_SOURCE"].ConvertTo<Byte>();
            record.Type = dataRecord["VIEW_TYPE"].ConvertTo<Byte>();
            record.RecId2 = dataRecord["VIEW_REC_ID2"].ConvertTo<String>();
            record.Table2 = dataRecord["VIEW_TABLE2"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="ViewLogRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, ViewLogRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_VIEW_ID", record.Id == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Id);
            this.MapParameterIn(command, "@PA_VIEW_TABLE", record.Table);
            this.MapParameterIn(command, "@PA_VIEW_REC_ID", record.RecId);
            this.MapParameterIn(command, "@PA_VIEW_SOURCE", record.Source);
            this.MapParameterIn(command, "@PA_VIEW_TYPE", record.Type);
            this.MapParameterIn(command, "@PA_VIEW_REC_ID2", record.RecId2);
            this.MapParameterIn(command, "@PA_VIEW_TABLE2", record.Table2);
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
        ///     The <see cref="ViewLogRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, ViewLogRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_VIEW_ID", record.Id);
            record.Table = this.MapParameterOut(command, "@PA_VIEW_TABLE", record.Table);
            record.RecId = this.MapParameterOut(command, "@PA_VIEW_REC_ID", record.RecId);
            record.Source = this.MapParameterOut(command, "@PA_VIEW_SOURCE", record.Source);
            record.Type = this.MapParameterOut(command, "@PA_VIEW_TYPE", record.Type);
            record.RecId2 = this.MapParameterOut(command, "@PA_VIEW_REC_ID2", record.RecId2);
            record.Table2 = this.MapParameterOut(command, "@PA_VIEW_TABLE2", record.Table2);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IViewLogRepository.TableName
        {
            get { return this.TableName; }
        }

        void IViewLogRepository.Create(Consensus.Common.ViewLogRecord record)
        {
            this.Create(record);
        }

        #endregion
    }
}
