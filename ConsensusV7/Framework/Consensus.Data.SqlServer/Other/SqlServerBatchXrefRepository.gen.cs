using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Other
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="BatchXrefRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerBatchXrefRepository : SqlServerRepository<BatchXrefRecord, Int32>, IBatchXrefRepository
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
            get { return "BatchXref"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="BatchXrefRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_BATXR_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "BATCH_XREF"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="BatchXrefRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="BatchXrefRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, BatchXrefRecord record)
        {
            record.Id = dataRecord["BATXR_ID"].ConvertTo<Int32>();
            record.AddDate = dataRecord["BATXR_ADD_DATE"].ConvertTo<DateTime>();
            record.AddBy = dataRecord["BATXR_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["BATXR_MOD_DATE"].ConvertTo<DateTime>();
            record.ModBy = dataRecord["BATXR_MOD_BY"].ConvertTo<String>();
            record.RcvDate = dataRecord["BATXR_RCV_DATE"].ConvertTo<DateTime>();
            record.RcvFrom = dataRecord["BATXR_RCV_FROM"].ConvertTo<String>();
            record.BatId = dataRecord["BATXR_BAT_ID"].ConvertTo<String>();
            record.RecordId = dataRecord["BATXR_RECORD_ID"].ConvertTo<String>();
            record.TableName = dataRecord["BATXR_TABLE_NAME"].ConvertTo<String>();
            record.LinkId = dataRecord["BATXR_LINK_ID"].ConvertTo<String>();
            record.LinkUrl = dataRecord["BATXR_LINK_URL"].ConvertTo<String>();
            record.Status = dataRecord["BATXR_STATUS"].ConvertTo<Byte>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="BatchXrefRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, BatchXrefRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_BATXR_ID", record.Id == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Id);
            this.MapParameterIn(command, "@PA_BATXR_BAT_ID", record.BatId);
            this.MapParameterIn(command, "@PA_BATXR_RECORD_ID", record.RecordId);
            this.MapParameterIn(command, "@PA_BATXR_TABLE_NAME", record.TableName);
            this.MapParameterIn(command, "@PA_BATXR_LINK_ID", record.LinkId);
            this.MapParameterIn(command, "@PA_BATXR_LINK_URL", record.LinkUrl);
            this.MapParameterIn(command, "@PA_BATXR_STATUS", record.Status);
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
        ///     The <see cref="BatchXrefRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, BatchXrefRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_BATXR_ID", record.Id);
            record.BatId = this.MapParameterOut(command, "@PA_BATXR_BAT_ID", record.BatId);
            record.RecordId = this.MapParameterOut(command, "@PA_BATXR_RECORD_ID", record.RecordId);
            record.TableName = this.MapParameterOut(command, "@PA_BATXR_TABLE_NAME", record.TableName);
            record.LinkId = this.MapParameterOut(command, "@PA_BATXR_LINK_ID", record.LinkId);
            record.LinkUrl = this.MapParameterOut(command, "@PA_BATXR_LINK_URL", record.LinkUrl);
            record.Status = this.MapParameterOut(command, "@PA_BATXR_STATUS", record.Status);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="BatchXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="batId">
        ///     The value which identifies the <see cref='BatchXrefModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="BatchXrefRecord" /> instances that match the specified <paramref name='batId' />.
        /// </returns>
        public IEnumerable<BatchXrefRecord> FetchAllByBatId(String batId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "BatId");
            this.MapParameterIn(command, "@PA_BATXR_BAT_ID", batId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IBatchXrefRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Other.BatchXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="batId">
        ///     The value which identifies the <see cref="!:BatchXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Other.BatchXrefRecord" /> instances that match the specified <paramref name="batId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Other.BatchXrefRecord> IBatchXrefRepository.FetchAllByBatId(System.String batId)
        {
            return this.FetchAllByBatId(batId);
        }

        #endregion
    }
}
