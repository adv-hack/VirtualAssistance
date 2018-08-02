if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusFinanceInvheaderFetchAllBySelcospid')
  exec ('create procedure dbo.spConsensusFinanceInvheaderFetchAllBySelcospid as select 1 as temp')
go
alter procedure dbo.spConsensusFinanceInvheaderFetchAllBySelcospid(@PA_INV_SELCO_SP_ID varchar(11) = null output) as 
begin
  select 
    INV_ID,
    INV_LOCK,
    INV_ADD_DATE,
    INV_ADD_BY,
    INV_MOD_DATE,
    INV_MOD_BY,
    INV_RCV_DATE,
    INV_RCV_FROM,
    INV_BOOK_ID,
    INV_ORG_ID,
    INV_PERSON_ID,
    INV_SALESMAN_ID,
    INV_DELVRY_REF,
    INV_CARRIER,
    INV_DELVRY_DATE,
    INV_ORDER_DATE,
    INV_CUST_ORDER_NO,
    INV_DELVRY_ADD,
    INV_REF,
    INV_DATE,
    INV_STATUS,
    INV_ADD,
    INV_CREDIT_NTE_REF,
    INV_CREDIT_NTE_DTE,
    INV_CREDIT_NTE_STA,
    INV_NOTES,
    INV_NET_TOTAL,
    INV_VAT_TOTAL,
    INV_GROSS_TOTAL,
    INV_NET_TOTAL_BC,
    INV_VAT_TOTAL_BC,
    INV_GROSS_TOTAL_BC,
    INV_CURRENCY_TYPE,
    INV_TYPE,
    INV_ACCOUNT_TYPE,
    INV_IN_RESPECT_OF,
    INV_FOOTER,
    INV_CREDIT_PERCENT,
    INV_COURSE_ID,
    INV_COURSE_NAME,
    INV_CORS_STRT_DTE,
    INV_COURSE_END_DTE,
    INV_CORS_COST_CODE,
    INV_BOOK_REF,
    INV_BOOKER,
    INV_BOOK_ORG_NAME,
    INV_ADD_MAILSTRING,
    INV_BK_ORG_CUST_AC,
    INV_VENUE_ORG_NAME,
    INV_PENALTY,
    INV_BOOK_ORG_REGI,
    INV_PRINT_BOOKER,
    INV_INV_ORG_NAME,
    INV_EXTRA_NOTES,
    INV_BAT_ID,
    INV_SALES_ID,
    INV_TEXT,
    INV_PAY_DATE,
    INV_PAY_STATUS,
    INV_PROJ_ID,
    INV_CCARD_ID,
    INV_RECVD,
    INV_RECVD_BC,
    INV_PERIOD,
    INV_DUE_DATE,
    INV_UNPAID_VAL,
    INV_UNPAID_VAL_BC,
    INV_NOTES_ID,
    INV_CRYSTAL_RPT,
    INV_APP_BY,
    INV_APP_DATE,
    INV_FOR_ATTN_OF,
    INV_PRINTED,
    INV_CURR_RATE_BC,
    INV_CURR_RATE_BC2,
    INV_SELCO_SP_ID,
    INV_MEP_ID,
    INV_LT_ID,
    INV_USERCHAR_1,
    INV_ACC_STATUS,
    INV_ACC_REF,
    INV_ACC_NOTES,
    INV_ACC_MOD_BY,
    INV_ACC_MOD_DATE,
    INV_NET_TOTAL_BC2,
    INV_VAT_TOTAL_BC2,
    INV_GROSS_TOTAL_BC2,
    INV_UNPAID_TOTAL_BC2,
    INV_PRINT_BAT_ID,
    INV_PERSON_PHONE,
    INV_ACC_ID,
    INV_BAT_ERROR,
    INV_SALES_PROLE_ID,
    INV_PROLE_ID
  from dbo.InvHeader
  where INV_SELCO_SP_ID = @PA_INV_SELCO_SP_ID
end
go
