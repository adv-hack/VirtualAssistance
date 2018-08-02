if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusLearningBookingFetchAllByDocsmethod')
  exec ('create procedure dbo.spConsensusLearningBookingFetchAllByDocsmethod as select 1 as temp')
go
alter procedure dbo.spConsensusLearningBookingFetchAllByDocsmethod(@PA_BOOK_DOCS_METHOD varchar(40) = null output) as 
begin
  select 
    BOOK_ID,
    BOOK_LOCK,
    BOOK_ADD_DATE,
    BOOK_ADD_BY,
    BOOK_MOD_DATE,
    BOOK_MOD_BY,
    BOOK_RCV_DATE,
    BOOK_RCV_FROM,
    BOOK_ORG_ID,
    BOOK_PERSON_ID,
    BOOK_COURSE_ID,
    BOOK_SALESMAN,
    BOOK_INV_ID,
    BOOK_STATUS,
    BOOK_STATUS_DATE,
    BOOK_ORDER_DATE,
    BOOK_DLVRY_DATE,
    BOOK_DLVRY_REF,
    BOOK_CARRIER,
    BOOK_CUST_ORD_NO,
    BOOK_ORDER_TYPE,
    BOOK_INV_STATUS,
    BOOK_INV_ADD,
    BOOK_DLVRY_ADD,
    BOOK_NOTES,
    BOOK_NET_TOTAL,
    BOOK_VAT_TOTAL,
    BOOK_GROSS_TOTAL,
    BOOK_PLACES,
    BOOK_PROV_LETTER,
    BOOK_CONFIRMED,
    BOOK_JOIN_PACK,
    BOOK_PAID_DATE,
    BOOK_UNION_ID,
    BOOK_TUC_REGION,
    BOOK_APPROVED,
    BOOK_APPROVED_BY,
    BOOK_APPROVE_DATE,
    BOOK_TIMING_FLAG,
    BOOK_ARCH_FLAG,
    BOOK_BOOKING_METHD,
    BOOK_PAYMENT_METHD,
    BOOK_SOURCE_CODE,
    BOOK_NET_TOTAL_ADJ,
    BOOK_DATE_PAID,
    BOOK_TIMES_MOVED,
    BOOK_CORS_MVD_FROM,
    BOOK_STUDENT_PRICE,
    BOOK_ADJUST_VATCD,
    BOOK_ADJUST_DESCRP,
    BOOK_CONF_SENT_DTE,
    BOOK_JOIN_SENT_DTE,
    BOOK_TIME_MVD_CUST,
    BOOK_CORS_MVD_CUST,
    BOOK_PROV_SENT_DTE,
    BOOK_INV_ORG_ID,
    BOOK_INV_EXT_NOTES,
    BOOK_INVOICED,
    BOOK_FOR_ATTN_OF,
    BOOK_DO_NOT_INVOIC,
    BOOK_MSTC_ID,
    BOOK_BAT_ID,
    BOOK_BAT_ID2,
    BOOK_BLOCK_PRICED,
    BOOK_PL_ID,
    BOOK_BLOCK_PRICE,
    BOOK_INCOM_CODE,
    BOOK_EXPEND_CODE,
    BOOK_PRODUCT_GROUP,
    BOOK_REASON,
    BOOK_USERCHAR_1,
    BOOK_CCARD_ID,
    BOOK_PROV_PACK,
    BOOK_CONF_PACK,
    BOOK_JOINING_PACK,
    BOOK_POST_PACK,
    BOOK_PROV_TO_BOOK,
    BOOK_PROV_TO_DEL,
    BOOK_CONF_TO_BOOK,
    BOOK_CONF_TO_DEL,
    BOOK_JOIN_TO_BOOK,
    BOOK_JOIN_TO_DEL,
    BOOK_POST_TO_BOOK,
    BOOK_POST_TO_DEL,
    BOOK_PAID,
    BOOK_PROV_INV,
    BOOK_CONF_INV,
    BOOK_JOIN_INV,
    BOOK_POST_INV,
    BOOK_PERIOD,
    BOOK_USERCHAR_2,
    BOOK_CANCEL_DATE,
    BOOK_CANCEL_BY,
    BOOK_PP_SENT_DTE,
    BOOK_BU_ID,
    BOOK_OPP_ID,
    BOOK_CRYSTAL_INV,
    BOOK_QUO_ID,
    BOOK_DISC_METHOD,
    BOOK_DELIV_ADD,
    BOOK_DOCS_METHOD,
    BOOK_DUE_DATE,
    BOOK_SALES_MAN,
    BOOK_SOP_SENT_DTE,
    BOOK_SOP_STATUS,
    BOOK_SOP_NOTES,
    BOOK_SOP_IN_DTE,
    BOOK_SOP_REF,
    BOOK_SOP_INV_REF,
    BOOK_DISC_VALUE,
    BOOK_PRINT_LOG,
    BOOK_CANC_REASON,
    BOOK_SOP_REL_DTE,
    BOOK_SOP_INT_1,
    BOOK_USERCHAR_3,
    BOOK_USER_DATE_1,
    BOOK_USER_DATE_2,
    BOOK_USER_DATE_3,
    BOOK_MULTI_LANG,
    BOOK_APPROVER1_ID,
    BOOK_APPROVER2_ID,
    BOOK_APPROVER3_ID,
    BOOK_NOMINATOR_ID,
    BOOK_APPROVER1_DOC,
    BOOK_APPROVER2_DOC,
    BOOK_APPROVER3_DOC,
    BOOK_NOMINATOR_DOC,
    BOOK_ECUST_ID,
    BOOK_ECUST_00,
    BOOK_ECUST_01,
    BOOK_ECUST_02,
    BOOK_ECUST_03,
    BOOK_ECUST_04,
    BOOK_ECUST_05,
    BOOK_ECUST_06,
    BOOK_ECUST_07,
    BOOK_ECUST_08,
    BOOK_ECUST_09,
    BOOK_CURRENCY_TYPE,
    BOOK_CURR_RATE_BC,
    BOOK_CURR_RATE_BC2,
    BOOK_APPROVER4_ID,
    BOOK_REJECT1_ID,
    BOOK_REJECT2_ID,
    BOOK_REJECT3_ID,
    BOOK_REJECT4_ID,
    BOOK_SELCO_SP_ID,
    BOOK_ADD_ID,
    BOOK_APPREJ1_EMAIL,
    BOOK_APPREJ2_EMAIL,
    BOOK_APPREJ3_EMAIL,
    BOOK_APPREJ4_EMAIL,
    BOOK_APPREJ1_DATE,
    BOOK_APPREJ2_DATE,
    BOOK_APPREJ3_DATE,
    BOOK_APPREJ4_DATE,
    BOOK_PROLE_ID,
    BOOK_VATCD_OVRRIDE,
    BOOK_ORG_CUST_AC,
    BOOK_USER_DATE_4,
    BOOK_USER_DATE_5,
    BOOK_USER_DATE_6,
    BOOK_USERCHAR_4,
    BOOK_USERCHAR_5,
    BOOK_USERCHAR_6,
    BOOK_USER_TINT_1,
    BOOK_USER_TINT_2,
    BOOK_USER_TINT_3,
    BOOK_USER_TINT_4,
    BOOK_USER_TINT_5,
    BOOK_USER_TINT_6,
    BOOK_DELIV_FAO,
    BOOK_DELIV_PHONE,
    BOOK_INV_PROLE_ID,
    BOOK_INV_TYPE,
    BOOK_CHARGE_TYPE,
    BOOK_DEPOSIT_TOT,
    BOOK_DEPOSIT_PAID,
    BOOK_SCHN_ID,
    BOOK_SY_TYPE,
    BOOK_PRJOIN_SENT_DTE,
    BOOK_POJOIN_SENT_DTE,
    BOOK_PREJOIN_PACK,
    BOOK_PSTJOIN_PACK,
    BOOK_PREJOIN_TO_BOOK,
    BOOK_PREJOIN_TO_DEL,
    BOOK_PSTJOIN_TO_BOOK,
    BOOK_PSTJOIN_TO_DEL,
    BOOK_NET_TOTAL_BC,
    BOOK_NET_TOTAL_BC2,
    BOOK_TERMS_ACC_BY,
    BOOK_INVOICE_RULE,
    BOOK_INVOICE_RULE_OFFSET,
    BOOK_DO_NOT_INVOICE_REASON,
    BOOK_INVOICE_OFFSET_TYPE,
    BOOK_INVOICE_WHEN_STATUS,
    BOOK_INVOICE_MUST_USE_RULE,
    BOOK_INVOICE_CONSOLIDATE,
    BOOK_INVOICE_FORMAT,
    BOOK_INVOICE_FORMAT_0_TEXT,
    BOOK_INVOICE_FORMAT_1_TEXT,
    BOOK_ACC_ID,
    BOOK_RESV_TO_DATE,
    BOOK_AGT_ID,
    BOOK_AGT_ORG_ID,
    BOOK_AGT_TYPE,
    BOOK_AGT_COMMISSION,
    BOOK_INVOICE_PER_DEL,
    BOOK_MANAGED,
    BOOK_CANCEL_REF,
    BOOK_INVOICE_PER_PERSON,
    BOOK_PROFORMA,
    BOOK_CART_ID,
    BOOK_PS_ID,
    BOOK_PROMO_CODE,
    BOOK_CUST_BR_INF,
    BOOK_CONF_SENT_OFFLINE_DATE,
    BOOK_USERNUM_1,
    BOOK_USERNUM_2,
    BOOK_USERNUM_3,
    BOOK_USERNUM_4,
    BOOK_USERNUM_5,
    BOOK_USERNUM_6
  from dbo.Booking
  where BOOK_DOCS_METHOD = @PA_BOOK_DOCS_METHOD
end
go
