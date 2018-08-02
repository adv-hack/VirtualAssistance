if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusDocumentLiteratureRemoveById')
  exec ('create procedure dbo.spConsensusDocumentLiteratureRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusDocumentLiteratureRemoveById(@PA_LIT_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.Literature
  where LIT_ID = @PA_LIT_ID
end
go
