if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMarketingSaqQueryStepsFetchAllByQryid')
  exec ('create procedure dbo.spConsensusMarketingSaqQueryStepsFetchAllByQryid as select 1 as temp')
go
alter procedure dbo.spConsensusMarketingSaqQueryStepsFetchAllByQryid(@PA_QSTEP_QRY_ID bigint = null output) as 
begin
  select 
    QSTEP_ID,
    QSTEP_ADD_BY,
    QSTEP_ADD_DATE,
    QSTEP_MOD_BY,
    QSTEP_MOD_DATE,
    QSTEP_QRY_ID,
    QSTEP_STEP_ID,
    QSTEP_LINK,
    QSTEP_ORDER,
    QSTEP_RESULT_COUNT,
    QSTEP_ORG_TOTAL,
    QSTEP_ROLE_TOTAL,
    QSTEP_PERSON_TOTAL,
    QSTEP_RUN_TIME,
    QSTEP_LINK_CHANGE,
    QSTEP_SCHED_RUN_DATE,
    QSTEP_SCHED_RUN_TIME,
    QSTEP_CALCULATED_DATE,
    QSTEP_OUTPUT_DATE,
    QSTEP_LOCKED
  from dbo.SAQ_QUERY_STEPS
  where QSTEP_QRY_ID = @PA_QSTEP_QRY_ID
end
go
