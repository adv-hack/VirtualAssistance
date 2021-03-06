if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusOtherExportconfigurationsCreate')
  exec ('create procedure dbo.spConsensusOtherExportconfigurationsCreate as select 1 as temp')
go
alter procedure dbo.spConsensusOtherExportconfigurationsCreate(@PA_EC_ID integer = null output, @PA_EC_TITLE nvarchar(255) = null output, @PA_EC_DESCRIPTION nvarchar(max) = null output, @PA_EC_TYPE tinyint = null output, @PA_EC_EXPORT_XML_CONFIG varchar(max) = null output, @PA_EC_BAT_NAME varchar(255) = null output, @PA_EC_BAT_TYPE varchar(255) = null output, @PA_EC_BAT_PROC_NAME varchar(500) = null output, @PA_EC_BAT_NOTES varchar(500) = null output, @PA_EC_SELCO_SP_ID varchar(80) = null output, @PA_EC_ACTIVE tinyint = null output, @PA_EC_RUN_SETTING tinyint = null output, @PA_EC_RUN_TIMES varchar(255) = null output, @PA_EC_LAST_RUN_DATE datetime = null output, @PA_EC_NEXT_RUN_DATE datetime = null output, @PA_EC_RUN_MINUTES integer = null output, @PA_EC_EXPORT_TYPE tinyint = null output, @PA_EC_FTP_HOST nvarchar(255) = null output, @PA_EC_FTP_PORT integer = null output, @PA_EC_FTP_USERNAME nvarchar(255) = null output, @PA_EC_FTP_PASSWORD nvarchar(255) = null output, @PA_EC_FTP_PASSIVE tinyint = null output, @PA_EC_FTP_PROXY nvarchar(255) = null output, @PA_EC_DAY tinyint = null output, @PA_EC_DAY_OF_THE_WEEK varchar(20) = null output, @PA_EC_ON_DAY tinyint = null output, @PA_EC_DEST_SQL_CONNECTION varchar(500) = null output, @PA_EC_CREATE_IF_ZERO_RECORDS tinyint = null output, @PA_EC_NOTIFICATION_ARG_ID varchar(11) = null output, @PA_EC_NOTIFICATION_FAILURE_ARG_ID varchar(11) = null output, @PA_EC_NOTIFICATION_SENDER_EMAIL varchar(255) = null output, @PA_EC_BAT_ARG_ID varchar(11) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.ExportConfigurations(
    EC_ADD_DATE,
    EC_ADD_BY,
    EC_MOD_DATE,
    EC_MOD_BY,
    EC_TITLE,
    EC_DESCRIPTION,
    EC_TYPE,
    EC_EXPORT_XML_CONFIG,
    EC_BAT_NAME,
    EC_BAT_TYPE,
    EC_BAT_PROC_NAME,
    EC_BAT_NOTES,
    EC_SELCO_SP_ID,
    EC_ACTIVE,
    EC_RUN_SETTING,
    EC_RUN_TIMES,
    EC_LAST_RUN_DATE,
    EC_NEXT_RUN_DATE,
    EC_RUN_MINUTES,
    EC_EXPORT_TYPE,
    EC_FTP_HOST,
    EC_FTP_PORT,
    EC_FTP_USERNAME,
    EC_FTP_PASSWORD,
    EC_FTP_PASSIVE,
    EC_FTP_PROXY,
    EC_DAY,
    EC_DAY_OF_THE_WEEK,
    EC_ON_DAY,
    EC_DEST_SQL_CONNECTION,
    EC_CREATE_IF_ZERO_RECORDS,
    EC_NOTIFICATION_ARG_ID,
    EC_NOTIFICATION_FAILURE_ARG_ID,
    EC_NOTIFICATION_SENDER_EMAIL,
    EC_BAT_ARG_ID
  ) values (
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    @PA_EC_TITLE,
    @PA_EC_DESCRIPTION,
    @PA_EC_TYPE,
    @PA_EC_EXPORT_XML_CONFIG,
    @PA_EC_BAT_NAME,
    @PA_EC_BAT_TYPE,
    @PA_EC_BAT_PROC_NAME,
    @PA_EC_BAT_NOTES,
    @PA_EC_SELCO_SP_ID,
    @PA_EC_ACTIVE,
    @PA_EC_RUN_SETTING,
    @PA_EC_RUN_TIMES,
    @PA_EC_LAST_RUN_DATE,
    @PA_EC_NEXT_RUN_DATE,
    @PA_EC_RUN_MINUTES,
    @PA_EC_EXPORT_TYPE,
    @PA_EC_FTP_HOST,
    @PA_EC_FTP_PORT,
    @PA_EC_FTP_USERNAME,
    @PA_EC_FTP_PASSWORD,
    @PA_EC_FTP_PASSIVE,
    @PA_EC_FTP_PROXY,
    @PA_EC_DAY,
    @PA_EC_DAY_OF_THE_WEEK,
    @PA_EC_ON_DAY,
    @PA_EC_DEST_SQL_CONNECTION,
    @PA_EC_CREATE_IF_ZERO_RECORDS,
    @PA_EC_NOTIFICATION_ARG_ID,
    @PA_EC_NOTIFICATION_FAILURE_ARG_ID,
    @PA_EC_NOTIFICATION_SENDER_EMAIL,
    @PA_EC_BAT_ARG_ID
  );
    set @PA_EC_ID = @@identity;
end
go
