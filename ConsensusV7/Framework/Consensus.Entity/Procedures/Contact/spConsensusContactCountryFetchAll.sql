if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusContactCountryFetchAll')
  exec ('create procedure dbo.spConsensusContactCountryFetchAll as select 1 as temp')
go
alter procedure dbo.spConsensusContactCountryFetchAll as 
begin
  select 
    CO_ID,
    CO_ADD_BY,
    CO_ADD_DATE,
    CO_MOD_BY,
    CO_MOD_DATE,
    CO_RCV_FROM,
    CO_RCV_DATE,
    CO_NAME,
    CO_FORMAT,
    CO_REP,
    CO_AREA,
    CO_REP_ID,
    CO_REP1_ID,
    CO_REP2_ID,
    CO_POSTCODE_FLAG,
    CO_ORG_TYPE,
    CO_PRODUCT_GROUP,
    CO_POSTCODE,
    CO_INDUSTRY,
    CO_TERR_ID,
    CO_LOCK,
    CO_COUNTY,
    CO_VAT_TYPE,
    CO_LANGUAGE,
    CO_CURRENCY,
    CO_USERCHAR_1,
    CO_USERCHAR_2,
    CO_USERNUM_1,
    CO_USERNUM_2,
    CO_NOTES,
    CO_EURO,
    CO_COUNTRY_CODE,
    CO_TOWN,
    CO_PCODE_LU,
    CO_LINE_POS,
    CO_VAT_CODE,
    CO_VAT_COUNTRY_CODE,
    CO_MAILSTRING_ORDER,
    CO_MAILSTRING_DISPLAY,
    CO_MAILSTRING_NEWLINE,
    CO_COUNTRY_CODE_2
  from dbo.Country
end
go
