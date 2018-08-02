if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusOtherWorkflowCreate')
  exec ('create procedure dbo.spConsensusOtherWorkflowCreate as select 1 as temp')
go
alter procedure dbo.spConsensusOtherWorkflowCreate(@PA_WF_ID varchar(11) = null output, @PA_WF_LOCK varchar(11) = null output, @PA_WF_NAME varchar(255) = null output, @PA_WF_DESC varchar(2000) = null output, @PA_WF_REC_TYPE varchar(50) = null output, @PA_WF_AUTO_LINK tinyint = null output, @PA_WF_FIRST_WFR_ID varchar(11) = null output, @PA_WF_DELAY integer = null output, @PA_WF_OCCURS tinyint = null output, @PA_WF_DAY_OF_WEEK tinyint = null output, @PA_WF_DAILY_FREQ tinyint = null output, @PA_WF_NORMAL_TIME datetime = null output, @PA_WF_FREQUENCY integer = null output, @PA_WF_VALID_FROM_DATE datetime = null output, @PA_WF_VALID_TO_DATE datetime = null output, @PA_WF_DISABLED tinyint = null output, @PA_WF_RUN_DATETIME datetime = null output, @PA_WF_LAST_RUN_DTTIME datetime = null output, @PA_WF_CREATED_BY_V1 bit = null output, @PA_WF_GROUP varchar(40) = null output, @PA_WF_UNIQUE_SYS_NAME varchar(50) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  exec spNextID 1501, @PA_WF_ID output
  
  insert into dbo.Workflow(
    WF_ID,
    WF_ADD_DATE,
    WF_ADD_BY,
    WF_MOD_DATE,
    WF_MOD_BY,
    WF_RCV_DATE,
    WF_RCV_FROM,
    WF_LOCK,
    WF_NAME,
    WF_DESC,
    WF_REC_TYPE,
    WF_AUTO_LINK,
    WF_FIRST_WFR_ID,
    WF_DELAY,
    WF_OCCURS,
    WF_DAY_OF_WEEK,
    WF_DAILY_FREQ,
    WF_NORMAL_TIME,
    WF_FREQUENCY,
    WF_VALID_FROM_DATE,
    WF_VALID_TO_DATE,
    WF_DISABLED,
    WF_RUN_DATETIME,
    WF_LAST_RUN_DTTIME,
    WF_CREATED_BY_V1,
    WF_GROUP,
    WF_UNIQUE_SYS_NAME
  ) values (
    @PA_WF_ID,
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    '',
    @PA_WF_LOCK,
    @PA_WF_NAME,
    @PA_WF_DESC,
    @PA_WF_REC_TYPE,
    @PA_WF_AUTO_LINK,
    @PA_WF_FIRST_WFR_ID,
    @PA_WF_DELAY,
    @PA_WF_OCCURS,
    @PA_WF_DAY_OF_WEEK,
    @PA_WF_DAILY_FREQ,
    @PA_WF_NORMAL_TIME,
    @PA_WF_FREQUENCY,
    @PA_WF_VALID_FROM_DATE,
    @PA_WF_VALID_TO_DATE,
    @PA_WF_DISABLED,
    @PA_WF_RUN_DATETIME,
    @PA_WF_LAST_RUN_DTTIME,
    @PA_WF_CREATED_BY_V1,
    @PA_WF_GROUP,
    @PA_WF_UNIQUE_SYS_NAME
  );
end
go
