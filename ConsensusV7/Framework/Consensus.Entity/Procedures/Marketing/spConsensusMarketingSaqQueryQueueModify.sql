if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMarketingSaqQueryQueueModify')
  exec ('create procedure dbo.spConsensusMarketingSaqQueryQueueModify as select 1 as temp')
go
alter procedure dbo.spConsensusMarketingSaqQueryQueueModify(@PA_QQ_ID bigint = null output, @PA_QQ_PROLE_ID varchar(11) = null output, @PA_QQ_PRIORITY tinyint = null output, @PA_QQ_PROCESSED tinyint = null output, @PA_QQ_QRY_ID bigint = null output, @PA_QQ_OUTPUT_OPTION tinyint = null output, @PA_QQ_PROCESS_OPTION tinyint = null output, @PA_QQ_EMAIL_WHEN_DONE tinyint = null output, @PA_QQ_REDO_RESULTS_IF_EXIST tinyint = null output, @PA_QQ_EMAIL_ADDRESS varchar(240) = null output, @PA_QQ_ACT_TYPE varchar(25) = null output, @PA_QQ_ACT_DATE datetime = null output, @PA_QQ_ACT_PROLE_ID varchar(11) = null output, @PA_QQ_ACT_NOTE varchar(2000) = null output, @PA_QQ_LIST_ID varchar(11) = null output, @PA_QQ_PROF_KEY varchar(40) = null output, @PA_QQ_PROF_VALUE varchar(40) = null output, @PA_QQ_PROF_VALUE2 varchar(40) = null output, @PA_QQ_PROF_VALUE3 varchar(20) = null output, @PA_QQ_FILE_TYPE varchar(10) = null output, @PA_QQ_PM_ID varchar(11) = null output, @PA_QQ_DATE_SELECTED datetime = null output, @PA_QQ_STATUS varchar(40) = null output, @PA_QQ_ERROR varchar(3000) = null output, @PA_QQ_PROF_KEY_ORG varchar(40) = null output, @PA_QQ_PROF_VALUE_ORG varchar(40) = null output, @PA_QQ_PROF_VALUE2_ORG varchar(40) = null output, @PA_QQ_RESULTS_TYPE varchar(10) = null output, @PA_QQ_ACT_ARG_ID varchar(11) = null output, @PA_QQ_ACT_QUEST_ID varchar(11) = null output, @PA_QQ_ACT_PROMOTION_ID varchar(11) = null output, @PA_QQ_BPP_LIT_ID varchar(11) = null output, @PA_QQ_PACK_ID varchar(11) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.SAQ_QUERY_QUEUE set
    QQ_MOD_DATE = getDate(),
    QQ_MOD_BY = @_AUDIT_USER_ID,
    QQ_PROLE_ID = @PA_QQ_PROLE_ID,
    QQ_PRIORITY = @PA_QQ_PRIORITY,
    QQ_PROCESSED = @PA_QQ_PROCESSED,
    QQ_QRY_ID = @PA_QQ_QRY_ID,
    QQ_OUTPUT_OPTION = @PA_QQ_OUTPUT_OPTION,
    QQ_PROCESS_OPTION = @PA_QQ_PROCESS_OPTION,
    QQ_EMAIL_WHEN_DONE = @PA_QQ_EMAIL_WHEN_DONE,
    QQ_REDO_RESULTS_IF_EXIST = @PA_QQ_REDO_RESULTS_IF_EXIST,
    QQ_EMAIL_ADDRESS = @PA_QQ_EMAIL_ADDRESS,
    QQ_ACT_TYPE = @PA_QQ_ACT_TYPE,
    QQ_ACT_DATE = @PA_QQ_ACT_DATE,
    QQ_ACT_PROLE_ID = @PA_QQ_ACT_PROLE_ID,
    QQ_ACT_NOTE = @PA_QQ_ACT_NOTE,
    QQ_LIST_ID = @PA_QQ_LIST_ID,
    QQ_PROF_KEY = @PA_QQ_PROF_KEY,
    QQ_PROF_VALUE = @PA_QQ_PROF_VALUE,
    QQ_PROF_VALUE2 = @PA_QQ_PROF_VALUE2,
    QQ_PROF_VALUE3 = @PA_QQ_PROF_VALUE3,
    QQ_FILE_TYPE = @PA_QQ_FILE_TYPE,
    QQ_PM_ID = @PA_QQ_PM_ID,
    QQ_DATE_SELECTED = @PA_QQ_DATE_SELECTED,
    QQ_STATUS = @PA_QQ_STATUS,
    QQ_ERROR = @PA_QQ_ERROR,
    QQ_PROF_KEY_ORG = @PA_QQ_PROF_KEY_ORG,
    QQ_PROF_VALUE_ORG = @PA_QQ_PROF_VALUE_ORG,
    QQ_PROF_VALUE2_ORG = @PA_QQ_PROF_VALUE2_ORG,
    QQ_RESULTS_TYPE = @PA_QQ_RESULTS_TYPE,
    QQ_ACT_ARG_ID = @PA_QQ_ACT_ARG_ID,
    QQ_ACT_QUEST_ID = @PA_QQ_ACT_QUEST_ID,
    QQ_ACT_PROMOTION_ID = @PA_QQ_ACT_PROMOTION_ID,
    QQ_BPP_LIT_ID = @PA_QQ_BPP_LIT_ID,
    QQ_PACK_ID = @PA_QQ_PACK_ID
  where QQ_ID = @PA_QQ_ID;
end
go
