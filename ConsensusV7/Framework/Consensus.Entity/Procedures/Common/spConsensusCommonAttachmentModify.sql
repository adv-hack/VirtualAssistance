if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusCommonAttachmentModify')
  exec ('create procedure dbo.spConsensusCommonAttachmentModify as select 1 as temp')
go
alter procedure dbo.spConsensusCommonAttachmentModify(@PA_ATT_ID varchar(11) = null output, @PA_ATT_LOCK varchar(10) = null output, @PA_ATT_TABLE_ID integer = null output, @PA_ATT_RECORD_ID varchar(11) = null output, @PA_ATT_FILE_NAME varchar(255) = null output, @PA_ATT_FILE_DESC nvarchar(max) = null output, @PA_ATT_DATE_ETD datetime = null output, @PA_ATT_CHKD_BY varchar(10) = null output, @PA_ATT_CHKD_DATE datetime = null output, @PA_ATT_ORDER_NUM tinyint = null output, @PA_ATT_ORGL_NAME varchar(255) = null output, @PA_ATT_VERSION_NO float = null output, @PA_ATT_TEMPLATE varchar(255) = null output, @PA_ATT_SOURCE_DATA varchar(max) = null output, @PA_ATT_TYPE tinyint = null output, @PA_ATT_CHKD_OUT_DATE datetime = null output, @PA_ATT_CHKD_OUT_BY varchar(3) = null output, @PA_ATT_CHKD_IN_DATE datetime = null output, @PA_ATT_CHKD_IN_BY varchar(3) = null output, @PA_ATT_PIC_ID varchar(11) = null output, @PA_ATT_TEXT varchar(max) = null output, @PA_ATT_URL_PATH varchar(150) = null output, @PA_ATT_PAGESETUP varchar(255) = null output, @PA_ATT_COMPRESS tinyint = null output, @PA_ATT_EXTENSION varchar(11) = null output, @PA_ATT_ATTRIB01 varchar(40) = null output, @PA_ATT_WEB tinyint = null output, @PA_ATT_PRINT_ONLY tinyint = null output, @PA_ATT_EMAIL_ONLY tinyint = null output, @PA_ATT_UG_NAME varchar(50) = null output, @PA_ATT_CATEGORY varchar(40) = null output, @PA_ATT_START_OFFSET integer = null output, @PA_ATT_END_OFFSET integer = null output, @PA_ATT_MIME varchar(250) = null output, @PA_ATT_SIZE bigint = null output, @PA_ATT_VISIBILITY tinyint = null output, @PA_ATT_ARCHIVED tinyint = null output, @PA_ATT_ARCHIVE_FILE varchar(255) = null output, @PA_ATT_ARCHIVE_BAT_ID varchar(11) = null output, @PA_ATT_TABLE_URL varchar(240) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.Attachment set
    ATT_MOD_DATE = getDate(),
    ATT_MOD_BY = @_AUDIT_USER_ID,
    ATT_LOCK = @PA_ATT_LOCK,
    ATT_TABLE_ID = @PA_ATT_TABLE_ID,
    ATT_RECORD_ID = @PA_ATT_RECORD_ID,
    ATT_FILE_NAME = @PA_ATT_FILE_NAME,
    ATT_FILE_DESC = @PA_ATT_FILE_DESC,
    ATT_DATE_ETD = @PA_ATT_DATE_ETD,
    ATT_CHKD_BY = @PA_ATT_CHKD_BY,
    ATT_CHKD_DATE = @PA_ATT_CHKD_DATE,
    ATT_ORDER_NUM = @PA_ATT_ORDER_NUM,
    ATT_ORGL_NAME = @PA_ATT_ORGL_NAME,
    ATT_VERSION_NO = @PA_ATT_VERSION_NO,
    ATT_TEMPLATE = @PA_ATT_TEMPLATE,
    ATT_SOURCE_DATA = @PA_ATT_SOURCE_DATA,
    ATT_TYPE = @PA_ATT_TYPE,
    ATT_CHKD_OUT_DATE = @PA_ATT_CHKD_OUT_DATE,
    ATT_CHKD_OUT_BY = @PA_ATT_CHKD_OUT_BY,
    ATT_CHKD_IN_DATE = @PA_ATT_CHKD_IN_DATE,
    ATT_CHKD_IN_BY = @PA_ATT_CHKD_IN_BY,
    ATT_PIC_ID = @PA_ATT_PIC_ID,
    ATT_TEXT = @PA_ATT_TEXT,
    ATT_URL_PATH = @PA_ATT_URL_PATH,
    ATT_PAGESETUP = @PA_ATT_PAGESETUP,
    ATT_COMPRESS = @PA_ATT_COMPRESS,
    ATT_EXTENSION = @PA_ATT_EXTENSION,
    ATT_ATTRIB01 = @PA_ATT_ATTRIB01,
    ATT_WEB = @PA_ATT_WEB,
    ATT_PRINT_ONLY = @PA_ATT_PRINT_ONLY,
    ATT_EMAIL_ONLY = @PA_ATT_EMAIL_ONLY,
    ATT_UG_NAME = @PA_ATT_UG_NAME,
    ATT_CATEGORY = @PA_ATT_CATEGORY,
    ATT_START_OFFSET = @PA_ATT_START_OFFSET,
    ATT_END_OFFSET = @PA_ATT_END_OFFSET,
    ATT_MIME = @PA_ATT_MIME,
    ATT_SIZE = @PA_ATT_SIZE,
    ATT_VISIBILITY = @PA_ATT_VISIBILITY,
    ATT_ARCHIVED = @PA_ATT_ARCHIVED,
    ATT_ARCHIVE_FILE = @PA_ATT_ARCHIVE_FILE,
    ATT_ARCHIVE_BAT_ID = @PA_ATT_ARCHIVE_BAT_ID,
    ATT_TABLE_URL = @PA_ATT_TABLE_URL
  where ATT_ID = @PA_ATT_ID;
end
go
