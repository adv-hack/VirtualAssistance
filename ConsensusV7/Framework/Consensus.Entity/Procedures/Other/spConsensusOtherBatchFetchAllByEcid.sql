if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusOtherBatchFetchAllByEcid')
  exec ('create procedure dbo.spConsensusOtherBatchFetchAllByEcid as select 1 as temp')
go
alter procedure dbo.spConsensusOtherBatchFetchAllByEcid(@PA_BAT_EC_ID integer = null output) as 
begin
  select 
    BAT_ID,
    BAT_LOCK,
    BAT_ADD_DATE,
    BAT_ADD_BY,
    BAT_MOD_DATE,
    BAT_MOD_BY,
    BAT_RCV_DATE,
    BAT_RCV_FROM,
    BAT_TYPE,
    BAT_PROC,
    BAT_STATUS,
    BAT_PATH,
    BAT_SELECT,
    BAT_COUNT,
    BAT_START_D_T,
    BAT_RUN_D_T,
    BAT_RUN_BY,
    BAT_NOTE,
    BAT_CRT_NEXT_BATCH,
    BAT_DELAY_NXT_BTCH,
    BAT_RUN_DATE,
    BAT_SELCO_SP_ID,
    BAT_PROC1,
    BAT_LAST_DATE,
    BAT_ERROR_NOTE,
    BAT_EXT_FLAG,
    BAT_DD_STATUS,
    BAT_REC_ID,
    BAT_OPT_1,
    BAT_OPT_2,
    BAT_OPT_3,
    BAT_OPT_4,
    BAT_EXT_FILE_1,
    BAT_USER_TINT_1,
    BAT_FROM_DATE,
    BAT_TO_DATE,
    BAT_EXT_DATE,
    BAT_EXT_REF,
    BAT_RERUN,
    BAT_EC_ID,
    BAT_ARG_ID,
    BAT_DI_ID
  from dbo.Batch
  where BAT_EC_ID = @PA_BAT_EC_ID
end
go
