if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusFinanceAccountFetchAllByAddid')
  exec ('create procedure dbo.spConsensusFinanceAccountFetchAllByAddid as select 1 as temp')
go
alter procedure dbo.spConsensusFinanceAccountFetchAllByAddid(@PA_ACC_ADD_ID varchar(11) = null output) as 
begin
  select 
    ACC_ID,
    ACC_LOCK,
    ACC_ADD_DATE,
    ACC_ADD_BY,
    ACC_MOD_DATE,
    ACC_MOD_BY,
    ACC_RCV_DATE,
    ACC_RCV_FROM,
    ACC_SYSTEM,
    ACC_SYSTEM_REF,
    ACC_ORG_ID,
    ACC_PRINCIPAL,
    ACC_PROLE_ID,
    ACC_CONTACT_ID,
    ACC_ADD_ID,
    ACC_SELCO_SP_ID,
    ACC_NO_ADD_CHANGE,
    ACC_PAYMENT_DAYS,
    ACC_STATUS,
    ACC_PAYMENT_TYPE,
    ACC_PAY_TERMS_1,
    ACC_PAY_TERMS_2,
    ACC_PAY_TERMS_3,
    ACC_PAY_TERMS_4,
    ACC_CREDIT,
    ACC_SPECIAL_TERMS,
    ACC_VATCD,
    ACC_INV_FOR_ATTN_OF,
    ACC_INVOICE_RULE,
    ACC_INVOICE_RULE_OFFSET,
    ACC_INVOICE_CONSOLIDATE,
    ACC_INVOICE_WHEN_STATUS,
    ACC_INVOICE_FORMAT,
    ACC_INVOICE_MUST_USE_RULE,
    ACC_INVOICE_FORMAT_0_TEXT,
    ACC_INVOICE_FORMAT_1_TEXT,
    ACC_INVOICE_OFFSET_TYPE,
    ACC_INV_ADD_TO,
    ACC_NAT_ACCOUNT,
    ACC_BANK_NAME,
    ACC_BANK_SORT_CODE,
    ACC_BANK_NO,
    ACC_BANK_ADD_ID,
    ACC_PAYMENT_METHD,
    ACC_DOC_TYPE,
    ACC_COUT_OFF_DAYS,
    ACC_TYPE,
    ACC_TITLE,
    ACC_STATUS_DATE,
    ACC_BAT_ID,
    ACC_REQ_CREDIT,
    ACC_DOCS_METHOD,
    ACC_DO_NOT_CHASE,
    ACC_INV_PACK_ID,
    ACC_REQ_PAYMENT_TYPE,
    ACC_REQ_PAYMENT_DAYS,
    ACC_DEFAULT_INV_STATUS,
    ACC_CURRENCY_TYPE,
    ACC_VAT_REG_NUM,
    ACC_MEM_PAYMENT_DAYS,
    ACC_PO_REQ,
    ACC_RUN_DATE,
    ACC_PSH_ID,
    ACC_DEFAULT,
    ACC_RULE_TYPE,
    ACC_NAT_ACCOUNT_DATE,
    ACC_COURSE_LEN,
    ACC_RENEW_DAYS,
    ACC_FIXED_RENEWAL,
    ACC_RENEWAL_MONTH,
    ACC_RENEWAL_DAY,
    ACC_RENEW,
    ACC_EXCL_DAY
  from dbo.Account
  where ACC_ADD_ID = @PA_ACC_ADD_ID
end
go
