if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusLearningElementFetchAllByPshid')
  exec ('create procedure dbo.spConsensusLearningElementFetchAllByPshid as select 1 as temp')
go
alter procedure dbo.spConsensusLearningElementFetchAllByPshid(@PA_ELEM_PSH_ID integer = null output) as 
begin
  select 
    ELEM_ID,
    ELEM_LOCK,
    ELEM_ADD_DATE,
    ELEM_ADD_BY,
    ELEM_MOD_DATE,
    ELEM_MOD_BY,
    ELEM_RCV_DATE,
    ELEM_RCV_FROM,
    ELEM_DEL_ID,
    ELEM_PROD_ID,
    ELEM_ACT_ID,
    ELEM_COURSE_ID,
    ELEM_BOOK_ID,
    ELEM_WHO_PAYS,
    ELEM_CERT_NO,
    ELEM_ATTENDED,
    ELEM_USER_DATE_1,
    ELEM_USER_DATE_2,
    ELEM_USER_DATE_3,
    ELEM_USERINT_1,
    ELEM_USERINT_2,
    ELEM_USERNUM_1,
    ELEM_USERNUM_2,
    ELEM_USERNUM_3,
    ELEM_CURRENCY_TYPE,
    ELEM_PRICE,
    ELEM_BLOCK_PRICE,
    ELEM_PRICE_BC,
    ELEM_BLOCK_PRCE_BC,
    ELEM_VATCD,
    ELEM_COST_CODE,
    ELEM_DO_NOT_INVCE,
    ELEM_INVOICED,
    ELEM_INVOICED_DATE,
    ELEM_DESCRIPTION,
    ELEM_REV_CODE,
    ELEM_INVOICE_PRINT,
    ELEM_CANCELLED,
    ELEM_NOTES,
    ELEM_CREDITED,
    ELEM_NON_ATD_RSN,
    ELEM_CERT_ISE_DAT,
    ELEM_CERT_PRN_DAT,
    ELEM_LCSE_NO,
    ELEM_LCSE_ISE_DAT,
    ELEM_LCSE_PRN_DAT,
    ELEM_REQ_DATE,
    ELEM_PASS,
    ELEM_SCORE,
    ELEM_CHOSEN,
    ELEM_TYPE,
    ELEM_STATUS,
    ELEM_GRADE,
    ELEM_PRICE_BC2,
    ELEM_BLK_PRICE_BC2,
    ELEM_PAYMENT_METHD,
    ELEM_QTY,
    ELEM_UNT_PRICE,
    ELEM_UNT_PRICE_BC,
    ELEM_UNT_PRICE_BC2,
    ELEM_SHOW_SALES,
    ELEM_MSTC_ID,
    ELEM_LST_PRICE,
    ELEM_LST_PRICE_BC,
    ELEM_LST_PRICE_BC2,
    ELEM_DEL_TYPE,
    ELEM_DEL_ATTRIBS,
    ELEM_PL_ID,
    ELEM_DEL_QTY,
    ELEM_BLOCK,
    ELEM_RESULT,
    ELEM_HISTORY,
    ELEM_RETAIL_PRICE,
    ELEM_COST_PRICE,
    ELEM_RET_PRICE_BC,
    ELEM_CST_PRICE_BC,
    ELEM_RET_PRICE_BC2,
    ELEM_CST_PRICE_BC2,
    ELEM_VAL_TO_REV,
    ELEM_DEL_TYPE_DESC,
    ELEM_DESCRIPTION2,
    ELEM_LMSP_ID,
    ELEM_SCO_START_DTE,
    ELEM_FAIL_RSN,
    ELEM_MAIN_SESSION,
    ELEM_SELL_MSTC_ID,
    ELEM_PREPAY_UNITS,
    ELEM_START_DATE,
    ELEM_END_DATE,
    ELEM_REG_NO,
    ELEM_SXREF_ID,
    ELEM_ROOM_TYPE,
    ELEM_ROOM_BED_TYPE,
    ELEM_QTY_2,
    ELEM_QUAL_ID,
    ELEM_TICKET_PNTS,
    ELEM_DISC_REASON,
    ELEM_START_TIME,
    ELEM_END_TIME,
    ELEM_SST_ID,
    ELEM_SUB_QTY_1,
    ELEM_SUB_QTY_2,
    ELEM_SUB_QTY_3,
    ELEM_SUB_QTY_4,
    ELEM_SUB_QTY_5,
    ELEM_SUB_QTY_6,
    ELEM_SUB_QTY_7,
    ELEM_SUB_QTY_8,
    ELEM_SUB_QTY_9,
    ELEM_UNT_PRC_1,
    ELEM_UNT_PRC_2,
    ELEM_UNT_PRC_3,
    ELEM_UNT_PRC_4,
    ELEM_UNT_PRC_5,
    ELEM_UNT_PRC_6,
    ELEM_UNT_PRC_7,
    ELEM_UNT_PRC_8,
    ELEM_UNT_PRC_9,
    ELEM_UNT_TYPE,
    ELEM_VAT_AMT,
    ELEM_PRICE_CALC,
    ELEM_DISC_AMT,
    ELEM_LMSP_SUSPEND_DATA,
    ELEM_LMSP_SCORE,
    ELEM_LMSP_LESSON_STATUS,
    ELEM_LMSP_COMMENTS,
    ELEM_CHG_PRC_BY,
    ELEM_CHG_PRC_DATE,
    ELEM_CERT_PRINT_STATUS,
    ELEM_CR_ID,
    ELEM_CERT_PRN_DATE,
    ELEM_CERT_PRINT_ANYWAY,
    ELEM_SELCO_SP_ID,
    ELEM_CHK_IN_TIME,
    ELEM_EXP_CHK_OUT_TIME,
    ELEM_ACT_CHK_OUT_TIME,
    ELEM_PRS_ID,
    ELEM_TEACH_HRS,
    ELEM_STUD_WKS,
    ELEM_COMMISSION_DONE,
    ELEM_COMMISSION_ELEM_ID,
    ELEM_AGT_ID,
    ELEM_EVENT_CANCEL,
    ELEM_PROFORMA,
    ELEM_BAT_ID,
    ELEM_SOP_NO,
    ELEM_ERROR_DESC,
    ELEM_GRP_ID,
    ELEM_AUTH_STATUS,
    ELEM_ELEM_ID,
    ELEM_BKT_ID,
    ELEM_UNIT_PRICE_DISC,
    ELEM_UNIT_PRICE_DISC_BC,
    ELEM_UNIT_PRICE_DISC_BC2,
    ELEM_UNIT_DISCOUNT,
    ELEM_UNIT_DISCOUNT_BC,
    ELEM_UNIT_DISCOUNT_BC2,
    ELEM_PRICE_DISC,
    ELEM_PRICE_DISC_BC,
    ELEM_PRICE_DISC_BC2,
    ELEM_DISCOUNT,
    ELEM_DISCOUNT_BC,
    ELEM_DISCOUNT_BC2,
    ELEM_EXT_STATUS,
    ELEM_CURR_RATE_BC,
    ELEM_CURR_RATE_BC2,
    ELEM_SENT_DATE,
    ELEM_DELIV_DATE,
    ELEM_RET_DATE,
    ELEM_DELIVER_TO_DEL,
    ELEM_BOM_ID,
    ELEM_DISC_ID,
    ELEM_EXCL_DISCAMT,
    ELEM_DISC_APPLIED_DATE,
    ELEM_BOOK_GROUP,
    ELEM_RECOMMENDED,
    ELEM_MANDATORY,
    ELEM_ST_ELEM_ID,
    ELEM_UNIQUE_REF,
    ELEM_PARTNER_SYS_REF,
    ELEM_QUO_DET_ID,
    ELEM_CERT_EXPY_DATE,
    ELEM_AUTH_PROLE_ID,
    ELEM_AUTH_ASSO_TYPE,
    ELEM_AUTH_CODE,
    ELEM_AUTH_REQ_DATE,
    ELEM_LAST_AUTH_PROLE_ID,
    ELEM_AUTH_LAST_COMMENTS,
    ELEM_PSH_ID,
    ELEM_BLOCK_DEL,
    ELEM_PRS_TYPE,
    ELEM_CANCEL_DATE,
    ELEM_SCORE_1,
    ELEM_SCORE_2,
    ELEM_SCORE_3,
    ELEM_SCORE_4,
    ELEM_SCORE_5,
    ELEM_SCORE_6,
    ELEM_PDPE_ID,
    ELEM_SCO_END_DTE,
    ELEM_LMSP_TOTAL_TIME,
    ELEM_LMSP_LESSON_LOCATION,
    ELEM_LMSP_COMPLETES,
    ELEM_GIFT_AID,
    ELEM_CLAIMED
  from dbo.Element
  where ELEM_PSH_ID = @PA_ELEM_PSH_ID
end
go
