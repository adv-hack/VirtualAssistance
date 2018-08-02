if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusOtherWorkflowRemoveById')
  exec ('create procedure dbo.spConsensusOtherWorkflowRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusOtherWorkflowRemoveById(@PA_WF_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.Workflow
  where WF_ID = @PA_WF_ID
end
go
