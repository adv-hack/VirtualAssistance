if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusLearningDelegateFetchById')
  exec ('create procedure dbo.spConsensusLearningDelegateFetchById as select 1 as temp')
go
alter procedure dbo.spConsensusLearningDelegateFetchById(@PA_DEL_ID varchar(11) = null output) as 
begin
  select 
    DEL_ID,
    DEL_LOCK,
    DEL_ADD_DATE,
    DEL_ADD_BY,
    DEL_MOD_DATE,
    DEL_MOD_BY,
    DEL_RCV_DATE,
    DEL_RCV_FROM,
    DEL_LINE_NO,
    DEL_BOOK_ID,
    DEL_PRODUCT_ID,
    DEL_ORG_ID,
    DEL_PERSON_ID,
    DEL_QUANTITY,
    DEL_LIST_PRICE,
    DEL_DISCOUNT,
    DEL_DISCTD_PRICE,
    DEL_NET_VAL,
    DEL_VAT_CODE,
    DEL_VAT_RATE,
    DEL_VAT_AMT,
    DEL_TOT_PRICE,
    DEL_UNION_ID,
    DEL_TUC_REGION,
    DEL_BOOK_APPROVED,
    DEL_BOOK_APPR_BY,
    DEL_BOOK_APPR_DATE,
    DEL_PACK,
    DEL_USERINT_1,
    DEL_USERINT_2,
    DEL_USERINT_3,
    DEL_USERINT_4,
    DEL_USERINT_5,
    DEL_USERINT_6,
    DEL_USERINT_7,
    DEL_USERINT_8,
    DEL_USERINT_9,
    DEL_USERINT_10,
    DEL_PROLE_ID,
    DEL_NOTES_ID,
    DEL_WAIT_STATUS,
    DEL_NOTES,
    DEL_TIME_MVD_CUST,
    DEL_CANCEL_DATE,
    DEL_CANCEL_BY,
    DEL_REMIND_METHOD,
    DEL_REMIND_DATE,
    DEL_REMIND_BY,
    DEL_CONFIRM_METHOD,
    DEL_CONFIRM_DATE,
    DEL_CONFIRM_BY,
    DEL_DELIV_ADDRESS,
    DEL_DEL_ID,
    DEL_USERCHAR_1,
    DEL_SUB_DEL_ID,
    DEL_PAY,
    DEL_PAY2,
    DEL_TRN_ID,
    DEL_COURSE_ID,
    DEL_BUD_VAL,
    DEL_BUDC_ID,
    DEL_BUD_COST_ID,
    DEL_WAIT_PROD_ID,
    DEL_WAIT_DATE,
    DEL_TEAM,
    DEL_SPEC_REQ,
    DEL_BAT_ID,
    DEL_BADGE_NAME,
    DEL_TOT_TKT_PNTS,
    DEL_TCK_DEL_ID,
    DEL_COURSE_NAME,
    DEL_COURSE_ST_DATE,
    DEL_PASS,
    DEL_MEP_ID,
    DEL_PRICE_CALC,
    DEL_DEPOS_VAL,
    DEL_DEPOS_VAL_BC,
    DEL_DEPOS_VAL_BC2,
    DEL_ALT_PHONE,
    DEL_ATTRIB01,
    DEL_ATTRIB02,
    DEL_ATTRIB03,
    DEL_ATTRIB04,
    DEL_ATTRIB05,
    DEL_ATTRIB06,
    DEL_ATTRIB07,
    DEL_ATTRIB08,
    DEL_ATTRIB09,
    DEL_ATTRIB10,
    DEL_ATTRIB11,
    DEL_DEPOS_UNPAID,
    DEL_DEPOS_UNPAID_BC,
    DEL_DEPOS_UNPAID_BC2,
    DEL_START_DATE,
    DEL_END_DATE,
    DEL_DONOT_REPRICE,
    DEL_DD_PAYMENT_STAT,
    DEL_CANC_REASON,
    DEL_DEPOS_CHG_REASON,
    DEL_DOC_RECIPIENT,
    DEL_ATTRIB12,
    DEL_NOTES2,
    DEL_DOC_RECIPIENT_EMAIL,
    DEL_ETT_ID,
    DEL_TRANSFER_COUNT,
    DEL_SUBSTITUTE_COUNT,
    DEL_TRANSFER_DEL_ID,
    DEL_DIET_REQUIRE,
    DEL_ATTRIB13,
    DEL_SURNAME,
    DEL_INITIAL,
    DEL_MEM_REF,
    DEL_ADD_POSTCODE,
    DEL_ADD_ID,
    DEL_WAIT_PRIORITY,
    DEL_TBA_GENDER,
    DEL_TBA_NATIONALITY,
    DEL_TBA_ETHNICITY,
    DEL_CANCEL_REF,
    DEL_SHARE_DETAILS,
    DEL_AUTH_STATUS,
    DEL_MEDICAL_DET,
    DEL_DELIV_COUNTRY_ID,
    DEL_DELIV_FAO,
    DEL_DELIV_PHONE,
    DEL_SELCO_SP_ID,
    DEL_USERCHAR_2,
    DEL_EXCL_TOKEN,
    DEL_FIRST_NAME,
    DEL_NI_NUMBER,
    DEL_UNIQUE_REF
  from dbo.Delegate
  where DEL_ID = @PA_DEL_ID
end
go
