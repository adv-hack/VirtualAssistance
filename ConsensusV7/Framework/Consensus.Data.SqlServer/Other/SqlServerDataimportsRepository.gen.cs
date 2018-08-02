using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Other
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="DataimportsRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerDataimportsRepository : SqlServerRepository<DataimportsRecord, Int32>, IDataimportsRepository
    {
        #region properties

        /// <summary>
        ///     Gets the namespace in which the data type is contained.
        /// </summary>
        protected override String TypeNamespace
        {
            get { return "Other"; }
        }

        /// <summary>
        ///     Gets the name of the data type which is persisted by this repository.
        /// </summary>
        protected override String TypeName
        {
            get { return "Dataimports"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="DataimportsRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_DI_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "DataImports"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="DataimportsRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="DataimportsRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, DataimportsRecord record)
        {
            record.Id = dataRecord["DI_ID"].ConvertTo<Int32>();
            record.AddDate = dataRecord["DI_ADD_DATE"].ConvertTo<DateTime>();
            record.AddBy = dataRecord["DI_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["DI_MOD_DATE"].ConvertTo<DateTime>();
            record.ModBy = dataRecord["DI_MOD_BY"].ConvertTo<String>();
            record.Title = dataRecord["DI_TITLE"].ConvertTo<String>();
            record.Description = dataRecord["DI_DESCRIPTION"].ConvertTo<String>();
            record.Type = dataRecord["DI_TYPE"].ConvertTo<Byte?>();
            record.ServiceName = dataRecord["DI_SERVICE_NAME"].ConvertTo<String>();
            record.SourceSqlConnection = dataRecord["DI_SOURCE_SQL_CONNECTION"].ConvertTo<String>();
            record.DestSqlConnection = dataRecord["DI_DEST_SQL_CONNECTION"].ConvertTo<String>();
            record.Active = dataRecord["DI_ACTIVE"].ConvertTo<Byte?>();
            record.LastRunDate = dataRecord["DI_LAST_RUN_DATE"].ConvertTo<DateTime?>();
            record.NextRunDate = dataRecord["DI_NEXT_RUN_DATE"].ConvertTo<DateTime?>();
            record.RunMinutes = dataRecord["DI_RUN_MINUTES"].ConvertTo<Int32?>();
            record.FileDropFolder = dataRecord["DI_FILE_DROP_FOLDER"].ConvertTo<String>();
            record.FileColumnHeaders = dataRecord["DI_FILE_COLUMN_HEADERS"].ConvertTo<Byte?>();
            record.FileType = dataRecord["DI_FILE_TYPE"].ConvertTo<Byte>();
            record.ArgId = dataRecord["DI_ARG_ID"].ConvertTo<String>();
            record.FtpType = dataRecord["DI_FTP_TYPE"].ConvertTo<Byte>();
            record.FtpHost = dataRecord["DI_FTP_HOST"].ConvertTo<String>();
            record.FtpPort = dataRecord["DI_FTP_PORT"].ConvertTo<Int32?>();
            record.FtpUsername = dataRecord["DI_FTP_USERNAME"].ConvertTo<String>();
            record.FtpPassword = dataRecord["DI_FTP_PASSWORD"].ConvertTo<String>();
            record.FtpPassive = dataRecord["DI_FTP_PASSIVE"].ConvertTo<Byte?>();
            record.FtpProxy = dataRecord["DI_FTP_PROXY"].ConvertTo<String>();
            record.FtpSubFolders = dataRecord["DI_FTP_SUB_FOLDERS"].ConvertTo<String>();
            record.MsexchUsername = dataRecord["DI_MSEXCH_USERNAME"].ConvertTo<String>();
            record.MsexchPassword = dataRecord["DI_MSEXCH_PASSWORD"].ConvertTo<String>();
            record.MsexchAccount = dataRecord["DI_MSEXCH_ACCOUNT"].ConvertTo<String>();
            record.MsexchServiceUrl = dataRecord["DI_MSEXCH_SERVICE_URL"].ConvertTo<String>();
            record.ExcelSheet = dataRecord["DI_EXCEL_SHEET"].ConvertTo<String>();
            record.ExcelStart = dataRecord["DI_EXCEL_START"].ConvertTo<String>();
            record.ExcelEnd = dataRecord["DI_EXCEL_END"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="DataimportsRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, DataimportsRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_DI_ID", record.Id == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Id);
            this.MapParameterIn(command, "@PA_DI_TITLE", record.Title);
            this.MapParameterIn(command, "@PA_DI_DESCRIPTION", record.Description);
            this.MapParameterIn(command, "@PA_DI_TYPE", record.Type);
            this.MapParameterIn(command, "@PA_DI_SERVICE_NAME", record.ServiceName);
            this.MapParameterIn(command, "@PA_DI_SOURCE_SQL_CONNECTION", record.SourceSqlConnection);
            this.MapParameterIn(command, "@PA_DI_DEST_SQL_CONNECTION", record.DestSqlConnection);
            this.MapParameterIn(command, "@PA_DI_ACTIVE", record.Active);
            this.MapParameterIn(command, "@PA_DI_LAST_RUN_DATE", record.LastRunDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.LastRunDate);
            this.MapParameterIn(command, "@PA_DI_NEXT_RUN_DATE", record.NextRunDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.NextRunDate);
            this.MapParameterIn(command, "@PA_DI_RUN_MINUTES", record.RunMinutes == Int32.MinValue ? ( useV6Logic ? new Int32?(60) : null ) : record.RunMinutes);
            this.MapParameterIn(command, "@PA_DI_FILE_DROP_FOLDER", record.FileDropFolder);
            this.MapParameterIn(command, "@PA_DI_FILE_COLUMN_HEADERS", record.FileColumnHeaders);
            this.MapParameterIn(command, "@PA_DI_FILE_TYPE", record.FileType);
            this.MapParameterIn(command, "@PA_DI_ARG_ID", record.ArgId);
            this.MapParameterIn(command, "@PA_DI_FTP_TYPE", record.FtpType);
            this.MapParameterIn(command, "@PA_DI_FTP_HOST", record.FtpHost);
            this.MapParameterIn(command, "@PA_DI_FTP_PORT", record.FtpPort == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.FtpPort);
            this.MapParameterIn(command, "@PA_DI_FTP_USERNAME", record.FtpUsername);
            this.MapParameterIn(command, "@PA_DI_FTP_PASSWORD", record.FtpPassword);
            this.MapParameterIn(command, "@PA_DI_FTP_PASSIVE", record.FtpPassive);
            this.MapParameterIn(command, "@PA_DI_FTP_PROXY", record.FtpProxy);
            this.MapParameterIn(command, "@PA_DI_FTP_SUB_FOLDERS", record.FtpSubFolders);
            this.MapParameterIn(command, "@PA_DI_MSEXCH_USERNAME", record.MsexchUsername);
            this.MapParameterIn(command, "@PA_DI_MSEXCH_PASSWORD", record.MsexchPassword);
            this.MapParameterIn(command, "@PA_DI_MSEXCH_ACCOUNT", record.MsexchAccount);
            this.MapParameterIn(command, "@PA_DI_MSEXCH_SERVICE_URL", record.MsexchServiceUrl);
            this.MapParameterIn(command, "@PA_DI_EXCEL_SHEET", record.ExcelSheet);
            this.MapParameterIn(command, "@PA_DI_EXCEL_START", record.ExcelStart);
            this.MapParameterIn(command, "@PA_DI_EXCEL_END", record.ExcelEnd);
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
        ///     The <see cref="DataimportsRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, DataimportsRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_DI_ID", record.Id);
            record.Title = this.MapParameterOut(command, "@PA_DI_TITLE", record.Title);
            record.Description = this.MapParameterOut(command, "@PA_DI_DESCRIPTION", record.Description);
            record.Type = this.MapParameterOut(command, "@PA_DI_TYPE", record.Type);
            record.ServiceName = this.MapParameterOut(command, "@PA_DI_SERVICE_NAME", record.ServiceName);
            record.SourceSqlConnection = this.MapParameterOut(command, "@PA_DI_SOURCE_SQL_CONNECTION", record.SourceSqlConnection);
            record.DestSqlConnection = this.MapParameterOut(command, "@PA_DI_DEST_SQL_CONNECTION", record.DestSqlConnection);
            record.Active = this.MapParameterOut(command, "@PA_DI_ACTIVE", record.Active);
            record.LastRunDate = this.MapParameterOut(command, "@PA_DI_LAST_RUN_DATE", record.LastRunDate);
            record.NextRunDate = this.MapParameterOut(command, "@PA_DI_NEXT_RUN_DATE", record.NextRunDate);
            record.RunMinutes = this.MapParameterOut(command, "@PA_DI_RUN_MINUTES", record.RunMinutes);
            record.FileDropFolder = this.MapParameterOut(command, "@PA_DI_FILE_DROP_FOLDER", record.FileDropFolder);
            record.FileColumnHeaders = this.MapParameterOut(command, "@PA_DI_FILE_COLUMN_HEADERS", record.FileColumnHeaders);
            record.FileType = this.MapParameterOut(command, "@PA_DI_FILE_TYPE", record.FileType);
            record.ArgId = this.MapParameterOut(command, "@PA_DI_ARG_ID", record.ArgId);
            record.FtpType = this.MapParameterOut(command, "@PA_DI_FTP_TYPE", record.FtpType);
            record.FtpHost = this.MapParameterOut(command, "@PA_DI_FTP_HOST", record.FtpHost);
            record.FtpPort = this.MapParameterOut(command, "@PA_DI_FTP_PORT", record.FtpPort);
            record.FtpUsername = this.MapParameterOut(command, "@PA_DI_FTP_USERNAME", record.FtpUsername);
            record.FtpPassword = this.MapParameterOut(command, "@PA_DI_FTP_PASSWORD", record.FtpPassword);
            record.FtpPassive = this.MapParameterOut(command, "@PA_DI_FTP_PASSIVE", record.FtpPassive);
            record.FtpProxy = this.MapParameterOut(command, "@PA_DI_FTP_PROXY", record.FtpProxy);
            record.FtpSubFolders = this.MapParameterOut(command, "@PA_DI_FTP_SUB_FOLDERS", record.FtpSubFolders);
            record.MsexchUsername = this.MapParameterOut(command, "@PA_DI_MSEXCH_USERNAME", record.MsexchUsername);
            record.MsexchPassword = this.MapParameterOut(command, "@PA_DI_MSEXCH_PASSWORD", record.MsexchPassword);
            record.MsexchAccount = this.MapParameterOut(command, "@PA_DI_MSEXCH_ACCOUNT", record.MsexchAccount);
            record.MsexchServiceUrl = this.MapParameterOut(command, "@PA_DI_MSEXCH_SERVICE_URL", record.MsexchServiceUrl);
            record.ExcelSheet = this.MapParameterOut(command, "@PA_DI_EXCEL_SHEET", record.ExcelSheet);
            record.ExcelStart = this.MapParameterOut(command, "@PA_DI_EXCEL_START", record.ExcelStart);
            record.ExcelEnd = this.MapParameterOut(command, "@PA_DI_EXCEL_END", record.ExcelEnd);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IDataimportsRepository.TableName
        {
            get { return this.TableName; }
        }

        #endregion
    }
}
