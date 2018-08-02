using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="PackRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerPackRepository : SqlServerRepository<PackRecord, String>, IPackRepository
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
            get { return "Pack"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="PackRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_PACK_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Pack"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="PackRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="PackRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, PackRecord record)
        {
            record.Id = dataRecord["PACK_ID"].ConvertTo<String>();
            record.Lock = dataRecord["PACK_LOCK"].ConvertTo<String>();
            record.AddDate = dataRecord["PACK_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["PACK_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["PACK_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["PACK_MOD_BY"].ConvertTo<String>();
            record.RcvDate = dataRecord["PACK_RCV_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["PACK_RCV_FROM"].ConvertTo<String>();
            record.Name = dataRecord["PACK_NAME"].ConvertTo<String>();
            record.PackType = dataRecord["PACK_TYPE"].ConvertTo<Byte?>();
            record.ToBooker = dataRecord["PACK_TO_BOOKER"].ConvertTo<Byte?>();
            record.ToDel = dataRecord["PACK_TO_DEL"].ConvertTo<Byte?>();
            record.DocsMethod = dataRecord["PACK_DOCS_METHOD"].ConvertTo<String>();
            record.EmailSubject = dataRecord["PACK_EMAIL_SUBJECT"].ConvertTo<String>();
            record.Invoice = dataRecord["PACK_INVOICE"].ConvertTo<Byte?>();
            record.ActPqKeep = dataRecord["PACK_ACT_PQ_KEEP"].ConvertTo<Byte?>();
            record.EmailBody = dataRecord["PACK_EMAIL_BODY"].ConvertTo<String>();
            record.EmailOnly = dataRecord["PACK_EMAIL_ONLY"].ConvertTo<Byte>();
            record.PrintOnly = dataRecord["PACK_PRINT_ONLY"].ConvertTo<Byte>();
            record.Status = dataRecord["PACK_STATUS"].ConvertTo<Byte>();
            record.SendProleId = dataRecord["PACK_SEND_PROLE_ID"].ConvertTo<String>();
            record.Category = dataRecord["PACK_CATEGORY"].ConvertTo<String>();
            record.PqId = dataRecord["PACK_PQ_ID"].ConvertTo<String>();
            record.BccEmail = dataRecord["PACK_BCC_EMAIL"].ConvertTo<String>();
            record.MdnEmail = dataRecord["PACK_MDN_EMAIL"].ConvertTo<String>();
            record.DsnEmail = dataRecord["PACK_DSN_EMAIL"].ConvertTo<String>();
            record.DsnOptions = dataRecord["PACK_DSN_OPTIONS"].ConvertTo<String>();
            record.SelcoSpId = dataRecord["PACK_SELCO_SP_ID"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="PackRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, PackRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_PACK_ID", record.Id);
            this.MapParameterIn(command, "@PA_PACK_LOCK", record.Lock);
            this.MapParameterIn(command, "@PA_PACK_NAME", record.Name);
            this.MapParameterIn(command, "@PA_PACK_TYPE", record.PackType);
            this.MapParameterIn(command, "@PA_PACK_TO_BOOKER", record.ToBooker);
            this.MapParameterIn(command, "@PA_PACK_TO_DEL", record.ToDel);
            this.MapParameterIn(command, "@PA_PACK_DOCS_METHOD", record.DocsMethod);
            this.MapParameterIn(command, "@PA_PACK_EMAIL_SUBJECT", record.EmailSubject);
            this.MapParameterIn(command, "@PA_PACK_INVOICE", record.Invoice);
            this.MapParameterIn(command, "@PA_PACK_ACT_PQ_KEEP", record.ActPqKeep);
            this.MapParameterIn(command, "@PA_PACK_EMAIL_BODY", record.EmailBody);
            this.MapParameterIn(command, "@PA_PACK_EMAIL_ONLY", record.EmailOnly);
            this.MapParameterIn(command, "@PA_PACK_PRINT_ONLY", record.PrintOnly);
            this.MapParameterIn(command, "@PA_PACK_STATUS", record.Status);
            this.MapParameterIn(command, "@PA_PACK_SEND_PROLE_ID", record.SendProleId);
            this.MapParameterIn(command, "@PA_PACK_CATEGORY", record.Category);
            this.MapParameterIn(command, "@PA_PACK_PQ_ID", record.PqId);
            this.MapParameterIn(command, "@PA_PACK_BCC_EMAIL", record.BccEmail);
            this.MapParameterIn(command, "@PA_PACK_MDN_EMAIL", record.MdnEmail);
            this.MapParameterIn(command, "@PA_PACK_DSN_EMAIL", record.DsnEmail);
            this.MapParameterIn(command, "@PA_PACK_DSN_OPTIONS", record.DsnOptions);
            this.MapParameterIn(command, "@PA_PACK_SELCO_SP_ID", record.SelcoSpId);
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
        ///     The <see cref="PackRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, PackRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_PACK_ID", record.Id);
            record.Lock = this.MapParameterOut(command, "@PA_PACK_LOCK", record.Lock);
            record.Name = this.MapParameterOut(command, "@PA_PACK_NAME", record.Name);
            record.PackType = this.MapParameterOut(command, "@PA_PACK_TYPE", record.PackType);
            record.ToBooker = this.MapParameterOut(command, "@PA_PACK_TO_BOOKER", record.ToBooker);
            record.ToDel = this.MapParameterOut(command, "@PA_PACK_TO_DEL", record.ToDel);
            record.DocsMethod = this.MapParameterOut(command, "@PA_PACK_DOCS_METHOD", record.DocsMethod);
            record.EmailSubject = this.MapParameterOut(command, "@PA_PACK_EMAIL_SUBJECT", record.EmailSubject);
            record.Invoice = this.MapParameterOut(command, "@PA_PACK_INVOICE", record.Invoice);
            record.ActPqKeep = this.MapParameterOut(command, "@PA_PACK_ACT_PQ_KEEP", record.ActPqKeep);
            record.EmailBody = this.MapParameterOut(command, "@PA_PACK_EMAIL_BODY", record.EmailBody);
            record.EmailOnly = this.MapParameterOut(command, "@PA_PACK_EMAIL_ONLY", record.EmailOnly);
            record.PrintOnly = this.MapParameterOut(command, "@PA_PACK_PRINT_ONLY", record.PrintOnly);
            record.Status = this.MapParameterOut(command, "@PA_PACK_STATUS", record.Status);
            record.SendProleId = this.MapParameterOut(command, "@PA_PACK_SEND_PROLE_ID", record.SendProleId);
            record.Category = this.MapParameterOut(command, "@PA_PACK_CATEGORY", record.Category);
            record.PqId = this.MapParameterOut(command, "@PA_PACK_PQ_ID", record.PqId);
            record.BccEmail = this.MapParameterOut(command, "@PA_PACK_BCC_EMAIL", record.BccEmail);
            record.MdnEmail = this.MapParameterOut(command, "@PA_PACK_MDN_EMAIL", record.MdnEmail);
            record.DsnEmail = this.MapParameterOut(command, "@PA_PACK_DSN_EMAIL", record.DsnEmail);
            record.DsnOptions = this.MapParameterOut(command, "@PA_PACK_DSN_OPTIONS", record.DsnOptions);
            record.SelcoSpId = this.MapParameterOut(command, "@PA_PACK_SELCO_SP_ID", record.SelcoSpId);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="PackRecord" /> instances from the data store.
        /// </summary>
        /// <param name="emailBody">
        ///     The value which identifies the <see cref='PackModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="PackRecord" /> instances that match the specified <paramref name='emailBody' />.
        /// </returns>
        public IEnumerable<PackRecord> FetchAllByEmailBody(String emailBody)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "EmailBody");
            this.MapParameterIn(command, "@PA_PACK_EMAIL_BODY", emailBody);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="PackRecord" /> instances from the data store.
        /// </summary>
        /// <param name="sendProleId">
        ///     The value which identifies the <see cref='PackModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="PackRecord" /> instances that match the specified <paramref name='sendProleId' />.
        /// </returns>
        public IEnumerable<PackRecord> FetchAllBySendProleId(String sendProleId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "SendProleId");
            this.MapParameterIn(command, "@PA_PACK_SEND_PROLE_ID", sendProleId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="PackRecord" /> instances from the data store.
        /// </summary>
        /// <param name="pqId">
        ///     The value which identifies the <see cref='PackModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="PackRecord" /> instances that match the specified <paramref name='pqId' />.
        /// </returns>
        public IEnumerable<PackRecord> FetchAllByPqId(String pqId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "PqId");
            this.MapParameterIn(command, "@PA_PACK_PQ_ID", pqId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="PackRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref='PackModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="PackRecord" /> instances that match the specified <paramref name='selcoSpId' />.
        /// </returns>
        public IEnumerable<PackRecord> FetchAllBySelcoSpId(String selcoSpId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "SelcoSpId");
            this.MapParameterIn(command, "@PA_PACK_SELCO_SP_ID", selcoSpId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IPackRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Document.PackRecord" /> instances from the data store.
        /// </summary>
        /// <param name="emailBody">
        ///     The value which identifies the <see cref="!:PackModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Document.PackRecord" /> instances that match the specified <paramref name="emailBody" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.PackRecord> IPackRepository.FetchAllByEmailBody(System.String emailBody)
        {
            return this.FetchAllByEmailBody(emailBody);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Document.PackRecord" /> instances from the data store.
        /// </summary>
        /// <param name="sendProleId">
        ///     The value which identifies the <see cref="!:PackModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Document.PackRecord" /> instances that match the specified <paramref name="sendProleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.PackRecord> IPackRepository.FetchAllBySendProleId(System.String sendProleId)
        {
            return this.FetchAllBySendProleId(sendProleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Document.PackRecord" /> instances from the data store.
        /// </summary>
        /// <param name="pqId">
        ///     The value which identifies the <see cref="!:PackModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Document.PackRecord" /> instances that match the specified <paramref name="pqId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.PackRecord> IPackRepository.FetchAllByPqId(System.String pqId)
        {
            return this.FetchAllByPqId(pqId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Document.PackRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref="!:PackModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Document.PackRecord" /> instances that match the specified <paramref name="selcoSpId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.PackRecord> IPackRepository.FetchAllBySelcoSpId(System.String selcoSpId)
        {
            return this.FetchAllBySelcoSpId(selcoSpId);
        }

        #endregion
    }
}
