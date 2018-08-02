if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityStuserFetchAll')
  exec ('create procedure dbo.spConsensusSecurityStuserFetchAll as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityStuserFetchAll as 
begin
  select 
    USER_ID,
    USER_LOCK,
    USER_ADD_DATE,
    USER_ADD_BY,
    USER_MOD_DATE,
    USER_MOD_BY,
    USER_RCV_DATE,
    USER_RCV_FROM,
    USER_LOGIN_ID,
    USER_PERSON_ID,
    USER_PASSWORD,
    USER_FUNCTION,
    USER_HOME_SERVER,
    USER_LANGUAGE,
    USER_COUNTRY,
    USER_TUC_REGION,
    USER_BARRED,
    USER_DELETE,
    USER_SYSTEM,
    USER_REMOTE_USER,
    USER_UNION_USER,
    USER_COLLEGE_USER,
    USER_DIARY,
    USER_SALES_OPS,
    USER_QUOTES,
    USER_INVOICE,
    USER_ORDER_PROC,
    USER_REPORTS,
    USER_PROFILES,
    USER_TRAINING,
    USER_MARKETING,
    USER_SYLLABUS,
    USER_COURSES,
    USER_BOOKINGS,
    USER_MAILINGS,
    USER_ORGANISATIONS,
    USER_PERSONS,
    USER_CAMPAIGNS,
    USER_PROMOTIONS,
    USER_DATE_FORMAT,
    USER_TIME_FORMAT,
    USER_NUMBER_FORMAT,
    USER_QUOTES_APP,
    USER_WORD_PATH,
    USER_CCPATH,
    USER_CCUSER,
    USER_INSTALLATIONS,
    USER_PRINT,
    USER_ADD_CONT_STYL,
    USER_ACCOUNTS,
    USER_SALES,
    USER_SALES_APP,
    USER_SALES_PRINT,
    USER_DIRECT_TO_PRN,
    USER_TELESALES,
    USER_PROM_MASTER,
    USER_EXCEL_PATH,
    USER_NT_USER_NAME,
    USER_WEB_PROFILE,
    USER_WEB_PROFILE2,
    USER_SALESMAN,
    USER_SCHED_NAME,
    USER_PROG_TYPE,
    USER_FLOATING,
    USER_TIME_CONNECT,
    USER_CUSTOMISATION,
    USER_WORD,
    USER_WORD_DOC,
    USER_WORD_DOT,
    USER_WORD_DOT2,
    USER_MASTER,
    USER_GROUP,
    USER_REPORT_LEVEL,
    USER_QUEUE_NAME,
    USER_OFFICE,
    USER_SECURITY,
    USER_OUTPUT,
    USER_APPRV_VAL_1,
    USER_APPRV_VAL_2,
    USER_WEB_PAGE,
    USER_WEB_MENU,
    USER_MAX_SESSION,
    USER_LONG_LOGIN_ID,
    USER_LOGIN_COUNT,
    USER_READ,
    USER_CREATE,
    USER_UPDATE,
    USER_DELETIONS,
    USER_SELCO_SP_ID,
    USER_TTD_REFRESH,
    USER_DEF_SEARCH,
    USER_EDIT_EVENT_REF,
    USER_PERSON_PREF,
    USER_BOOK_PREF,
    USER_PERM_NOTES,
    USER_SIT_ID,
    USER_ALL_SELCOS,
    USER_DEF_RANDS_REGION,
    USER_PASSWORD_MOD_DATE,
    USER_RESET_PASSWORD,
    USER_LOGIN_DATE,
    USER_PWDP_ID,
    USER_DEF_ACCORDION,
    USER_EXPORT_SEARCH
  from dbo.STUser
end
go
