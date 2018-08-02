using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Other
{
    /// <summary>
    ///     Represents the "ExportConfigurations" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class ExportconfigurationsRecord : Record<Int32>, Cloneable<ExportconfigurationsRecord>, IEquatable<ExportconfigurationsRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "EC_ADD_DATE" field.
        /// </summary>
        private DateTime _addDate;

        /// <summary>
        ///     the value of the "EC_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "EC_MOD_DATE" field.
        /// </summary>
        private DateTime _modDate;

        /// <summary>
        ///     the value of the "EC_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "EC_TITLE" field.
        /// </summary>
        private String _title;

        /// <summary>
        ///     the value of the "EC_DESCRIPTION" field.
        /// </summary>
        private String _description;

        /// <summary>
        ///     the value of the "EC_TYPE" field.
        /// </summary>
        private Byte? _type;

        /// <summary>
        ///     the value of the "EC_EXPORT_XML_CONFIG" field.
        /// </summary>
        private String _exportXmlConfig;

        /// <summary>
        ///     the value of the "EC_BAT_NAME" field.
        /// </summary>
        private String _batName;

        /// <summary>
        ///     the value of the "EC_BAT_TYPE" field.
        /// </summary>
        private String _batType;

        /// <summary>
        ///     the value of the "EC_BAT_PROC_NAME" field.
        /// </summary>
        private String _batProcName;

        /// <summary>
        ///     the value of the "EC_BAT_NOTES" field.
        /// </summary>
        private String _batNotes;

        /// <summary>
        ///     the value of the "EC_SELCO_SP_ID" field.
        /// </summary>
        private String _selcoSpId;

        /// <summary>
        ///     the value of the "EC_ACTIVE" field.
        /// </summary>
        private Byte? _active;

        /// <summary>
        ///     the value of the "EC_RUN_SETTING" field.
        /// </summary>
        private Byte? _runSetting;

        /// <summary>
        ///     the value of the "EC_RUN_TIMES" field.
        /// </summary>
        private String _runTimes;

        /// <summary>
        ///     the value of the "EC_LAST_RUN_DATE" field.
        /// </summary>
        private DateTime? _lastRunDate;

        /// <summary>
        ///     the value of the "EC_NEXT_RUN_DATE" field.
        /// </summary>
        private DateTime? _nextRunDate;

        /// <summary>
        ///     the value of the "EC_RUN_MINUTES" field.
        /// </summary>
        private Int32? _runMinutes;

        /// <summary>
        ///     the value of the "EC_EXPORT_TYPE" field.
        /// </summary>
        private Byte? _exportType;

        /// <summary>
        ///     the value of the "EC_FTP_HOST" field.
        /// </summary>
        private String _ftpHost;

        /// <summary>
        ///     the value of the "EC_FTP_PORT" field.
        /// </summary>
        private Int32? _ftpPort;

        /// <summary>
        ///     the value of the "EC_FTP_USERNAME" field.
        /// </summary>
        private String _ftpUsername;

        /// <summary>
        ///     the value of the "EC_FTP_PASSWORD" field.
        /// </summary>
        private String _ftpPassword;

        /// <summary>
        ///     the value of the "EC_FTP_PASSIVE" field.
        /// </summary>
        private Byte? _ftpPassive;

        /// <summary>
        ///     the value of the "EC_FTP_PROXY" field.
        /// </summary>
        private String _ftpProxy;

        /// <summary>
        ///     the value of the "EC_DAY" field.
        /// </summary>
        private Byte _day;

        /// <summary>
        ///     the value of the "EC_DAY_OF_THE_WEEK" field.
        /// </summary>
        private String _dayOfTheWeek;

        /// <summary>
        ///     the value of the "EC_ON_DAY" field.
        /// </summary>
        private Byte _onDay;

        /// <summary>
        ///     the value of the "EC_DEST_SQL_CONNECTION" field.
        /// </summary>
        private String _destSqlConnection;

        /// <summary>
        ///     the value of the "EC_CREATE_IF_ZERO_RECORDS" field.
        /// </summary>
        private Byte _createIfZeroRecords;

        /// <summary>
        ///     the value of the "EC_NOTIFICATION_ARG_ID" field.
        /// </summary>
        private String _notificationArgId;

        /// <summary>
        ///     the value of the "EC_NOTIFICATION_FAILURE_ARG_ID" field.
        /// </summary>
        private String _notificationFailureArgId;

        /// <summary>
        ///     the value of the "EC_NOTIFICATION_SENDER_EMAIL" field.
        /// </summary>
        private String _notificationSenderEmail;

        /// <summary>
        ///     the value of the "EC_BAT_ARG_ID" field.
        /// </summary>
        private String _batArgId;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "EC_ADD_DATE" field.
        /// </summary>
        public DateTime AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "EC_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "EC_MOD_DATE" field.
        /// </summary>
        public DateTime ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "EC_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "EC_TITLE" field.
        /// </summary>
        public String Title
        {
            get { return _title; }
            set { _title = value; }
        }

        /// <summary>
        ///     the value of the "EC_DESCRIPTION" field.
        /// </summary>
        public String Description
        {
            get { return _description; }
            set { _description = value; }
        }

        /// <summary>
        ///     the value of the "EC_TYPE" field.
        /// </summary>
        public Byte? Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        ///     the value of the "EC_EXPORT_XML_CONFIG" field.
        /// </summary>
        public String ExportXmlConfig
        {
            get { return _exportXmlConfig; }
            set { _exportXmlConfig = value; }
        }

        /// <summary>
        ///     the value of the "EC_BAT_NAME" field.
        /// </summary>
        public String BatName
        {
            get { return _batName; }
            set { _batName = value; }
        }

        /// <summary>
        ///     the value of the "EC_BAT_TYPE" field.
        /// </summary>
        public String BatType
        {
            get { return _batType; }
            set { _batType = value; }
        }

        /// <summary>
        ///     the value of the "EC_BAT_PROC_NAME" field.
        /// </summary>
        public String BatProcName
        {
            get { return _batProcName; }
            set { _batProcName = value; }
        }

        /// <summary>
        ///     the value of the "EC_BAT_NOTES" field.
        /// </summary>
        public String BatNotes
        {
            get { return _batNotes; }
            set { _batNotes = value; }
        }

        /// <summary>
        ///     the value of the "EC_SELCO_SP_ID" field.
        /// </summary>
        public String SelcoSpId
        {
            get { return _selcoSpId; }
            set { _selcoSpId = value; }
        }

        /// <summary>
        ///     the value of the "EC_ACTIVE" field.
        /// </summary>
        public Byte? Active
        {
            get { return _active; }
            set { _active = value; }
        }

        /// <summary>
        ///     the value of the "EC_RUN_SETTING" field.
        /// </summary>
        public Byte? RunSetting
        {
            get { return _runSetting; }
            set { _runSetting = value; }
        }

        /// <summary>
        ///     the value of the "EC_RUN_TIMES" field.
        /// </summary>
        public String RunTimes
        {
            get { return _runTimes; }
            set { _runTimes = value; }
        }

        /// <summary>
        ///     the value of the "EC_LAST_RUN_DATE" field.
        /// </summary>
        public DateTime? LastRunDate
        {
            get { return _lastRunDate; }
            set { _lastRunDate = value; }
        }

        /// <summary>
        ///     the value of the "EC_NEXT_RUN_DATE" field.
        /// </summary>
        public DateTime? NextRunDate
        {
            get { return _nextRunDate; }
            set { _nextRunDate = value; }
        }

        /// <summary>
        ///     the value of the "EC_RUN_MINUTES" field.
        /// </summary>
        public Int32? RunMinutes
        {
            get { return _runMinutes; }
            set { _runMinutes = value; }
        }

        /// <summary>
        ///     the value of the "EC_EXPORT_TYPE" field.
        /// </summary>
        public Byte? ExportType
        {
            get { return _exportType; }
            set { _exportType = value; }
        }

        /// <summary>
        ///     the value of the "EC_FTP_HOST" field.
        /// </summary>
        public String FtpHost
        {
            get { return _ftpHost; }
            set { _ftpHost = value; }
        }

        /// <summary>
        ///     the value of the "EC_FTP_PORT" field.
        /// </summary>
        public Int32? FtpPort
        {
            get { return _ftpPort; }
            set { _ftpPort = value; }
        }

        /// <summary>
        ///     the value of the "EC_FTP_USERNAME" field.
        /// </summary>
        public String FtpUsername
        {
            get { return _ftpUsername; }
            set { _ftpUsername = value; }
        }

        /// <summary>
        ///     the value of the "EC_FTP_PASSWORD" field.
        /// </summary>
        public String FtpPassword
        {
            get { return _ftpPassword; }
            set { _ftpPassword = value; }
        }

        /// <summary>
        ///     the value of the "EC_FTP_PASSIVE" field.
        /// </summary>
        public Byte? FtpPassive
        {
            get { return _ftpPassive; }
            set { _ftpPassive = value; }
        }

        /// <summary>
        ///     the value of the "EC_FTP_PROXY" field.
        /// </summary>
        public String FtpProxy
        {
            get { return _ftpProxy; }
            set { _ftpProxy = value; }
        }

        /// <summary>
        ///     the value of the "EC_DAY" field.
        /// </summary>
        public Byte Day
        {
            get { return _day; }
            set { _day = value; }
        }

        /// <summary>
        ///     the value of the "EC_DAY_OF_THE_WEEK" field.
        /// </summary>
        public String DayOfTheWeek
        {
            get { return _dayOfTheWeek; }
            set { _dayOfTheWeek = value; }
        }

        /// <summary>
        ///     the value of the "EC_ON_DAY" field.
        /// </summary>
        public Byte OnDay
        {
            get { return _onDay; }
            set { _onDay = value; }
        }

        /// <summary>
        ///     the value of the "EC_DEST_SQL_CONNECTION" field.
        /// </summary>
        public String DestSqlConnection
        {
            get { return _destSqlConnection; }
            set { _destSqlConnection = value; }
        }

        /// <summary>
        ///     the value of the "EC_CREATE_IF_ZERO_RECORDS" field.
        /// </summary>
        public Byte CreateIfZeroRecords
        {
            get { return _createIfZeroRecords; }
            set { _createIfZeroRecords = value; }
        }

        /// <summary>
        ///     the value of the "EC_NOTIFICATION_ARG_ID" field.
        /// </summary>
        public String NotificationArgId
        {
            get { return _notificationArgId; }
            set { _notificationArgId = value; }
        }

        /// <summary>
        ///     the value of the "EC_NOTIFICATION_FAILURE_ARG_ID" field.
        /// </summary>
        public String NotificationFailureArgId
        {
            get { return _notificationFailureArgId; }
            set { _notificationFailureArgId = value; }
        }

        /// <summary>
        ///     the value of the "EC_NOTIFICATION_SENDER_EMAIL" field.
        /// </summary>
        public String NotificationSenderEmail
        {
            get { return _notificationSenderEmail; }
            set { _notificationSenderEmail = value; }
        }

        /// <summary>
        ///     the value of the "EC_BAT_ARG_ID" field.
        /// </summary>
        public String BatArgId
        {
            get { return _batArgId; }
            set { _batArgId = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="ExportconfigurationsRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="ExportconfigurationsRecord" /> object instance.
        /// </returns>
        public ExportconfigurationsRecord Clone()
        {
            ExportconfigurationsRecord record = new ExportconfigurationsRecord();
            record.Id = this.Id;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.Title = this.Title;
            record.Description = this.Description;
            record.Type = this.Type;
            record.ExportXmlConfig = this.ExportXmlConfig;
            record.BatName = this.BatName;
            record.BatType = this.BatType;
            record.BatProcName = this.BatProcName;
            record.BatNotes = this.BatNotes;
            record.SelcoSpId = this.SelcoSpId;
            record.Active = this.Active;
            record.RunSetting = this.RunSetting;
            record.RunTimes = this.RunTimes;
            record.LastRunDate = this.LastRunDate;
            record.NextRunDate = this.NextRunDate;
            record.RunMinutes = this.RunMinutes;
            record.ExportType = this.ExportType;
            record.FtpHost = this.FtpHost;
            record.FtpPort = this.FtpPort;
            record.FtpUsername = this.FtpUsername;
            record.FtpPassword = this.FtpPassword;
            record.FtpPassive = this.FtpPassive;
            record.FtpProxy = this.FtpProxy;
            record.Day = this.Day;
            record.DayOfTheWeek = this.DayOfTheWeek;
            record.OnDay = this.OnDay;
            record.DestSqlConnection = this.DestSqlConnection;
            record.CreateIfZeroRecords = this.CreateIfZeroRecords;
            record.NotificationArgId = this.NotificationArgId;
            record.NotificationFailureArgId = this.NotificationFailureArgId;
            record.NotificationSenderEmail = this.NotificationSenderEmail;
            record.BatArgId = this.BatArgId;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="ExportconfigurationsRecord" /> instance is equal to another <see cref="ExportconfigurationsRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="ExportconfigurationsRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(ExportconfigurationsRecord that)
        {
            Boolean result = true;
            result = result && (this.Id == that.Id);
            result = result && (this.Title.TrimOrNullify() == that.Title.TrimOrNullify());
            result = result && (this.Description.TrimOrNullify() == that.Description.TrimOrNullify());
            result = result && (this.Type == that.Type);
            result = result && (this.ExportXmlConfig.TrimOrNullify() == that.ExportXmlConfig.TrimOrNullify());
            result = result && (this.BatName.TrimOrNullify() == that.BatName.TrimOrNullify());
            result = result && (this.BatType.TrimOrNullify() == that.BatType.TrimOrNullify());
            result = result && (this.BatProcName.TrimOrNullify() == that.BatProcName.TrimOrNullify());
            result = result && (this.BatNotes.TrimOrNullify() == that.BatNotes.TrimOrNullify());
            result = result && (this.SelcoSpId.TrimOrNullify() == that.SelcoSpId.TrimOrNullify());
            result = result && (this.Active == that.Active);
            result = result && (this.RunSetting == that.RunSetting);
            result = result && (this.RunTimes.TrimOrNullify() == that.RunTimes.TrimOrNullify());
            result = result && (this.LastRunDate == that.LastRunDate);
            result = result && (this.NextRunDate == that.NextRunDate);
            result = result && (this.RunMinutes == that.RunMinutes);
            result = result && (this.ExportType == that.ExportType);
            result = result && (this.FtpHost.TrimOrNullify() == that.FtpHost.TrimOrNullify());
            result = result && (this.FtpPort == that.FtpPort);
            result = result && (this.FtpUsername.TrimOrNullify() == that.FtpUsername.TrimOrNullify());
            result = result && (this.FtpPassword.TrimOrNullify() == that.FtpPassword.TrimOrNullify());
            result = result && (this.FtpPassive == that.FtpPassive);
            result = result && (this.FtpProxy.TrimOrNullify() == that.FtpProxy.TrimOrNullify());
            result = result && (this.Day == that.Day);
            result = result && (this.DayOfTheWeek.TrimOrNullify() == that.DayOfTheWeek.TrimOrNullify());
            result = result && (this.OnDay == that.OnDay);
            result = result && (this.DestSqlConnection.TrimOrNullify() == that.DestSqlConnection.TrimOrNullify());
            result = result && (this.CreateIfZeroRecords == that.CreateIfZeroRecords);
            result = result && (this.NotificationArgId.TrimOrNullify() == that.NotificationArgId.TrimOrNullify());
            result = result && (this.NotificationFailureArgId.TrimOrNullify() == that.NotificationFailureArgId.TrimOrNullify());
            result = result && (this.NotificationSenderEmail.TrimOrNullify() == that.NotificationSenderEmail.TrimOrNullify());
            result = result && (this.BatArgId.TrimOrNullify() == that.BatArgId.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
