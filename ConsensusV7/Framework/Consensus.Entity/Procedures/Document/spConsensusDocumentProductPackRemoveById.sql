if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusDocumentProductPackRemoveById')
  exec ('create procedure dbo.spConsensusDocumentProductPackRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusDocumentProductPackRemoveById(@PA_PPA_ID integer = null output) as 
begin
  delete 
  from dbo.Product_Pack
  where PPA_ID = @PA_PPA_ID
end
go
