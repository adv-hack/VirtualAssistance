if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusCommonAttachmentDataFetchAll')
  exec ('create procedure dbo.spConsensusCommonAttachmentDataFetchAll as select 1 as temp')
go
alter procedure dbo.spConsensusCommonAttachmentDataFetchAll as 
begin
  select 
    ATTD_ID,
    ATTD_ATT_ID,
    ATTD_VERSION_NO,
    ATTD_BINARY,
    ATTD_TEXT
  from dbo.Attachment_Data
end
go
