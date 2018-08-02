using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="IcalmessageRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerICalMessageRepository : SqlServerRepository<IcalmessageRecord, Int32>, IICalMessageRepository
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
            get { return "Icalmessage"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="IcalmessageRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_ICM_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "ICalMessage"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="IcalmessageRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="IcalmessageRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, IcalmessageRecord record)
        {
            record.Id = dataRecord["ICM_ID"].ConvertTo<Int32>();
            record.AddDate = dataRecord["ICM_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["ICM_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["ICM_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["ICM_MOD_BY"].ConvertTo<String>();
            record.IcmtId = dataRecord["ICM_ICMT_ID"].ConvertTo<Int32?>();
            record.Current = dataRecord["ICM_CURRENT"].ConvertTo<Byte?>();
            record.Method = dataRecord["ICM_METHOD"].ConvertTo<Byte?>();
            record.Name = dataRecord["ICM_NAME"].ConvertTo<String>();
            record.Description = dataRecord["ICM_DESCRIPTION"].ConvertTo<String>();
            record.Subject = dataRecord["ICM_SUBJECT"].ConvertTo<String>();
            record.Location = dataRecord["ICM_LOCATION"].ConvertTo<String>();
            record.Text = dataRecord["ICM_TEXT"].ConvertTo<String>();
            record.SelcoSpId = dataRecord["ICM_SELCO_SP_ID"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="IcalmessageRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, IcalmessageRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_ICM_ID", record.Id == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Id);
            this.MapParameterIn(command, "@PA_ICM_ICMT_ID", record.IcmtId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.IcmtId);
            this.MapParameterIn(command, "@PA_ICM_CURRENT", record.Current);
            this.MapParameterIn(command, "@PA_ICM_METHOD", record.Method);
            this.MapParameterIn(command, "@PA_ICM_NAME", record.Name);
            this.MapParameterIn(command, "@PA_ICM_DESCRIPTION", record.Description);
            this.MapParameterIn(command, "@PA_ICM_SUBJECT", record.Subject);
            this.MapParameterIn(command, "@PA_ICM_LOCATION", record.Location);
            this.MapParameterIn(command, "@PA_ICM_TEXT", record.Text);
            this.MapParameterIn(command, "@PA_ICM_SELCO_SP_ID", record.SelcoSpId);
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
        ///     The <see cref="IcalmessageRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, IcalmessageRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_ICM_ID", record.Id);
            record.IcmtId = this.MapParameterOut(command, "@PA_ICM_ICMT_ID", record.IcmtId);
            record.Current = this.MapParameterOut(command, "@PA_ICM_CURRENT", record.Current);
            record.Method = this.MapParameterOut(command, "@PA_ICM_METHOD", record.Method);
            record.Name = this.MapParameterOut(command, "@PA_ICM_NAME", record.Name);
            record.Description = this.MapParameterOut(command, "@PA_ICM_DESCRIPTION", record.Description);
            record.Subject = this.MapParameterOut(command, "@PA_ICM_SUBJECT", record.Subject);
            record.Location = this.MapParameterOut(command, "@PA_ICM_LOCATION", record.Location);
            record.Text = this.MapParameterOut(command, "@PA_ICM_TEXT", record.Text);
            record.SelcoSpId = this.MapParameterOut(command, "@PA_ICM_SELCO_SP_ID", record.SelcoSpId);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="IcalmessageRecord" /> instances from the data store.
        /// </summary>
        /// <param name="icmtId">
        ///     The value which identifies the <see cref='ICalMessageModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="IcalmessageRecord" /> instances that match the specified <paramref name='icmtId' />.
        /// </returns>
        public IEnumerable<IcalmessageRecord> FetchAllByIcmtId(Int32? icmtId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "IcmtId");
            this.MapParameterIn(command, "@PA_ICM_ICMT_ID", icmtId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="IcalmessageRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref='ICalMessageModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="IcalmessageRecord" /> instances that match the specified <paramref name='selcoSpId' />.
        /// </returns>
        public IEnumerable<IcalmessageRecord> FetchAllBySelcoSpId(String selcoSpId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "SelcoSpId");
            this.MapParameterIn(command, "@PA_ICM_SELCO_SP_ID", selcoSpId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IICalMessageRepository.TableName
        {
            get { return this.TableName; }
        }

        System.Collections.Generic.IEnumerable<Consensus.Document.IcalmessageRecord> IICalMessageRepository.FetchAllByIcmtId(System.Nullable<System.Int32> icmtId)
        {
            return this.FetchAllByIcmtId(icmtId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Document.IcalmessageRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref="!:ICalMessageModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Document.IcalmessageRecord" /> instances that match the specified <paramref name="selcoSpId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.IcalmessageRecord> IICalMessageRepository.FetchAllBySelcoSpId(System.String selcoSpId)
        {
            return this.FetchAllBySelcoSpId(selcoSpId);
        }

        #endregion
    }
}
