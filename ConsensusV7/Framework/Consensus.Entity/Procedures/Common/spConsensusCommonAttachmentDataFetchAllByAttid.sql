if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusCommonAttachmentDataFetchAllByAttid')
  exec ('create procedure dbo.spConsensusCommonAttachmentDataFetchAllByAttid as select 1 as temp')
go
alter procedure dbo.spConsensusCommonAttachmentDataFetchAllByAttid(@PA_ATTD_ATT_ID varchar(11) = null output) as 
begin
  select 
    ATTD_ID,
    ATTD_ATT_ID,
    ATTD_VERSION_NO,
    ATTD_BINARY,
    ATTD_TEXT
  from dbo.Attachment_Data
  where ATTD_ATT_ID = @PA_ATTD_ATT_ID
end
go
