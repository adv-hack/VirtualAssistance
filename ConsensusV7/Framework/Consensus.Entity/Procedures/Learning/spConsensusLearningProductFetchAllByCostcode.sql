if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusLearningProductFetchAllByCostcode')
  exec ('create procedure dbo.spConsensusLearningProductFetchAllByCostcode as select 1 as temp')
go
alter procedure dbo.spConsensusLearningProductFetchAllByCostcode(@PA_PROD_COST_CODE varchar(40) = null output) as 
begin
  select 
    PROD_ID,
    PROD_LOCK,
    PROD_ADD_DATE,
    PROD_ADD_BY,
    PROD_MOD_DATE,
    PROD_MOD_BY,
    PROD_RCV_DATE,
    PROD_RCV_FROM,
    PROD_GROUP_ID,
    PROD_REF,
    PROD_NAME,
    PROD_DESCRIP,
    PROD_TEXT1,
    PROD_TEXT2,
    PROD_TEXT3,
    PROD_TEXT4,
    PROD_TEXT5,
    PROD_SY_PRODUCT,
    PROD_TYPE,
    PROD_CATEGORY,
    PROD_STATUS,
    PROD_GROUP,
    PROD_UNIT,
    PROD_PRICE,
    PROD_BLOCK_PRICE,
    PROD_SPARE_PRICE,
    PROD_COST_PRICE,
    PROD_COST_CODE,
    PROD_REV_CODE,
    PROD_DISC_SCHED,
    PROD_VAT_CODE,
    PROD_MIN_ATTEND,
    PROD_MAX_ATTEND,
    PROD_COURSE_LEN,
    PROD_DIARY_TYPE,
    PROD_NORM_COLLEGE,
    PROD_NEXT_COURSE,
    PROD_SPARE_FLAG1,
    PROD_SPARE_FLAG2,
    PROD_CERT_PRINTED,
    PROD_TUC_REGION,
    PROD_ENTRY_DATE,
    PROD_PROJECT_NO,
    PROD_COMMISSION_BY,
    PROD_KEY,
    PROD_CODE,
    PROD_TYPE_LOW,
    PROD_REF_LOW,
    PROD_QUES_SET,
    PROD_START_QNO,
    PROD_SELL_HINT,
    PROD_DET,
    PROD_ASS,
    PROD_RETAIL_PRICE,
    PROD_MARGIN,
    PROD_SUPPLIER_NAME,
    PROD_SUPPLIER_ID,
    PROD_PIC_ID,
    PROD_JOIN_LETT,
    PROD_CONFIRM_LETT,
    PROD_QUEST_LETT,
    PROD_SURV_LETT,
    PROD_NO_CST_NO_SEL,
    PROD_PROV_LETT,
    PROD_INV_LETT,
    PROD_DO_NOT_INVOIC,
    PROD_TOP_LEVEL,
    PROD_ADD_ID,
    PROD_ROOM_TYPE,
    PROD_ROOM_GRADE,
    PROD_STATE,
    PROD_STOCKED,
    PROD_QTY_AV,
    PROD_QTY_AC,
    PROD_QTY_BO,
    PROD_QTY_OR,
    PROD_COURSEMASTER,
    PROD_CURRENCY,
    PROD_LAST_USED,
    PROD_DAILY_DEL_RAT,
    PROD_OVERNIGHT_RAT,
    PROD_SYNDICATE_RAT,
    PROD_EQUIP1,
    PROD_EQUIP2,
    PROD_EQUIP3,
    PROD_EQUIP4,
    PROD_EQUIP5,
    PROD_EQUIP6,
    PROD_EQUIP7,
    PROD_EQUIP8,
    PROD_EQUIP9,
    PROD_EQUIP10,
    PROD_EQUIP11,
    PROD_EQUIP12,
    PROD_EQUIP13,
    PROD_EQUIP14,
    PROD_EQUIP15,
    PROD_GENERALISED,
    PROD_NETW_TYPE,
    PROD_REN_TYPE,
    PROD_OLD_DESC,
    PROD_CLASS,
    PROD_TI_CODE,
    PROD_DEP_REPS,
    PROD_LEAD_DEPT,
    PROD_CURRENT,
    PROD_MEDIA,
    PROD_MAX_DISC,
    PROD_USERCHAR_1,
    PROD_USERCHAR_2,
    PROD_USERNUM_1,
    PROD_AVAIL_DATE,
    PROD_CERT_FMT,
    PROD_CERT_NAME,
    PROD_LSE_PRINTED,
    PROD_REQ_FREQCY,
    PROD_ADM_TXT_ID,
    PROD_TRN_TXT_ID,
    PROD_ENQ_QST_ID,
    PROD_DEL_QST_ID,
    PROD_PROV_PACK,
    PROD_CONF_PACK,
    PROD_JOINING_PACK,
    PROD_POST_PACK,
    PROD_PROV_INV,
    PROD_CONF_INV,
    PROD_JOIN_INV,
    PROD_POST_INV,
    PROD_MSTC_TYPE,
    PROD_OVERBOOK,
    PROD_COMMISSION,
    PROD_PLAN_ID,
    PROD_PLAN_NAME,
    PROD_NO_HOURS,
    PROD_EXPIRY_MONTHS,
    PROD_PLACES,
    PROD_PRE_PAY_TYPE,
    PROD_GRADES,
    PROD_PROLE_ID,
    PROD_MAN_PROLE_ID,
    PROD_LEVEL,
    PROD_SERIALISED,
    PROD_URL,
    PROD_VAL_TO_REV_PC,
    PROD_BKT_ID,
    PROD_BT_ID,
    PROD_NAME2,
    PROD_GL_CODE1,
    PROD_GL_CODE2,
    PROD_RESOURSE,
    PROD_LOC_ID,
    PROD_WEB,
    PROD_DESC_FILE,
    PROD_USERCHAR_3,
    PROD_USERINT_1,
    PROD_USERINT_2,
    PROD_USERINT_3,
    PROD_USERINT_4,
    PROD_USERDATE_1,
    PROD_USERINT_5,
    PROD_USERNUM_2,
    PROD_USERINT_6,
    PROD_USERCHAR_4,
    PROD_USERCHAR_5,
    PROD_USERNUM_3,
    PROD_USERNUM_4,
    PROD_USERNUM_5,
    PROD_USERINT_7,
    PROD_USERINT_8,
    PROD_USERINT_9,
    PROD_MEMB_PRC_GRP,
    PROD_SCO_MANIF_XML,
    prod_quantity,
    PROD_NON_SCORM,
    PROD_MS_NEW,
    PROD_MS_REMIND1,
    PROD_MS_REMIND2,
    PROD_MS_RENEW,
    PROD_MS_LAPSED,
    PROD_MS_CANCEL,
    PROD_MS_GROUP,
    PROD_RENEW_DAYS,
    PROD_SELCO_SP_ID,
    PROD_MEM_INV_TYPE,
    PROD_AUTH_PN_ID,
    PROD_ISBN,
    PROD_PAGE_COUNT,
    PROD_MS_REMIND3,
    PROD_MS_RM1_DAYS,
    PROD_MS_RM2_DAYS,
    PROD_MS_RM3_DAYS,
    PROD_MS_LAPS_DAYS,
    PROD_FREQ,
    PROD_DESC_FILE_Y,
    PROD_MS_RENEWED,
    PROD_REG_BODY_ID_1,
    PROD_REG_BODY_ID_2,
    PROD_USERCHAR_6,
    PROD_U_DATE_1,
    PROD_U_DATE_2,
    PROD_U_DATE_3,
    PROD_U_DATE_4,
    PROD_U_DATE_5,
    PROD_U_DATE_6,
    PROD_USERNUM_6,
    PROD_ROOM_BED_TYPE,
    PROD_LAY_STD,
    PROD_LAY_THEATER,
    PROD_LAY_INFORMAL,
    PROD_LAY_CLASS,
    PROD_LAY_OTHER,
    PROD_MAX_THEATER,
    PROD_MAX_INFORMAL,
    PROD_MAX_CLASS,
    PROD_MAX_OTHER,
    PROD_PRICE_BAND,
    PROD_SLTY_ID,
    PROD_KEYWORDS,
    PROD_LMS_NAME,
    PROD_EL_SELF_APRV,
    PROD_CUT_PRD,
    PROD_RENEWAL_MONTH,
    PROD_RENEWAL_DAY,
    PROD_FIXED_RENEWAL,
    PROD_EXCL_DAY,
    PROD_EXCL_CALC,
    PROD_SG_NO,
    PROD_MS_APP,
    PROD_MS_OFF,
    PROD_FUNDED,
    PROD_FUNDED_ORG_ID,
    PROD_QUAL_DEL,
    PROD_BREAK_MUST_EXIST,
    PROD_ORG_ID,
    PROD_BD_PREP_BY,
    PROD_BD_PREP_DATE,
    PROD_BD_STATUS,
    PROD_BD_APP_BY,
    PROD_BD_APP_DATE,
    PROD_BD_TOT_EST_COST,
    PROD_NO_INV_RENEW,
    PROD_CALC_COMMISSION,
    PROD_REGION,
    PROD_STATIC_RESOURSE,
    PROD_POOLED_RESOURSE,
    PROD_CLASH_CHECK,
    PROD_DEF_TRAINEE_DAYS,
    PROD_GRANT_ELIGIBLE,
    PROD_GRANT_VALUE_AVAILABLE,
    PROD_BREAKEVEN_1,
    PROD_BREAKEVEN_2,
    PROD_EXT_COURSEWARE,
    PROD_CONTINGENCY,
    PROD_COST,
    PROD_DELIVERY_DAY,
    PROD_EXT_URL,
    PROD_USE_EXT_URL,
    PROD_REF_NO,
    PROD_PREFIX,
    PROD_NONE_CHARGEABLE,
    PROD_RULE_INC_FAMILY,
    PROD_DONATION,
    PROD_RENEW,
    PROD_RENEWABLE,
    PROD_COURSE_NOTES_TEXT_ID,
    PROD_DESIG_LETTERS,
    PROD_NON_RENEW_MEMB,
    PROD_AGE_RESTRICTION_1,
    PROD_AGE_RESTRICTION_2,
    PROD_RESTRICT_TYPE,
    PROD_EXPIRY_DATE,
    PROD_INV_ZERO_VAL,
    PROD_CREDIT_HOURS,
    PROD_DD_NO_OF_INSTALLMENTS,
    PROD_DD_FREQUENCY,
    PROD_EXCLUDE_TRAIN_HISTORY,
    PROD_START_DATE_TYPE,
    PROD_START_DATE_FIXED,
    PROD_START_DATE_OFFSET,
    PROD_START_DATE_OFFSET_TYPE,
    PROD_END_DATE_TYPE,
    PROD_END_DATE_FIXED,
    PROD_END_DATE_OFFSET,
    PROD_END_DATE_OFFSET_TYPE,
    PROD_DESC_EDITABLE,
    PROD_STOCK_TYPE,
    PROD_STOCK_EXPECTED_DATE,
    PROD_MEM_FIRST_BOOK,
    PROD_MIN_SCORE,
    PROD_SCORE_OUTOF,
    PROD_GRADE_WEB,
    PROD_PREDELIV,
    PROD_AUTHOR_NAME,
    PROD_TOPUP,
    PROD_LIMIT_PL_TYPE,
    PROD_PREPAY_UNITS,
    PROD_DELIV_METHOD,
    PROD_LOCKDOWN,
    PROD_PROMOTION,
    PROD_SEARCH_GROUP,
    PROD_LIMIT_PL_ID,
    PROD_DEF_ELEM_ST,
    PROD_NEXT_NO,
    PROD_SUFFIX,
    PROD_NO_MEMB_DISCOUNT,
    PROD_QUEST_ID,
    PROD_SHORT_DESC,
    PROD_ONECLICK_CHECKOUT,
    PROD_BOOKER_ONLY,
    PROD_LAY_USHAPE,
    PROD_LAY_BROOM,
    PROD_LAY_BROUT,
    PROD_MAX_USHAPE,
    PROD_MAX_BROOM,
    PROD_MAX_BROUT,
    PROD_WP_NAME,
    PROD_DEPT,
    PROD_SKU,
    PROD_JOB_CODE,
    PROD_JOB_ANALY_CODE,
    PROD_JOB_TYPE,
    PROD_JOB_PARENT,
    PROD_PSH_ID,
    PROD_IMAGE,
    PROD_ONLINE_SCHE,
    PROD_QUOTEBOOK_RATIO,
    PROD_COORDS,
    PROD_URL_NAME,
    PROD_ZERO_PAD,
    PROD_TRAIN_PROV,
    PROD_REORDER_LEV,
    PROD_LICENSED,
    PROD_DEL_CLOSE_DAYS,
    PROD_TRN_RULES_TXT,
    PROD_CERT_DEF_DELIVER,
    PROD_DEF_METH_DEL,
    PROD_CERT_TEMP_LTT_ID,
    PROD_REORDER_LEAD,
    PROD_NOM_MEM_DET,
    PROD_NOM_MEM_REQ,
    PROD_NOM_MEM_PROD_ID,
    PROD_PACK_SEND_PROLE_ID,
    PROD_PACK_BCC_EMAIL,
    PROD_PACK_MDN_EMAIL,
    PROD_PACK_DSN_EMAIL,
    PROD_PACK_DSN_OPTIONS,
    PROD_CODE_IMAGE,
    PROD_GATEWAY_ACC_ID,
    PROD_ROYALTY_MODEL,
    PROD_SESSIONS_DESCRIPTION,
    PROD_SESSIONS_HEADER,
    PROD_CUT_PRD_TIME,
    PROD_GIFTAID
  from dbo.Product
  where PROD_COST_CODE = @PA_PROD_COST_CODE
end
go
