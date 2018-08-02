if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusOtherWorkflowModify')
  exec ('create procedure dbo.spConsensusOtherWorkflowModify as select 1 as temp')
go
alter procedure dbo.spConsensusOtherWorkflowModify(@PA_WF_ID varchar(11) = null output, @PA_WF_LOCK varchar(11) = null output, @PA_WF_NAME varchar(255) = null output, @PA_WF_DESC varchar(2000) = null output, @PA_WF_REC_TYPE varchar(50) = null output, @PA_WF_AUTO_LINK tinyint = null output, @PA_WF_FIRST_WFR_ID varchar(11) = null output, @PA_WF_DELAY integer = null output, @PA_WF_OCCURS tinyint = null output, @PA_WF_DAY_OF_WEEK tinyint = null output, @PA_WF_DAILY_FREQ tinyint = null output, @PA_WF_NORMAL_TIME datetime = null output, @PA_WF_FREQUENCY integer = null output, @PA_WF_VALID_FROM_DATE datetime = null output, @PA_WF_VALID_TO_DATE datetime = null output, @PA_WF_DISABLED tinyint = null output, @PA_WF_RUN_DATETIME datetime = null output, @PA_WF_LAST_RUN_DTTIME datetime = null output, @PA_WF_CREATED_BY_V1 bit = null output, @PA_WF_GROUP varchar(40) = null output, @PA_WF_UNIQUE_SYS_NAME varchar(50) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.Workflow set
    WF_MOD_DATE = getDate(),
    WF_MOD_BY = @_AUDIT_USER_ID,
    WF_LOCK = @PA_WF_LOCK,
    WF_NAME = @PA_WF_NAME,
    WF_DESC = @PA_WF_DESC,
    WF_REC_TYPE = @PA_WF_REC_TYPE,
    WF_AUTO_LINK = @PA_WF_AUTO_LINK,
    WF_FIRST_WFR_ID = @PA_WF_FIRST_WFR_ID,
    WF_DELAY = @PA_WF_DELAY,
    WF_OCCURS = @PA_WF_OCCURS,
    WF_DAY_OF_WEEK = @PA_WF_DAY_OF_WEEK,
    WF_DAILY_FREQ = @PA_WF_DAILY_FREQ,
    WF_NORMAL_TIME = @PA_WF_NORMAL_TIME,
    WF_FREQUENCY = @PA_WF_FREQUENCY,
    WF_VALID_FROM_DATE = @PA_WF_VALID_FROM_DATE,
    WF_VALID_TO_DATE = @PA_WF_VALID_TO_DATE,
    WF_DISABLED = @PA_WF_DISABLED,
    WF_RUN_DATETIME = @PA_WF_RUN_DATETIME,
    WF_LAST_RUN_DTTIME = @PA_WF_LAST_RUN_DTTIME,
    WF_CREATED_BY_V1 = @PA_WF_CREATED_BY_V1,
    WF_GROUP = @PA_WF_GROUP,
    WF_UNIQUE_SYS_NAME = @PA_WF_UNIQUE_SYS_NAME
  where WF_ID = @PA_WF_ID;
end
go
