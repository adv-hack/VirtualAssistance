if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusContactCountryModify')
  exec ('create procedure dbo.spConsensusContactCountryModify as select 1 as temp')
go
alter procedure dbo.spConsensusContactCountryModify(@PA_CO_ID varchar(11) = null output, @PA_CO_NAME varchar(50) = null output, @PA_CO_FORMAT varchar(50) = null output, @PA_CO_REP varchar(80) = null output, @PA_CO_AREA varchar(10) = null output, @PA_CO_REP_ID varchar(11) = null output, @PA_CO_REP1_ID varchar(11) = null output, @PA_CO_REP2_ID varchar(11) = null output, @PA_CO_POSTCODE_FLAG varchar(1) = null output, @PA_CO_ORG_TYPE varchar(20) = null output, @PA_CO_PRODUCT_GROUP varchar(20) = null output, @PA_CO_POSTCODE varchar(15) = null output, @PA_CO_INDUSTRY varchar(25) = null output, @PA_CO_TERR_ID varchar(11) = null output, @PA_CO_LOCK varchar(11) = null output, @PA_CO_COUNTY varchar(50) = null output, @PA_CO_VAT_TYPE tinyint = null output, @PA_CO_LANGUAGE varchar(50) = null output, @PA_CO_CURRENCY varchar(3) = null output, @PA_CO_USERCHAR_1 varchar(100) = null output, @PA_CO_USERCHAR_2 varchar(100) = null output, @PA_CO_USERNUM_1 float = null output, @PA_CO_USERNUM_2 float = null output, @PA_CO_NOTES varchar(max) = null output, @PA_CO_EURO tinyint = null output, @PA_CO_COUNTRY_CODE varchar(10) = null output, @PA_CO_TOWN varchar(50) = null output, @PA_CO_PCODE_LU tinyint = null output, @PA_CO_LINE_POS varchar(8) = null output, @PA_CO_VAT_CODE varchar(25) = null output, @PA_CO_VAT_COUNTRY_CODE varchar(2) = null output, @PA_CO_MAILSTRING_ORDER varchar(7) = null output, @PA_CO_MAILSTRING_DISPLAY varchar(7) = null output, @PA_CO_MAILSTRING_NEWLINE varchar(7) = null output, @PA_CO_COUNTRY_CODE_2 char(2) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.Country set
    CO_MOD_DATE = getDate(),
    CO_MOD_BY = @_AUDIT_USER_ID,
    CO_NAME = @PA_CO_NAME,
    CO_FORMAT = @PA_CO_FORMAT,
    CO_REP = @PA_CO_REP,
    CO_AREA = @PA_CO_AREA,
    CO_REP_ID = @PA_CO_REP_ID,
    CO_REP1_ID = @PA_CO_REP1_ID,
    CO_REP2_ID = @PA_CO_REP2_ID,
    CO_POSTCODE_FLAG = @PA_CO_POSTCODE_FLAG,
    CO_ORG_TYPE = @PA_CO_ORG_TYPE,
    CO_PRODUCT_GROUP = @PA_CO_PRODUCT_GROUP,
    CO_POSTCODE = @PA_CO_POSTCODE,
    CO_INDUSTRY = @PA_CO_INDUSTRY,
    CO_TERR_ID = @PA_CO_TERR_ID,
    CO_LOCK = @PA_CO_LOCK,
    CO_COUNTY = @PA_CO_COUNTY,
    CO_VAT_TYPE = @PA_CO_VAT_TYPE,
    CO_LANGUAGE = @PA_CO_LANGUAGE,
    CO_CURRENCY = @PA_CO_CURRENCY,
    CO_USERCHAR_1 = @PA_CO_USERCHAR_1,
    CO_USERCHAR_2 = @PA_CO_USERCHAR_2,
    CO_USERNUM_1 = @PA_CO_USERNUM_1,
    CO_USERNUM_2 = @PA_CO_USERNUM_2,
    CO_NOTES = @PA_CO_NOTES,
    CO_EURO = @PA_CO_EURO,
    CO_COUNTRY_CODE = @PA_CO_COUNTRY_CODE,
    CO_TOWN = @PA_CO_TOWN,
    CO_PCODE_LU = @PA_CO_PCODE_LU,
    CO_LINE_POS = @PA_CO_LINE_POS,
    CO_VAT_CODE = @PA_CO_VAT_CODE,
    CO_VAT_COUNTRY_CODE = @PA_CO_VAT_COUNTRY_CODE,
    CO_MAILSTRING_ORDER = @PA_CO_MAILSTRING_ORDER,
    CO_MAILSTRING_DISPLAY = @PA_CO_MAILSTRING_DISPLAY,
    CO_MAILSTRING_NEWLINE = @PA_CO_MAILSTRING_NEWLINE,
    CO_COUNTRY_CODE_2 = @PA_CO_COUNTRY_CODE_2
  where CO_ID = @PA_CO_ID;
end
go
