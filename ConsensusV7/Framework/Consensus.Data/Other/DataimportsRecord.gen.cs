using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Other
{
    /// <summary>
    ///     Represents the "DataImports" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class DataimportsRecord : Record<Int32>, Cloneable<DataimportsRecord>, IEquatable<DataimportsRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "DI_ADD_DATE" field.
        /// </summary>
        private DateTime _addDate;

        /// <summary>
        ///     the value of the "DI_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "DI_MOD_DATE" field.
        /// </summary>
        private DateTime _modDate;

        /// <summary>
        ///     the value of the "DI_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "DI_TITLE" field.
        /// </summary>
        private String _title;

        /// <summary>
        ///     the value of the "DI_DESCRIPTION" field.
        /// </summary>
        private String _description;

        /// <summary>
        ///     the value of the "DI_TYPE" field.
        /// </summary>
        private Byte? _type;

        /// <summary>
        ///     the value of the "DI_SERVICE_NAME" field.
        /// </summary>
        private String _serviceName;

        /// <summary>
        ///     the value of the "DI_SOURCE_SQL_CONNECTION" field.
        /// </summary>
        private String _sourceSqlConnection;

        /// <summary>
        ///     the value of the "DI_DEST_SQL_CONNECTION" field.
        /// </summary>
        private String _destSqlConnection;

        /// <summary>
        ///     the value of the "DI_ACTIVE" field.
        /// </summary>
        private Byte? _active;

        /// <summary>
        ///     the value of the "DI_LAST_RUN_DATE" field.
        /// </summary>
        private DateTime? _lastRunDate;

        /// <summary>
        ///     the value of the "DI_NEXT_RUN_DATE" field.
        /// </summary>
        private DateTime? _nextRunDate;

        /// <summary>
        ///     the value of the "DI_RUN_MINUTES" field.
        /// </summary>
        private Int32? _runMinutes;

        /// <summary>
        ///     the value of the "DI_FILE_DROP_FOLDER" field.
        /// </summary>
        private String _fileDropFolder;

        /// <summary>
        ///     the value of the "DI_FILE_COLUMN_HEADERS" field.
        /// </summary>
        private Byte? _fileColumnHeaders;

        /// <summary>
        ///     the value of the "DI_FILE_TYPE" field.
        /// </summary>
        private Byte _fileType;

        /// <summary>
        ///     the value of the "DI_ARG_ID" field.
        /// </summary>
        private String _argId;

        /// <summary>
        ///     the value of the "DI_FTP_TYPE" field.
        /// </summary>
        private Byte _ftpType;

        /// <summary>
        ///     the value of the "DI_FTP_HOST" field.
        /// </summary>
        private String _ftpHost;

        /// <summary>
        ///     the value of the "DI_FTP_PORT" field.
        /// </summary>
        private Int32? _ftpPort;

        /// <summary>
        ///     the value of the "DI_FTP_USERNAME" field.
        /// </summary>
        private String _ftpUsername;

        /// <summary>
        ///     the value of the "DI_FTP_PASSWORD" field.
        /// </summary>
        private String _ftpPassword;

        /// <summary>
        ///     the value of the "DI_FTP_PASSIVE" field.
        /// </summary>
        private Byte? _ftpPassive;

        /// <summary>
        ///     the value of the "DI_FTP_PROXY" field.
        /// </summary>
        private String _ftpProxy;

        /// <summary>
        ///     the value of the "DI_FTP_SUB_FOLDERS" field.
        /// </summary>
        private String _ftpSubFolders;

        /// <summary>
        ///     the value of the "DI_MSEXCH_USERNAME" field.
        /// </summary>
        private String _msexchUsername;

        /// <summary>
        ///     the value of the "DI_MSEXCH_PASSWORD" field.
        /// </summary>
        private String _msexchPassword;

        /// <summary>
        ///     the value of the "DI_MSEXCH_ACCOUNT" field.
        /// </summary>
        private String _msexchAccount;

        /// <summary>
        ///     the value of the "DI_MSEXCH_SERVICE_URL" field.
        /// </summary>
        private String _msexchServiceUrl;

        /// <summary>
        ///     the value of the "DI_EXCEL_SHEET" field.
        /// </summary>
        private String _excelSheet;

        /// <summary>
        ///     the value of the "DI_EXCEL_START" field.
        /// </summary>
        private String _excelStart;

        /// <summary>
        ///     the value of the "DI_EXCEL_END" field.
        /// </summary>
        private String _excelEnd;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "DI_ADD_DATE" field.
        /// </summary>
        public DateTime AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "DI_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "DI_MOD_DATE" field.
        /// </summary>
        public DateTime ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "DI_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "DI_TITLE" field.
        /// </summary>
        public String Title
        {
            get { return _title; }
            set { _title = value; }
        }

        /// <summary>
        ///     the value of the "DI_DESCRIPTION" field.
        /// </summary>
        public String Description
        {
            get { return _description; }
            set { _description = value; }
        }

        /// <summary>
        ///     the value of the "DI_TYPE" field.
        /// </summary>
        public Byte? Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        ///     the value of the "DI_SERVICE_NAME" field.
        /// </summary>
        public String ServiceName
        {
            get { return _serviceName; }
            set { _serviceName = value; }
        }

        /// <summary>
        ///     the value of the "DI_SOURCE_SQL_CONNECTION" field.
        /// </summary>
        public String SourceSqlConnection
        {
            get { return _sourceSqlConnection; }
            set { _sourceSqlConnection = value; }
        }

        /// <summary>
        ///     the value of the "DI_DEST_SQL_CONNECTION" field.
        /// </summary>
        public String DestSqlConnection
        {
            get { return _destSqlConnection; }
            set { _destSqlConnection = value; }
        }

        /// <summary>
        ///     the value of the "DI_ACTIVE" field.
        /// </summary>
        public Byte? Active
        {
            get { return _active; }
            set { _active = value; }
        }

        /// <summary>
        ///     the value of the "DI_LAST_RUN_DATE" field.
        /// </summary>
        public DateTime? LastRunDate
        {
            get { return _lastRunDate; }
            set { _lastRunDate = value; }
        }

        /// <summary>
        ///     the value of the "DI_NEXT_RUN_DATE" field.
        /// </summary>
        public DateTime? NextRunDate
        {
            get { return _nextRunDate; }
            set { _nextRunDate = value; }
        }

        /// <summary>
        ///     the value of the "DI_RUN_MINUTES" field.
        /// </summary>
        public Int32? RunMinutes
        {
            get { return _runMinutes; }
            set { _runMinutes = value; }
        }

        /// <summary>
        ///     the value of the "DI_FILE_DROP_FOLDER" field.
        /// </summary>
        public String FileDropFolder
        {
            get { return _fileDropFolder; }
            set { _fileDropFolder = value; }
        }

        /// <summary>
        ///     the value of the "DI_FILE_COLUMN_HEADERS" field.
        /// </summary>
        public Byte? FileColumnHeaders
        {
            get { return _fileColumnHeaders; }
            set { _fileColumnHeaders = value; }
        }

        /// <summary>
        ///     the value of the "DI_FILE_TYPE" field.
        /// </summary>
        public Byte FileType
        {
            get { return _fileType; }
            set { _fileType = value; }
        }

        /// <summary>
        ///     the value of the "DI_ARG_ID" field.
        /// </summary>
        public String ArgId
        {
            get { return _argId; }
            set { _argId = value; }
        }

        /// <summary>
        ///     the value of the "DI_FTP_TYPE" field.
        /// </summary>
        public Byte FtpType
        {
            get { return _ftpType; }
            set { _ftpType = value; }
        }

        /// <summary>
        ///     the value of the "DI_FTP_HOST" field.
        /// </summary>
        public String FtpHost
        {
            get { return _ftpHost; }
            set { _ftpHost = value; }
        }

        /// <summary>
        ///     the value of the "DI_FTP_PORT" field.
        /// </summary>
        public Int32? FtpPort
        {
            get { return _ftpPort; }
            set { _ftpPort = value; }
        }

        /// <summary>
        ///     the value of the "DI_FTP_USERNAME" field.
        /// </summary>
        public String FtpUsername
        {
            get { return _ftpUsername; }
            set { _ftpUsername = value; }
        }

        /// <summary>
        ///     the value of the "DI_FTP_PASSWORD" field.
        /// </summary>
        public String FtpPassword
        {
            get { return _ftpPassword; }
            set { _ftpPassword = value; }
        }

        /// <summary>
        ///     the value of the "DI_FTP_PASSIVE" field.
        /// </summary>
        public Byte? FtpPassive
        {
            get { return _ftpPassive; }
            set { _ftpPassive = value; }
        }

        /// <summary>
        ///     the value of the "DI_FTP_PROXY" field.
        /// </summary>
        public String FtpProxy
        {
            get { return _ftpProxy; }
            set { _ftpProxy = value; }
        }

        /// <summary>
        ///     the value of the "DI_FTP_SUB_FOLDERS" field.
        /// </summary>
        public String FtpSubFolders
        {
            get { return _ftpSubFolders; }
            set { _ftpSubFolders = value; }
        }

        /// <summary>
        ///     the value of the "DI_MSEXCH_USERNAME" field.
        /// </summary>
        public String MsexchUsername
        {
            get { return _msexchUsername; }
            set { _msexchUsername = value; }
        }

        /// <summary>
        ///     the value of the "DI_MSEXCH_PASSWORD" field.
        /// </summary>
        public String MsexchPassword
        {
            get { return _msexchPassword; }
            set { _msexchPassword = value; }
        }

        /// <summary>
        ///     the value of the "DI_MSEXCH_ACCOUNT" field.
        /// </summary>
        public String MsexchAccount
        {
            get { return _msexchAccount; }
            set { _msexchAccount = value; }
        }

        /// <summary>
        ///     the value of the "DI_MSEXCH_SERVICE_URL" field.
        /// </summary>
        public String MsexchServiceUrl
        {
            get { return _msexchServiceUrl; }
            set { _msexchServiceUrl = value; }
        }

        /// <summary>
        ///     the value of the "DI_EXCEL_SHEET" field.
        /// </summary>
        public String ExcelSheet
        {
            get { return _excelSheet; }
            set { _excelSheet = value; }
        }

        /// <summary>
        ///     the value of the "DI_EXCEL_START" field.
        /// </summary>
        public String ExcelStart
        {
            get { return _excelStart; }
            set { _excelStart = value; }
        }

        /// <summary>
        ///     the value of the "DI_EXCEL_END" field.
        /// </summary>
        public String ExcelEnd
        {
            get { return _excelEnd; }
            set { _excelEnd = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="DataimportsRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="DataimportsRecord" /> object instance.
        /// </returns>
        public DataimportsRecord Clone()
        {
            DataimportsRecord record = new DataimportsRecord();
            record.Id = this.Id;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.Title = this.Title;
            record.Description = this.Description;
            record.Type = this.Type;
            record.ServiceName = this.ServiceName;
            record.SourceSqlConnection = this.SourceSqlConnection;
            record.DestSqlConnection = this.DestSqlConnection;
            record.Active = this.Active;
            record.LastRunDate = this.LastRunDate;
            record.NextRunDate = this.NextRunDate;
            record.RunMinutes = this.RunMinutes;
            record.FileDropFolder = this.FileDropFolder;
            record.FileColumnHeaders = this.FileColumnHeaders;
            record.FileType = this.FileType;
            record.ArgId = this.ArgId;
            record.FtpType = this.FtpType;
            record.FtpHost = this.FtpHost;
            record.FtpPort = this.FtpPort;
            record.FtpUsername = this.FtpUsername;
            record.FtpPassword = this.FtpPassword;
            record.FtpPassive = this.FtpPassive;
            record.FtpProxy = this.FtpProxy;
            record.FtpSubFolders = this.FtpSubFolders;
            record.MsexchUsername = this.MsexchUsername;
            record.MsexchPassword = this.MsexchPassword;
            record.MsexchAccount = this.MsexchAccount;
            record.MsexchServiceUrl = this.MsexchServiceUrl;
            record.ExcelSheet = this.ExcelSheet;
            record.ExcelStart = this.ExcelStart;
            record.ExcelEnd = this.ExcelEnd;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="DataimportsRecord" /> instance is equal to another <see cref="DataimportsRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="DataimportsRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(DataimportsRecord that)
        {
            Boolean result = true;
            result = result && (this.Id == that.Id);
            result = result && (this.Title.TrimOrNullify() == that.Title.TrimOrNullify());
            result = result && (this.Description.TrimOrNullify() == that.Description.TrimOrNullify());
            result = result && (this.Type == that.Type);
            result = result && (this.ServiceName.TrimOrNullify() == that.ServiceName.TrimOrNullify());
            result = result && (this.SourceSqlConnection.TrimOrNullify() == that.SourceSqlConnection.TrimOrNullify());
            result = result && (this.DestSqlConnection.TrimOrNullify() == that.DestSqlConnection.TrimOrNullify());
            result = result && (this.Active == that.Active);
            result = result && (this.LastRunDate == that.LastRunDate);
            result = result && (this.NextRunDate == that.NextRunDate);
            result = result && (this.RunMinutes == that.RunMinutes);
            result = result && (this.FileDropFolder.TrimOrNullify() == that.FileDropFolder.TrimOrNullify());
            result = result && (this.FileColumnHeaders == that.FileColumnHeaders);
            result = result && (this.FileType == that.FileType);
            result = result && (this.ArgId.TrimOrNullify() == that.ArgId.TrimOrNullify());
            result = result && (this.FtpType == that.FtpType);
            result = result && (this.FtpHost.TrimOrNullify() == that.FtpHost.TrimOrNullify());
            result = result && (this.FtpPort == that.FtpPort);
            result = result && (this.FtpUsername.TrimOrNullify() == that.FtpUsername.TrimOrNullify());
            result = result && (this.FtpPassword.TrimOrNullify() == that.FtpPassword.TrimOrNullify());
            result = result && (this.FtpPassive == that.FtpPassive);
            result = result && (this.FtpProxy.TrimOrNullify() == that.FtpProxy.TrimOrNullify());
            result = result && (this.FtpSubFolders.TrimOrNullify() == that.FtpSubFolders.TrimOrNullify());
            result = result && (this.MsexchUsername.TrimOrNullify() == that.MsexchUsername.TrimOrNullify());
            result = result && (this.MsexchPassword.TrimOrNullify() == that.MsexchPassword.TrimOrNullify());
            result = result && (this.MsexchAccount.TrimOrNullify() == that.MsexchAccount.TrimOrNullify());
            result = result && (this.MsexchServiceUrl.TrimOrNullify() == that.MsexchServiceUrl.TrimOrNullify());
            result = result && (this.ExcelSheet.TrimOrNullify() == that.ExcelSheet.TrimOrNullify());
            result = result && (this.ExcelStart.TrimOrNullify() == that.ExcelStart.TrimOrNullify());
            result = result && (this.ExcelEnd.TrimOrNullify() == that.ExcelEnd.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
