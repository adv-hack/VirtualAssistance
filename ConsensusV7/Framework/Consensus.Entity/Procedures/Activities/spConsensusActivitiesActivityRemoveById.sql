if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusActivitiesActivityRemoveById')
  exec ('create procedure dbo.spConsensusActivitiesActivityRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusActivitiesActivityRemoveById(@PA_ACT_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.Activity
  where ACT_ID = @PA_ACT_ID
end
go
