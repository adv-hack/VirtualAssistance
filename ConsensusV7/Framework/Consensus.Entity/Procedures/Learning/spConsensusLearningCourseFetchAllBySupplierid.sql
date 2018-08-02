if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusLearningCourseFetchAllBySupplierid')
  exec ('create procedure dbo.spConsensusLearningCourseFetchAllBySupplierid as select 1 as temp')
go
alter procedure dbo.spConsensusLearningCourseFetchAllBySupplierid(@PA_COURSE_SUPPLIER_ID varchar(11) = null output) as 
begin
  select 
    COURSE_ID,
    COURSE_LOCK,
    COURSE_ADD_DATE,
    COURSE_ADD_BY,
    COURSE_MOD_DATE,
    COURSE_MOD_BY,
    COURSE_RCV_DATE,
    COURSE_RCV_FROM,
    COURSE_PERSON_ID,
    COURSE_PRODUCT_ID,
    COURSE_LOC_ID,
    COURSE_ORG_ID,
    COURSE_REF,
    COURSE_NAME,
    COURSE_TYPE,
    COURSE_SECTOR,
    COURSE_ON_SITE,
    COURSE_BLOCK_PRICD,
    COURSE_START_DATE,
    COURSE_END_DATE,
    COURSE_START_TIME,
    COURSE_END_TIME,
    COURSE_STATUS,
    COURSE_DIARY_TYPE,
    COURSE_LENGTH,
    COURSE_MIN_PLACES,
    COURSE_MAX_PLACES,
    COURSE_FREE_PLACES,
    COURSE_CONF_PLACES,
    COURSE_PROVIS_BKGS,
    COURSE_RESV_PLACES,
    COURSE_WAITING,
    COURSE_CANCELS,
    COURSE_BLOCK_THRES,
    COURSE_BLOCK_PRICE,
    COURSE_STUDT_PRICE,
    COURSE_EST_PUR_PRC,
    COURSE_NO_HOURS,
    COURSE_VAT_CODE,
    COURSE_COST_CODE,
    COURSE_REV_CODE,
    COURSE_JN_INF_ORDE,
    COURSE_NOTES,
    COURSE_TUC_REGION,
    COURSE_BUDGET,
    COURSE_ACTUAL,
    COURSE_PAY_FAG,
    COURSE_PAY_DATE,
    COURSE_PAY_CHEQ_NO,
    COURSE_COLL_INV_NO,
    COURSE_INCL_OUTLIN,
    COURSE_INCL_MAP,
    COURSE_INC_SPC_INS,
    COURSE_INCL_BK_FRM,
    COURSE_INC_PST_QST,
    COURSE_INC_PRE_SRV,
    COURSE_BUD_PERIOD,
    COURSE_BUD_FORECST,
    COURSE_SOURCE_CODE,
    COURSE_PERSON_ID_2,
    COURSE_CLASS,
    COURSE_HOST_NAME,
    COURSE_VENU_ACTUAL,
    COURSE_VENU_BUDGET,
    COURSE_CATER_ACTUL,
    COURSE_CATER_BDGET,
    COURSE_HOTEL_ACTUL,
    COURSE_HOTEL_BDGET,
    COURSE_EQUIP_ACTUL,
    COURSE_EQUIP_BDGET,
    COURSE_TRAV_ACTUAL,
    COURSE_TRAV_BUDGET,
    COURSE_EXP_ACTUAL,
    COURSE_EXP_BUDGET,
    COURSE_OTHR_ACTUAL,
    COURSE_OTHR_BUDGET,
    COURSE_QUEST_LETT,
    COURSE_SURV_LETT,
    COURSE_BOOK_ACTUAL,
    COURSE_ACTUAL_TOT,
    COURSE_INCL_JOIN,
    COURSE_INC_CONFIRM,
    COURSE_JOIN_LETT,
    COURSE_CONFRM_LETT,
    COURSE_PROV_LETT,
    COURSE_INV_LETT,
    COURSE_DO_NOT_INVC,
    COURSE_CANCEL_DATE,
    COURSE_CANCEL_BY,
    COURSE_INC_CSH_INV,
    COURSE_INC_PRO_FRM,
    COURSE_INC_RECEIPT,
    COURSE_CMC,
    COURSE_PL_ID,
    COURSE_SUPPLIER_ID,
    COURSE_BREAK_EVEN,
    COURSE_CHANGE_HIST,
    COURSE_BIP,
    COURSE_QUEST_ID,
    COURSE_POST_ID,
    COURSE_ORDER_NO,
    COURSE_PROV_PACK,
    COURSE_CONF_PACK,
    COURSE_JOINING_PACK,
    COURSE_POST_PACK,
    COURSE_PROV_INV,
    COURSE_CONF_INV,
    COURSE_JOIN_INV,
    COURSE_POST_INV,
    COURSE_PERIOD,
    COURSE_SEARCH_NAME,
    COURSE_EVR_ID,
    COURSE_OPP_ID,
    COURSE_SESS_COUNT,
    COURSE_PRIVATE,
    COURSE_PLAN_ID,
    COURSE_PLAN_NAME,
    COURSE_WEB,
    COURSE_GRADES,
    COURSE_DESC_TXT_ID,
    COURSE_TARG_TXT_ID,
    COURSE_SETUP_TIME,
    COURSE_DATE_DEC,
    COURSE_NUM_INVITE,
    COURSE_PERSON_ID_3,
    COURSE_PERSON_ID_4,
    COURSE_BU_ID,
    COURSE_USERNUM_1,
    COURSE_USERNUM_2,
    COURSE_URL,
    COURSE_PROJ_ID,
    COURSE_CODE,
    COURSE_BT_ID,
    COURSE_COMMENTS,
    COURSE_3RD_PARTY,
    COURSE_U_DATE_1,
    COURSE_U_DATE_2,
    COURSE_U_DATE_3,
    COURSE_U_DATE_4,
    COURSE_USERNUM_3,
    COURSE_ADD_ID,
    COURSE_NAME2,
    COURSE_USERCHAR_1,
    COURSE_USERCHAR_2,
    COURSE_USERCHAR_3,
    COURSE_USERCHAR_4,
    COURSE_SUP_ROLE_ID,
    COURSE_CURRENCY,
    COURSE_PRICE_A,
    COURSE_PRICE_B,
    COURSE_PRICE_C,
    COURSE_PRICE_D,
    COURSE_PRICE_E,
    COURSE_CHARGABLE,
    COURSE_SELCO_SP_ID,
    COURSE_USERNUM_4,
    COURSE_USERNUM_5,
    COURSE_USERNUM_6,
    COURSE_USERNUM_7,
    COURSE_INVOICED,
    COURSE_BKT_ID,
    COURSE_CONTPROL_ID,
    COURSE_BUD_REV,
    COURSE_BUD_FORCAST,
    COURSE_U_DATE_5,
    COURSE_U_DATE_6,
    COURSE_USERCHAR_5,
    COURSE_USERCHAR_6,
    COURSE_U_TINT_1,
    COURSE_U_TINT_2,
    COURSE_U_TINT_3,
    COURSE_U_TINT_4,
    COURSE_U_TINT_5,
    COURSE_U_TINT_6,
    COURSE_SY_TYPE,
    COURSE_PREJOIN_PACK,
    COURSE_PSTJOIN_PACK,
    COURSE_BOOK_ACT_BC2,
    COURSE_ACT_TOT_BC2,
    COURSE_PROV_SENT_DTE,
    COURSE_CONF_SENT_DTE,
    COURSE_JOIN_SENT_DTE,
    COURSE_PP_SENT_DTE,
    COURSE_PRJOIN_SENT_DTE,
    COURSE_POJOIN_SENT_DTE,
    COURSE_CUT_PRD,
    COURSE_SUP_STATUS,
    COURSE_OVERBOOK,
    COURSE_PROV_ORG_ID,
    COURSE_PROV_PROLE_ID,
    COURSE_ALLOC_STATUS,
    COURSE_EST_HOURS,
    COURSE_FLOAT,
    COURSE_ACT_HOURS,
    COURSE_NOTES2,
    COURSE_NOTES3,
    COURSE_FUNDED,
    COURSE_FUNDED_ORG_ID,
    COURSE_QUAL_DEL,
    COURSE_COH_ONLY,
    COURSE_ANALYSIS_1,
    COURSE_ANALYSIS_2,
    COURSE_RESERVATIONS,
    COURSE_DEF_ELEM_ST,
    COURSE_LAPSED,
    COURSE_INT_NOTES,
    COURSE_BD_COMP_BY,
    COURSE_BD_COMP_DATE,
    COURSE_BD_TOT_ACT_COST,
    COURSE_BD_STATUS,
    COURSE_SUBS,
    COURSE_TRANSFERS,
    COURSE_HAS_TRAINER,
    COURSE_BD_PREP_BY,
    COURSE_BD_PREP_DATE,
    COURSE_BD_APP_BY,
    COURSE_BD_APP_DATE,
    COURSE_BD_TOT_EST_COST,
    COURSE_CALC_COMMISSION,
    COURSE_BAT_ID,
    COURSE_CANCEL_PACK,
    COURSE_CANP_SENT_DTE,
    COURSE_CANCELLATION_DATE,
    COURSE_REASON,
    COURSE_UNRECOVERABLE_CANC_LOSS,
    COURSE_DEFAULT_TRAINEE_DAYS,
    COURSE_GRANT_ELIGABLE,
    COURSE_GRANT_VALUE_AVAILABLE,
    COURSE_BREAKEVEN_VALUE1,
    COURSE_BREAKEVEN_VALUE2,
    COURSE_EXT_COURSEWARE,
    COURSE_CONTINGENCY,
    COURSE_COST,
    COURSE_DELIVERY_DAYS,
    COURSE_MTR_PROLE_ID,
    COURSE_MA_PROLE_ID,
    COURSE_ACADY_CODE,
    COURSE_NO_AUTO_UPDATE,
    COURSE_COURSE_ID,
    COURSE_USERMULTI_1,
    COURSE_CLONE,
    COURSE_OUT_OF_HOURS,
    COURSE_STOP_TRAIN_COMPLETION,
    COURSE_BD_ORIG_COST,
    COURSE_ORDER,
    COURSE_ELEM_ID,
    COURSE_CODE_LOOKUP1,
    COURSE_PSH_ID,
    COURSE_BLOCK_TYPE,
    COURSE_ATT_MOD_BY,
    COURSE_ATT_MOD_DATE,
    COURSE_AVAIL,
    COURSE_FIRST_LIC_EVENT,
    COURSE_TRNP_ID,
    COURSE_LICENSED,
    COURSE_RESULT_REC_DATE,
    COURSE_PAPERS_REC_DATE,
    COURSE_CERT_ISSUE_DATE,
    COURSE_DEL_IMP_DATE,
    COURSE_ITEMS_RECEIVED_DATE,
    COURSE_DELIV_METHD,
    COURSE_PACK_SEND_PROLE_ID,
    COURSE_PACK_BCC_EMAIL,
    COURSE_PACK_MDN_EMAIL,
    COURSE_PACK_DSN_EMAIL,
    COURSE_PACK_DSN_OPTIONS,
    COURSE_CODE_IMAGE,
    COURSE_CLIENT_REF,
    COURSE_SESSIONS_DESCRIPTION,
    COURSE_SESSIONS_HEADER,
    COURSE_CUT_PRD_TIME
  from dbo.Course
  where COURSE_SUPPLIER_ID = @PA_COURSE_SUPPLIER_ID
end
go
