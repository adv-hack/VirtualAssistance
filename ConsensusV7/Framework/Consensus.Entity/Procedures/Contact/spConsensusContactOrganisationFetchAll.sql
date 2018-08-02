if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusContactOrganisationFetchAll')
  exec ('create procedure dbo.spConsensusContactOrganisationFetchAll as select 1 as temp')
go
alter procedure dbo.spConsensusContactOrganisationFetchAll as 
begin
  select 
    ORG_ID,
    ORG_LOCK,
    ORG_ADD_DATE,
    ORG_ADD_BY,
    ORG_MOD_DATE,
    ORG_MOD_BY,
    ORG_RCV_DATE,
    ORG_RCV_FROM,
    ORG_NAME,
    ORG_SHORTNAME,
    ORG_HIERARCHY,
    ORG_PHONE,
    ORG_FAX,
    ORG_TYPE,
    ORG_HIERARCHY_LEVL,
    ORG_HIERARCHY_LAST,
    ORG_NO_EMPLOYEE,
    ORG_NO_TUCMEMBER,
    ORG_TUC_PERCENT,
    ORG_DAILY_HRS,
    ORG_BLOCKRATE_NO,
    ORG_TUC_REGION,
    ORG_MAJOR_UNION,
    ORG_STUDENT_AUTH,
    ORG_UNION_REPORT,
    ORG_BLOCKRATE_FLAG,
    ORG_DONOTMAIL,
    ORG_DISTRIBUTOR,
    ORG_USERCHAR_5,
    ORG_INDUSTRY,
    ORG_AREA,
    ORG_NOTES,
    ORG_SPECIAL_DEAL,
    ORG_ORGCHART,
    ORG_SOURCE,
    ORG_VAT_REF,
    ORG_DISCOUNT,
    ORG_SOUNDEX_KEY,
    ORG_NORM_START,
    ORG_NORM_FINISH,
    ORG_SALES_REVENUE,
    ORG_TURNOVER,
    ORG_SALES_POT,
    ORG_EMPLOYEES,
    ORG_ATTRACTIVE,
    ORG_POTENTIAL,
    ORG_SALES_REV_BC,
    ORG_TURNOVER_BC,
    ORG_SALES_POT_BC,
    ORG_CURRENCY_TYPE,
    ORG_CUSTOMER_ACC,
    ORG_GROUP_ACC,
    ORG_DEPOSIT_ACC,
    ORG_EXEC_CODE,
    ORG_USERCHAR_1,
    ORG_USERCHAR_2,
    ORG_USERCHAR_3,
    ORG_USERCHAR_4,
    ORG_USERNUM_1,
    ORG_USERNUM_2,
    ORG_USERNUM_3,
    ORG_USERNUM_4,
    ORG_ACCMGR1_ID,
    ORG_ACCMGR2_ID,
    ORG_STRATEGIC_ACC,
    ORG_PIC_ID,
    ORG_PARENT,
    ORG_LIST_ID,
    ORG_SPECIAL_TERMS,
    ORG_AKA,
    ORG_HOLD1,
    ORG_HOLD2,
    ORG_URL,
    ORG_USERCHAR_6,
    ORG_USERCHAR_7,
    ORG_USERCHAR_8,
    ORG_USERCHAR_9,
    ORG_USERCHAR_10,
    ORG_COMMENTS,
    ORG_RANK,
    ORG_MATCH_KEY,
    ORG_TERR1_ID,
    ORG_TERR2_ID,
    ORG_TERR3_ID,
    ORG_BAT_ID,
    ORG_USERDATE_1,
    ORG_USERDATE_2,
    ORG_CURRENCY,
    ORG_PAYMENT_DAYS,
    ORG_PAYMENT_TYPE,
    ORG_PAY_TERMS_1,
    ORG_PAY_TERMS_2,
    ORG_PAY_TERMS_3,
    ORG_PAY_TERMS_4,
    ORG_CREDIT_CURR,
    ORG_CREDIT,
    ORG_CREDIT_BC,
    ORG_CREDIT_BC2,
    ORG_EXIST_CLIENT,
    ORG_SIC1,
    ORG_SIC2,
    ORG_SIC3,
    ORG_SIC4,
    ORG_DUNS,
    ORG_STD_CODE,
    ORG_SECURITY,
    ORG_FLAG_1,
    ORG_ACC_STATUS,
    ORG_ALT_NAME_1,
    ORG_ALT_NAME_2,
    ORG_BKT_ID,
    ORG_PL_ID,
    ORG_VAT_CODE,
    ORG_USERCHAR_11,
    ORG_EMAIL,
    ORG_SOURCE_PM_ID,
    ORG_USERCHAR_12,
    ORG_USERCHAR_13,
    ORG_USERCHAR_14,
    ORG_USERCHAR_15,
    ORG_USERDATE_3,
    ORG_USERDATE_4,
    ORG_USERDATE_5,
    ORG_USERNUM_5,
    ORG_USERNUM_6,
    ORG_USERNUM_7,
    ORG_USERNUM_8,
    ORG_USERINT_1,
    ORG_USERINT_2,
    ORG_USERINT_3,
    ORG_USERINT_4,
    ORG_USERINT_5,
    ORG_MEM_C_TOT,
    ORG_MEM_R_TOT,
    ORG_MEM_L_TOT,
    ORG_DONOTFAX,
    ORG_VATCD,
    ORG_CUST_STATUS,
    ORG_DISABLED,
    ORG_USERINT_6,
    ORG_USERDATE_6,
    ORG_OUR_ORG,
    ORG_EXT_KEY,
    ORG_ATTRIB_CHAR_01,
    ORG_ATTRIB_CHAR_02,
    ORG_ATTRIB_CHAR_03,
    ORG_ATTRIB_CHAR_04,
    ORG_ATTRIB_CHAR_05,
    ORG_ATTRIB_DATE_01,
    ORG_TYPE_SUB,
    ORG_PHONE_STD,
    ORG_FAX_STD,
    ORG_IMM_DUNS,
    ORG_IMM_NAME,
    ORG_HQ_DUNS,
    ORG_HQ_NAME,
    ORG_ULTUK_DUNS,
    ORG_ULTUK_NAME,
    ORG_ULT_DUNS,
    ORG_ULT_NAME,
    ORG_MEM_A_TOT,
    ORG_SELCO_SP_ID,
    ORG_AREA2,
    ORG_REGION2,
    ORG_SECTYPE_ID,
    org_sub_region,
    ORG_STATUS,
    ORG_OS_ID,
    ORG_CONFIRMATION,
    ORG_JI,
    ORG_UNIQUE_REF,
    ORG_REF,
    ORG_REF_PASSWORD,
    ORG_VALID_DOMAIN_SUFFIX,
    ORG_SUPP_BKT_ID,
    ORG_DO_NOT_SPARE1,
    ORG_DO_NOT_SPARE2,
    ORG_DO_NOT_SPARE3,
    ORG_DO_NOT_SPARE4,
    ORG_VAT_REG_NUM,
    ORG_REPORT_PASSWORD,
    ORG_REPORT_PATH,
    ORG_REPORT_USERNAME,
    ORG_INV_AUTH_PASSWORD,
    ORG_WEB_ENABLED,
    ORG_PERSON_COUNT,
    ORG_SPEND,
    ORG_ON_HOLD,
    ORG_PSH_ID,
    ORG_PORTAL_CONFIRMATION
  from dbo.Organisation
end
go
