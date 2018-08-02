if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusCommonAttachmentDataRemoveById')
  exec ('create procedure dbo.spConsensusCommonAttachmentDataRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusCommonAttachmentDataRemoveById(@PA_ATTD_ID integer = null output) as 
begin
  delete 
  from dbo.Attachment_Data
  where ATTD_ID = @PA_ATTD_ID
end
go
