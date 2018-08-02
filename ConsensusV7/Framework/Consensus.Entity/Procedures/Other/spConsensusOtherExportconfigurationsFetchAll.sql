if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusOtherExportconfigurationsFetchAll')
  exec ('create procedure dbo.spConsensusOtherExportconfigurationsFetchAll as select 1 as temp')
go
alter procedure dbo.spConsensusOtherExportconfigurationsFetchAll as 
begin
  select 
    EC_ID,
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
  from dbo.ExportConfigurations
end
go
