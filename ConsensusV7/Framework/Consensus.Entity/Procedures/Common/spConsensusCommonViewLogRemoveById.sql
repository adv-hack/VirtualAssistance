if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusCommonViewLogRemoveById')
  exec ('create procedure dbo.spConsensusCommonViewLogRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusCommonViewLogRemoveById(@PA_VIEW_ID integer = null output) as 
begin
  delete 
  from dbo.VIEW_LOG
  where VIEW_ID = @PA_VIEW_ID
end
go
