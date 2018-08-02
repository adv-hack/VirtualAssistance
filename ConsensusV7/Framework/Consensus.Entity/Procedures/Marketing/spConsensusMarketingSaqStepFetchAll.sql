if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMarketingSaqStepFetchAll')
  exec ('create procedure dbo.spConsensusMarketingSaqStepFetchAll as select 1 as temp')
go
alter procedure dbo.spConsensusMarketingSaqStepFetchAll as 
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
end
go
