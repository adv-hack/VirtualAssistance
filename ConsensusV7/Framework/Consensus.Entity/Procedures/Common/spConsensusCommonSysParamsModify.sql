if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusCommonSysParamsModify')
  exec ('create procedure dbo.spConsensusCommonSysParamsModify as select 1 as temp')
go
alter procedure dbo.spConsensusCommonSysParamsModify(@PA_SP_ID varchar(11) = null output, @PA_SP_LOCK varchar(10) = null output, @PA_SP_SEC_PN_ID varchar(11) = null output, @PA_SP_REO_ORG_ID varchar(11) = null output, @PA_SP_VATREG varchar(20) = null output, @PA_SP_TIPS_CODE_PREFX varchar(3) = null output, @PA_SP_INV_NO_PREFIX varchar(5) = null output, @PA_SP_NEXT_INV_NO integer = null output, @PA_SP_NEXT_CREDIT_NTE bigint = null output, @PA_SP_HEADED_PAPER tinyint = null output, @PA_SP_HEADING1 varchar(80) = null output, @PA_SP_HEADING varchar(240) = null output, @PA_SP_FOOTER varchar(240) = null output, @PA_SP_FOOTER_REO_LABL varchar(30) = null output, @PA_SP_FOOTER_PHONE varchar(20) = null output, @PA_SP_FOOTER_GEN_SEC varchar(20) = null output, @PA_SP_PIC_ID varchar(11) = null output, @PA_SP_GENERAL_TEXT_ID varchar(11) = null output, @PA_SP_GEN_CORS_TXT_ID varchar(11) = null output, @PA_SP_AUTH_SPECL_INST varchar(11) = null output, @PA_SP_DB_ID varchar(3) = null output, @PA_SP_MAIN tinyint = null output, @PA_SP_REMOTE varchar(11) = null output, @PA_SP_NXT_SALE_LEG_NO float = null output, @PA_SP_QUO_STATUS tinyint = null output, @PA_SP_QUO_SOURCE tinyint = null output, @PA_SP_FORMAT_ACT_NOTE tinyint = null output, @PA_SP_ORG_SRCH_FILTER tinyint = null output, @PA_SP_MID tinyint = null output, @PA_SP_USE_MATCH_FIELD tinyint = null output, @PA_SP_OFFR_PRE_QUT_PN tinyint = null output, @PA_SP_CURRENT_RELEASE integer = null output, @PA_SP_LOWEST_RELEASE integer = null output, @PA_SP_MAN_AUTO_ALLOC tinyint = null output, @PA_SP_ADD_MAN1_TO_ACT tinyint = null output, @PA_SP_ADD_MAN2_TO_ACT tinyint = null output, @PA_SP_ADD_DIST_TO_ACT tinyint = null output, @PA_SP_PERD_ROLL varchar(1) = null output, @PA_SP_FT_CAN_CHG_THRS integer = null output, @PA_SP_SD_CAN_CHG_THRS integer = null output, @PA_SP_CANC_CHRG_PRCNT float = null output, @PA_SP_FT_TRAN_CHG_THR integer = null output, @PA_SP_TRAN_CHGE_PRCNT float = null output, @PA_SP_EXT_MV_CHG_PRCN float = null output, @PA_SP_JOIN_LETT varchar(11) = null output, @PA_SP_CONFIRM_LETT varchar(11) = null output, @PA_SP_PROV_LETT varchar(11) = null output, @PA_SP_QUEST_LETT varchar(11) = null output, @PA_SP_SURV_LETT varchar(11) = null output, @PA_SP_INV_LETT varchar(11) = null output, @PA_SP_UPDATE_STRG tinyint = null output, @PA_SP_JOB_TYPE tinyint = null output, @PA_SP_PREVENT_EDIT tinyint = null output, @PA_SP_SUBS_LETTER tinyint = null output, @PA_SP_REMOTE_USED tinyint = null output, @PA_SP_MERGE_LOCK varchar(10) = null output, @PA_SP_INV_RESTRICT tinyint = null output, @PA_SP_CURR_PERD varchar(11) = null output, @PA_SP_DEFAULT_ORG_ID varchar(11) = null output, @PA_SP_OPP_ACT_MAND tinyint = null output, @PA_SP_SMTP_SERVER varchar(100) = null output, @PA_SP_ADMIN_EMAIL varchar(50) = null output, @PA_SP_USE_AKA_FIELD tinyint = null output, @PA_SP_EXPORT_NUM integer = null output, @PA_SP_IMPORT_NUM integer = null output, @PA_SP_EXPORT_DATE datetime = null output, @PA_SP_BASE_CURR varchar(3) = null output, @PA_SP_REG varchar(30) = null output, @PA_SP_FILE_STORE_PATH varchar(255) = null output, @PA_SP_PIC_STORE_PATH varchar(255) = null output, @PA_SP_NET_PATH varchar(255) = null output, @PA_SP_BU_SECURITY tinyint = null output, @PA_SP_ENQ_QST_ID varchar(11) = null output, @PA_SP_DEL_QST_ID varchar(11) = null output, @PA_SP_BASE_CURR2 varchar(3) = null output, @PA_SP_PROV_PACK varchar(11) = null output, @PA_SP_CONF_PACK varchar(11) = null output, @PA_SP_JOINING_PACK varchar(11) = null output, @PA_SP_POST_PACK varchar(11) = null output, @PA_SP_PROV_INV tinyint = null output, @PA_SP_CONF_INV tinyint = null output, @PA_SP_JOIN_INV tinyint = null output, @PA_SP_POST_INV tinyint = null output, @PA_SP_PROV_NO_PLACE tinyint = null output, @PA_SP_TRAINER_EMAIL varchar(150) = null output, @PA_SP_CB_DAYS varchar(50) = null output, @PA_SP_PAYMENT_DAYS integer = null output, @PA_SP_PAYMENT_TYPE tinyint = null output, @PA_SP_PAY_TERMS_1 varchar(255) = null output, @PA_SP_PAY_TERMS_2 varchar(255) = null output, @PA_SP_PAY_TERMS_3 varchar(255) = null output, @PA_SP_PAY_TERMS_4 varchar(255) = null output, @PA_SP_UPGRADE_PATH varchar(255) = null output, @PA_SP_TC_LETT varchar(11) = null output, @PA_SP_PRINTER1 varchar(255) = null output, @PA_SP_PRINTER2 varchar(255) = null output, @PA_SP_INITIALS varchar(2) = null output, @PA_SP_CRYSTAL_INV varchar(30) = null output, @PA_SP_FLAG varchar(30) = null output, @PA_SP_BOOK_OTH_NODES tinyint = null output, @PA_SP_USER_NUMB_1 float = null output, @PA_SP_VAT_METHOD tinyint = null output, @PA_SP_NO_LOGON tinyint = null output, @PA_SP_Q_RESULTS tinyint = null output, @PA_SP_FILE_PROD_EXT tinyint = null output, @PA_SP_REG2 varchar(150) = null output, @PA_SP_REG3 varchar(512) = null output, @PA_SP_ELEM_FLAGS tinyint = null output, @PA_SP_SELL_COMP_NAME varchar(80) = null output, @PA_SP_BOOK_APPROVAL tinyint = null output, @PA_SP_BKT_ID varchar(11) = null output, @PA_SP_ATTACHMENTS_URL varchar(500) = null output, @PA_SP_PERIODS integer = null output, @PA_SP_BAT_SEL_PROC varchar(500) = null output, @PA_SP_BAT_OUT_PROC varchar(500) = null output, @PA_SP_BAT_OUT_DIR varchar(500) = null output, @PA_SP_DEF_INV_LT_ID varchar(11) = null output, @PA_SP_MEM_INV_LT_ID varchar(11) = null output, @PA_SP_PROJ_INV_LT_ID varchar(11) = null output, @PA_SP_NO_SALESTEAM tinyint = null output, @PA_SP_CRYSTAL_URL varchar(100) = null output, @PA_SP_CRYSTAL_ODBC varchar(255) = null output, @PA_SP_CRYSTAL_STD_REPS varchar(100) = null output, @PA_SP_CRYSTAL_CUST_REPS varchar(100) = null output, @PA_SP_CRYSTAL_USER_REPS varchar(100) = null output, @PA_SP_INV_NO_SUFFIX varchar(5) = null output, @PA_SP_NEXT_PROFORM_NO bigint = null output, @PA_SP_ONLY_MEM_PRICE integer = null output, @PA_SP_MEMBER_ONLY_PRC tinyint = null output, @PA_SP_GL_SALES_CTRL varchar(20) = null output, @PA_SP_GL_VAT_CTRL varchar(20) = null output, @PA_SP_GL_BANK varchar(20) = null output, @PA_SP_GL_BANK_CHARGE varchar(20) = null output, @PA_SP_GL_WRITEOFF varchar(20) = null output, @PA_SP_GL_SL_ADJ varchar(20) = null output, @PA_SP_GL_1 varchar(30) = null output, @PA_SP_GL_2 varchar(30) = null output, @PA_SP_GL_3 varchar(30) = null output, @PA_SP_GL_4 varchar(30) = null output, @PA_SP_ACCT_DESC varchar(500) = null output, @PA_SP_MEAL_REPORT_NUM integer = null output, @PA_SP_BOOK_PREF tinyint = null output, @PA_SP_DPM_BCC tinyint = null output, @PA_SP_ADD_LINE_5 tinyint = null output, @PA_SP_SOURCE_CODE tinyint = null output, @PA_SP_REG_LOOKUP tinyint = null output, @PA_SP_DEFAULT_TEXT_1 varchar(500) = null output, @PA_SP_WSPOSTCODE_PATH varchar(500) = null output, @PA_SP_DEFAULT_INT_1 integer = null output, @PA_SP_DEFAULT_USAGE_DESC varchar(500) = null output, @PA_SP_AUTHORISE_PAY_METHOD tinyint = null output, @PA_SP_AUTHORISE_PAY_METHOD_PARAMS varchar(4000) = null output, @PA_SP_GL_BANK_CC varchar(20) = null output, @PA_SP_GL_BANK_DC varchar(20) = null output, @PA_SP_AUTHENTICATION_METHOD tinyint = null output, @PA_SP_EC4_PROV_NO_PLACE tinyint = null output, @PA_SP_ALT_INV_CALC tinyint = null output, @PA_SP_CRYSTAL_TEMPLATE_REPS varchar(100) = null output, @PA_SP_DEPOSIT decimal(19, 2) = null output, @PA_SP_INVOICE_RULE tinyint = null output, @PA_SP_INVOICE_RULE_OFFSET smallint = null output, @PA_SP_INVOICE_CONSOLIDATE tinyint = null output, @PA_SP_INVOICE_WHEN_STATUS varchar(20) = null output, @PA_SP_INVOICE_FORMAT tinyint = null output, @PA_SP_INVOICE_MUST_USE_RULE tinyint = null output, @PA_SP_INVOICE_FORMAT_0_TEXT varchar(500) = null output, @PA_SP_INVOICE_FORMAT_1_TEXT varchar(500) = null output, @PA_SP_INVOICE_OFFSET_TYPE varchar(20) = null output, @PA_SP_SHOW_ACCOUNT_BALANCE tinyint = null output, @PA_SP_INVOICE_DO_NOT_PRINT tinyint = null output, @PA_SP_TRANSFER_STATUS tinyint = null output, @PA_SP_SUBSTITUTE_STATUS tinyint = null output, @PA_SP_HOME_ADD tinyint = null output, @PA_SP_AUTO_TRANSFER tinyint = null output, @PA_SP_USE_CERT_RULES tinyint = null output, @PA_SP_FINANCE_CC varchar(30) = null output, @PA_SP_NO_EV_ATT_PRINT tinyint = null output, @PA_SP_CRYSTAL_URL_2 varchar(100) = null output, @PA_SP_MAIN_ROLE_DEFAULT tinyint = null output, @PA_SP_SHOW_MEM_ALL_ROLES tinyint = null output, @PA_SP_NEAREST_VENUE tinyint = null output, @PA_SP_NOT_CREDIT_TRAN tinyint = null output, @PA_SP_NOT_CREDIT_SUB tinyint = null output, @PA_SP_GET_UNLINKED_ACCOM tinyint = null output, @PA_SP_DEFAULTS varchar(100) = null output, @PA_SP_CHGPWD_DAYS integer = null output, @PA_SP_PWDREM_DAYS integer = null output, @PA_SP_DEF_INV_PACK_ID varchar(11) = null output, @PA_SP_NEXT_PPINVNO integer = null output, @PA_SP_NEXT_PPCREDITNO integer = null output, @PA_SP_INV_NO_PREFIX_PP varchar(5) = null output, @PA_SP_INV_NO_SUFFIX_PP varchar(5) = null output, @PA_SP_PRINCIPAL_ROLE_DEFAULT tinyint = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.Sys_Params set
    SP_MOD_DATE = getDate(),
    SP_MOD_BY = @_AUDIT_USER_ID,
    SP_LOCK = @PA_SP_LOCK,
    SP_SEC_PN_ID = @PA_SP_SEC_PN_ID,
    SP_REO_ORG_ID = @PA_SP_REO_ORG_ID,
    SP_VATREG = @PA_SP_VATREG,
    SP_TIPS_CODE_PREFX = @PA_SP_TIPS_CODE_PREFX,
    SP_INV_NO_PREFIX = @PA_SP_INV_NO_PREFIX,
    SP_NEXT_INV_NO = @PA_SP_NEXT_INV_NO,
    SP_NEXT_CREDIT_NTE = @PA_SP_NEXT_CREDIT_NTE,
    SP_HEADED_PAPER = @PA_SP_HEADED_PAPER,
    SP_HEADING1 = @PA_SP_HEADING1,
    SP_HEADING = @PA_SP_HEADING,
    SP_FOOTER = @PA_SP_FOOTER,
    SP_FOOTER_REO_LABL = @PA_SP_FOOTER_REO_LABL,
    SP_FOOTER_PHONE = @PA_SP_FOOTER_PHONE,
    SP_FOOTER_GEN_SEC = @PA_SP_FOOTER_GEN_SEC,
    SP_PIC_ID = @PA_SP_PIC_ID,
    SP_GENERAL_TEXT_ID = @PA_SP_GENERAL_TEXT_ID,
    SP_GEN_CORS_TXT_ID = @PA_SP_GEN_CORS_TXT_ID,
    SP_AUTH_SPECL_INST = @PA_SP_AUTH_SPECL_INST,
    SP_DB_ID = @PA_SP_DB_ID,
    SP_MAIN = @PA_SP_MAIN,
    SP_REMOTE = @PA_SP_REMOTE,
    SP_NXT_SALE_LEG_NO = @PA_SP_NXT_SALE_LEG_NO,
    SP_QUO_STATUS = @PA_SP_QUO_STATUS,
    SP_QUO_SOURCE = @PA_SP_QUO_SOURCE,
    SP_FORMAT_ACT_NOTE = @PA_SP_FORMAT_ACT_NOTE,
    SP_ORG_SRCH_FILTER = @PA_SP_ORG_SRCH_FILTER,
    SP_MID = @PA_SP_MID,
    SP_USE_MATCH_FIELD = @PA_SP_USE_MATCH_FIELD,
    SP_OFFR_PRE_QUT_PN = @PA_SP_OFFR_PRE_QUT_PN,
    SP_CURRENT_RELEASE = @PA_SP_CURRENT_RELEASE,
    SP_LOWEST_RELEASE = @PA_SP_LOWEST_RELEASE,
    SP_MAN_AUTO_ALLOC = @PA_SP_MAN_AUTO_ALLOC,
    SP_ADD_MAN1_TO_ACT = @PA_SP_ADD_MAN1_TO_ACT,
    SP_ADD_MAN2_TO_ACT = @PA_SP_ADD_MAN2_TO_ACT,
    SP_ADD_DIST_TO_ACT = @PA_SP_ADD_DIST_TO_ACT,
    SP_PERD_ROLL = @PA_SP_PERD_ROLL,
    SP_FT_CAN_CHG_THRS = @PA_SP_FT_CAN_CHG_THRS,
    SP_SD_CAN_CHG_THRS = @PA_SP_SD_CAN_CHG_THRS,
    SP_CANC_CHRG_PRCNT = @PA_SP_CANC_CHRG_PRCNT,
    SP_FT_TRAN_CHG_THR = @PA_SP_FT_TRAN_CHG_THR,
    SP_TRAN_CHGE_PRCNT = @PA_SP_TRAN_CHGE_PRCNT,
    SP_EXT_MV_CHG_PRCN = @PA_SP_EXT_MV_CHG_PRCN,
    SP_JOIN_LETT = @PA_SP_JOIN_LETT,
    SP_CONFIRM_LETT = @PA_SP_CONFIRM_LETT,
    SP_PROV_LETT = @PA_SP_PROV_LETT,
    SP_QUEST_LETT = @PA_SP_QUEST_LETT,
    SP_SURV_LETT = @PA_SP_SURV_LETT,
    SP_INV_LETT = @PA_SP_INV_LETT,
    SP_UPDATE_STRG = @PA_SP_UPDATE_STRG,
    SP_JOB_TYPE = @PA_SP_JOB_TYPE,
    SP_PREVENT_EDIT = @PA_SP_PREVENT_EDIT,
    SP_SUBS_LETTER = @PA_SP_SUBS_LETTER,
    SP_REMOTE_USED = @PA_SP_REMOTE_USED,
    SP_MERGE_LOCK = @PA_SP_MERGE_LOCK,
    SP_INV_RESTRICT = @PA_SP_INV_RESTRICT,
    SP_CURR_PERD = @PA_SP_CURR_PERD,
    SP_DEFAULT_ORG_ID = @PA_SP_DEFAULT_ORG_ID,
    SP_OPP_ACT_MAND = @PA_SP_OPP_ACT_MAND,
    SP_SMTP_SERVER = @PA_SP_SMTP_SERVER,
    SP_ADMIN_EMAIL = @PA_SP_ADMIN_EMAIL,
    SP_USE_AKA_FIELD = @PA_SP_USE_AKA_FIELD,
    SP_EXPORT_NUM = @PA_SP_EXPORT_NUM,
    SP_IMPORT_NUM = @PA_SP_IMPORT_NUM,
    SP_EXPORT_DATE = @PA_SP_EXPORT_DATE,
    SP_BASE_CURR = @PA_SP_BASE_CURR,
    SP_REG = @PA_SP_REG,
    SP_FILE_STORE_PATH = @PA_SP_FILE_STORE_PATH,
    SP_PIC_STORE_PATH = @PA_SP_PIC_STORE_PATH,
    SP_NET_PATH = @PA_SP_NET_PATH,
    SP_BU_SECURITY = @PA_SP_BU_SECURITY,
    SP_ENQ_QST_ID = @PA_SP_ENQ_QST_ID,
    SP_DEL_QST_ID = @PA_SP_DEL_QST_ID,
    SP_BASE_CURR2 = @PA_SP_BASE_CURR2,
    SP_PROV_PACK = @PA_SP_PROV_PACK,
    SP_CONF_PACK = @PA_SP_CONF_PACK,
    SP_JOINING_PACK = @PA_SP_JOINING_PACK,
    SP_POST_PACK = @PA_SP_POST_PACK,
    SP_PROV_INV = @PA_SP_PROV_INV,
    SP_CONF_INV = @PA_SP_CONF_INV,
    SP_JOIN_INV = @PA_SP_JOIN_INV,
    SP_POST_INV = @PA_SP_POST_INV,
    SP_PROV_NO_PLACE = @PA_SP_PROV_NO_PLACE,
    SP_TRAINER_EMAIL = @PA_SP_TRAINER_EMAIL,
    SP_CB_DAYS = @PA_SP_CB_DAYS,
    SP_PAYMENT_DAYS = @PA_SP_PAYMENT_DAYS,
    SP_PAYMENT_TYPE = @PA_SP_PAYMENT_TYPE,
    SP_PAY_TERMS_1 = @PA_SP_PAY_TERMS_1,
    SP_PAY_TERMS_2 = @PA_SP_PAY_TERMS_2,
    SP_PAY_TERMS_3 = @PA_SP_PAY_TERMS_3,
    SP_PAY_TERMS_4 = @PA_SP_PAY_TERMS_4,
    SP_UPGRADE_PATH = @PA_SP_UPGRADE_PATH,
    SP_TC_LETT = @PA_SP_TC_LETT,
    SP_PRINTER1 = @PA_SP_PRINTER1,
    SP_PRINTER2 = @PA_SP_PRINTER2,
    SP_INITIALS = @PA_SP_INITIALS,
    SP_CRYSTAL_INV = @PA_SP_CRYSTAL_INV,
    SP_FLAG = @PA_SP_FLAG,
    SP_BOOK_OTH_NODES = @PA_SP_BOOK_OTH_NODES,
    SP_USER_NUMB_1 = @PA_SP_USER_NUMB_1,
    SP_VAT_METHOD = @PA_SP_VAT_METHOD,
    SP_NO_LOGON = @PA_SP_NO_LOGON,
    SP_Q_RESULTS = @PA_SP_Q_RESULTS,
    SP_FILE_PROD_EXT = @PA_SP_FILE_PROD_EXT,
    SP_REG2 = @PA_SP_REG2,
    SP_REG3 = @PA_SP_REG3,
    SP_ELEM_FLAGS = @PA_SP_ELEM_FLAGS,
    SP_SELL_COMP_NAME = @PA_SP_SELL_COMP_NAME,
    SP_BOOK_APPROVAL = @PA_SP_BOOK_APPROVAL,
    SP_BKT_ID = @PA_SP_BKT_ID,
    SP_ATTACHMENTS_URL = @PA_SP_ATTACHMENTS_URL,
    SP_PERIODS = @PA_SP_PERIODS,
    SP_BAT_SEL_PROC = @PA_SP_BAT_SEL_PROC,
    SP_BAT_OUT_PROC = @PA_SP_BAT_OUT_PROC,
    SP_BAT_OUT_DIR = @PA_SP_BAT_OUT_DIR,
    SP_DEF_INV_LT_ID = @PA_SP_DEF_INV_LT_ID,
    SP_MEM_INV_LT_ID = @PA_SP_MEM_INV_LT_ID,
    SP_PROJ_INV_LT_ID = @PA_SP_PROJ_INV_LT_ID,
    SP_NO_SALESTEAM = @PA_SP_NO_SALESTEAM,
    SP_CRYSTAL_URL = @PA_SP_CRYSTAL_URL,
    SP_CRYSTAL_ODBC = @PA_SP_CRYSTAL_ODBC,
    SP_CRYSTAL_STD_REPS = @PA_SP_CRYSTAL_STD_REPS,
    SP_CRYSTAL_CUST_REPS = @PA_SP_CRYSTAL_CUST_REPS,
    SP_CRYSTAL_USER_REPS = @PA_SP_CRYSTAL_USER_REPS,
    SP_INV_NO_SUFFIX = @PA_SP_INV_NO_SUFFIX,
    SP_NEXT_PROFORM_NO = @PA_SP_NEXT_PROFORM_NO,
    SP_ONLY_MEM_PRICE = @PA_SP_ONLY_MEM_PRICE,
    SP_MEMBER_ONLY_PRC = @PA_SP_MEMBER_ONLY_PRC,
    SP_GL_SALES_CTRL = @PA_SP_GL_SALES_CTRL,
    SP_GL_VAT_CTRL = @PA_SP_GL_VAT_CTRL,
    SP_GL_BANK = @PA_SP_GL_BANK,
    SP_GL_BANK_CHARGE = @PA_SP_GL_BANK_CHARGE,
    SP_GL_WRITEOFF = @PA_SP_GL_WRITEOFF,
    SP_GL_SL_ADJ = @PA_SP_GL_SL_ADJ,
    SP_GL_1 = @PA_SP_GL_1,
    SP_GL_2 = @PA_SP_GL_2,
    SP_GL_3 = @PA_SP_GL_3,
    SP_GL_4 = @PA_SP_GL_4,
    SP_ACCT_DESC = @PA_SP_ACCT_DESC,
    SP_MEAL_REPORT_NUM = @PA_SP_MEAL_REPORT_NUM,
    SP_BOOK_PREF = @PA_SP_BOOK_PREF,
    SP_DPM_BCC = @PA_SP_DPM_BCC,
    SP_ADD_LINE_5 = @PA_SP_ADD_LINE_5,
    SP_SOURCE_CODE = @PA_SP_SOURCE_CODE,
    SP_REG_LOOKUP = @PA_SP_REG_LOOKUP,
    SP_DEFAULT_TEXT_1 = @PA_SP_DEFAULT_TEXT_1,
    SP_WSPOSTCODE_PATH = @PA_SP_WSPOSTCODE_PATH,
    SP_DEFAULT_INT_1 = @PA_SP_DEFAULT_INT_1,
    SP_DEFAULT_USAGE_DESC = @PA_SP_DEFAULT_USAGE_DESC,
    SP_AUTHORISE_PAY_METHOD = @PA_SP_AUTHORISE_PAY_METHOD,
    SP_AUTHORISE_PAY_METHOD_PARAMS = @PA_SP_AUTHORISE_PAY_METHOD_PARAMS,
    SP_GL_BANK_CC = @PA_SP_GL_BANK_CC,
    SP_GL_BANK_DC = @PA_SP_GL_BANK_DC,
    SP_AUTHENTICATION_METHOD = @PA_SP_AUTHENTICATION_METHOD,
    SP_EC4_PROV_NO_PLACE = @PA_SP_EC4_PROV_NO_PLACE,
    SP_ALT_INV_CALC = @PA_SP_ALT_INV_CALC,
    SP_CRYSTAL_TEMPLATE_REPS = @PA_SP_CRYSTAL_TEMPLATE_REPS,
    SP_DEPOSIT = @PA_SP_DEPOSIT,
    SP_INVOICE_RULE = @PA_SP_INVOICE_RULE,
    SP_INVOICE_RULE_OFFSET = @PA_SP_INVOICE_RULE_OFFSET,
    SP_INVOICE_CONSOLIDATE = @PA_SP_INVOICE_CONSOLIDATE,
    SP_INVOICE_WHEN_STATUS = @PA_SP_INVOICE_WHEN_STATUS,
    SP_INVOICE_FORMAT = @PA_SP_INVOICE_FORMAT,
    SP_INVOICE_MUST_USE_RULE = @PA_SP_INVOICE_MUST_USE_RULE,
    SP_INVOICE_FORMAT_0_TEXT = @PA_SP_INVOICE_FORMAT_0_TEXT,
    SP_INVOICE_FORMAT_1_TEXT = @PA_SP_INVOICE_FORMAT_1_TEXT,
    SP_INVOICE_OFFSET_TYPE = @PA_SP_INVOICE_OFFSET_TYPE,
    SP_SHOW_ACCOUNT_BALANCE = @PA_SP_SHOW_ACCOUNT_BALANCE,
    SP_INVOICE_DO_NOT_PRINT = @PA_SP_INVOICE_DO_NOT_PRINT,
    SP_TRANSFER_STATUS = @PA_SP_TRANSFER_STATUS,
    SP_SUBSTITUTE_STATUS = @PA_SP_SUBSTITUTE_STATUS,
    SP_HOME_ADD = @PA_SP_HOME_ADD,
    SP_AUTO_TRANSFER = @PA_SP_AUTO_TRANSFER,
    SP_USE_CERT_RULES = @PA_SP_USE_CERT_RULES,
    SP_FINANCE_CC = @PA_SP_FINANCE_CC,
    SP_NO_EV_ATT_PRINT = @PA_SP_NO_EV_ATT_PRINT,
    SP_CRYSTAL_URL_2 = @PA_SP_CRYSTAL_URL_2,
    SP_MAIN_ROLE_DEFAULT = @PA_SP_MAIN_ROLE_DEFAULT,
    SP_SHOW_MEM_ALL_ROLES = @PA_SP_SHOW_MEM_ALL_ROLES,
    SP_NEAREST_VENUE = @PA_SP_NEAREST_VENUE,
    SP_NOT_CREDIT_TRAN = @PA_SP_NOT_CREDIT_TRAN,
    SP_NOT_CREDIT_SUB = @PA_SP_NOT_CREDIT_SUB,
    SP_GET_UNLINKED_ACCOM = @PA_SP_GET_UNLINKED_ACCOM,
    SP_DEFAULTS = @PA_SP_DEFAULTS,
    SP_CHGPWD_DAYS = @PA_SP_CHGPWD_DAYS,
    SP_PWDREM_DAYS = @PA_SP_PWDREM_DAYS,
    SP_DEF_INV_PACK_ID = @PA_SP_DEF_INV_PACK_ID,
    SP_NEXT_PPINVNO = @PA_SP_NEXT_PPINVNO,
    SP_NEXT_PPCREDITNO = @PA_SP_NEXT_PPCREDITNO,
    SP_INV_NO_PREFIX_PP = @PA_SP_INV_NO_PREFIX_PP,
    SP_INV_NO_SUFFIX_PP = @PA_SP_INV_NO_SUFFIX_PP,
    SP_PRINCIPAL_ROLE_DEFAULT = @PA_SP_PRINCIPAL_ROLE_DEFAULT
  where SP_ID = @PA_SP_ID;
end
go
