if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusLearningEventProductRemoveById')
  exec ('create procedure dbo.spConsensusLearningEventProductRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusLearningEventProductRemoveById(@PA_EP_ID integer = null output) as 
begin
  delete 
  from dbo.EVENT_PRODUCT
  where EP_ID = @PA_EP_ID
end
go
