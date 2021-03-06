if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusFinanceInvlineCreate')
  exec ('create procedure dbo.spConsensusFinanceInvlineCreate as select 1 as temp')
go
alter procedure dbo.spConsensusFinanceInvlineCreate(@PA_INVLN_ID varchar(11) = null output, @PA_INVLN_INV_ID varchar(11) = null output, @PA_INVLN_PRODUCT_ID varchar(11) = null output, @PA_INVLN_ORDER_LN_ID varchar(11) = null output, @PA_INVLN_LINE_NO float = null output, @PA_INVLN_QTY float = null output, @PA_INVLN_UNIT_PRICE decimal(19, 4) = null output, @PA_INVLN_DISCOUNT decimal(19, 4) = null output, @PA_INVLN_DISCT_PRICE decimal(19, 4) = null output, @PA_INVLN_NET decimal(19, 4) = null output, @PA_INVLN_VAT_CODE varchar(25) = null output, @PA_INVLN_VAT_RATE decimal(19, 4) = null output, @PA_INVLN_VAT_AMT decimal(19, 4) = null output, @PA_INVLN_TOTAL_PRICE decimal(19, 4) = null output, @PA_INVLN_CREDIT_DESC varchar(11) = null output, @PA_INVLN_UNIT_PRCE_BC decimal(19, 4) = null output, @PA_INVLN_DISCOUNT_BC decimal(19, 4) = null output, @PA_INVLN_DISC_PRCE_BC decimal(19, 4) = null output, @PA_INVLN_NET_BC decimal(19, 4) = null output, @PA_INVLN_TOT_PRICE_BC decimal(19, 4) = null output, @PA_INVLN_CURR_TYPE varchar(3) = null output, @PA_INVLN_DESCRIPTION nvarchar(500) = null output, @PA_INVLN_SALES_ID varchar(11) = null output, @PA_INVLN_SALES_DET_ID varchar(11) = null output, @PA_INVLN_BOOK_ID varchar(11) = null output, @PA_INVLN_ELEM_ID varchar(11) = null output, @PA_INVLN_COURSE_ID varchar(11) = null output, @PA_INVLN_TYPE tinyint = null output, @PA_INVLN_PROD_NAME nvarchar(250) = null output, @PA_INVLN_PRD_REV_CODE varchar(40) = null output, @PA_INVLN_PROJ_ID varchar(11) = null output, @PA_INVLN_MEL_ID varchar(11) = null output, @PA_INVLN_UNT_PRCE_BC2 decimal(19, 4) = null output, @PA_INVLN_NET_BC2 decimal(19, 4) = null output, @PA_INVLN_TOT_PRCE_BC2 decimal(19, 4) = null output, @PA_INVLN_VAT_AMT_BC decimal(19, 4) = null output, @PA_INVLN_VAT_AMT_BC2 decimal(19, 4) = null output, @PA_INVLN_COST_CODE varchar(40) = null output, @PA_INVLN_CREDITED tinyint = null output, @PA_INVLN_USERCHAR_1 varchar(100) = null output, @PA_INVLN_ANL1 varchar(40) = null output, @PA_INVLN_ANL2 varchar(40) = null output, @PA_INVLN_ANL3 varchar(40) = null output, @PA_INVLN_DISCOUNT_BC2 decimal(19, 4) = null output, @PA_INVLN_DISC_PRICE_BC2 decimal(19, 4) = null output, @PA_INVLN_CREDIT_FOR_INVLN_ID varchar(11) = null output, @PA_INVLN_DO_NOT_PRINT tinyint = null output, @PA_INVLN_DEL_COST_CODE varchar(40) = null output, @PA_INVLN_SELCO_SP_ID varchar(11) = null output, @PA_INVLN_CURRENCY_TYPE varchar(3) = null output, @PA_INVLN_CURR_RATE_BC decimal(19, 10) = null output, @PA_INVLN_CURR_RATE_BC2 decimal(19, 10) = null output, @PA_INVLN_UNIT_PRICE_DISC decimal(19, 4) = null output, @PA_INVLN_UNIT_PRICE_DISC_BC decimal(19, 4) = null output, @PA_INVLN_UNIT_PRICE_DISC_BC2 decimal(19, 4) = null output, @PA_INVLN_DEPT varchar(3) = null output, @PA_INVLN_SKU varchar(16) = null output, @PA_INVLN_JOB_CODE varchar(10) = null output, @PA_INVLN_JOB_ANAL_CODE varchar(10) = null output, @PA_INVLN_JOB_TYPE varchar(3) = null output, @PA_INVLN_JOB_PARENT varchar(10) = null output, @PA_INVLN_PRS_TYPE tinyint = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  exec spNextID 404, @PA_INVLN_ID output
  
  insert into dbo.InvLine(
    INVLN_ID,
    INVLN_ADD_DATE,
    INVLN_ADD_BY,
    INVLN_MOD_DATE,
    INVLN_MOD_BY,
    INVLN_RCV_DATE,
    INVLN_RCV_FROM,
    INVLN_INV_ID,
    INVLN_PRODUCT_ID,
    INVLN_ORDER_LN_ID,
    INVLN_LINE_NO,
    INVLN_QTY,
    INVLN_UNIT_PRICE,
    INVLN_DISCOUNT,
    INVLN_DISCT_PRICE,
    INVLN_NET,
    INVLN_VAT_CODE,
    INVLN_VAT_RATE,
    INVLN_VAT_AMT,
    INVLN_TOTAL_PRICE,
    INVLN_CREDIT_DESC,
    INVLN_UNIT_PRCE_BC,
    INVLN_DISCOUNT_BC,
    INVLN_DISC_PRCE_BC,
    INVLN_NET_BC,
    INVLN_TOT_PRICE_BC,
    INVLN_CURR_TYPE,
    INVLN_DESCRIPTION,
    INVLN_SALES_ID,
    INVLN_SALES_DET_ID,
    INVLN_BOOK_ID,
    INVLN_ELEM_ID,
    INVLN_COURSE_ID,
    INVLN_TYPE,
    INVLN_PROD_NAME,
    INVLN_PRD_REV_CODE,
    INVLN_PROJ_ID,
    INVLN_MEL_ID,
    INVLN_UNT_PRCE_BC2,
    INVLN_NET_BC2,
    INVLN_TOT_PRCE_BC2,
    INVLN_VAT_AMT_BC,
    INVLN_VAT_AMT_BC2,
    INVLN_COST_CODE,
    INVLN_CREDITED,
    INVLN_USERCHAR_1,
    INVLN_ANL1,
    INVLN_ANL2,
    INVLN_ANL3,
    INVLN_DISCOUNT_BC2,
    INVLN_DISC_PRICE_BC2,
    INVLN_CREDIT_FOR_INVLN_ID,
    INVLN_DO_NOT_PRINT,
    INVLN_DEL_COST_CODE,
    INVLN_SELCO_SP_ID,
    INVLN_CURRENCY_TYPE,
    INVLN_CURR_RATE_BC,
    INVLN_CURR_RATE_BC2,
    INVLN_UNIT_PRICE_DISC,
    INVLN_UNIT_PRICE_DISC_BC,
    INVLN_UNIT_PRICE_DISC_BC2,
    INVLN_DEPT,
    INVLN_SKU,
    INVLN_JOB_CODE,
    INVLN_JOB_ANAL_CODE,
    INVLN_JOB_TYPE,
    INVLN_JOB_PARENT,
    INVLN_PRS_TYPE
  ) values (
    @PA_INVLN_ID,
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    '',
    @PA_INVLN_INV_ID,
    @PA_INVLN_PRODUCT_ID,
    @PA_INVLN_ORDER_LN_ID,
    @PA_INVLN_LINE_NO,
    @PA_INVLN_QTY,
    @PA_INVLN_UNIT_PRICE,
    @PA_INVLN_DISCOUNT,
    @PA_INVLN_DISCT_PRICE,
    @PA_INVLN_NET,
    @PA_INVLN_VAT_CODE,
    @PA_INVLN_VAT_RATE,
    @PA_INVLN_VAT_AMT,
    @PA_INVLN_TOTAL_PRICE,
    @PA_INVLN_CREDIT_DESC,
    @PA_INVLN_UNIT_PRCE_BC,
    @PA_INVLN_DISCOUNT_BC,
    @PA_INVLN_DISC_PRCE_BC,
    @PA_INVLN_NET_BC,
    @PA_INVLN_TOT_PRICE_BC,
    @PA_INVLN_CURR_TYPE,
    @PA_INVLN_DESCRIPTION,
    @PA_INVLN_SALES_ID,
    @PA_INVLN_SALES_DET_ID,
    @PA_INVLN_BOOK_ID,
    @PA_INVLN_ELEM_ID,
    @PA_INVLN_COURSE_ID,
    @PA_INVLN_TYPE,
    @PA_INVLN_PROD_NAME,
    @PA_INVLN_PRD_REV_CODE,
    @PA_INVLN_PROJ_ID,
    @PA_INVLN_MEL_ID,
    @PA_INVLN_UNT_PRCE_BC2,
    @PA_INVLN_NET_BC2,
    @PA_INVLN_TOT_PRCE_BC2,
    @PA_INVLN_VAT_AMT_BC,
    @PA_INVLN_VAT_AMT_BC2,
    @PA_INVLN_COST_CODE,
    @PA_INVLN_CREDITED,
    @PA_INVLN_USERCHAR_1,
    @PA_INVLN_ANL1,
    @PA_INVLN_ANL2,
    @PA_INVLN_ANL3,
    @PA_INVLN_DISCOUNT_BC2,
    @PA_INVLN_DISC_PRICE_BC2,
    @PA_INVLN_CREDIT_FOR_INVLN_ID,
    @PA_INVLN_DO_NOT_PRINT,
    @PA_INVLN_DEL_COST_CODE,
    @PA_INVLN_SELCO_SP_ID,
    @PA_INVLN_CURRENCY_TYPE,
    @PA_INVLN_CURR_RATE_BC,
    @PA_INVLN_CURR_RATE_BC2,
    @PA_INVLN_UNIT_PRICE_DISC,
    @PA_INVLN_UNIT_PRICE_DISC_BC,
    @PA_INVLN_UNIT_PRICE_DISC_BC2,
    @PA_INVLN_DEPT,
    @PA_INVLN_SKU,
    @PA_INVLN_JOB_CODE,
    @PA_INVLN_JOB_ANAL_CODE,
    @PA_INVLN_JOB_TYPE,
    @PA_INVLN_JOB_PARENT,
    @PA_INVLN_PRS_TYPE
  );
end
go
