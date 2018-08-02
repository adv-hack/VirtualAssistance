using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="PrintQueueRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerOutputQueueRepository : SqlServerRepository<PrintQueueRecord, String>, IOutputQueueRepository
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
            get { return "PrintQueue"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="PrintQueueRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_PQ_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "PRINT_QUEUE"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="PrintQueueRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="PrintQueueRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, PrintQueueRecord record)
        {
            record.Id = dataRecord["PQ_ID"].ConvertTo<String>();
            record.AddDate = dataRecord["PQ_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["PQ_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["PQ_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["PQ_MOD_BY"].ConvertTo<String>();
            record.RcvDate = dataRecord["PQ_RCV_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["PQ_RCV_FROM"].ConvertTo<String>();
            record.QueueType = dataRecord["PQ_QUEUE_TYPE"].ConvertTo<String>();
            record.AddId = dataRecord["PQ_ADD_ID"].ConvertTo<String>();
            record.OrgId = dataRecord["PQ_ORG_ID"].ConvertTo<String>();
            record.SendType = dataRecord["PQ_SEND_TYPE"].ConvertTo<Byte?>();
            record.StationaryType = dataRecord["PQ_STATIONARY_TYPE"].ConvertTo<Byte?>();
            record.AdminPnId = dataRecord["PQ_ADMIN_PN_ID"].ConvertTo<String>();
            record.AdminProleId = dataRecord["PQ_ADMIN_PROLE_ID"].ConvertTo<String>();
            record.MailServer = dataRecord["PQ_MAIL_SERVER"].ConvertTo<String>();
            record.LogonId = dataRecord["PQ_LOGON_ID"].ConvertTo<String>();
            record.LogonPassword = dataRecord["PQ_LOGON_PASSWORD"].ConvertTo<String>();
            record.PrintServer = dataRecord["PQ_PRINT_SERVER"].ConvertTo<String>();
            record.PrintPrinter = dataRecord["PQ_PRINT_PRINTER"].ConvertTo<String>();
            record.PrinterType = dataRecord["PQ_PRINTER_TYPE"].ConvertTo<String>();
            record.PrinterNotes = dataRecord["PQ_PRINTER_NOTES"].ConvertTo<String>();
            record.Description = dataRecord["PQ_DESCRIPTION"].ConvertTo<String>();
            record.SystemDefault = dataRecord["PQ_SYSTEM_DEFAULT"].ConvertTo<Byte?>();
            record.DpmServer = dataRecord["PQ_DPM_SERVER"].ConvertTo<String>();
            record.Status = dataRecord["PQ_STATUS"].ConvertTo<Byte?>();
            record.Port = dataRecord["PQ_PORT"].ConvertTo<String>();
            record.Ssl = dataRecord["PQ_SSL"].ConvertTo<Byte?>();
            record.Proxy = dataRecord["PQ_PROXY"].ConvertTo<Byte?>();
            record.From = dataRecord["PQ_FROM"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="PrintQueueRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, PrintQueueRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_PQ_ID", record.Id);
            this.MapParameterIn(command, "@PA_PQ_QUEUE_TYPE", record.QueueType);
            this.MapParameterIn(command, "@PA_PQ_ADD_ID", record.AddId);
            this.MapParameterIn(command, "@PA_PQ_ORG_ID", record.OrgId);
            this.MapParameterIn(command, "@PA_PQ_SEND_TYPE", record.SendType);
            this.MapParameterIn(command, "@PA_PQ_STATIONARY_TYPE", record.StationaryType);
            this.MapParameterIn(command, "@PA_PQ_ADMIN_PN_ID", record.AdminPnId);
            this.MapParameterIn(command, "@PA_PQ_ADMIN_PROLE_ID", record.AdminProleId);
            this.MapParameterIn(command, "@PA_PQ_MAIL_SERVER", record.MailServer);
            this.MapParameterIn(command, "@PA_PQ_LOGON_ID", record.LogonId);
            this.MapParameterIn(command, "@PA_PQ_LOGON_PASSWORD", record.LogonPassword);
            this.MapParameterIn(command, "@PA_PQ_PRINT_SERVER", record.PrintServer);
            this.MapParameterIn(command, "@PA_PQ_PRINT_PRINTER", record.PrintPrinter);
            this.MapParameterIn(command, "@PA_PQ_PRINTER_TYPE", record.PrinterType);
            this.MapParameterIn(command, "@PA_PQ_PRINTER_NOTES", record.PrinterNotes);
            this.MapParameterIn(command, "@PA_PQ_DESCRIPTION", record.Description);
            this.MapParameterIn(command, "@PA_PQ_SYSTEM_DEFAULT", record.SystemDefault);
            this.MapParameterIn(command, "@PA_PQ_DPM_SERVER", record.DpmServer);
            this.MapParameterIn(command, "@PA_PQ_STATUS", record.Status);
            this.MapParameterIn(command, "@PA_PQ_PORT", record.Port);
            this.MapParameterIn(command, "@PA_PQ_SSL", record.Ssl);
            this.MapParameterIn(command, "@PA_PQ_PROXY", record.Proxy);
            this.MapParameterIn(command, "@PA_PQ_FROM", record.From);
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
        ///     The <see cref="PrintQueueRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, PrintQueueRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_PQ_ID", record.Id);
            record.QueueType = this.MapParameterOut(command, "@PA_PQ_QUEUE_TYPE", record.QueueType);
            record.AddId = this.MapParameterOut(command, "@PA_PQ_ADD_ID", record.AddId);
            record.OrgId = this.MapParameterOut(command, "@PA_PQ_ORG_ID", record.OrgId);
            record.SendType = this.MapParameterOut(command, "@PA_PQ_SEND_TYPE", record.SendType);
            record.StationaryType = this.MapParameterOut(command, "@PA_PQ_STATIONARY_TYPE", record.StationaryType);
            record.AdminPnId = this.MapParameterOut(command, "@PA_PQ_ADMIN_PN_ID", record.AdminPnId);
            record.AdminProleId = this.MapParameterOut(command, "@PA_PQ_ADMIN_PROLE_ID", record.AdminProleId);
            record.MailServer = this.MapParameterOut(command, "@PA_PQ_MAIL_SERVER", record.MailServer);
            record.LogonId = this.MapParameterOut(command, "@PA_PQ_LOGON_ID", record.LogonId);
            record.LogonPassword = this.MapParameterOut(command, "@PA_PQ_LOGON_PASSWORD", record.LogonPassword);
            record.PrintServer = this.MapParameterOut(command, "@PA_PQ_PRINT_SERVER", record.PrintServer);
            record.PrintPrinter = this.MapParameterOut(command, "@PA_PQ_PRINT_PRINTER", record.PrintPrinter);
            record.PrinterType = this.MapParameterOut(command, "@PA_PQ_PRINTER_TYPE", record.PrinterType);
            record.PrinterNotes = this.MapParameterOut(command, "@PA_PQ_PRINTER_NOTES", record.PrinterNotes);
            record.Description = this.MapParameterOut(command, "@PA_PQ_DESCRIPTION", record.Description);
            record.SystemDefault = this.MapParameterOut(command, "@PA_PQ_SYSTEM_DEFAULT", record.SystemDefault);
            record.DpmServer = this.MapParameterOut(command, "@PA_PQ_DPM_SERVER", record.DpmServer);
            record.Status = this.MapParameterOut(command, "@PA_PQ_STATUS", record.Status);
            record.Port = this.MapParameterOut(command, "@PA_PQ_PORT", record.Port);
            record.Ssl = this.MapParameterOut(command, "@PA_PQ_SSL", record.Ssl);
            record.Proxy = this.MapParameterOut(command, "@PA_PQ_PROXY", record.Proxy);
            record.From = this.MapParameterOut(command, "@PA_PQ_FROM", record.From);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="PrintQueueRecord" /> instances from the data store.
        /// </summary>
        /// <param name="adminProleId">
        ///     The value which identifies the <see cref='OutputQueueModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="PrintQueueRecord" /> instances that match the specified <paramref name='adminProleId' />.
        /// </returns>
        public IEnumerable<PrintQueueRecord> FetchAllByAdminProleId(String adminProleId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "AdminProleId");
            this.MapParameterIn(command, "@PA_PQ_ADMIN_PROLE_ID", adminProleId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IOutputQueueRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Document.PrintQueueRecord" /> instances from the data store.
        /// </summary>
        /// <param name="adminProleId">
        ///     The value which identifies the <see cref="!:OutputQueueModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Document.PrintQueueRecord" /> instances that match the specified <paramref name="adminProleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.PrintQueueRecord> IOutputQueueRepository.FetchAllByAdminProleId(System.String adminProleId)
        {
            return this.FetchAllByAdminProleId(adminProleId);
        }

        #endregion
    }
}
