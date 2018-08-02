if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMarketingSaqStepFetchById')
  exec ('create procedure dbo.spConsensusMarketingSaqStepFetchById as select 1 as temp')
go
alter procedure dbo.spConsensusMarketingSaqStepFetchById(@PA_STEP_ID bigint = null output) as 
begin
  select 
    STEP_ID,
    STEP_ADD_BY,
    STEP_ADD_DATE,
    STEP_MOD_BY,
    STEP_MOD_DATE,
    STEP_PROLE_ID,
    STEP_VISIBILITY,
    STEP_NAME,
    STEP_DESC,
    STEP_RESULT_SIZE_OPT,
    STEP_RESULT_SIZE,
    STEP_IN_USE,
    STEP_ORG_ONLY,
    STEP_LOCKED,
    STEP_BOOK_ONLY,
    STEP_LINK_DEFAULT
  from dbo.SAQ_STEP
  where STEP_ID = @PA_STEP_ID
end
go
