if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMarketingSaqStepRemoveById')
  exec ('create procedure dbo.spConsensusMarketingSaqStepRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusMarketingSaqStepRemoveById(@PA_STEP_ID bigint = null output) as 
begin
  delete 
  from dbo.SAQ_STEP
  where STEP_ID = @PA_STEP_ID
end
go
