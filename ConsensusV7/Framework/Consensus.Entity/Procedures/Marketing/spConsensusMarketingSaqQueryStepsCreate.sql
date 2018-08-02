if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMarketingSaqQueryStepsCreate')
  exec ('create procedure dbo.spConsensusMarketingSaqQueryStepsCreate as select 1 as temp')
go
alter procedure dbo.spConsensusMarketingSaqQueryStepsCreate(@PA_QSTEP_ID integer = null output, @PA_QSTEP_QRY_ID bigint = null output, @PA_QSTEP_STEP_ID bigint = null output, @PA_QSTEP_LINK varchar(10) = null output, @PA_QSTEP_ORDER smallint = null output, @PA_QSTEP_RESULT_COUNT bigint = null output, @PA_QSTEP_ORG_TOTAL bigint = null output, @PA_QSTEP_ROLE_TOTAL bigint = null output, @PA_QSTEP_PERSON_TOTAL bigint = null output, @PA_QSTEP_RUN_TIME datetime = null output, @PA_QSTEP_LINK_CHANGE bigint = null output, @PA_QSTEP_SCHED_RUN_DATE datetime = null output, @PA_QSTEP_SCHED_RUN_TIME datetime = null output, @PA_QSTEP_CALCULATED_DATE datetime = null output, @PA_QSTEP_OUTPUT_DATE datetime = null output, @PA_QSTEP_LOCKED tinyint = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.SAQ_QUERY_STEPS(
    QSTEP_ADD_DATE,
    QSTEP_ADD_BY,
    QSTEP_MOD_DATE,
    QSTEP_MOD_BY,
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
  ) values (
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    @PA_QSTEP_QRY_ID,
    @PA_QSTEP_STEP_ID,
    @PA_QSTEP_LINK,
    @PA_QSTEP_ORDER,
    @PA_QSTEP_RESULT_COUNT,
    @PA_QSTEP_ORG_TOTAL,
    @PA_QSTEP_ROLE_TOTAL,
    @PA_QSTEP_PERSON_TOTAL,
    @PA_QSTEP_RUN_TIME,
    @PA_QSTEP_LINK_CHANGE,
    @PA_QSTEP_SCHED_RUN_DATE,
    @PA_QSTEP_SCHED_RUN_TIME,
    @PA_QSTEP_CALCULATED_DATE,
    @PA_QSTEP_OUTPUT_DATE,
    @PA_QSTEP_LOCKED
  );
    set @PA_QSTEP_ID = @@identity;
end
go
