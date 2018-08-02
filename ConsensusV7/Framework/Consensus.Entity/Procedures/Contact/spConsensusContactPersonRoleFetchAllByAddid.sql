if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusContactPersonRoleFetchAllByAddid')
  exec ('create procedure dbo.spConsensusContactPersonRoleFetchAllByAddid as select 1 as temp')
go
alter procedure dbo.spConsensusContactPersonRoleFetchAllByAddid(@PA_PROLE_ADD_ID varchar(11) = null output) as 
begin
  select 
    PROLE_ID,
    PROLE_LOCK,
    PROLE_ADD_DATE,
    PROLE_ADD_BY,
    PROLE_MOD_DATE,
    PROLE_MOD_BY,
    PROLE_RCV_DATE,
    PROLE_RCV_FROM,
    PROLE_PERSON_ID,
    PROLE_ORG_ID,
    PROLE_POS_TITLE,
    PROLE_DEPT,
    PROLE_POS_TYPE,
    PROLE_POS_LEVEL,
    PROLE_PHONE,
    PROLE_FAX,
    PROLE_MOBILE,
    PROLE_EMAIL1,
    PROLE_REPORTS_TO,
    PROLE_SECRETARY,
    PROLE_PRINCIP_ROLE,
    PROLE_DO_NOT_MAIL,
    PROLE_ADD_ID,
    PROLE_START_DATE,
    PROLE_END_DATE,
    PROLE_UNION_ROL_NO,
    PROLE_BRANCH_NAME,
    PROLE_FIRST_COURSE,
    PROLE_TYPE,
    PROLE_ALT_PHONE,
    PROLE_ALT_FAX,
    PROLE_BUDGET,
    PROLE_NL_COPIES,
    PROLE_USER_TYPE,
    PROLE_USER_TYPE_1,
    PROLE_USER_TYPE_2,
    PROLE_USER_TYPE_3,
    PROLE_EXEC_CODE,
    PROLE_USERCHAR_1,
    PROLE_USERCHAR_2,
    PROLE_USERCHAR_3,
    PROLE_USERCHAR_4,
    PROLE_USERNUM_1,
    PROLE_USERNUM_2,
    PROLE_EMAIL,
    PROLE_ORG_NAME,
    PROLE_PN_NAME,
    PROLE_CONTACT_MGR,
    PROLE_SOURCE,
    PROLE_MAIL_LIMIT,
    PROLE_UNTIL,
    PROLE_MAIL_NOLIMIT,
    PROLE_EXT_ID_1,
    PROLE_EXT_ID_2,
    PROLE_EXT_ID_3,
    PROLE_SECRET_PHONE,
    PROLE_NOTES,
    PROLE_LBST_DATE,
    PROLE_POST_SPEC,
    PROLE_SCALE_POINT,
    PROLE_GRADE_BAND,
    PROLE_DIS_FLAG,
    PROLE_WEB_PROF,
    PROLE_WEB_PASS,
    PROLE_CUSTOMER_ACC,
    PROLE_CJT_ID,
    PROLE_PAYROLL,
    PROLE_STAFF_NO,
    PROLE_COST_CENTRE,
    PROLE_KEY_CONTACT,
    PROLE_MEM_C_TOT,
    PROLE_MEM_R_TOT,
    PROLE_MEM_L_TOT,
    PROLE_CONTACT_MGR2,
    PROLE_USERCHAR_5,
    PROLE_USERCHAR_6,
    PROLE_USERINT_1,
    PROLE_USERINT_2,
    PROLE_USERINT_3,
    PROLE_USERINT_4,
    PROLE_USERINT_5,
    PROLE_USERINT_6,
    PROLE_USERNUM_3,
    PROLE_USERNUM_4,
    PROLE_USERNUM_5,
    PROLE_USERNUM_6,
    PROLE_USERDATE_1,
    PROLE_USERDATE_2,
    PROLE_USERDATE_3,
    PROLE_USERDATE_4,
    PROLE_USERDATE_5,
    PROLE_USERDATE_6,
    PROLE_DO_NOT_FAX,
    PROLE_DO_NOT_EMAIL,
    PROLE_DO_NOT_SWAP,
    PROLE_DO_NOT_SPARE,
    PROLE_PRIVATE_ADD,
    PROLE_COST_CODE,
    PROLE_MAIN_WORKADD,
    PROLE_MAIN_PRIVADD,
    PROLE_WORK_ADD,
    PROLE_LM_PHONE,
    PROLE_LM_EMAIL,
    PROLE_SERVICE,
    PROLE_PAY_LOCATION,
    PROLE_BA,
    PROLE_BA1,
    PROLE_TRN_ADMIN,
    PROLE_ATTRIB_NUM_01,
    PROLE_ATTRIB_CHAR_01,
    PROLE_ATTRIB_TINT_01,
    PROLE_WTE,
    PROLE_PHONE_STD,
    PROLE_FAX_STD,
    PROLE_ALT_PHONE_STD,
    PROLE_ALT_FAX_STD,
    PROLE_SECRET_PHONE_STD,
    PROLE_LM_PHONE_STD,
    PROLE_DELIV_POINT1,
    PROLE_DELIV_POINT2,
    PROLE_SHOW_ADDRESS,
    PROLE_SHOW_PHONE,
    PROLE_SHOW_EMAIL,
    PROLE_MEM_A_TOT,
    PROLE_SELCO_SP_ID,
    PROLE_CJT_ACHIEVED,
    PROLE_MEM_REF,
    PROLE_HOUR_RTE,
    PROLE_BUDH_ID,
    PROLE_OS_ID,
    PROLE_JOB_LVL,
    PROLE_REPORTS_TO_1,
    PROLE_OSU_ID,
    PROLE_AJT_ID,
    PROLE_UNIQUE_REF,
    PROLE_SEND_TO_WHICH_EMAIL,
    PROLE_REPTO_LINEAGE,
    PROLE_REPTO_DEPTH,
    PROLE_MEMB_CHECK_1,
    PROLE_MEMB_CHECK_2,
    PROLE_MEMB_CHECK_3,
    PROLE_MEMB_CHECK_4,
    PROLE_MEMB_CHECK_5,
    PROLE_MEMB_CHECK_6,
    PROLE_MEMB_CHECK_7,
    PROLE_USERINT_7,
    PROLE_USERINT_8,
    PROLE_USERINT_9,
    PROLE_USERINT_10,
    PROLE_USERINT_11,
    PROLE_OVERSEAS,
    PROLE_SEND_TO_WHICH_MOBILE,
    PROLE_DO_NOT_SPARE1,
    PROLE_DO_NOT_SPARE2,
    PROLE_DO_NOT_SPARE3,
    PROLE_DO_NOT_SPARE4,
    PROLE_AREA,
    PROLE_REGION,
    PROLE_PROFILE_DESCRIPTION,
    PROLE_DEFAULT_PR_ID
  from dbo.Person_Role
  where PROLE_ADD_ID = @PA_PROLE_ADD_ID
end
go
