if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusContactTrainerFetchAllByAinattrib01')
  exec ('create procedure dbo.spConsensusContactTrainerFetchAllByAinattrib01 as select 1 as temp')
go
alter procedure dbo.spConsensusContactTrainerFetchAllByAinattrib01(@PA_TRAIN_ATTRIB01 varchar(40) = null output) as 
begin
  select 
    TRAIN_ID,
    TRAIN_LOCK,
    TRAIN_ADD_DATE,
    TRAIN_ADD_BY,
    TRAIN_MOD_DATE,
    TRAIN_MOD_BY,
    TRAIN_RCV_DATE,
    TRAIN_RCV_FROM,
    TRAIN_PROLE_ID,
    TRAIN_APP_ID,
    TRAIN_START_DATE,
    TRAIN_STATUS,
    TRAIN_REVIEW_DATE,
    TRAIN_REF,
    TRAIN_COST,
    TRAIN_USERCHAR_1,
    TRAIN_USERCHAR_2,
    TRAIN_USERCHAR_3,
    TRAIN_USERCHAR_4,
    TRAIN_USERCHAR_5,
    TRAIN_USERCHAR_6,
    TRAIN_USERINT_1,
    TRAIN_USERINT_2,
    TRAIN_USERINT_3,
    TRAIN_USERINT_4,
    TRAIN_USERINT_5,
    TRAIN_USERINT_6,
    TRAIN_USERNUM_1,
    TRAIN_USERNUM_2,
    TRAIN_USERNUM_3,
    TRAIN_USERNUM_4,
    TRAIN_USERNUM_5,
    TRAIN_USERNUM_6,
    TRAIN_USERDATE_1,
    TRAIN_USERDATE_2,
    TRAIN_USERDATE_3,
    TRAIN_USERDATE_4,
    TRAIN_USERDATE_5,
    TRAIN_USERDATE_6,
    TRAIN_BIOG,
    TRAIN_ATTRIB01,
    TRAIN_DAY_COST,
    TRAIN_HOUR_COST,
    TRAIN_BASE_POSTCODE,
    TRAIN_BASE_LAT,
    TRAIN_BASE_LONG,
    TRAIN_SELCO_SP_ID,
    TRAIN_INS_EXPIRY,
    TRN_UNIQUE_REF,
    TRAIN_FEE_NOTES_TEXT_ID,
    TRAIN_HOTEL_REQ_TEXT_ID,
    TRAIN_OTHER_INFO_TEXT_ID,
    TRAIN_PASSWORD,
    TRAIN_WEB,
    TRAIN_BIOG_PIC_URL,
    TRAIN_SY_TYPE
  from dbo.Trainer
  where TRAIN_ATTRIB01 = @PA_TRAIN_ATTRIB01
end
go
