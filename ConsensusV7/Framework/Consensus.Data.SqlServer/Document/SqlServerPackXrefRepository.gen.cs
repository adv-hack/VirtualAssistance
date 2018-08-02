using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="PackXrefRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerPackXrefRepository : SqlServerRepository<PackXrefRecord, String>, IPackXrefRepository
    {
        #region properties

        /// <summary>
        ///     Gets the namespace in which the data type is contained.
        /// </summary>
        protected override String TypeNamespace
        {
            get { return "Document"; }
        }

        /// <summary>
        ///     Gets the name of the data type which is persisted by this repository.
        /// </summary>
        protected override String TypeName
        {
            get { return "PackXref"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="PackXrefRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_PACKXREF_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Pack_Xref"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="PackXrefRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="PackXrefRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, PackXrefRecord record)
        {
            record.Id = dataRecord["PACKXREF_ID"].ConvertTo<String>();
            record.Lock = dataRecord["PACKXREF_LOCK"].ConvertTo<String>();
            record.AddDate = dataRecord["PACKXREF_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["PACKXREF_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["PACKXREF_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["PACKXREF_MOD_BY"].ConvertTo<String>();
            record.RcvDate = dataRecord["PACKXREF_RCV_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["PACKXREF_RCV_FROM"].ConvertTo<String>();
            record.PackId = dataRecord["PACKXREF_PACK_ID"].ConvertTo<String>();
            record.LitId = dataRecord["PACKXREF_LIT_ID"].ConvertTo<String>();
            record.Seq = dataRecord["PACKXREF_SEQ"].ConvertTo<Int32?>();
            record.SmsId = dataRecord["PACKXREF_SMS_ID"].ConvertTo<Int32?>();
            record.IcmId = dataRecord["PACKXREF_ICM_ID"].ConvertTo<Int32?>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="PackXrefRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, PackXrefRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_PACKXREF_ID", record.Id);
            this.MapParameterIn(command, "@PA_PACKXREF_LOCK", record.Lock);
            this.MapParameterIn(command, "@PA_PACKXREF_PACK_ID", record.PackId);
            this.MapParameterIn(command, "@PA_PACKXREF_LIT_ID", record.LitId);
            this.MapParameterIn(command, "@PA_PACKXREF_SEQ", record.Seq == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Seq);
            this.MapParameterIn(command, "@PA_PACKXREF_SMS_ID", record.SmsId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.SmsId);
            this.MapParameterIn(command, "@PA_PACKXREF_ICM_ID", record.IcmId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.IcmId);
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
        ///     The <see cref="PackXrefRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, PackXrefRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_PACKXREF_ID", record.Id);
            record.Lock = this.MapParameterOut(command, "@PA_PACKXREF_LOCK", record.Lock);
            record.PackId = this.MapParameterOut(command, "@PA_PACKXREF_PACK_ID", record.PackId);
            record.LitId = this.MapParameterOut(command, "@PA_PACKXREF_LIT_ID", record.LitId);
            record.Seq = this.MapParameterOut(command, "@PA_PACKXREF_SEQ", record.Seq);
            record.SmsId = this.MapParameterOut(command, "@PA_PACKXREF_SMS_ID", record.SmsId);
            record.IcmId = this.MapParameterOut(command, "@PA_PACKXREF_ICM_ID", record.IcmId);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="PackXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="packId">
        ///     The value which identifies the <see cref='PackXrefModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="PackXrefRecord" /> instances that match the specified <paramref name='packId' />.
        /// </returns>
        public IEnumerable<PackXrefRecord> FetchAllByPackId(String packId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "PackId");
            this.MapParameterIn(command, "@PA_PACKXREF_PACK_ID", packId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="PackXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="litId">
        ///     The value which identifies the <see cref='PackXrefModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="PackXrefRecord" /> instances that match the specified <paramref name='litId' />.
        /// </returns>
        public IEnumerable<PackXrefRecord> FetchAllByLitId(String litId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "LitId");
            this.MapParameterIn(command, "@PA_PACKXREF_LIT_ID", litId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="PackXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="smsId">
        ///     The value which identifies the <see cref='PackXrefModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="PackXrefRecord" /> instances that match the specified <paramref name='smsId' />.
        /// </returns>
        public IEnumerable<PackXrefRecord> FetchAllBySmsId(Int32? smsId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "SmsId");
            this.MapParameterIn(command, "@PA_PACKXREF_SMS_ID", smsId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="PackXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="icmId">
        ///     The value which identifies the <see cref='PackXrefModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="PackXrefRecord" /> instances that match the specified <paramref name='icmId' />.
        /// </returns>
        public IEnumerable<PackXrefRecord> FetchAllByIcmId(Int32? icmId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "IcmId");
            this.MapParameterIn(command, "@PA_PACKXREF_ICM_ID", icmId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IPackXrefRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Document.PackXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="packId">
        ///     The value which identifies the <see cref="!:PackXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Document.PackXrefRecord" /> instances that match the specified <paramref name="packId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.PackXrefRecord> IPackXrefRepository.FetchAllByPackId(System.String packId)
        {
            return this.FetchAllByPackId(packId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Document.PackXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="litId">
        ///     The value which identifies the <see cref="!:PackXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Document.PackXrefRecord" /> instances that match the specified <paramref name="litId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.PackXrefRecord> IPackXrefRepository.FetchAllByLitId(System.String litId)
        {
            return this.FetchAllByLitId(litId);
        }

        System.Collections.Generic.IEnumerable<Consensus.Document.PackXrefRecord> IPackXrefRepository.FetchAllBySmsId(System.Nullable<System.Int32> smsId)
        {
            return this.FetchAllBySmsId(smsId);
        }

        System.Collections.Generic.IEnumerable<Consensus.Document.PackXrefRecord> IPackXrefRepository.FetchAllByIcmId(System.Nullable<System.Int32> icmId)
        {
            return this.FetchAllByIcmId(icmId);
        }

        #endregion
    }
}
