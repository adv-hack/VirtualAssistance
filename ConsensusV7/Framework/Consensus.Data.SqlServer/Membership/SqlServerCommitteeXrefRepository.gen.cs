using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Membership
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="CommitteeXrefRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerCommitteeXrefRepository : SqlServerRepository<CommitteeXrefRecord, String>, ICommitteeXrefRepository
    {
        #region properties

        /// <summary>
        ///     Gets the namespace in which the data type is contained.
        /// </summary>
        protected override String TypeNamespace
        {
            get { return "Membership"; }
        }

        /// <summary>
        ///     Gets the name of the data type which is persisted by this repository.
        /// </summary>
        protected override String TypeName
        {
            get { return "CommitteeXref"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="CommitteeXrefRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_COMXREF_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Committee_Xref"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="CommitteeXrefRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="CommitteeXrefRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, CommitteeXrefRecord record)
        {
            record.Id = dataRecord["COMXREF_ID"].ConvertTo<String>();
            record.AddBy = dataRecord["COMXREF_ADD_BY"].ConvertTo<String>();
            record.AddDate = dataRecord["COMXREF_ADD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["COMXREF_MOD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["COMXREF_MOD_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["COMXREF_RCV_FROM"].ConvertTo<String>();
            record.RcvDate = dataRecord["COMXREF_RCV_DATE"].ConvertTo<DateTime?>();
            record.ComId = dataRecord["COMXREF_COM_ID"].ConvertTo<String>();
            record.TableName = dataRecord["COMXREF_TABLE_NAME"].ConvertTo<String>();
            record.RecordId = dataRecord["COMXREF_RECORD_ID"].ConvertTo<String>();
            record.Disabled = dataRecord["COMXREF_DISABLED"].ConvertTo<Byte?>();
            record.Role = dataRecord["COMXREF_ROLE"].ConvertTo<String>();
            record.Date = dataRecord["COMXREF_DATE"].ConvertTo<DateTime?>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="CommitteeXrefRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, CommitteeXrefRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_COMXREF_ID", record.Id);
            this.MapParameterIn(command, "@PA_COMXREF_COM_ID", record.ComId);
            this.MapParameterIn(command, "@PA_COMXREF_TABLE_NAME", record.TableName);
            this.MapParameterIn(command, "@PA_COMXREF_RECORD_ID", record.RecordId);
            this.MapParameterIn(command, "@PA_COMXREF_DISABLED", record.Disabled);
            this.MapParameterIn(command, "@PA_COMXREF_ROLE", record.Role);
            this.MapParameterIn(command, "@PA_COMXREF_DATE", record.Date == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Date);
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
        ///     The <see cref="CommitteeXrefRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, CommitteeXrefRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_COMXREF_ID", record.Id);
            record.ComId = this.MapParameterOut(command, "@PA_COMXREF_COM_ID", record.ComId);
            record.TableName = this.MapParameterOut(command, "@PA_COMXREF_TABLE_NAME", record.TableName);
            record.RecordId = this.MapParameterOut(command, "@PA_COMXREF_RECORD_ID", record.RecordId);
            record.Disabled = this.MapParameterOut(command, "@PA_COMXREF_DISABLED", record.Disabled);
            record.Role = this.MapParameterOut(command, "@PA_COMXREF_ROLE", record.Role);
            record.Date = this.MapParameterOut(command, "@PA_COMXREF_DATE", record.Date);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="CommitteeXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="comId">
        ///     The value which identifies the <see cref='CommitteeXrefModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="CommitteeXrefRecord" /> instances that match the specified <paramref name='comId' />.
        /// </returns>
        public IEnumerable<CommitteeXrefRecord> FetchAllByComId(String comId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "ComId");
            this.MapParameterIn(command, "@PA_COMXREF_COM_ID", comId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String ICommitteeXrefRepository.TableName
        {
            get { return this.TableName; }
        }

        void ICommitteeXrefRepository.Create(Consensus.Membership.CommitteeXrefRecord record)
        {
            this.Create(record);
        }

        void ICommitteeXrefRepository.Modify(Consensus.Membership.CommitteeXrefRecord record)
        {
            this.Modify(record);
        }

        void ICommitteeXrefRepository.RemoveById(Consensus.Membership.CommitteeXrefRecord record)
        {
            this.RemoveById(record);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Membership.CommitteeXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="comId">
        ///     The value which identifies the <see cref="!:CommitteeXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Membership.CommitteeXrefRecord" /> instances that match the specified <paramref name="comId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.CommitteeXrefRecord> ICommitteeXrefRepository.FetchAllByComId(System.String comId)
        {
            return this.FetchAllByComId(comId);
        }

        #endregion
    }
}
