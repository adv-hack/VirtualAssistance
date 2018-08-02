if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusCommonProfileRemoveById')
  exec ('create procedure dbo.spConsensusCommonProfileRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusCommonProfileRemoveById(@PA_PROF_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.Profile
  where PROF_ID = @PA_PROF_ID
end
go
