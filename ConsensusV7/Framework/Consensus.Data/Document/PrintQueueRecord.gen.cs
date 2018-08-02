using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Represents the "PRINT_QUEUE" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class PrintQueueRecord : Record<String>, Cloneable<PrintQueueRecord>, IEquatable<PrintQueueRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "PQ_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "PQ_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "PQ_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "PQ_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "PQ_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "PQ_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "PQ_QUEUE_TYPE" field.
        /// </summary>
        private String _queueType;

        /// <summary>
        ///     the value of the "PQ_ADD_ID" field.
        /// </summary>
        private String _addId;

        /// <summary>
        ///     the value of the "PQ_ORG_ID" field.
        /// </summary>
        private String _orgId;

        /// <summary>
        ///     the value of the "PQ_SEND_TYPE" field.
        /// </summary>
        private Byte? _sendType;

        /// <summary>
        ///     the value of the "PQ_STATIONARY_TYPE" field.
        /// </summary>
        private Byte? _stationaryType;

        /// <summary>
        ///     the value of the "PQ_ADMIN_PN_ID" field.
        /// </summary>
        private String _adminPnId;

        /// <summary>
        ///     the value of the "PQ_ADMIN_PROLE_ID" field.
        /// </summary>
        private String _adminProleId;

        /// <summary>
        ///     the value of the "PQ_MAIL_SERVER" field.
        /// </summary>
        private String _mailServer;

        /// <summary>
        ///     the value of the "PQ_LOGON_ID" field.
        /// </summary>
        private String _logonId;

        /// <summary>
        ///     the value of the "PQ_LOGON_PASSWORD" field.
        /// </summary>
        private String _logonPassword;

        /// <summary>
        ///     the value of the "PQ_PRINT_SERVER" field.
        /// </summary>
        private String _printServer;

        /// <summary>
        ///     the value of the "PQ_PRINT_PRINTER" field.
        /// </summary>
        private String _printPrinter;

        /// <summary>
        ///     the value of the "PQ_PRINTER_TYPE" field.
        /// </summary>
        private String _printerType;

        /// <summary>
        ///     the value of the "PQ_PRINTER_NOTES" field.
        /// </summary>
        private String _printerNotes;

        /// <summary>
        ///     the value of the "PQ_DESCRIPTION" field.
        /// </summary>
        private String _description;

        /// <summary>
        ///     the value of the "PQ_SYSTEM_DEFAULT" field.
        /// </summary>
        private Byte? _systemDefault;

        /// <summary>
        ///     the value of the "PQ_DPM_SERVER" field.
        /// </summary>
        private String _dpmServer;

        /// <summary>
        ///     the value of the "PQ_STATUS" field.
        /// </summary>
        private Byte? _status;

        /// <summary>
        ///     the value of the "PQ_PORT" field.
        /// </summary>
        private String _port;

        /// <summary>
        ///     the value of the "PQ_SSL" field.
        /// </summary>
        private Byte? _ssl;

        /// <summary>
        ///     the value of the "PQ_PROXY" field.
        /// </summary>
        private Byte? _proxy;

        /// <summary>
        ///     the value of the "PQ_FROM" field.
        /// </summary>
        private String _from;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "PQ_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "PQ_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "PQ_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "PQ_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "PQ_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "PQ_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "PQ_QUEUE_TYPE" field.
        /// </summary>
        public String QueueType
        {
            get { return _queueType; }
            set { _queueType = value; }
        }

        /// <summary>
        ///     the value of the "PQ_ADD_ID" field.
        /// </summary>
        public String AddId
        {
            get { return _addId; }
            set { _addId = value; }
        }

        /// <summary>
        ///     the value of the "PQ_ORG_ID" field.
        /// </summary>
        public String OrgId
        {
            get { return _orgId; }
            set { _orgId = value; }
        }

        /// <summary>
        ///     the value of the "PQ_SEND_TYPE" field.
        /// </summary>
        public Byte? SendType
        {
            get { return _sendType; }
            set { _sendType = value; }
        }

        /// <summary>
        ///     the value of the "PQ_STATIONARY_TYPE" field.
        /// </summary>
        public Byte? StationaryType
        {
            get { return _stationaryType; }
            set { _stationaryType = value; }
        }

        /// <summary>
        ///     the value of the "PQ_ADMIN_PN_ID" field.
        /// </summary>
        public String AdminPnId
        {
            get { return _adminPnId; }
            set { _adminPnId = value; }
        }

        /// <summary>
        ///     the value of the "PQ_ADMIN_PROLE_ID" field.
        /// </summary>
        public String AdminProleId
        {
            get { return _adminProleId; }
            set { _adminProleId = value; }
        }

        /// <summary>
        ///     the value of the "PQ_MAIL_SERVER" field.
        /// </summary>
        public String MailServer
        {
            get { return _mailServer; }
            set { _mailServer = value; }
        }

        /// <summary>
        ///     the value of the "PQ_LOGON_ID" field.
        /// </summary>
        public String LogonId
        {
            get { return _logonId; }
            set { _logonId = value; }
        }

        /// <summary>
        ///     the value of the "PQ_LOGON_PASSWORD" field.
        /// </summary>
        public String LogonPassword
        {
            get { return _logonPassword; }
            set { _logonPassword = value; }
        }

        /// <summary>
        ///     the value of the "PQ_PRINT_SERVER" field.
        /// </summary>
        public String PrintServer
        {
            get { return _printServer; }
            set { _printServer = value; }
        }

        /// <summary>
        ///     the value of the "PQ_PRINT_PRINTER" field.
        /// </summary>
        public String PrintPrinter
        {
            get { return _printPrinter; }
            set { _printPrinter = value; }
        }

        /// <summary>
        ///     the value of the "PQ_PRINTER_TYPE" field.
        /// </summary>
        public String PrinterType
        {
            get { return _printerType; }
            set { _printerType = value; }
        }

        /// <summary>
        ///     the value of the "PQ_PRINTER_NOTES" field.
        /// </summary>
        public String PrinterNotes
        {
            get { return _printerNotes; }
            set { _printerNotes = value; }
        }

        /// <summary>
        ///     the value of the "PQ_DESCRIPTION" field.
        /// </summary>
        public String Description
        {
            get { return _description; }
            set { _description = value; }
        }

        /// <summary>
        ///     the value of the "PQ_SYSTEM_DEFAULT" field.
        /// </summary>
        public Byte? SystemDefault
        {
            get { return _systemDefault; }
            set { _systemDefault = value; }
        }

        /// <summary>
        ///     the value of the "PQ_DPM_SERVER" field.
        /// </summary>
        public String DpmServer
        {
            get { return _dpmServer; }
            set { _dpmServer = value; }
        }

        /// <summary>
        ///     the value of the "PQ_STATUS" field.
        /// </summary>
        public Byte? Status
        {
            get { return _status; }
            set { _status = value; }
        }

        /// <summary>
        ///     the value of the "PQ_PORT" field.
        /// </summary>
        public String Port
        {
            get { return _port; }
            set { _port = value; }
        }

        /// <summary>
        ///     the value of the "PQ_SSL" field.
        /// </summary>
        public Byte? Ssl
        {
            get { return _ssl; }
            set { _ssl = value; }
        }

        /// <summary>
        ///     the value of the "PQ_PROXY" field.
        /// </summary>
        public Byte? Proxy
        {
            get { return _proxy; }
            set { _proxy = value; }
        }

        /// <summary>
        ///     the value of the "PQ_FROM" field.
        /// </summary>
        public String From
        {
            get { return _from; }
            set { _from = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="PrintQueueRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="PrintQueueRecord" /> object instance.
        /// </returns>
        public PrintQueueRecord Clone()
        {
            PrintQueueRecord record = new PrintQueueRecord();
            record.Id = this.Id;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.QueueType = this.QueueType;
            record.AddId = this.AddId;
            record.OrgId = this.OrgId;
            record.SendType = this.SendType;
            record.StationaryType = this.StationaryType;
            record.AdminPnId = this.AdminPnId;
            record.AdminProleId = this.AdminProleId;
            record.MailServer = this.MailServer;
            record.LogonId = this.LogonId;
            record.LogonPassword = this.LogonPassword;
            record.PrintServer = this.PrintServer;
            record.PrintPrinter = this.PrintPrinter;
            record.PrinterType = this.PrinterType;
            record.PrinterNotes = this.PrinterNotes;
            record.Description = this.Description;
            record.SystemDefault = this.SystemDefault;
            record.DpmServer = this.DpmServer;
            record.Status = this.Status;
            record.Port = this.Port;
            record.Ssl = this.Ssl;
            record.Proxy = this.Proxy;
            record.From = this.From;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="PrintQueueRecord" /> instance is equal to another <see cref="PrintQueueRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="PrintQueueRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(PrintQueueRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.QueueType.TrimOrNullify() == that.QueueType.TrimOrNullify());
            result = result && (this.AddId.TrimOrNullify() == that.AddId.TrimOrNullify());
            result = result && (this.OrgId.TrimOrNullify() == that.OrgId.TrimOrNullify());
            result = result && (this.SendType == that.SendType);
            result = result && (this.StationaryType == that.StationaryType);
            result = result && (this.AdminPnId.TrimOrNullify() == that.AdminPnId.TrimOrNullify());
            result = result && (this.AdminProleId.TrimOrNullify() == that.AdminProleId.TrimOrNullify());
            result = result && (this.MailServer.TrimOrNullify() == that.MailServer.TrimOrNullify());
            result = result && (this.LogonId.TrimOrNullify() == that.LogonId.TrimOrNullify());
            result = result && (this.LogonPassword.TrimOrNullify() == that.LogonPassword.TrimOrNullify());
            result = result && (this.PrintServer.TrimOrNullify() == that.PrintServer.TrimOrNullify());
            result = result && (this.PrintPrinter.TrimOrNullify() == that.PrintPrinter.TrimOrNullify());
            result = result && (this.PrinterType.TrimOrNullify() == that.PrinterType.TrimOrNullify());
            result = result && (this.PrinterNotes.TrimOrNullify() == that.PrinterNotes.TrimOrNullify());
            result = result && (this.Description.TrimOrNullify() == that.Description.TrimOrNullify());
            result = result && (this.SystemDefault == that.SystemDefault);
            result = result && (this.DpmServer.TrimOrNullify() == that.DpmServer.TrimOrNullify());
            result = result && (this.Status == that.Status);
            result = result && (this.Port.TrimOrNullify() == that.Port.TrimOrNullify());
            result = result && (this.Ssl == that.Ssl);
            result = result && (this.Proxy == that.Proxy);
            result = result && (this.From.TrimOrNullify() == that.From.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
