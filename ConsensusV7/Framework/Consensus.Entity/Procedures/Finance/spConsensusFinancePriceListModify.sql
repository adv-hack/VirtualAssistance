if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusFinancePriceListModify')
  exec ('create procedure dbo.spConsensusFinancePriceListModify as select 1 as temp')
go
alter procedure dbo.spConsensusFinancePriceListModify(@PA_PL_ID varchar(11) = null output, @PA_PL_LOCK varchar(10) = null output, @PA_PL_CURRENCY varchar(3) = null output, @PA_PL_NAME varchar(30) = null output, @PA_PL_VALID_FROM datetime = null output, @PA_PL_VALID_UNTIL datetime = null output, @PA_PL_BUSINESS_UNIT varchar(11) = null output, @PA_PL_TICKET tinyint = null output, @PA_PL_PROD_FAMILY varchar(50) = null output, @PA_PL_BKT_ID varchar(11) = null output, @PA_PL_ORG_ONLY tinyint = null output, @PA_PL_STATUS tinyint = null output, @PA_PL_PREPAY_ACCOUNT_ONLY tinyint = null output, @PA_PL_PSH_ID integer = null output, @PA_PL_DEFAULT tinyint = null output, @PA_PL_VAT_CODE varchar(40) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.Price_List set
    PL_MOD_DATE = getDate(),
    PL_MOD_BY = @_AUDIT_USER_ID,
    PL_LOCK = @PA_PL_LOCK,
    PL_CURRENCY = @PA_PL_CURRENCY,
    PL_NAME = @PA_PL_NAME,
    PL_VALID_FROM = @PA_PL_VALID_FROM,
    PL_VALID_UNTIL = @PA_PL_VALID_UNTIL,
    PL_BUSINESS_UNIT = @PA_PL_BUSINESS_UNIT,
    PL_TICKET = @PA_PL_TICKET,
    PL_PROD_FAMILY = @PA_PL_PROD_FAMILY,
    PL_BKT_ID = @PA_PL_BKT_ID,
    PL_ORG_ONLY = @PA_PL_ORG_ONLY,
    PL_STATUS = @PA_PL_STATUS,
    PL_PREPAY_ACCOUNT_ONLY = @PA_PL_PREPAY_ACCOUNT_ONLY,
    PL_PSH_ID = @PA_PL_PSH_ID,
    PL_DEFAULT = @PA_PL_DEFAULT,
    PL_VAT_CODE = @PA_PL_VAT_CODE
  where PL_ID = @PA_PL_ID;
end
go
