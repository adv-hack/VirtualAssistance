if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusDocumentPackRemoveById')
  exec ('create procedure dbo.spConsensusDocumentPackRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusDocumentPackRemoveById(@PA_PACK_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.Pack
  where PACK_ID = @PA_PACK_ID
end
go
