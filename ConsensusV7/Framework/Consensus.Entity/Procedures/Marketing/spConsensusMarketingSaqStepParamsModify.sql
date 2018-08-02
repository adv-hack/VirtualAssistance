if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMarketingSaqStepParamsModify')
  exec ('create procedure dbo.spConsensusMarketingSaqStepParamsModify as select 1 as temp')
go
alter procedure dbo.spConsensusMarketingSaqStepParamsModify(@PA_STPRM_ID bigint = null output, @PA_STPRM_STEP_ID bigint = null output, @PA_STPRM_F_ID bigint = null output, @PA_STPRM_CONDITION varchar(10) = null output, @PA_STPRM_VALUE varchar(100) = null output, @PA_STPRM_OPERAND varchar(15) = null output, @PA_STPRM_KEEP_WITH_PREVIOUS tinyint = null output, @PA_STPRM_ORDER integer = null output, @PA_STPRM_PRE_BRACKET varchar(5) = null output, @PA_STPRM_POST_BRACKET varchar(5) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.SAQ_STEP_PARAMS set
    STPRM_MOD_DATE = getDate(),
    STPRM_MOD_BY = @_AUDIT_USER_ID,
    STPRM_STEP_ID = @PA_STPRM_STEP_ID,
    STPRM_F_ID = @PA_STPRM_F_ID,
    STPRM_CONDITION = @PA_STPRM_CONDITION,
    STPRM_VALUE = @PA_STPRM_VALUE,
    STPRM_OPERAND = @PA_STPRM_OPERAND,
    STPRM_KEEP_WITH_PREVIOUS = @PA_STPRM_KEEP_WITH_PREVIOUS,
    STPRM_ORDER = @PA_STPRM_ORDER,
    STPRM_PRE_BRACKET = @PA_STPRM_PRE_BRACKET,
    STPRM_POST_BRACKET = @PA_STPRM_POST_BRACKET
  where STPRM_ID = @PA_STPRM_ID;
end
go
