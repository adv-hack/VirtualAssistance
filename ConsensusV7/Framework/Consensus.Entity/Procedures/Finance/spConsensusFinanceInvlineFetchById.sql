if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusFinanceInvlineFetchById')
  exec ('create procedure dbo.spConsensusFinanceInvlineFetchById as select 1 as temp')
go
alter procedure dbo.spConsensusFinanceInvlineFetchById(@PA_INVLN_ID varchar(11) = null output) as 
begin
  select 
    INVLN_ID,
    INVLN_ADD_DATE,
    INVLN_ADD_BY,
    INVLN_MOD_DATE,
    INVLN_MOD_BY,
    INVLN_RCV_DATE,
    INVLN_RCV_FROM,
    INVLN_INV_ID,
    INVLN_PRODUCT_ID,
    INVLN_ORDER_LN_ID,
    INVLN_LINE_NO,
    INVLN_QTY,
    INVLN_UNIT_PRICE,
    INVLN_DISCOUNT,
    INVLN_DISCT_PRICE,
    INVLN_NET,
    INVLN_VAT_CODE,
    INVLN_VAT_RATE,
    INVLN_VAT_AMT,
    INVLN_TOTAL_PRICE,
    INVLN_CREDIT_DESC,
    INVLN_UNIT_PRCE_BC,
    INVLN_DISCOUNT_BC,
    INVLN_DISC_PRCE_BC,
    INVLN_NET_BC,
    INVLN_TOT_PRICE_BC,
    INVLN_CURR_TYPE,
    INVLN_DESCRIPTION,
    INVLN_SALES_ID,
    INVLN_SALES_DET_ID,
    INVLN_BOOK_ID,
    INVLN_ELEM_ID,
    INVLN_COURSE_ID,
    INVLN_TYPE,
    INVLN_PROD_NAME,
    INVLN_PRD_REV_CODE,
    INVLN_PROJ_ID,
    INVLN_MEL_ID,
    INVLN_UNT_PRCE_BC2,
    INVLN_NET_BC2,
    INVLN_TOT_PRCE_BC2,
    INVLN_VAT_AMT_BC,
    INVLN_VAT_AMT_BC2,
    INVLN_COST_CODE,
    INVLN_CREDITED,
    INVLN_USERCHAR_1,
    INVLN_ANL1,
    INVLN_ANL2,
    INVLN_ANL3,
    INVLN_DISCOUNT_BC2,
    INVLN_DISC_PRICE_BC2,
    INVLN_CREDIT_FOR_INVLN_ID,
    INVLN_DO_NOT_PRINT,
    INVLN_DEL_COST_CODE,
    INVLN_SELCO_SP_ID,
    INVLN_CURRENCY_TYPE,
    INVLN_CURR_RATE_BC,
    INVLN_CURR_RATE_BC2,
    INVLN_UNIT_PRICE_DISC,
    INVLN_UNIT_PRICE_DISC_BC,
    INVLN_UNIT_PRICE_DISC_BC2,
    INVLN_DEPT,
    INVLN_SKU,
    INVLN_JOB_CODE,
    INVLN_JOB_ANAL_CODE,
    INVLN_JOB_TYPE,
    INVLN_JOB_PARENT,
    INVLN_PRS_TYPE
  from dbo.InvLine
  where INVLN_ID = @PA_INVLN_ID
end
go
