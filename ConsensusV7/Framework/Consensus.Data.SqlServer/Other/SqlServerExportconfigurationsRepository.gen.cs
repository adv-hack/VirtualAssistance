using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Other
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="ExportconfigurationsRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerExportconfigurationsRepository : SqlServerRepository<ExportconfigurationsRecord, Int32>, IExportconfigurationsRepository
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
            get { return "Exportconfigurations"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="ExportconfigurationsRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_EC_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "ExportConfigurations"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="ExportconfigurationsRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="ExportconfigurationsRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, ExportconfigurationsRecord record)
        {
            record.Id = dataRecord["EC_ID"].ConvertTo<Int32>();
            record.AddDate = dataRecord["EC_ADD_DATE"].ConvertTo<DateTime>();
            record.AddBy = dataRecord["EC_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["EC_MOD_DATE"].ConvertTo<DateTime>();
            record.ModBy = dataRecord["EC_MOD_BY"].ConvertTo<String>();
            record.Title = dataRecord["EC_TITLE"].ConvertTo<String>();
            record.Description = dataRecord["EC_DESCRIPTION"].ConvertTo<String>();
            record.Type = dataRecord["EC_TYPE"].ConvertTo<Byte?>();
            record.ExportXmlConfig = dataRecord["EC_EXPORT_XML_CONFIG"].ConvertTo<String>();
            record.BatName = dataRecord["EC_BAT_NAME"].ConvertTo<String>();
            record.BatType = dataRecord["EC_BAT_TYPE"].ConvertTo<String>();
            record.BatProcName = dataRecord["EC_BAT_PROC_NAME"].ConvertTo<String>();
            record.BatNotes = dataRecord["EC_BAT_NOTES"].ConvertTo<String>();
            record.SelcoSpId = dataRecord["EC_SELCO_SP_ID"].ConvertTo<String>();
            record.Active = dataRecord["EC_ACTIVE"].ConvertTo<Byte?>();
            record.RunSetting = dataRecord["EC_RUN_SETTING"].ConvertTo<Byte?>();
            record.RunTimes = dataRecord["EC_RUN_TIMES"].ConvertTo<String>();
            record.LastRunDate = dataRecord["EC_LAST_RUN_DATE"].ConvertTo<DateTime?>();
            record.NextRunDate = dataRecord["EC_NEXT_RUN_DATE"].ConvertTo<DateTime?>();
            record.RunMinutes = dataRecord["EC_RUN_MINUTES"].ConvertTo<Int32?>();
            record.ExportType = dataRecord["EC_EXPORT_TYPE"].ConvertTo<Byte?>();
            record.FtpHost = dataRecord["EC_FTP_HOST"].ConvertTo<String>();
            record.FtpPort = dataRecord["EC_FTP_PORT"].ConvertTo<Int32?>();
            record.FtpUsername = dataRecord["EC_FTP_USERNAME"].ConvertTo<String>();
            record.FtpPassword = dataRecord["EC_FTP_PASSWORD"].ConvertTo<String>();
            record.FtpPassive = dataRecord["EC_FTP_PASSIVE"].ConvertTo<Byte?>();
            record.FtpProxy = dataRecord["EC_FTP_PROXY"].ConvertTo<String>();
            record.Day = dataRecord["EC_DAY"].ConvertTo<Byte>();
            record.DayOfTheWeek = dataRecord["EC_DAY_OF_THE_WEEK"].ConvertTo<String>();
            record.OnDay = dataRecord["EC_ON_DAY"].ConvertTo<Byte>();
            record.DestSqlConnection = dataRecord["EC_DEST_SQL_CONNECTION"].ConvertTo<String>();
            record.CreateIfZeroRecords = dataRecord["EC_CREATE_IF_ZERO_RECORDS"].ConvertTo<Byte>();
            record.NotificationArgId = dataRecord["EC_NOTIFICATION_ARG_ID"].ConvertTo<String>();
            record.NotificationFailureArgId = dataRecord["EC_NOTIFICATION_FAILURE_ARG_ID"].ConvertTo<String>();
            record.NotificationSenderEmail = dataRecord["EC_NOTIFICATION_SENDER_EMAIL"].ConvertTo<String>();
            record.BatArgId = dataRecord["EC_BAT_ARG_ID"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="ExportconfigurationsRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, ExportconfigurationsRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_EC_ID", record.Id == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Id);
            this.MapParameterIn(command, "@PA_EC_TITLE", record.Title);
            this.MapParameterIn(command, "@PA_EC_DESCRIPTION", record.Description);
            this.MapParameterIn(command, "@PA_EC_TYPE", record.Type);
            this.MapParameterIn(command, "@PA_EC_EXPORT_XML_CONFIG", record.ExportXmlConfig);
            this.MapParameterIn(command, "@PA_EC_BAT_NAME", record.BatName);
            this.MapParameterIn(command, "@PA_EC_BAT_TYPE", record.BatType);
            this.MapParameterIn(command, "@PA_EC_BAT_PROC_NAME", record.BatProcName);
            this.MapParameterIn(command, "@PA_EC_BAT_NOTES", record.BatNotes);
            this.MapParameterIn(command, "@PA_EC_SELCO_SP_ID", record.SelcoSpId);
            this.MapParameterIn(command, "@PA_EC_ACTIVE", record.Active);
            this.MapParameterIn(command, "@PA_EC_RUN_SETTING", record.RunSetting);
            this.MapParameterIn(command, "@PA_EC_RUN_TIMES", record.RunTimes);
            this.MapParameterIn(command, "@PA_EC_LAST_RUN_DATE", record.LastRunDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.LastRunDate);
            this.MapParameterIn(command, "@PA_EC_NEXT_RUN_DATE", record.NextRunDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.NextRunDate);
            this.MapParameterIn(command, "@PA_EC_RUN_MINUTES", record.RunMinutes == Int32.MinValue ? ( useV6Logic ? new Int32?(60) : null ) : record.RunMinutes);
            this.MapParameterIn(command, "@PA_EC_EXPORT_TYPE", record.ExportType);
            this.MapParameterIn(command, "@PA_EC_FTP_HOST", record.FtpHost);
            this.MapParameterIn(command, "@PA_EC_FTP_PORT", record.FtpPort == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.FtpPort);
            this.MapParameterIn(command, "@PA_EC_FTP_USERNAME", record.FtpUsername);
            this.MapParameterIn(command, "@PA_EC_FTP_PASSWORD", record.FtpPassword);
            this.MapParameterIn(command, "@PA_EC_FTP_PASSIVE", record.FtpPassive);
            this.MapParameterIn(command, "@PA_EC_FTP_PROXY", record.FtpProxy);
            this.MapParameterIn(command, "@PA_EC_DAY", record.Day);
            this.MapParameterIn(command, "@PA_EC_DAY_OF_THE_WEEK", record.DayOfTheWeek);
            this.MapParameterIn(command, "@PA_EC_ON_DAY", record.OnDay);
            this.MapParameterIn(command, "@PA_EC_DEST_SQL_CONNECTION", record.DestSqlConnection);
            this.MapParameterIn(command, "@PA_EC_CREATE_IF_ZERO_RECORDS", record.CreateIfZeroRecords);
            this.MapParameterIn(command, "@PA_EC_NOTIFICATION_ARG_ID", record.NotificationArgId);
            this.MapParameterIn(command, "@PA_EC_NOTIFICATION_FAILURE_ARG_ID", record.NotificationFailureArgId);
            this.MapParameterIn(command, "@PA_EC_NOTIFICATION_SENDER_EMAIL", record.NotificationSenderEmail);
            this.MapParameterIn(command, "@PA_EC_BAT_ARG_ID", record.BatArgId);
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
        ///     The <see cref="ExportconfigurationsRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, ExportconfigurationsRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_EC_ID", record.Id);
            record.Title = this.MapParameterOut(command, "@PA_EC_TITLE", record.Title);
            record.Description = this.MapParameterOut(command, "@PA_EC_DESCRIPTION", record.Description);
            record.Type = this.MapParameterOut(command, "@PA_EC_TYPE", record.Type);
            record.ExportXmlConfig = this.MapParameterOut(command, "@PA_EC_EXPORT_XML_CONFIG", record.ExportXmlConfig);
            record.BatName = this.MapParameterOut(command, "@PA_EC_BAT_NAME", record.BatName);
            record.BatType = this.MapParameterOut(command, "@PA_EC_BAT_TYPE", record.BatType);
            record.BatProcName = this.MapParameterOut(command, "@PA_EC_BAT_PROC_NAME", record.BatProcName);
            record.BatNotes = this.MapParameterOut(command, "@PA_EC_BAT_NOTES", record.BatNotes);
            record.SelcoSpId = this.MapParameterOut(command, "@PA_EC_SELCO_SP_ID", record.SelcoSpId);
            record.Active = this.MapParameterOut(command, "@PA_EC_ACTIVE", record.Active);
            record.RunSetting = this.MapParameterOut(command, "@PA_EC_RUN_SETTING", record.RunSetting);
            record.RunTimes = this.MapParameterOut(command, "@PA_EC_RUN_TIMES", record.RunTimes);
            record.LastRunDate = this.MapParameterOut(command, "@PA_EC_LAST_RUN_DATE", record.LastRunDate);
            record.NextRunDate = this.MapParameterOut(command, "@PA_EC_NEXT_RUN_DATE", record.NextRunDate);
            record.RunMinutes = this.MapParameterOut(command, "@PA_EC_RUN_MINUTES", record.RunMinutes);
            record.ExportType = this.MapParameterOut(command, "@PA_EC_EXPORT_TYPE", record.ExportType);
            record.FtpHost = this.MapParameterOut(command, "@PA_EC_FTP_HOST", record.FtpHost);
            record.FtpPort = this.MapParameterOut(command, "@PA_EC_FTP_PORT", record.FtpPort);
            record.FtpUsername = this.MapParameterOut(command, "@PA_EC_FTP_USERNAME", record.FtpUsername);
            record.FtpPassword = this.MapParameterOut(command, "@PA_EC_FTP_PASSWORD", record.FtpPassword);
            record.FtpPassive = this.MapParameterOut(command, "@PA_EC_FTP_PASSIVE", record.FtpPassive);
            record.FtpProxy = this.MapParameterOut(command, "@PA_EC_FTP_PROXY", record.FtpProxy);
            record.Day = this.MapParameterOut(command, "@PA_EC_DAY", record.Day);
            record.DayOfTheWeek = this.MapParameterOut(command, "@PA_EC_DAY_OF_THE_WEEK", record.DayOfTheWeek);
            record.OnDay = this.MapParameterOut(command, "@PA_EC_ON_DAY", record.OnDay);
            record.DestSqlConnection = this.MapParameterOut(command, "@PA_EC_DEST_SQL_CONNECTION", record.DestSqlConnection);
            record.CreateIfZeroRecords = this.MapParameterOut(command, "@PA_EC_CREATE_IF_ZERO_RECORDS", record.CreateIfZeroRecords);
            record.NotificationArgId = this.MapParameterOut(command, "@PA_EC_NOTIFICATION_ARG_ID", record.NotificationArgId);
            record.NotificationFailureArgId = this.MapParameterOut(command, "@PA_EC_NOTIFICATION_FAILURE_ARG_ID", record.NotificationFailureArgId);
            record.NotificationSenderEmail = this.MapParameterOut(command, "@PA_EC_NOTIFICATION_SENDER_EMAIL", record.NotificationSenderEmail);
            record.BatArgId = this.MapParameterOut(command, "@PA_EC_BAT_ARG_ID", record.BatArgId);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IExportconfigurationsRepository.TableName
        {
            get { return this.TableName; }
        }

        #endregion
    }
}
