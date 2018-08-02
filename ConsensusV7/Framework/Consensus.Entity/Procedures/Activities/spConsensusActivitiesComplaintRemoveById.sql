if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusActivitiesComplaintRemoveById')
  exec ('create procedure dbo.spConsensusActivitiesComplaintRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusActivitiesComplaintRemoveById(@PA_CMPL_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.Complaint
  where CMPL_ID = @PA_CMPL_ID
end
go
