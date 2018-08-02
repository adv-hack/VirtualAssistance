if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusFinancePricesCreate')
  exec ('create procedure dbo.spConsensusFinancePricesCreate as select 1 as temp')
go
alter procedure dbo.spConsensusFinancePricesCreate(@PA_PRS_ID varchar(11) = null output, @PA_PRS_LOCK varchar(10) = null output, @PA_PRS_PL_ID varchar(11) = null output, @PA_PRS_PROD_ID varchar(11) = null output, @PA_PRS_PRICE decimal(19, 4) = null output, @PA_PRS_BLOCK_PRICE decimal(19, 4) = null output, @PA_PRS_SPARE_PRICE decimal(19, 4) = null output, @PA_PRS_COST_PRICE decimal(19, 4) = null output, @PA_PRS_COST_CODE varchar(40) = null output, @PA_PRS_REV_CODE varchar(40) = null output, @PA_PRS_DISC_SCHED varchar(2) = null output, @PA_PRS_VAT_CODE varchar(25) = null output, @PA_PRS_RETAIL_PRICE decimal(19, 4) = null output, @PA_PRS_NO_COST_NO_SEL tinyint = null output, @PA_PRS_DEFAULT tinyint = null output, @PA_PRS_GL_CODE1 varchar(20) = null output, @PA_PRS_GL_CODE2 varchar(20) = null output, @PA_PRS_PROD_CATEGORY varchar(12) = null output, @PA_PRS_DISC_PERCENT decimal(19, 2) = null output, @PA_PRS_PRICE_A decimal(19, 4) = null output, @PA_PRS_PRICE_B decimal(19, 4) = null output, @PA_PRS_PRICE_C decimal(19, 4) = null output, @PA_PRS_PRICE_D decimal(19, 4) = null output, @PA_PRS_PRICE_E decimal(19, 4) = null output, @PA_PRS_GROUP_QTY integer = null output, @PA_PRS_GROUP_DTE integer = null output, @PA_PRS_GROUP_QTY_ID varchar(11) = null output, @PA_PRS_GROUP_DTE_ID varchar(11) = null output, @PA_PRS_QTY_MIN integer = null output, @PA_PRS_QTY_MAX integer = null output, @PA_PRS_VALID_FROM datetime = null output, @PA_PRS_VALID_UNTIL datetime = null output, @PA_PRS_BEFORE_DAYS integer = null output, @PA_PRS_VAT_CODE2 varchar(25) = null output, @PA_PRS_START_DATE datetime = null output, @PA_PRS_END_DATE datetime = null output, @PA_PRS_QUAL_ID varchar(11) = null output, @PA_PRS_PREPAY_PROD_ID varchar(11) = null output, @PA_PRS_LINE_ID varchar(11) = null output, @PA_PRS_SEAS_ID varchar(11) = null output, @PA_PRS_INC_PLACES tinyint = null output, @PA_PRS_SUB_PRICE_1 decimal(19, 2) = null output, @PA_PRS_SUB_PRICE_2 decimal(19, 2) = null output, @PA_PRS_SUB_PRICE_3 decimal(19, 2) = null output, @PA_PRS_SUB_PRICE_4 decimal(19, 2) = null output, @PA_PRS_SUB_PRICE_5 decimal(19, 2) = null output, @PA_PRS_SUB_PRICE_6 decimal(19, 2) = null output, @PA_PRS_SUB_PRICE_7 decimal(19, 2) = null output, @PA_PRS_SUB_PRICE_8 decimal(19, 2) = null output, @PA_PRS_SUB_PRICE_9 decimal(19, 2) = null output, @PA_PRS_CURR_TYPE varchar(4) = null output, @PA_PRS_DO_NOT_RECALC tinyint = null output, @PA_PRS_SCHN_NUMBER tinyint = null output, @PA_PRS_MEMB_PRICE tinyint = null output, @PA_PRS_START integer = null output, @PA_PRS_END integer = null output, @PA_PRS_DESC varchar(30) = null output, @PA_PRS_PRS_ID varchar(30) = null output, @PA_PRS_WEB tinyint = null output, @PA_PRS_VALID_DATE tinyint = null output, @PA_PRS_REGION varchar(40) = null output, @PA_PRS_TYPE tinyint = null output, @PA_PRS_SEA_ID integer = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.Prices(
    PRS_ADD_DATE,
    PRS_ADD_BY,
    PRS_MOD_DATE,
    PRS_MOD_BY,
    PRS_RCV_DATE,
    PRS_RCV_FROM,
    PRS_LOCK,
    PRS_PL_ID,
    PRS_PROD_ID,
    PRS_PRICE,
    PRS_BLOCK_PRICE,
    PRS_SPARE_PRICE,
    PRS_COST_PRICE,
    PRS_COST_CODE,
    PRS_REV_CODE,
    PRS_DISC_SCHED,
    PRS_VAT_CODE,
    PRS_RETAIL_PRICE,
    PRS_NO_COST_NO_SEL,
    PRS_DEFAULT,
    PRS_GL_CODE1,
    PRS_GL_CODE2,
    PRS_PROD_CATEGORY,
    PRS_DISC_PERCENT,
    PRS_PRICE_A,
    PRS_PRICE_B,
    PRS_PRICE_C,
    PRS_PRICE_D,
    PRS_PRICE_E,
    PRS_GROUP_QTY,
    PRS_GROUP_DTE,
    PRS_GROUP_QTY_ID,
    PRS_GROUP_DTE_ID,
    PRS_QTY_MIN,
    PRS_QTY_MAX,
    PRS_VALID_FROM,
    PRS_VALID_UNTIL,
    PRS_BEFORE_DAYS,
    PRS_VAT_CODE2,
    PRS_START_DATE,
    PRS_END_DATE,
    PRS_QUAL_ID,
    PRS_PREPAY_PROD_ID,
    PRS_LINE_ID,
    PRS_SEAS_ID,
    PRS_INC_PLACES,
    PRS_SUB_PRICE_1,
    PRS_SUB_PRICE_2,
    PRS_SUB_PRICE_3,
    PRS_SUB_PRICE_4,
    PRS_SUB_PRICE_5,
    PRS_SUB_PRICE_6,
    PRS_SUB_PRICE_7,
    PRS_SUB_PRICE_8,
    PRS_SUB_PRICE_9,
    PRS_CURR_TYPE,
    PRS_DO_NOT_RECALC,
    PRS_SCHN_NUMBER,
    PRS_MEMB_PRICE,
    PRS_START,
    PRS_END,
    PRS_DESC,
    PRS_PRS_ID,
    PRS_WEB,
    PRS_VALID_DATE,
    PRS_REGION,
    PRS_TYPE,
    PRS_SEA_ID
  ) values (
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    '',
    @PA_PRS_LOCK,
    @PA_PRS_PL_ID,
    @PA_PRS_PROD_ID,
    @PA_PRS_PRICE,
    @PA_PRS_BLOCK_PRICE,
    @PA_PRS_SPARE_PRICE,
    @PA_PRS_COST_PRICE,
    @PA_PRS_COST_CODE,
    @PA_PRS_REV_CODE,
    @PA_PRS_DISC_SCHED,
    @PA_PRS_VAT_CODE,
    @PA_PRS_RETAIL_PRICE,
    @PA_PRS_NO_COST_NO_SEL,
    @PA_PRS_DEFAULT,
    @PA_PRS_GL_CODE1,
    @PA_PRS_GL_CODE2,
    @PA_PRS_PROD_CATEGORY,
    @PA_PRS_DISC_PERCENT,
    @PA_PRS_PRICE_A,
    @PA_PRS_PRICE_B,
    @PA_PRS_PRICE_C,
    @PA_PRS_PRICE_D,
    @PA_PRS_PRICE_E,
    @PA_PRS_GROUP_QTY,
    @PA_PRS_GROUP_DTE,
    @PA_PRS_GROUP_QTY_ID,
    @PA_PRS_GROUP_DTE_ID,
    @PA_PRS_QTY_MIN,
    @PA_PRS_QTY_MAX,
    @PA_PRS_VALID_FROM,
    @PA_PRS_VALID_UNTIL,
    @PA_PRS_BEFORE_DAYS,
    @PA_PRS_VAT_CODE2,
    @PA_PRS_START_DATE,
    @PA_PRS_END_DATE,
    @PA_PRS_QUAL_ID,
    @PA_PRS_PREPAY_PROD_ID,
    @PA_PRS_LINE_ID,
    @PA_PRS_SEAS_ID,
    @PA_PRS_INC_PLACES,
    @PA_PRS_SUB_PRICE_1,
    @PA_PRS_SUB_PRICE_2,
    @PA_PRS_SUB_PRICE_3,
    @PA_PRS_SUB_PRICE_4,
    @PA_PRS_SUB_PRICE_5,
    @PA_PRS_SUB_PRICE_6,
    @PA_PRS_SUB_PRICE_7,
    @PA_PRS_SUB_PRICE_8,
    @PA_PRS_SUB_PRICE_9,
    @PA_PRS_CURR_TYPE,
    @PA_PRS_DO_NOT_RECALC,
    @PA_PRS_SCHN_NUMBER,
    @PA_PRS_MEMB_PRICE,
    @PA_PRS_START,
    @PA_PRS_END,
    @PA_PRS_DESC,
    @PA_PRS_PRS_ID,
    @PA_PRS_WEB,
    @PA_PRS_VALID_DATE,
    @PA_PRS_REGION,
    @PA_PRS_TYPE,
    @PA_PRS_SEA_ID
  );
    set @PA_PRS_ID = @@identity;
end
go
