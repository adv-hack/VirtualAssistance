if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusContactAddressModify')
  exec ('create procedure dbo.spConsensusContactAddressModify as select 1 as temp')
go
alter procedure dbo.spConsensusContactAddressModify(@PA_ADD_ID varchar(11) = null output, @PA_ADD_LOCK varchar(10) = null output, @PA_ADD_BUILDING nvarchar(50) = null output, @PA_ADD_STREET nvarchar(50) = null output, @PA_ADD_TOWN nvarchar(50) = null output, @PA_ADD_AREA nvarchar(50) = null output, @PA_ADD_COUNTY nvarchar(50) = null output, @PA_ADD_POSTCODE varchar(12) = null output, @PA_ADD_COUNTRY nvarchar(50) = null output, @PA_ADD_COUNTRY_STYLE varchar(20) = null output, @PA_ADD_MAILSTRING nvarchar(240) = null output, @PA_ADD_MAP varchar(11) = null output, @PA_ADD_JOINING_INSTRC varchar(11) = null output, @PA_ADD_COUNTRY_VALUE tinyint = null output, @PA_ADD_CO_CODE varchar(10) = null output, @PA_ADD_CO_AREA varchar(40) = null output, @PA_ADD_CO_REGION varchar(40) = null output, @PA_ADD_USERCHAR_1 varchar(100) = null output, @PA_ADD_USERCHAR_2 varchar(100) = null output, @PA_ADD_USERCHAR_3 varchar(100) = null output, @PA_ADD_DRTION_TEXT varchar(11) = null output, @PA_ADD_DRTION_HTML varchar(11) = null output, @PA_ADD_LOCATION_URL varchar(11) = null output, @PA_ADD_PHONE varchar(25) = null output, @PA_ADD_FAX varchar(25) = null output, @PA_ADD_EMAIL varchar(250) = null output, @PA_ADD_CUSTOMER_ACC varchar(9) = null output, @PA_ADD_5 nvarchar(50) = null output, @PA_ADD_PHONE_STD varchar(10) = null output, @PA_ADD_FAX_STD varchar(10) = null output, @PA_ADD_LAT decimal(19, 4) = null output, @PA_ADD_LONG decimal(19, 4) = null output, @PA_ADD_GRID_EAST varchar(5) = null output, @PA_ADD_GRID_NORTH varchar(5) = null output, @PA_ADD_BAT_ID varchar(11) = null output, @PA_ADD_DX_CODE varchar(100) = null output, @PA_ADD_DX_EXCHANGE varchar(50) = null output, @PA_ADD_DX_BARCODE varchar(67) = null output, @PA_ADD_MAILSORT_CODE varchar(25) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.Address set
    ADD_MOD_DATE = getDate(),
    ADD_MOD_BY = @_AUDIT_USER_ID,
    ADD_LOCK = @PA_ADD_LOCK,
    ADD_BUILDING = @PA_ADD_BUILDING,
    ADD_STREET = @PA_ADD_STREET,
    ADD_TOWN = @PA_ADD_TOWN,
    ADD_AREA = @PA_ADD_AREA,
    ADD_COUNTY = @PA_ADD_COUNTY,
    ADD_POSTCODE = @PA_ADD_POSTCODE,
    ADD_COUNTRY = @PA_ADD_COUNTRY,
    ADD_COUNTRY_STYLE = @PA_ADD_COUNTRY_STYLE,
    ADD_MAILSTRING = @PA_ADD_MAILSTRING,
    ADD_MAP = @PA_ADD_MAP,
    ADD_JOINING_INSTRC = @PA_ADD_JOINING_INSTRC,
    ADD_COUNTRY_VALUE = @PA_ADD_COUNTRY_VALUE,
    ADD_CO_CODE = @PA_ADD_CO_CODE,
    ADD_CO_AREA = @PA_ADD_CO_AREA,
    ADD_CO_REGION = @PA_ADD_CO_REGION,
    ADD_USERCHAR_1 = @PA_ADD_USERCHAR_1,
    ADD_USERCHAR_2 = @PA_ADD_USERCHAR_2,
    ADD_USERCHAR_3 = @PA_ADD_USERCHAR_3,
    ADD_DRTION_TEXT = @PA_ADD_DRTION_TEXT,
    ADD_DRTION_HTML = @PA_ADD_DRTION_HTML,
    ADD_LOCATION_URL = @PA_ADD_LOCATION_URL,
    ADD_PHONE = @PA_ADD_PHONE,
    ADD_FAX = @PA_ADD_FAX,
    ADD_EMAIL = @PA_ADD_EMAIL,
    ADD_CUSTOMER_ACC = @PA_ADD_CUSTOMER_ACC,
    ADD_5 = @PA_ADD_5,
    ADD_PHONE_STD = @PA_ADD_PHONE_STD,
    ADD_FAX_STD = @PA_ADD_FAX_STD,
    ADD_LAT = @PA_ADD_LAT,
    ADD_LONG = @PA_ADD_LONG,
    ADD_GRID_EAST = @PA_ADD_GRID_EAST,
    ADD_GRID_NORTH = @PA_ADD_GRID_NORTH,
    ADD_BAT_ID = @PA_ADD_BAT_ID,
    ADD_DX_CODE = @PA_ADD_DX_CODE,
    ADD_DX_EXCHANGE = @PA_ADD_DX_EXCHANGE,
    ADD_DX_BARCODE = @PA_ADD_DX_BARCODE,
    ADD_MAILSORT_CODE = @PA_ADD_MAILSORT_CODE
  where ADD_ID = @PA_ADD_ID;
end
go
