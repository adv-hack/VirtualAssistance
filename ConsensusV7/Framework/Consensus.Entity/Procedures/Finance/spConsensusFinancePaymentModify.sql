if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusFinancePaymentModify')
  exec ('create procedure dbo.spConsensusFinancePaymentModify as select 1 as temp')
go
alter procedure dbo.spConsensusFinancePaymentModify(@PA_PAY_ID varchar(11) = null output, @PA_PAY_LOCK varchar(10) = null output, @PA_PAY_CCARD_TYPE varchar(40) = null output, @PA_PAY_NAME varchar(80) = null output, @PA_PAY_NUMBER varchar(50) = null output, @PA_PAY_EXPY_DTE datetime = null output, @PA_PAY_APPVL_REF varchar(30) = null output, @PA_PAY_ISSUE_NO varchar(5) = null output, @PA_PAY_CURR_TYPE varchar(3) = null output, @PA_PAY_RECVD decimal(19, 4) = null output, @PA_PAY_RECVD_BC decimal(19, 4) = null output, @PA_PAY_DATE datetime = null output, @PA_PAY_TYPE varchar(25) = null output, @PA_PAY_CUSTOMER_ACC varchar(50) = null output, @PA_PAY_UNUSED_VAL decimal(19, 4) = null output, @PA_PAY_UNUSED_VAL_BC decimal(19, 4) = null output, @PA_PAY_GL_CODE varchar(20) = null output, @PA_PAY_PERIOD varchar(8) = null output, @PA_PAY_ORDER_ID varchar(11) = null output, @PA_PAY_HIDDEN tinyint = null output, @PA_PAY_CHEQUE_NO varchar(25) = null output, @PA_PAY_SORT_CODE varchar(10) = null output, @PA_PAY_STATUS varchar(50) = null output, @PA_PAY_NOTES varchar(4000) = null output, @PA_PAY_VALID_DATE datetime = null output, @PA_PAY_CURR_RATE_BC decimal(19, 8) = null output, @PA_PAY_CURR_RATE_BC2 decimal(19, 8) = null output, @PA_PAY_SELCO_SP_ID varchar(11) = null output, @PA_PAY_MEP_ID varchar(11) = null output, @PA_PAY_ORG_ID varchar(11) = null output, @PA_PAY_PN_ID varchar(11) = null output, @PA_PAY_REF varchar(30) = null output, @PA_PAY_BOOK_ID varchar(11) = null output, @PA_PAY_CARD_SEC_ID varchar(8) = null output, @PA_PAY_START_MONTH varchar(2) = null output, @PA_PAY_START_YEAR varchar(4) = null output, @PA_PAY_EXPY_MONTH varchar(2) = null output, @PA_PAY_EXPY_YEAR varchar(4) = null output, @PA_PAY_REFUND_PAY_ID varchar(11) = null output, @PA_PAY_REFUND_PAY_REF varchar(30) = null output, @PA_PAY_TXN_TYPE integer = null output, @PA_PAY_BANKING_REF varchar(20) = null output, @PA_PAY_BAT_ID varchar(11) = null output, @PA_PAY_BANK_CHG decimal(19, 4) = null output, @PA_PAY_BANK_CHG_BC decimal(19, 4) = null output, @PA_PAY_BANK_CHG_BC2 decimal(19, 4) = null output, @PA_PAY_MEP_CRT_BAT_ID varchar(11) = null output, @PA_PAY_RECVD_BC2 decimal(19, 4) = null output, @PA_PAY_UNUSED_VAL_BC2 decimal(19, 4) = null output, @PA_PAY_COST_CODE varchar(40) = null output, @PA_PAY_PURPOSE tinyint = null output, @PA_PAY_SCHN_ID varchar(11) = null output, @PA_PAY_ADD_ID varchar(11) = null output, @PA_PAY_REVERSE_RES varchar(50) = null output, @PA_PAY_BANK_SORT_CODE varchar(10) = null output, @PA_PAY_BANK_ACCOUNT varchar(50) = null output, @PA_PAY_ACC_ID varchar(11) = null output, @PA_PAY_ACC_TRAN_RET float = null output, @PA_PAY_EXP_BAT_ID varchar(11) = null output, @PA_PAY_MOTO tinyint = null output, @PA_PAY_LT_ID varchar(11) = null output, @PA_PAY_MSTC_ID varchar(11) = null output, @PA_PAY_ORIGINAL_CUSTOMER_ACC varchar(50) = null output, @PA_PAY_TOKEN varchar(40) = null output, @PA_PAY_VOUCHER_TYPE varchar(40) = null output, @PA_PAY_GATEWAY_ACC_ID varchar(40) = null output, @PA_PAY_CARDHOLDER_PROLE_ID varchar(11) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.Payment set
    PAY_MOD_DATE = getDate(),
    PAY_MOD_BY = @_AUDIT_USER_ID,
    PAY_LOCK = @PA_PAY_LOCK,
    PAY_CCARD_TYPE = @PA_PAY_CCARD_TYPE,
    PAY_NAME = @PA_PAY_NAME,
    PAY_NUMBER = @PA_PAY_NUMBER,
    PAY_EXPY_DTE = @PA_PAY_EXPY_DTE,
    PAY_APPVL_REF = @PA_PAY_APPVL_REF,
    PAY_ISSUE_NO = @PA_PAY_ISSUE_NO,
    PAY_CURR_TYPE = @PA_PAY_CURR_TYPE,
    PAY_RECVD = @PA_PAY_RECVD,
    PAY_RECVD_BC = @PA_PAY_RECVD_BC,
    PAY_DATE = @PA_PAY_DATE,
    PAY_TYPE = @PA_PAY_TYPE,
    PAY_CUSTOMER_ACC = @PA_PAY_CUSTOMER_ACC,
    PAY_UNUSED_VAL = @PA_PAY_UNUSED_VAL,
    PAY_UNUSED_VAL_BC = @PA_PAY_UNUSED_VAL_BC,
    PAY_GL_CODE = @PA_PAY_GL_CODE,
    PAY_PERIOD = @PA_PAY_PERIOD,
    PAY_ORDER_ID = @PA_PAY_ORDER_ID,
    PAY_HIDDEN = @PA_PAY_HIDDEN,
    PAY_CHEQUE_NO = @PA_PAY_CHEQUE_NO,
    PAY_SORT_CODE = @PA_PAY_SORT_CODE,
    PAY_STATUS = @PA_PAY_STATUS,
    PAY_NOTES = @PA_PAY_NOTES,
    PAY_VALID_DATE = @PA_PAY_VALID_DATE,
    PAY_CURR_RATE_BC = @PA_PAY_CURR_RATE_BC,
    PAY_CURR_RATE_BC2 = @PA_PAY_CURR_RATE_BC2,
    PAY_SELCO_SP_ID = @PA_PAY_SELCO_SP_ID,
    PAY_MEP_ID = @PA_PAY_MEP_ID,
    PAY_ORG_ID = @PA_PAY_ORG_ID,
    PAY_PN_ID = @PA_PAY_PN_ID,
    PAY_REF = @PA_PAY_REF,
    PAY_BOOK_ID = @PA_PAY_BOOK_ID,
    PAY_CARD_SEC_ID = @PA_PAY_CARD_SEC_ID,
    PAY_START_MONTH = @PA_PAY_START_MONTH,
    PAY_START_YEAR = @PA_PAY_START_YEAR,
    PAY_EXPY_MONTH = @PA_PAY_EXPY_MONTH,
    PAY_EXPY_YEAR = @PA_PAY_EXPY_YEAR,
    PAY_REFUND_PAY_ID = @PA_PAY_REFUND_PAY_ID,
    PAY_REFUND_PAY_REF = @PA_PAY_REFUND_PAY_REF,
    PAY_TXN_TYPE = @PA_PAY_TXN_TYPE,
    PAY_BANKING_REF = @PA_PAY_BANKING_REF,
    PAY_BAT_ID = @PA_PAY_BAT_ID,
    PAY_BANK_CHG = @PA_PAY_BANK_CHG,
    PAY_BANK_CHG_BC = @PA_PAY_BANK_CHG_BC,
    PAY_BANK_CHG_BC2 = @PA_PAY_BANK_CHG_BC2,
    PAY_MEP_CRT_BAT_ID = @PA_PAY_MEP_CRT_BAT_ID,
    PAY_RECVD_BC2 = @PA_PAY_RECVD_BC2,
    PAY_UNUSED_VAL_BC2 = @PA_PAY_UNUSED_VAL_BC2,
    PAY_COST_CODE = @PA_PAY_COST_CODE,
    PAY_PURPOSE = @PA_PAY_PURPOSE,
    PAY_SCHN_ID = @PA_PAY_SCHN_ID,
    PAY_ADD_ID = @PA_PAY_ADD_ID,
    PAY_REVERSE_RES = @PA_PAY_REVERSE_RES,
    PAY_BANK_SORT_CODE = @PA_PAY_BANK_SORT_CODE,
    PAY_BANK_ACCOUNT = @PA_PAY_BANK_ACCOUNT,
    PAY_ACC_ID = @PA_PAY_ACC_ID,
    PAY_ACC_TRAN_RET = @PA_PAY_ACC_TRAN_RET,
    PAY_EXP_BAT_ID = @PA_PAY_EXP_BAT_ID,
    PAY_MOTO = @PA_PAY_MOTO,
    PAY_LT_ID = @PA_PAY_LT_ID,
    PAY_MSTC_ID = @PA_PAY_MSTC_ID,
    PAY_ORIGINAL_CUSTOMER_ACC = @PA_PAY_ORIGINAL_CUSTOMER_ACC,
    PAY_TOKEN = @PA_PAY_TOKEN,
    PAY_VOUCHER_TYPE = @PA_PAY_VOUCHER_TYPE,
    PAY_GATEWAY_ACC_ID = @PA_PAY_GATEWAY_ACC_ID,
    PAY_CARDHOLDER_PROLE_ID = @PA_PAY_CARDHOLDER_PROLE_ID
  where PAY_ID = @PA_PAY_ID;
end
go
