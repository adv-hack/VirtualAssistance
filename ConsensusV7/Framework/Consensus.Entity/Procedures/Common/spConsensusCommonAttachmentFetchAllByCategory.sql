if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusCommonAttachmentFetchAllByCategory')
  exec ('create procedure dbo.spConsensusCommonAttachmentFetchAllByCategory as select 1 as temp')
go
alter procedure dbo.spConsensusCommonAttachmentFetchAllByCategory(@PA_ATT_CATEGORY varchar(40) = null output) as 
begin
  select 
    ATT_ID,
    ATT_LOCK,
    ATT_ADD_DATE,
    ATT_ADD_BY,
    ATT_MOD_DATE,
    ATT_MOD_BY,
    ATT_RCV_DATE,
    ATT_RCV_FROM,
    ATT_TABLE_ID,
    ATT_RECORD_ID,
    ATT_FILE_NAME,
    ATT_FILE_DESC,
    ATT_DATE_ETD,
    ATT_CHKD_BY,
    ATT_CHKD_DATE,
    ATT_ORDER_NUM,
    ATT_ORGL_NAME,
    ATT_VERSION_NO,
    ATT_TEMPLATE,
    ATT_SOURCE_DATA,
    ATT_TYPE,
    ATT_CHKD_OUT_DATE,
    ATT_CHKD_OUT_BY,
    ATT_CHKD_IN_DATE,
    ATT_CHKD_IN_BY,
    ATT_PIC_ID,
    ATT_TEXT,
    ATT_URL_PATH,
    ATT_PAGESETUP,
    ATT_COMPRESS,
    ATT_EXTENSION,
    ATT_ATTRIB01,
    ATT_WEB,
    ATT_PRINT_ONLY,
    ATT_EMAIL_ONLY,
    ATT_UG_NAME,
    ATT_CATEGORY,
    ATT_START_OFFSET,
    ATT_END_OFFSET,
    ATT_MIME,
    ATT_SIZE,
    ATT_VISIBILITY,
    ATT_ARCHIVED,
    ATT_ARCHIVE_FILE,
    ATT_ARCHIVE_BAT_ID,
    ATT_TABLE_URL
  from dbo.Attachment
  where ATT_CATEGORY = @PA_ATT_CATEGORY
end
go
