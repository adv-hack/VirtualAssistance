if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusCommonAttachmentDataFetchById')
  exec ('create procedure dbo.spConsensusCommonAttachmentDataFetchById as select 1 as temp')
go
alter procedure dbo.spConsensusCommonAttachmentDataFetchById(@PA_ATTD_ID integer = null output) as 
begin
  select 
    ATTD_ID,
    ATTD_ATT_ID,
    ATTD_VERSION_NO,
    ATTD_BINARY,
    ATTD_TEXT
  from dbo.Attachment_Data
  where ATTD_ID = @PA_ATTD_ID
end
go
