if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusContactAssociatesRemoveById')
  exec ('create procedure dbo.spConsensusContactAssociatesRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusContactAssociatesRemoveById(@PA_ASSO_ID integer = null output) as 
begin
  delete 
  from dbo.Associates
  where ASSO_ID = @PA_ASSO_ID
end
go
