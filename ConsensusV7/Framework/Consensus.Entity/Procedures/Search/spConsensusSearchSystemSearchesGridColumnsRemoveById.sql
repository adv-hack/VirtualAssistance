if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSearchSystemSearchesGridColumnsRemoveById')
  exec ('create procedure dbo.spConsensusSearchSystemSearchesGridColumnsRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusSearchSystemSearchesGridColumnsRemoveById(@PA_SYSSC_ID integer = null output) as 
begin
  delete 
  from dbo.System_Searches_Grid_Columns
  where SYSSC_ID = @PA_SYSSC_ID
end
go
