if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusOtherDataimportsModify')
  exec ('create procedure dbo.spConsensusOtherDataimportsModify as select 1 as temp')
go
alter procedure dbo.spConsensusOtherDataimportsModify(@PA_DI_ID integer = null output, @PA_DI_TITLE nvarchar(255) = null output, @PA_DI_DESCRIPTION nvarchar(max) = null output, @PA_DI_TYPE tinyint = null output, @PA_DI_SERVICE_NAME varchar(255) = null output, @PA_DI_SOURCE_SQL_CONNECTION varchar(500) = null output, @PA_DI_DEST_SQL_CONNECTION varchar(500) = null output, @PA_DI_ACTIVE tinyint = null output, @PA_DI_LAST_RUN_DATE datetime = null output, @PA_DI_NEXT_RUN_DATE datetime = null output, @PA_DI_RUN_MINUTES integer = null output, @PA_DI_FILE_DROP_FOLDER varchar(500) = null output, @PA_DI_FILE_COLUMN_HEADERS tinyint = null output, @PA_DI_FILE_TYPE tinyint = null output, @PA_DI_ARG_ID varchar(11) = null output, @PA_DI_FTP_TYPE tinyint = null output, @PA_DI_FTP_HOST nvarchar(255) = null output, @PA_DI_FTP_PORT integer = null output, @PA_DI_FTP_USERNAME nvarchar(255) = null output, @PA_DI_FTP_PASSWORD nvarchar(255) = null output, @PA_DI_FTP_PASSIVE tinyint = null output, @PA_DI_FTP_PROXY nvarchar(255) = null output, @PA_DI_FTP_SUB_FOLDERS varchar(500) = null output, @PA_DI_MSEXCH_USERNAME nvarchar(255) = null output, @PA_DI_MSEXCH_PASSWORD nvarchar(255) = null output, @PA_DI_MSEXCH_ACCOUNT nvarchar(255) = null output, @PA_DI_MSEXCH_SERVICE_URL nvarchar(255) = null output, @PA_DI_EXCEL_SHEET varchar(50) = null output, @PA_DI_EXCEL_START varchar(10) = null output, @PA_DI_EXCEL_END varchar(10) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.DataImports set
    DI_MOD_DATE = getDate(),
    DI_MOD_BY = @_AUDIT_USER_ID,
    DI_TITLE = @PA_DI_TITLE,
    DI_DESCRIPTION = @PA_DI_DESCRIPTION,
    DI_TYPE = @PA_DI_TYPE,
    DI_SERVICE_NAME = @PA_DI_SERVICE_NAME,
    DI_SOURCE_SQL_CONNECTION = @PA_DI_SOURCE_SQL_CONNECTION,
    DI_DEST_SQL_CONNECTION = @PA_DI_DEST_SQL_CONNECTION,
    DI_ACTIVE = @PA_DI_ACTIVE,
    DI_LAST_RUN_DATE = @PA_DI_LAST_RUN_DATE,
    DI_NEXT_RUN_DATE = @PA_DI_NEXT_RUN_DATE,
    DI_RUN_MINUTES = @PA_DI_RUN_MINUTES,
    DI_FILE_DROP_FOLDER = @PA_DI_FILE_DROP_FOLDER,
    DI_FILE_COLUMN_HEADERS = @PA_DI_FILE_COLUMN_HEADERS,
    DI_FILE_TYPE = @PA_DI_FILE_TYPE,
    DI_ARG_ID = @PA_DI_ARG_ID,
    DI_FTP_TYPE = @PA_DI_FTP_TYPE,
    DI_FTP_HOST = @PA_DI_FTP_HOST,
    DI_FTP_PORT = @PA_DI_FTP_PORT,
    DI_FTP_USERNAME = @PA_DI_FTP_USERNAME,
    DI_FTP_PASSWORD = @PA_DI_FTP_PASSWORD,
    DI_FTP_PASSIVE = @PA_DI_FTP_PASSIVE,
    DI_FTP_PROXY = @PA_DI_FTP_PROXY,
    DI_FTP_SUB_FOLDERS = @PA_DI_FTP_SUB_FOLDERS,
    DI_MSEXCH_USERNAME = @PA_DI_MSEXCH_USERNAME,
    DI_MSEXCH_PASSWORD = @PA_DI_MSEXCH_PASSWORD,
    DI_MSEXCH_ACCOUNT = @PA_DI_MSEXCH_ACCOUNT,
    DI_MSEXCH_SERVICE_URL = @PA_DI_MSEXCH_SERVICE_URL,
    DI_EXCEL_SHEET = @PA_DI_EXCEL_SHEET,
    DI_EXCEL_START = @PA_DI_EXCEL_START,
    DI_EXCEL_END = @PA_DI_EXCEL_END
  where DI_ID = @PA_DI_ID;
end
go
