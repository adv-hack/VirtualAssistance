using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="SmsMessageRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerSmsMessageRepository : SqlServerRepository<SmsMessageRecord, Int32>, ISmsMessageRepository
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
            get { return "SmsMessage"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="SmsMessageRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_SMS_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "SMS_Message"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="SmsMessageRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="SmsMessageRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, SmsMessageRecord record)
        {
            record.Id = dataRecord["SMS_ID"].ConvertTo<Int32>();
            record.AddDate = dataRecord["SMS_ADD_DATE"].ConvertTo<DateTime>();
            record.AddBy = dataRecord["SMS_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["SMS_MOD_DATE"].ConvertTo<DateTime>();
            record.ModBy = dataRecord["SMS_MOD_BY"].ConvertTo<String>();
            record.SmtId = dataRecord["SMS_SMT_ID"].ConvertTo<Int32?>();
            record.Name = dataRecord["SMS_NAME"].ConvertTo<String>();
            record.Description = dataRecord["SMS_DESCRIPTION"].ConvertTo<String>();
            record.Text = dataRecord["SMS_TEXT"].ConvertTo<String>();
            record.Current = dataRecord["SMS_CURRENT"].ConvertTo<Boolean?>();
            record.SelcoSpId = dataRecord["SMS_SELCO_SP_ID"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="SmsMessageRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, SmsMessageRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_SMS_ID", record.Id == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Id);
            this.MapParameterIn(command, "@PA_SMS_SMT_ID", record.SmtId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.SmtId);
            this.MapParameterIn(command, "@PA_SMS_NAME", record.Name);
            this.MapParameterIn(command, "@PA_SMS_DESCRIPTION", record.Description);
            this.MapParameterIn(command, "@PA_SMS_TEXT", record.Text);
            this.MapParameterIn(command, "@PA_SMS_CURRENT", record.Current);
            this.MapParameterIn(command, "@PA_SMS_SELCO_SP_ID", record.SelcoSpId);
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
        ///     The <see cref="SmsMessageRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, SmsMessageRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_SMS_ID", record.Id);
            record.SmtId = this.MapParameterOut(command, "@PA_SMS_SMT_ID", record.SmtId);
            record.Name = this.MapParameterOut(command, "@PA_SMS_NAME", record.Name);
            record.Description = this.MapParameterOut(command, "@PA_SMS_DESCRIPTION", record.Description);
            record.Text = this.MapParameterOut(command, "@PA_SMS_TEXT", record.Text);
            record.Current = this.MapParameterOut(command, "@PA_SMS_CURRENT", record.Current);
            record.SelcoSpId = this.MapParameterOut(command, "@PA_SMS_SELCO_SP_ID", record.SelcoSpId);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="SmsMessageRecord" /> instances from the data store.
        /// </summary>
        /// <param name="smtId">
        ///     The value which identifies the <see cref='SmsMessageModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="SmsMessageRecord" /> instances that match the specified <paramref name='smtId' />.
        /// </returns>
        public IEnumerable<SmsMessageRecord> FetchAllBySmtId(Int32? smtId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "SmtId");
            this.MapParameterIn(command, "@PA_SMS_SMT_ID", smtId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="SmsMessageRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref='SmsMessageModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="SmsMessageRecord" /> instances that match the specified <paramref name='selcoSpId' />.
        /// </returns>
        public IEnumerable<SmsMessageRecord> FetchAllBySelcoSpId(String selcoSpId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "SelcoSpId");
            this.MapParameterIn(command, "@PA_SMS_SELCO_SP_ID", selcoSpId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String ISmsMessageRepository.TableName
        {
            get { return this.TableName; }
        }

        System.Collections.Generic.IEnumerable<Consensus.Document.SmsMessageRecord> ISmsMessageRepository.FetchAllBySmtId(System.Nullable<System.Int32> smtId)
        {
            return this.FetchAllBySmtId(smtId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Document.SmsMessageRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref="!:SmsMessageModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Document.SmsMessageRecord" /> instances that match the specified <paramref name="selcoSpId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.SmsMessageRecord> ISmsMessageRepository.FetchAllBySelcoSpId(System.String selcoSpId)
        {
            return this.FetchAllBySelcoSpId(selcoSpId);
        }

        #endregion
    }
}
