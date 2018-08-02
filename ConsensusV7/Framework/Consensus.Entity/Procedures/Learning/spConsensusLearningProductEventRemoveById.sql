if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusLearningProductEventRemoveById')
  exec ('create procedure dbo.spConsensusLearningProductEventRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusLearningProductEventRemoveById(@PA_PE_ID integer = null output) as 
begin
  delete 
  from dbo.Product_Event
  where PE_ID = @PA_PE_ID
end
go
