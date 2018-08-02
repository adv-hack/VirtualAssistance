if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMarketingSaqStepCreate')
  exec ('create procedure dbo.spConsensusMarketingSaqStepCreate as select 1 as temp')
go
alter procedure dbo.spConsensusMarketingSaqStepCreate(@PA_STEP_ID bigint = null output, @PA_STEP_PROLE_ID varchar(11) = null output, @PA_STEP_VISIBILITY tinyint = null output, @PA_STEP_NAME varchar(100) = null output, @PA_STEP_DESC varchar(200) = null output, @PA_STEP_RESULT_SIZE_OPT tinyint = null output, @PA_STEP_RESULT_SIZE bigint = null output, @PA_STEP_IN_USE tinyint = null output, @PA_STEP_ORG_ONLY tinyint = null output, @PA_STEP_LOCKED tinyint = null output, @PA_STEP_BOOK_ONLY tinyint = null output, @PA_STEP_LINK_DEFAULT varchar(10) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.SAQ_STEP(
    STEP_ADD_DATE,
    STEP_ADD_BY,
    STEP_MOD_DATE,
    STEP_MOD_BY,
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
  ) values (
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    @PA_STEP_PROLE_ID,
    @PA_STEP_VISIBILITY,
    @PA_STEP_NAME,
    @PA_STEP_DESC,
    @PA_STEP_RESULT_SIZE_OPT,
    @PA_STEP_RESULT_SIZE,
    @PA_STEP_IN_USE,
    @PA_STEP_ORG_ONLY,
    @PA_STEP_LOCKED,
    @PA_STEP_BOOK_ONLY,
    @PA_STEP_LINK_DEFAULT
  );
    set @PA_STEP_ID = @@identity;
end
go
