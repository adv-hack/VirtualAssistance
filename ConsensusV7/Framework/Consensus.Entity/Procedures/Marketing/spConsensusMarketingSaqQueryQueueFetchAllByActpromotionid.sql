if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMarketingSaqQueryQueueFetchAllByActpromotionid')
  exec ('create procedure dbo.spConsensusMarketingSaqQueryQueueFetchAllByActpromotionid as select 1 as temp')
go
alter procedure dbo.spConsensusMarketingSaqQueryQueueFetchAllByActpromotionid(@PA_QQ_ACT_PROMOTION_ID varchar(11) = null output) as 
begin
  select 
    QQ_ID,
    QQ_ADD_BY,
    QQ_ADD_DATE,
    QQ_MOD_BY,
    QQ_MOD_DATE,
    QQ_PROLE_ID,
    QQ_PRIORITY,
    QQ_PROCESSED,
    QQ_QRY_ID,
    QQ_OUTPUT_OPTION,
    QQ_PROCESS_OPTION,
    QQ_EMAIL_WHEN_DONE,
    QQ_REDO_RESULTS_IF_EXIST,
    QQ_EMAIL_ADDRESS,
    QQ_ACT_TYPE,
    QQ_ACT_DATE,
    QQ_ACT_PROLE_ID,
    QQ_ACT_NOTE,
    QQ_LIST_ID,
    QQ_PROF_KEY,
    QQ_PROF_VALUE,
    QQ_PROF_VALUE2,
    QQ_PROF_VALUE3,
    QQ_FILE_TYPE,
    QQ_PM_ID,
    QQ_DATE_SELECTED,
    QQ_STATUS,
    QQ_ERROR,
    QQ_PROF_KEY_ORG,
    QQ_PROF_VALUE_ORG,
    QQ_PROF_VALUE2_ORG,
    QQ_RESULTS_TYPE,
    QQ_ACT_ARG_ID,
    QQ_ACT_QUEST_ID,
    QQ_ACT_PROMOTION_ID,
    QQ_BPP_LIT_ID
  from dbo.SAQ_QUERY_QUEUE
  where QQ_ACT_PROMOTION_ID = @PA_QQ_ACT_PROMOTION_ID
end
go
