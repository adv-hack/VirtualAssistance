if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusLearningDelegateRemoveById')
  exec ('create procedure dbo.spConsensusLearningDelegateRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusLearningDelegateRemoveById(@PA_DEL_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.Delegate
  where DEL_ID = @PA_DEL_ID
end
go
