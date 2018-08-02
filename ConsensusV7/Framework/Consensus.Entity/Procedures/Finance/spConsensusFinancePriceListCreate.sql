if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusFinancePriceListCreate')
  exec ('create procedure dbo.spConsensusFinancePriceListCreate as select 1 as temp')
go
alter procedure dbo.spConsensusFinancePriceListCreate(@PA_PL_ID varchar(11) = null output, @PA_PL_LOCK varchar(10) = null output, @PA_PL_CURRENCY varchar(3) = null output, @PA_PL_NAME varchar(30) = null output, @PA_PL_VALID_FROM datetime = null output, @PA_PL_VALID_UNTIL datetime = null output, @PA_PL_BUSINESS_UNIT varchar(11) = null output, @PA_PL_TICKET tinyint = null output, @PA_PL_PROD_FAMILY varchar(50) = null output, @PA_PL_BKT_ID varchar(11) = null output, @PA_PL_ORG_ONLY tinyint = null output, @PA_PL_STATUS tinyint = null output, @PA_PL_PREPAY_ACCOUNT_ONLY tinyint = null output, @PA_PL_PSH_ID integer = null output, @PA_PL_DEFAULT tinyint = null output, @PA_PL_VAT_CODE varchar(40) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.Price_List(
    PL_ADD_DATE,
    PL_ADD_BY,
    PL_MOD_DATE,
    PL_MOD_BY,
    PL_RCV_DATE,
    PL_RCV_FROM,
    PL_LOCK,
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
  ) values (
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    '',
    @PA_PL_LOCK,
    @PA_PL_CURRENCY,
    @PA_PL_NAME,
    @PA_PL_VALID_FROM,
    @PA_PL_VALID_UNTIL,
    @PA_PL_BUSINESS_UNIT,
    @PA_PL_TICKET,
    @PA_PL_PROD_FAMILY,
    @PA_PL_BKT_ID,
    @PA_PL_ORG_ONLY,
    @PA_PL_STATUS,
    @PA_PL_PREPAY_ACCOUNT_ONLY,
    @PA_PL_PSH_ID,
    @PA_PL_DEFAULT,
    @PA_PL_VAT_CODE
  );
    set @PA_PL_ID = @@identity;
end
go
