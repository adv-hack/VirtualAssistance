if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMarketingSaqStepParamsCreate')
  exec ('create procedure dbo.spConsensusMarketingSaqStepParamsCreate as select 1 as temp')
go
alter procedure dbo.spConsensusMarketingSaqStepParamsCreate(@PA_STPRM_ID bigint = null output, @PA_STPRM_STEP_ID bigint = null output, @PA_STPRM_F_ID bigint = null output, @PA_STPRM_CONDITION varchar(10) = null output, @PA_STPRM_VALUE varchar(100) = null output, @PA_STPRM_OPERAND varchar(15) = null output, @PA_STPRM_KEEP_WITH_PREVIOUS tinyint = null output, @PA_STPRM_ORDER integer = null output, @PA_STPRM_PRE_BRACKET varchar(5) = null output, @PA_STPRM_POST_BRACKET varchar(5) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.SAQ_STEP_PARAMS(
    STPRM_ADD_DATE,
    STPRM_ADD_BY,
    STPRM_MOD_DATE,
    STPRM_MOD_BY,
    STPRM_STEP_ID,
    STPRM_F_ID,
    STPRM_CONDITION,
    STPRM_VALUE,
    STPRM_OPERAND,
    STPRM_KEEP_WITH_PREVIOUS,
    STPRM_ORDER,
    STPRM_PRE_BRACKET,
    STPRM_POST_BRACKET
  ) values (
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    @PA_STPRM_STEP_ID,
    @PA_STPRM_F_ID,
    @PA_STPRM_CONDITION,
    @PA_STPRM_VALUE,
    @PA_STPRM_OPERAND,
    @PA_STPRM_KEEP_WITH_PREVIOUS,
    @PA_STPRM_ORDER,
    @PA_STPRM_PRE_BRACKET,
    @PA_STPRM_POST_BRACKET
  );
    set @PA_STPRM_ID = @@identity;
end
go
