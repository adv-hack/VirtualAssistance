if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusCommonAttachmentRemoveById')
  exec ('create procedure dbo.spConsensusCommonAttachmentRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusCommonAttachmentRemoveById(@PA_ATT_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.Attachment
  where ATT_ID = @PA_ATT_ID
end
go
