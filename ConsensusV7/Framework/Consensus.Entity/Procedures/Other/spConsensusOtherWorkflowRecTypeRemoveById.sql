if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusOtherWorkflowRecTypeRemoveById')
  exec ('create procedure dbo.spConsensusOtherWorkflowRecTypeRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusOtherWorkflowRecTypeRemoveById(@PA_WRT_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.Workflow_Rec_Type
  where WRT_ID = @PA_WRT_ID
end
go
