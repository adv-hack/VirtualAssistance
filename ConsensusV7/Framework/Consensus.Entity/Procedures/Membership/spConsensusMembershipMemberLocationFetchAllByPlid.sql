if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMembershipMemberLocationFetchAllByPlid')
  exec ('create procedure dbo.spConsensusMembershipMemberLocationFetchAllByPlid as select 1 as temp')
go
alter procedure dbo.spConsensusMembershipMemberLocationFetchAllByPlid(@PA_MEL_PL_ID varchar(11) = null output) as 
begin
  select 
    MEL_ID,
    MEL_ADD_BY,
    MEL_ADD_DATE,
    MEL_MOD_BY,
    MEL_MOD_DATE,
    MEL_RCV_FROM,
    MEL_RCV_DATE,
    MEL_MEM_ID,
    MEL_MEP_ID,
    MEL_START,
    MEL_END,
    MEL_STATUS,
    MEL_TYPE,
    MEL_FEE,
    MEL_FEE_BC,
    MEL_FEE_BC2,
    MEL_CURRENCY,
    MEL_ORG_ID,
    MEL_PROLE_ID,
    MEL_MAIL_ADD_ID,
    MEL_MAIL_INV_ID,
    MEL_MAIL_TO_HOME,
    MEL_RENEW_LOC,
    MEL_PRINCIPAL,
    MEL_OVERSEAS,
    MEL_VATCD,
    MEL_REF,
    MEL_VAT_RATE,
    MEL_VAT_AMT,
    MEL_VAT_AMT_BC,
    MEL_VAT_AMT_BC2,
    MEL_INVLN_ID,
    MEL_NO_COPIES,
    MEL_INVOICED,
    MEL_USERNAME,
    MEL_PASSWORD,
    MEL_SY_TYPE,
    MEL_PROD_ID,
    MEL_CURRENT,
    MEL_GROSS_FEE,
    MEL_GROSS_FEE_BC,
    MEL_GROSS_FEE_BC2,
    MEL_DISC_REASON,
    MEL_PHONE_OVERRIDE,
    MEL_FAX_OVERRIDE,
    MEL_PHONE_STD_OVERRIDE,
    MEL_FAX_STD_OVERRIDE,
    MEL_EMAIL_OVERRIDE,
    MEL_URL,
    MEL_FEE_NOT_PRO_RATA,
    MEL_WEB_ENABLED,
    MEL_FEE_EXEMPT,
    MEL_CURRENT_DATE,
    MEL_CANCEL_DATE,
    MEL_PL_ID,
    MEL_DISC_ID,
    MEL_DISCOUNT,
    MEL_DISCOUNT_BC,
    MEL_DISCOUNT_BC2,
    MEL_DISC_APPLIED_DATE,
    MEL_FEE_CALCULATED,
    MEL_LIST_PRICE,
    MEL_LIST_PRICE_BC,
    MEL_LIST_PRICE_BC2,
    MEL_DESPATCH_DATE,
    MEL_PO_NUMBER,
    MEL_QTY,
    MEL_DO_NOT_RENEW,
    MEL_CANCEL_REASON,
    MEL_UNT_PRICE,
    MEL_UNT_PRICE_BC,
    MEL_UNT_PRICE_BC2,
    MEL_DISC_RENEWAL,
    MEL_PRICE_MODIFIED,
    MEL_DISC_PERCENT,
    MEL_REV_CODE,
    MEL_COST_CODE
  from dbo.Member_location
  where MEL_PL_ID = @PA_MEL_PL_ID
end
go
