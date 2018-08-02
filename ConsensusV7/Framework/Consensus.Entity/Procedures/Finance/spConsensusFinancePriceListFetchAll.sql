if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusFinancePriceListFetchAll')
  exec ('create procedure dbo.spConsensusFinancePriceListFetchAll as select 1 as temp')
go
alter procedure dbo.spConsensusFinancePriceListFetchAll as 
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
end
go
