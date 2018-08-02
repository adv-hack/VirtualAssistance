if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMarketingSaqQueryStepsRemoveById')
  exec ('create procedure dbo.spConsensusMarketingSaqQueryStepsRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusMarketingSaqQueryStepsRemoveById(@PA_QSTEP_ID integer = null output) as 
begin
  delete 
  from dbo.SAQ_QUERY_STEPS
  where QSTEP_ID = @PA_QSTEP_ID
end
go
