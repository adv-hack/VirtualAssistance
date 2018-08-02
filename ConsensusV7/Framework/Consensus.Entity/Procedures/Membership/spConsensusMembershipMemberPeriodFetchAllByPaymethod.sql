if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMembershipMemberPeriodFetchAllByPaymethod')
  exec ('create procedure dbo.spConsensusMembershipMemberPeriodFetchAllByPaymethod as select 1 as temp')
go
alter procedure dbo.spConsensusMembershipMemberPeriodFetchAllByPaymethod(@PA_MEP_PAY_METHOD varchar(40) = null output) as 
begin
  select 
    MEP_ID,
    MEP_ADD_BY,
    MEP_ADD_DATE,
    MEP_MOD_BY,
    MEP_MOD_DATE,
    MEP_RCV_FROM,
    MEP_RCV_DATE,
    MEP_MEM_ID,
    MEP_PROD_ID,
    MEP_MEM_GRADE,
    MEP_YEAR,
    MEP_START,
    MEP_END,
    MEP_RENEW_DATE1,
    MEP_RENEW_DATE2,
    MEP_RENEW_DATE3,
    MEP_QTY_1,
    MEP_QTY_2,
    MEP_QTY_3,
    MEP_QTY_4,
    MEP_QTY_5,
    MEP_FEE,
    MEP_FEE_BC,
    MEP_FEE_BC2,
    MEP_CURRENCY,
    MEP_FEE_EXTRA,
    MEP_FEE_EXTRA_BC,
    MEP_FEE_EXTRA_BC2,
    MEP_PAY_METHOD,
    MEP_PAY_STATUS,
    MEP_PO_REF,
    MEP_CCARD_TYPE,
    MEP_NAME_ON_CARD,
    MEP_CCARD_NUMBER,
    MEP_CCARD_START,
    MEP_CCARD_EXPY,
    MEP_BANK_ACC_CODE,
    MEP_SORT_CODE,
    MEP_CCARD_ISSUE,
    MEP_SECURITY,
    MEP_CCARD_AUTHCODE,
    MEP_DOCS_METHOD,
    MEP_INV_ORG_ID,
    MEP_INV_PROLE_ID,
    MEP_INV_ADD_ID,
    MEP_PRICE_LIST_ID,
    MEP_CURRENT,
    MEP_PM_ID,
    MEP_SUB_ONLY,
    MEP_RENEWED_DATE,
    MEP_LAPSED_DATE,
    MEP_RENEW_DATE_0,
    MEP_STATUS,
    MEP_SELCO_SP_ID,
    MEP_RENEWAL_DATE,
    MEP_RENEW_START,
    MEP_CREATE_BAT_ID,
    MEP_RENEW_BAT_ID,
    MEP_OLD_MEP_ID,
    MEP_INC_HIERARCHY,
    MEP_NO_COPIES_1,
    MEP_NO_COPIES_2,
    MEP_NO_COPIES_3,
    MEP_CUST_ORDER_NO,
    MEP_USERCHAR_1,
    MEP_CANCEL_REASON,
    MEP_MEMB_RATE,
    MEP_MEM_TYPE,
    MEP_FOR_ATTN_OF,
    MEP_ORG_CUST_AC,
    MEP_REMIND1_BAT_ID,
    MEP_REMIND2_BAT_ID,
    MEP_REMIND3_BAT_ID,
    MEP_REMIND4_BAT_ID,
    MEP_REMIND1_DATE,
    MEP_REMIND2_DATE,
    MEP_REMIND3_DATE,
    MEP_REMIND4_DATE,
    MEP_PREV_STATUS,
    MEP_CONT_PAYMENT,
    MEP_NET_FEE,
    MEP_NET_FEE_BC,
    MEP_NET_FEE_BC2,
    MEP_VAT_AMT,
    MEP_VAT_AMT_BC,
    MEP_VAT_AMT_BC2,
    MEP_NOTES,
    MEP_CURRENT_DATE,
    MEP_LAPSE_DATE,
    MEP_BATCH_INVOICE,
    MEP_BASKET_FL,
    MEP_INDEM_INSUR_DATE,
    MEP_EXP_BAT_ID,
    MEP_ROLLBACK_DATE,
    MEP_STATUS_INT,
    MEP_SHORT_DATED,
    MEP_CART_ID,
    MEP_PCLN_ID,
    MEP_CURR_RATE_BC,
    MEP_CURR_RATE_BC2,
    MEP_APP_METHOD,
    MEP_OPP_ID,
    MEP_DO_NOT_INVOIC,
    MEP_PO_EXPIRATION_DATE,
    MEP_ACC_ID,
    MEP_MEMBERSHIP_NAME
  from dbo.Member_period
  where MEP_PAY_METHOD = @PA_MEP_PAY_METHOD
end
go
