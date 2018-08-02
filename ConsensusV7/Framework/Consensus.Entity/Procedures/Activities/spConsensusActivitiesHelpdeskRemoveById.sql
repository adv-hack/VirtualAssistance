if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusActivitiesHelpdeskRemoveById')
  exec ('create procedure dbo.spConsensusActivitiesHelpdeskRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusActivitiesHelpdeskRemoveById(@PA_HD_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.Helpdesk
  where HD_ID = @PA_HD_ID
end
go
