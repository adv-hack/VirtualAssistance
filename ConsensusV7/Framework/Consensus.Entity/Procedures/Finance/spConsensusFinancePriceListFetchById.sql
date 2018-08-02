if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusFinancePriceListFetchById')
  exec ('create procedure dbo.spConsensusFinancePriceListFetchById as select 1 as temp')
go
alter procedure dbo.spConsensusFinancePriceListFetchById(@PA_PL_ID varchar(11) = null output) as 
begin
  select 
    PL_ID,
    PL_LOCK,
    PL_ADD_DATE,
    PL_ADD_BY,
    PL_MOD_DATE,
    PL_MOD_BY,
    PL_RCV_DATE,
    PL_RCV_FROM,
    PL_CURRENCY,
    PL_NAME,
    PL_VALID_FROM,
    PL_VALID_UNTIL,
    PL_BUSINESS_UNIT,
    PL_TICKET,
    PL_PROD_FAMILY,
    PL_BKT_ID,
    PL_ORG_ONLY,
    PL_STATUS,
    PL_PREPAY_ACCOUNT_ONLY,
    PL_PSH_ID,
    PL_DEFAULT,
    PL_VAT_CODE
  from dbo.Price_List
  where PL_ID = @PA_PL_ID
end
go
