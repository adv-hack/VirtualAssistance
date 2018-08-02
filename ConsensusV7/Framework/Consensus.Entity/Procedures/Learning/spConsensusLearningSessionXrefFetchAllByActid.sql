if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusLearningSessionXrefFetchAllByActid')
  exec ('create procedure dbo.spConsensusLearningSessionXrefFetchAllByActid as select 1 as temp')
go
alter procedure dbo.spConsensusLearningSessionXrefFetchAllByActid(@PA_SXREF_ACT_ID varchar(11) = null output) as 
begin
  select 
    SXREF_ID,
    SXREF_LOCK,
    SXREF_ADD_DATE,
    SXREF_ADD_BY,
    SXREF_MOD_DATE,
    SXREF_MOD_BY,
    SXREF_RCV_DATE,
    SXREF_RCV_FROM,
    SXREF_COURSE_ID,
    SXREF_ACT_ID,
    SXREF_REAL,
    SXREF_ELEMENT,
    SXREF_MANDATORY,
    SXREF_INV_PRINT,
    SXREF_CURRENCY,
    SXREF_PRICE,
    SXREF_BLOCK_PRICE,
    SXREF_PRICE_BC,
    SXREF_BLK_PRICE_BC,
    SXREF_VATCD,
    SXREF_REV_CODE,
    SXREF_COST_CODE,
    SXREF_DO_NOT_INV,
    SXREF_SHOW_SALES,
    SXREF_NO_IN_SET,
    SXREF_RETAIL_PRICE,
    SXREF_COST_PRICE,
    SXREF_RET_PRICE_BC,
    SXREF_CST_PRICE_BC,
    SXREF_RET_PRIC_BC2,
    SXREF_CST_PRIC_BC2,
    SXREF_PRICE_A,
    SXREF_PRICE_B,
    SXREF_PRICE_C,
    SXREF_PRICE_D,
    SXREF_PRICE_E,
    SXREF_DEFAULT,
    SXREF_PL_ID,
    SXREF_TICKET,
    SXREF_GROUP_QTY,
    SXREF_GROUP_DTE,
    SXREF_GROUP_QTY_ID,
    SXREF_GROUP_DTE_ID,
    SXREF_QTY_MIN,
    SXREF_QTY_MAX,
    SXREF_VALID_FROM,
    SXREF_VALID_UNTIL,
    SXREF_BEFORE_DAYS,
    SXREF_CHARGEABLE,
    SXREF_MAIN_SESSION,
    SXREF_ETT_ID,
    SXREF_GRP_SG_ID,
    SXREF_STRM_SG_ID,
    SXREF_GRID_START,
    SXREF_GRID_END,
    SXREF_SESS_PNTS,
    SXREF_MAST_SESS,
    SXREF_SELECTED,
    SXREF_COUNT_DEL,
    SXREF_PAY_PNTS,
    SXREF_CODE,
    SXREF_ACTXREF_ID,
    SXREF_PROD_ID,
    SXREF_PL_NAME,
    SXREF_PRS_ID,
    SXREF_MEMBER,
    SXREF_START_DAY,
    SXREF_END_DAY,
    SXREF_LST_PRICE,
    SXREF_STUDENT,
    SXREF_BOM_ID,
    SXREF_EP_ID,
    SXREF_VALID_DATE,
    SXREF_REGION,
    SXREF_CSG_ID
  from dbo.Session_Xref
  where SXREF_ACT_ID = @PA_SXREF_ACT_ID
end
go
