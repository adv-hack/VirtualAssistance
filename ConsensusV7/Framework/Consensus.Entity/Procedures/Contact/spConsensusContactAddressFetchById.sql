if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusContactAddressFetchById')
  exec ('create procedure dbo.spConsensusContactAddressFetchById as select 1 as temp')
go
alter procedure dbo.spConsensusContactAddressFetchById(@PA_ADD_ID varchar(11) = null output) as 
begin
  select 
    ADD_ID,
    ADD_LOCK,
    ADD_ADD_DATE,
    ADD_ADD_BY,
    ADD_MOD_DATE,
    ADD_MOD_BY,
    ADD_RCV_DATE,
    ADD_RCV_FROM,
    ADD_BUILDING,
    ADD_STREET,
    ADD_TOWN,
    ADD_AREA,
    ADD_COUNTY,
    ADD_POSTCODE,
    ADD_COUNTRY,
    ADD_COUNTRY_STYLE,
    ADD_MAILSTRING,
    ADD_MAP,
    ADD_JOINING_INSTRC,
    ADD_COUNTRY_VALUE,
    ADD_CO_CODE,
    ADD_CO_AREA,
    ADD_CO_REGION,
    ADD_USERCHAR_1,
    ADD_USERCHAR_2,
    ADD_USERCHAR_3,
    ADD_DRTION_TEXT,
    ADD_DRTION_HTML,
    ADD_LOCATION_URL,
    ADD_PHONE,
    ADD_FAX,
    ADD_EMAIL,
    ADD_CUSTOMER_ACC,
    ADD_5,
    ADD_PHONE_STD,
    ADD_FAX_STD,
    ADD_LAT,
    ADD_LONG,
    ADD_GRID_EAST,
    ADD_GRID_NORTH,
    ADD_BAT_ID,
    ADD_DX_CODE,
    ADD_DX_EXCHANGE,
    ADD_DX_BARCODE,
    ADD_MAILSORT_CODE
  from dbo.Address
  where ADD_ID = @PA_ADD_ID
end
go
