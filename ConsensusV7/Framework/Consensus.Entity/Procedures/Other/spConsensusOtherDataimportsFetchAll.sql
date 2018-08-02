if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusOtherDataimportsFetchAll')
  exec ('create procedure dbo.spConsensusOtherDataimportsFetchAll as select 1 as temp')
go
alter procedure dbo.spConsensusOtherDataimportsFetchAll as 
begin
  select 
    DI_ID,
    DI_ADD_DATE,
    DI_ADD_BY,
    DI_MOD_DATE,
    DI_MOD_BY,
    DI_TITLE,
    DI_DESCRIPTION,
    DI_TYPE,
    DI_SERVICE_NAME,
    DI_SOURCE_SQL_CONNECTION,
    DI_DEST_SQL_CONNECTION,
    DI_ACTIVE,
    DI_LAST_RUN_DATE,
    DI_NEXT_RUN_DATE,
    DI_RUN_MINUTES,
    DI_FILE_DROP_FOLDER,
    DI_FILE_COLUMN_HEADERS,
    DI_FILE_TYPE,
    DI_ARG_ID,
    DI_FTP_TYPE,
    DI_FTP_HOST,
    DI_FTP_PORT,
    DI_FTP_USERNAME,
    DI_FTP_PASSWORD,
    DI_FTP_PASSIVE,
    DI_FTP_PROXY,
    DI_FTP_SUB_FOLDERS,
    DI_MSEXCH_USERNAME,
    DI_MSEXCH_PASSWORD,
    DI_MSEXCH_ACCOUNT,
    DI_MSEXCH_SERVICE_URL,
    DI_EXCEL_SHEET,
    DI_EXCEL_START,
    DI_EXCEL_END
  from dbo.DataImports
end
go
