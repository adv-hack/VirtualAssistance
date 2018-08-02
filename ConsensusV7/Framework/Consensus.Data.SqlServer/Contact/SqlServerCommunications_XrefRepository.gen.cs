using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="CommunicationsXrefRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerCommunications_XrefRepository : SqlServerRepository<CommunicationsXrefRecord, Int64>, ICommunications_XrefRepository
    {
        #region properties

        /// <summary>
        ///     Gets the namespace in which the data type is contained.
        /// </summary>
        protected override String TypeNamespace
        {
            get { return "Contact"; }
        }

        /// <summary>
        ///     Gets the name of the data type which is persisted by this repository.
        /// </summary>
        protected override String TypeName
        {
            get { return "CommunicationsXref"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="CommunicationsXrefRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_COMMXREF_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Communications_Xref"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="CommunicationsXrefRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="CommunicationsXrefRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, CommunicationsXrefRecord record)
        {
            record.Id = dataRecord["COMMXREF_ID"].ConvertTo<Int64>();
            record.AddDate = dataRecord["COMMXREF_ADD_DATE"].ConvertTo<DateTime>();
            record.AddBy = dataRecord["COMMXREF_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["COMMXREF_MOD_DATE"].ConvertTo<DateTime>();
            record.ModBy = dataRecord["COMMXREF_MOD_BY"].ConvertTo<String>();
            record.TableName = dataRecord["COMMXREF_TABLE_NAME"].ConvertTo<String>();
            record.RecordId = dataRecord["COMMXREF_RECORD_ID"].ConvertTo<String>();
            record.CommId = dataRecord["COMMXREF_COMM_ID"].ConvertTo<Int64>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="CommunicationsXrefRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, CommunicationsXrefRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_COMMXREF_ID", record.Id == Int64.MinValue ? ( useV6Logic ? new Int64?(0) : null ) : record.Id);
            this.MapParameterIn(command, "@PA_COMMXREF_TABLE_NAME", record.TableName);
            this.MapParameterIn(command, "@PA_COMMXREF_RECORD_ID", record.RecordId);
            this.MapParameterIn(command, "@PA_COMMXREF_COMM_ID", record.CommId == Int64.MinValue ? ( useV6Logic ? new Int64?(0) : null ) : record.CommId);
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
        ///     The <see cref="CommunicationsXrefRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, CommunicationsXrefRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_COMMXREF_ID", record.Id);
            record.TableName = this.MapParameterOut(command, "@PA_COMMXREF_TABLE_NAME", record.TableName);
            record.RecordId = this.MapParameterOut(command, "@PA_COMMXREF_RECORD_ID", record.RecordId);
            record.CommId = this.MapParameterOut(command, "@PA_COMMXREF_COMM_ID", record.CommId);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="CommunicationsXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="commId">
        ///     The value which identifies the <see cref='Communications_XrefModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="CommunicationsXrefRecord" /> instances that match the specified <paramref name='commId' />.
        /// </returns>
        public IEnumerable<CommunicationsXrefRecord> FetchAllByCommId(Int64 commId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "CommId");
            this.MapParameterIn(command, "@PA_COMMXREF_COMM_ID", commId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="CommunicationsXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="recordId">
        ///     The value which identifies the <see cref='Communications_XrefModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="CommunicationsXrefRecord" /> instances that match the specified <paramref name='recordId' />.
        /// </returns>
        public IEnumerable<CommunicationsXrefRecord> FetchAllByRecordId(String recordId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "RecordId");
            this.MapParameterIn(command, "@PA_COMMXREF_RECORD_ID", recordId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String ICommunications_XrefRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Contact.CommunicationsXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="commId">
        ///     The value which identifies the <see cref="!:Communications_XrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Contact.CommunicationsXrefRecord" /> instances that match the specified <paramref name="commId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.CommunicationsXrefRecord> ICommunications_XrefRepository.FetchAllByCommId(System.Int64 commId)
        {
            return this.FetchAllByCommId(commId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Contact.CommunicationsXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="recordId">
        ///     The value which identifies the <see cref="!:Communications_XrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Contact.CommunicationsXrefRecord" /> instances that match the specified <paramref name="recordId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.CommunicationsXrefRecord> ICommunications_XrefRepository.FetchAllByRecordId(System.String recordId)
        {
            return this.FetchAllByRecordId(recordId);
        }

        #endregion
    }
}
