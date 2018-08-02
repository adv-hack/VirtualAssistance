if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusOtherBatchModify')
  exec ('create procedure dbo.spConsensusOtherBatchModify as select 1 as temp')
go
alter procedure dbo.spConsensusOtherBatchModify(@PA_BAT_ID varchar(11) = null output, @PA_BAT_LOCK varchar(10) = null output, @PA_BAT_TYPE varchar(40) = null output, @PA_BAT_PROC varchar(255) = null output, @PA_BAT_STATUS varchar(50) = null output, @PA_BAT_PATH varchar(255) = null output, @PA_BAT_SELECT varchar(30) = null output, @PA_BAT_COUNT integer = null output, @PA_BAT_START_D_T datetime = null output, @PA_BAT_RUN_D_T datetime = null output, @PA_BAT_RUN_BY varchar(3) = null output, @PA_BAT_NOTE varchar(max) = null output, @PA_BAT_CRT_NEXT_BATCH tinyint = null output, @PA_BAT_DELAY_NXT_BTCH float = null output, @PA_BAT_RUN_DATE datetime = null output, @PA_BAT_SELCO_SP_ID varchar(11) = null output, @PA_BAT_PROC1 varchar(255) = null output, @PA_BAT_LAST_DATE datetime = null output, @PA_BAT_ERROR_NOTE varchar(max) = null output, @PA_BAT_EXT_FLAG tinyint = null output, @PA_BAT_DD_STATUS tinyint = null output, @PA_BAT_REC_ID varchar(11) = null output, @PA_BAT_OPT_1 tinyint = null output, @PA_BAT_OPT_2 tinyint = null output, @PA_BAT_OPT_3 tinyint = null output, @PA_BAT_OPT_4 tinyint = null output, @PA_BAT_EXT_FILE_1 varchar(40) = null output, @PA_BAT_USER_TINT_1 tinyint = null output, @PA_BAT_FROM_DATE datetime = null output, @PA_BAT_TO_DATE datetime = null output, @PA_BAT_EXT_DATE datetime = null output, @PA_BAT_EXT_REF varchar(8) = null output, @PA_BAT_RERUN tinyint = null output, @PA_BAT_EC_ID integer = null output, @PA_BAT_ARG_ID varchar(11) = null output, @PA_BAT_DI_ID integer = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.Batch set
    BAT_MOD_DATE = getDate(),
    BAT_MOD_BY = @_AUDIT_USER_ID,
    BAT_LOCK = @PA_BAT_LOCK,
    BAT_TYPE = @PA_BAT_TYPE,
    BAT_PROC = @PA_BAT_PROC,
    BAT_STATUS = @PA_BAT_STATUS,
    BAT_PATH = @PA_BAT_PATH,
    BAT_SELECT = @PA_BAT_SELECT,
    BAT_COUNT = @PA_BAT_COUNT,
    BAT_START_D_T = @PA_BAT_START_D_T,
    BAT_RUN_D_T = @PA_BAT_RUN_D_T,
    BAT_RUN_BY = @PA_BAT_RUN_BY,
    BAT_NOTE = @PA_BAT_NOTE,
    BAT_CRT_NEXT_BATCH = @PA_BAT_CRT_NEXT_BATCH,
    BAT_DELAY_NXT_BTCH = @PA_BAT_DELAY_NXT_BTCH,
    BAT_RUN_DATE = @PA_BAT_RUN_DATE,
    BAT_SELCO_SP_ID = @PA_BAT_SELCO_SP_ID,
    BAT_PROC1 = @PA_BAT_PROC1,
    BAT_LAST_DATE = @PA_BAT_LAST_DATE,
    BAT_ERROR_NOTE = @PA_BAT_ERROR_NOTE,
    BAT_EXT_FLAG = @PA_BAT_EXT_FLAG,
    BAT_DD_STATUS = @PA_BAT_DD_STATUS,
    BAT_REC_ID = @PA_BAT_REC_ID,
    BAT_OPT_1 = @PA_BAT_OPT_1,
    BAT_OPT_2 = @PA_BAT_OPT_2,
    BAT_OPT_3 = @PA_BAT_OPT_3,
    BAT_OPT_4 = @PA_BAT_OPT_4,
    BAT_EXT_FILE_1 = @PA_BAT_EXT_FILE_1,
    BAT_USER_TINT_1 = @PA_BAT_USER_TINT_1,
    BAT_FROM_DATE = @PA_BAT_FROM_DATE,
    BAT_TO_DATE = @PA_BAT_TO_DATE,
    BAT_EXT_DATE = @PA_BAT_EXT_DATE,
    BAT_EXT_REF = @PA_BAT_EXT_REF,
    BAT_RERUN = @PA_BAT_RERUN,
    BAT_EC_ID = @PA_BAT_EC_ID,
    BAT_ARG_ID = @PA_BAT_ARG_ID,
    BAT_DI_ID = @PA_BAT_DI_ID
  where BAT_ID = @PA_BAT_ID;
end
go
