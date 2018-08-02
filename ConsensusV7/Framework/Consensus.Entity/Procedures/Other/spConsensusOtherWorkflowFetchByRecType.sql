if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusOtherWorkflowFetchByRecType')
  exec ('create procedure dbo.spConsensusOtherWorkflowFetchByRecType as select 1 as temp')
go
alter procedure dbo.spConsensusOtherWorkflowFetchByRecType(@PA_WF_REC_TYPE varchar(50) = null output) as 
begin
  select 
    WF_ID,
    WF_LOCK,
    WF_ADD_DATE,
    WF_ADD_BY,
    WF_MOD_DATE,
    WF_MOD_BY,
    WF_RCV_DATE,
    WF_RCV_FROM,
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
  from dbo.Workflow
  where WF_REC_TYPE = @PA_WF_REC_TYPE
end
go