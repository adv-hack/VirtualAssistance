if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusContactTrainProdXrefFetchById')
  exec ('create procedure dbo.spConsensusContactTrainProdXrefFetchById as select 1 as temp')
go
alter procedure dbo.spConsensusContactTrainProdXrefFetchById(@PA_TPXREF_ID varchar(11) = null output) as 
begin
  select 
    TPXREF_ID,
    TPXREF_ADD_BY,
    TPXREF_ADD_DATE,
    TPXREF_MOD_BY,
    TPXREF_MOD_DATE,
    TPXREF_RCV_FROM,
    TPXREF_RCV_DATE,
    TPXREF_TRAIN_ID,
    TPXREF_LOC_ID,
    TPXREF_PROD_ID,
    TPXREF_START_DATE,
    TPXREF_END_DATE,
    TPXREF_STATUS,
    TPXREF_GRADE,
    TPXREF_NOTES,
    TPXREF_COST,
    TPXREF_USERCHAR_1,
    TPXREF_USERCHAR_2,
    TPXREF_USERCHAR_3,
    TPXREF_USERCHAR_4,
    TPXREF_USERCHAR_5,
    TPXREF_USERCHAR_6,
    TPXREF_USERINT_1,
    TPXREF_USERINT_2,
    TPXREF_USERINT_3,
    TPXREF_USERINT_4,
    TPXREF_USERINT_5,
    TPXREF_USERINT_6,
    TPXREF_USERNUM_1,
    TPXREF_USERNUM_2,
    TPXREF_USERNUM_3,
    TPXREF_USERNUM_4,
    TPXREF_USERNUM_5,
    TPXREF_USERNUM_6,
    TPXREF_USERDATE_1,
    TPXREF_USERDATE_2,
    TPXREF_USERDATE_3,
    TPXREF_USERDATE_4,
    TPXREF_USERDATE_5,
    TPXREF_USERDATE_6
  from dbo.TRAIN_PROD_XREF
  where TPXREF_ID = @PA_TPXREF_ID
end
go
