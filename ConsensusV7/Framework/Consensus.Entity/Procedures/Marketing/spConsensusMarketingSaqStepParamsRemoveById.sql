if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMarketingSaqStepParamsRemoveById')
  exec ('create procedure dbo.spConsensusMarketingSaqStepParamsRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusMarketingSaqStepParamsRemoveById(@PA_STPRM_ID bigint = null output) as 
begin
  delete 
  from dbo.SAQ_STEP_PARAMS
  where STPRM_ID = @PA_STPRM_ID
end
go
