if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMarketingSaqStepParamsFetchAllByFid')
  exec ('create procedure dbo.spConsensusMarketingSaqStepParamsFetchAllByFid as select 1 as temp')
go
alter procedure dbo.spConsensusMarketingSaqStepParamsFetchAllByFid(@PA_STPRM_F_ID bigint = null output) as 
begin
  select 
    STPRM_ID,
    STPRM_ADD_BY,
    STPRM_ADD_DATE,
    STPRM_MOD_BY,
    STPRM_MOD_DATE,
    STPRM_STEP_ID,
    STPRM_F_ID,
    STPRM_CONDITION,
    STPRM_VALUE,
    STPRM_OPERAND,
    STPRM_KEEP_WITH_PREVIOUS,
    STPRM_ORDER,
    STPRM_PRE_BRACKET,
    STPRM_POST_BRACKET
  from dbo.SAQ_STEP_PARAMS
  where STPRM_F_ID = @PA_STPRM_F_ID
end
go
