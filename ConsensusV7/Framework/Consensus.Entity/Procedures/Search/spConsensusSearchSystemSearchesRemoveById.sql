if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSearchSystemSearchesRemoveById')
  exec ('create procedure dbo.spConsensusSearchSystemSearchesRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusSearchSystemSearchesRemoveById(@PA_SYSS_ID integer = null output) as 
begin
  delete 
  from dbo.System_Searches
  where SYSS_ID = @PA_SYSS_ID
end
go
