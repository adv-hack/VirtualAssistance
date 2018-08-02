if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusActivitiesActivityCreate')
  exec ('create procedure dbo.spConsensusActivitiesActivityCreate as select 1 as temp')
go
alter procedure dbo.spConsensusActivitiesActivityCreate(@PA_ACT_ID varchar(11) = null output, @PA_ACT_LOCK varchar(10) = null output, @PA_ACT_TYPE varchar(40) = null output, @PA_ACT_DONE_IT tinyint = null output, @PA_ACT_KEY_NOTE varchar(30) = null output, @PA_ACT_ACTION_DATE datetime = null output, @PA_ACT_TIME datetime = null output, @PA_ACT_NEXT_DATE datetime = null output, @PA_ACT_END_DATE datetime = null output, @PA_ACT_END_TIME datetime = null output, @PA_ACT_LOC_ID varchar(11) = null output, @PA_ACT_RESULT varchar(100) = null output, @PA_ACT_PREV_ACTIV varchar(11) = null output, @PA_ACT_PROMOTION_ID varchar(11) = null output, @PA_ACT_BOOK_ID varchar(11) = null output, @PA_ACT_COURSE_ID varchar(11) = null output, @PA_ACT_TRAINER_ID varchar(11) = null output, @PA_ACT_TEXT_ID varchar(11) = null output, @PA_ACT_NOTE varchar(max) = null output, @PA_ACT_DONE_IT_DATE datetime = null output, @PA_ACT_SOURCE_CODE varchar(15) = null output, @PA_ACT_LAST_NO varchar(11) = null output, @PA_ACT_HIERARCHY varchar(100) = null output, @PA_ACT_LEVEL varchar(10) = null output, @PA_ACT_INITIATED_BY float = null output, @PA_ACT_MAN_ISSUES varchar(25) = null output, @PA_ACT_VISIT_OBJ varchar(25) = null output, @PA_ACT_CB_1 float = null output, @PA_ACT_CB_2 float = null output, @PA_ACT_CB_3 float = null output, @PA_ACT_CB_4 float = null output, @PA_ACT_CB_5 float = null output, @PA_ACT_CB_6 float = null output, @PA_ACT_CB_7 float = null output, @PA_ACT_CB_8 float = null output, @PA_ACT_CB_9 float = null output, @PA_ACT_CB_10 float = null output, @PA_ACT_OPP_ID varchar(11) = null output, @PA_ACT_HELP_TYPE varchar(40) = null output, @PA_ACT_PRODUCT_CODE varchar(40) = null output, @PA_ACT_PRODUCT_GROUP varchar(40) = null output, @PA_ACT_PIC_ID varchar(11) = null output, @PA_ACT_CLOS_CAT varchar(15) = null output, @PA_ACT_CLOS_DATA varchar(30) = null output, @PA_ACT_SOURCE varchar(20) = null output, @PA_ACT_SUBJECT varchar(200) = null output, @PA_ACT_SUB_TEXT varchar(50) = null output, @PA_ACT_SERVICE_TYPE varchar(30) = null output, @PA_ACT_PROBLEM_CAT varchar(1) = null output, @PA_ACT_IN_ID varchar(11) = null output, @PA_ACT_INVOICED tinyint = null output, @PA_ACT_SUP_CONT_REF varchar(40) = null output, @PA_ACT_CHARGE_TYPE varchar(30) = null output, @PA_ACT_MINUTES integer = null output, @PA_ACT_VALUE float = null output, @PA_ACT_VALUE_BC float = null output, @PA_ACT_CURRENCY_TYPE varchar(3) = null output, @PA_ACT_SCHEME_ID varchar(11) = null output, @PA_ACT_NXT_STAGE varchar(22) = null output, @PA_ACT_NXT_STGE_DATE datetime = null output, @PA_ACT_ALARMDATE datetime = null output, @PA_ACT_ALARMTIME datetime = null output, @PA_ACT_SYLLABUS_ID varchar(11) = null output, @PA_ACT_SESSION_NAME nvarchar(250) = null output, @PA_ACT_RESOURCE_ID varchar(11) = null output, @PA_ACT_REAL tinyint = null output, @PA_ACT_ELEMENT tinyint = null output, @PA_ACT_MANDATORY tinyint = null output, @PA_ACT_INVOICE_PRINT tinyint = null output, @PA_ACT_MAX_PLACES float = null output, @PA_ACT_MIN_PLACES float = null output, @PA_ACT_FREE_PLACES float = null output, @PA_ACT_PRICE float = null output, @PA_ACT_BLOCK_PRICE float = null output, @PA_ACT_PRICE_BC float = null output, @PA_ACT_BLOCK_PRICE_BC float = null output, @PA_ACT_VATCD varchar(25) = null output, @PA_ACT_REV_CODE varchar(40) = null output, @PA_ACT_COST_CODE varchar(40) = null output, @PA_ACT_DO_NOT_INVOICE tinyint = null output, @PA_ACT_FROM_BOM_TYPE varchar(20) = null output, @PA_ACT_ROOM_GRADE varchar(25) = null output, @PA_ACT_TASK_NAME varchar(50) = null output, @PA_ACT_TASK_STATUS varchar(25) = null output, @PA_ACT_EST_HOURS float = null output, @PA_ACT_ACTUAL_HOURS float = null output, @PA_ACT_USERNUM_1 float = null output, @PA_ACT_USERNUM_2 float = null output, @PA_ACT_USERNUM_3 float = null output, @PA_ACT_REVIEW_DATE datetime = null output, @PA_ACT_REVIEW_TIME datetime = null output, @PA_ACT_PROJ_ID varchar(11) = null output, @PA_ACT_FILE_PATH varchar(100) = null output, @PA_ACT_BIP float = null output, @PA_ACT_PART_NOTE varchar(255) = null output, @PA_ACT_PERIOD varchar(8) = null output, @PA_ACT_OVERBOOK float = null output, @PA_ACT_SESSION_NAME2 varchar(80) = null output, @PA_ACT_ORG_ID varchar(11) = null output, @PA_ACT_ADDRESS nvarchar(255) = null output, @PA_ACT_PQ_ID varchar(11) = null output, @PA_ACT_PQ_STATUS varchar(50) = null output, @PA_ACT_PQ_STATUS_TEXT varchar(4000) = null output, @PA_ACT_PQ_SEND_TYPE varchar(40) = null output, @PA_ACT_PQ_SENT_DATE datetime = null output, @PA_ACT_PQ_KEEP tinyint = null output, @PA_ACT_MEP_ID varchar(11) = null output, @PA_ACT_TYPE_SUB varchar(20) = null output, @PA_ACT_AUTO_ALLOCATE tinyint = null output, @PA_ACT_WF_ID varchar(11) = null output, @PA_ACT_EVR_INC_TOT tinyint = null output, @PA_ACT_EVR_INC_QUO tinyint = null output, @PA_ACT_ADD_ID varchar(11) = null output, @PA_ACT_ATTENDEES varchar(1000) = null output, @PA_ACT_CEN_ID varchar(11) = null output, @PA_ACT_ROOM_LAYOUT integer = null output, @PA_ACT_NOTE_HTML varchar(max) = null output, @PA_ACT_LAYOUT tinyint = null output, @PA_ACT_PLACES_TO_SET integer = null output, @PA_ACT_PROD_ID varchar(11) = null output, @PA_ACT_STAFF_NEEDED tinyint = null output, @PA_ACT_TIME_PREP float = null output, @PA_ACT_TIME_CLEAN float = null output, @PA_ACT_TRN_ID varchar(11) = null output, @PA_ACT_PRIORITY varchar(50) = null output, @PA_ACT_FLOAT tinyint = null output, @PA_ACT_ALLOC_STATUS tinyint = null output, @PA_ACT_DEPT_ID varchar(11) = null output, @PA_ACT_ROOM_BOOKING tinyint = null output, @PA_ACT_CONTPROL_ID varchar(11) = null output, @PA_ACT_RES_TYPE varchar(40) = null output, @PA_ACT_DURATION float = null output, @PA_ACT_PD_ID varchar(11) = null output, @PA_ACT_SELCO_SP_ID varchar(11) = null output, @PA_ACT_INC_IN_BUDGET tinyint = null output, @PA_ACT_VER_CAT varchar(50) = null output, @PA_ACT_PDPEMP_ID integer = null output, @PA_ACT_APP_BY varchar(3) = null output, @PA_ACT_APP_DATE datetime = null output, @PA_ACT_NEXT_REVIEW datetime = null output, @PA_ACT_INV_ID varchar(11) = null output, @PA_ACT_CODE varchar(11) = null output, @PA_ACT_SESSION_TYPE varchar(40) = null output, @PA_ACT_TEACH_HRS decimal(19, 2) = null output, @PA_ACT_STUD_WKS decimal(19, 2) = null output, @PA_ACT_NOTINUSE_START datetime = null output, @PA_ACT_NOTINUSE_END datetime = null output, @PA_ACT_CONF_SESSION_ORDER integer = null output, @PA_ACT_ADDED_BY tinyint = null output, @PA_ACT_OUTLOOK_UID varchar(255) = null output, @PA_ACT_UNIQUE_REF varchar(50) = null output, @PA_ACT_NO_SLOTS integer = null output, @PA_ACT_CANCELLED tinyint = null output, @PA_ACT_DELETE tinyint = null output, @PA_ACT_BOM_ID varchar(11) = null output, @PA_ACT_STATUS varchar(40) = null output, @PA_ACT_OUTCOME varchar(40) = null output, @PA_ACT_QUEST_ID varchar(11) = null output, @PA_ACT_BUILD_VERSION varchar(20) = null output, @PA_ACT_LOCKED_DATE datetime = null output, @PA_ACT_TIMEOUT datetime = null output, @PA_ACT_CG_CODE varchar(5) = null output, @PA_ACT_PROV_PACK varchar(11) = null output, @PA_ACT_CONF_PACK varchar(11) = null output, @PA_ACT_JOINING_PACK varchar(11) = null output, @PA_ACT_POST_PACK varchar(11) = null output, @PA_ACT_PREJOIN_PACK varchar(11) = null output, @PA_ACT_PSTJOIN_PACK varchar(11) = null output, @PA_ACT_PROV_SENT_DTE datetime = null output, @PA_ACT_CONF_SENT_DTE datetime = null output, @PA_ACT_JOIN_SENT_DTE datetime = null output, @PA_ACT_PP_SENT_DTE datetime = null output, @PA_ACT_PRJOIN_SENT_DTE datetime = null output, @PA_ACT_POJOIN_SENT_DTE datetime = null output, @PA_ACT_DROPDOWN_1 varchar(25) = null output, @PA_ACT_DROPDOWN_2 varchar(25) = null output, @PA_ACT_REVENUE_SPLIT float = null output, @PA_ACT_HOURS_SPLIT float = null output, @PA_ACT_ARRIVED tinyint = null output, @PA_ACT_EXP_OCCUPANCY integer = null output, @PA_ACT_RESERVE tinyint = null output, @PA_ACT_VISIT_OUTCOME varchar(50) = null output, @PA_ACT_TRNP_ID integer = null output, @PA_ACT_SHOW_ATT_LOG tinyint = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.Activity(
    ACT_ADD_DATE,
    ACT_ADD_BY,
    ACT_MOD_DATE,
    ACT_MOD_BY,
    ACT_RCV_DATE,
    ACT_RCV_FROM,
    ACT_LOCK,
    ACT_TYPE,
    ACT_DONE_IT,
    ACT_KEY_NOTE,
    ACT_ACTION_DATE,
    ACT_TIME,
    ACT_NEXT_DATE,
    ACT_END_DATE,
    ACT_END_TIME,
    ACT_LOC_ID,
    ACT_RESULT,
    ACT_PREV_ACTIV,
    ACT_PROMOTION_ID,
    ACT_BOOK_ID,
    ACT_COURSE_ID,
    ACT_TRAINER_ID,
    ACT_TEXT_ID,
    ACT_NOTE,
    ACT_DONE_IT_DATE,
    ACT_SOURCE_CODE,
    ACT_LAST_NO,
    ACT_HIERARCHY,
    ACT_LEVEL,
    ACT_INITIATED_BY,
    ACT_MAN_ISSUES,
    ACT_VISIT_OBJ,
    ACT_CB_1,
    ACT_CB_2,
    ACT_CB_3,
    ACT_CB_4,
    ACT_CB_5,
    ACT_CB_6,
    ACT_CB_7,
    ACT_CB_8,
    ACT_CB_9,
    ACT_CB_10,
    ACT_OPP_ID,
    ACT_HELP_TYPE,
    ACT_PRODUCT_CODE,
    ACT_PRODUCT_GROUP,
    ACT_PIC_ID,
    ACT_CLOS_CAT,
    ACT_CLOS_DATA,
    ACT_SOURCE,
    ACT_SUBJECT,
    ACT_SUB_TEXT,
    ACT_SERVICE_TYPE,
    ACT_PROBLEM_CAT,
    ACT_IN_ID,
    ACT_INVOICED,
    ACT_SUP_CONT_REF,
    ACT_CHARGE_TYPE,
    ACT_MINUTES,
    ACT_VALUE,
    ACT_VALUE_BC,
    ACT_CURRENCY_TYPE,
    ACT_SCHEME_ID,
    ACT_NXT_STAGE,
    ACT_NXT_STGE_DATE,
    ACT_ALARMDATE,
    ACT_ALARMTIME,
    ACT_SYLLABUS_ID,
    ACT_SESSION_NAME,
    ACT_RESOURCE_ID,
    ACT_REAL,
    ACT_ELEMENT,
    ACT_MANDATORY,
    ACT_INVOICE_PRINT,
    ACT_MAX_PLACES,
    ACT_MIN_PLACES,
    ACT_FREE_PLACES,
    ACT_PRICE,
    ACT_BLOCK_PRICE,
    ACT_PRICE_BC,
    ACT_BLOCK_PRICE_BC,
    ACT_VATCD,
    ACT_REV_CODE,
    ACT_COST_CODE,
    ACT_DO_NOT_INVOICE,
    ACT_FROM_BOM_TYPE,
    ACT_ROOM_GRADE,
    ACT_TASK_NAME,
    ACT_TASK_STATUS,
    ACT_EST_HOURS,
    ACT_ACTUAL_HOURS,
    ACT_USERNUM_1,
    ACT_USERNUM_2,
    ACT_USERNUM_3,
    ACT_REVIEW_DATE,
    ACT_REVIEW_TIME,
    ACT_PROJ_ID,
    ACT_FILE_PATH,
    ACT_BIP,
    ACT_PART_NOTE,
    ACT_PERIOD,
    ACT_OVERBOOK,
    ACT_SESSION_NAME2,
    ACT_ORG_ID,
    ACT_ADDRESS,
    ACT_PQ_ID,
    ACT_PQ_STATUS,
    ACT_PQ_STATUS_TEXT,
    ACT_PQ_SEND_TYPE,
    ACT_PQ_SENT_DATE,
    ACT_PQ_KEEP,
    ACT_MEP_ID,
    ACT_TYPE_SUB,
    ACT_AUTO_ALLOCATE,
    ACT_WF_ID,
    ACT_EVR_INC_TOT,
    ACT_EVR_INC_QUO,
    ACT_ADD_ID,
    ACT_ATTENDEES,
    ACT_CEN_ID,
    ACT_ROOM_LAYOUT,
    ACT_NOTE_HTML,
    ACT_LAYOUT,
    ACT_PLACES_TO_SET,
    ACT_PROD_ID,
    ACT_STAFF_NEEDED,
    ACT_TIME_PREP,
    ACT_TIME_CLEAN,
    ACT_TRN_ID,
    ACT_PRIORITY,
    ACT_FLOAT,
    ACT_ALLOC_STATUS,
    ACT_DEPT_ID,
    ACT_ROOM_BOOKING,
    ACT_CONTPROL_ID,
    ACT_RES_TYPE,
    ACT_DURATION,
    ACT_PD_ID,
    ACT_SELCO_SP_ID,
    ACT_INC_IN_BUDGET,
    ACT_VER_CAT,
    ACT_PDPEMP_ID,
    ACT_APP_BY,
    ACT_APP_DATE,
    ACT_NEXT_REVIEW,
    ACT_INV_ID,
    ACT_CODE,
    ACT_SESSION_TYPE,
    ACT_TEACH_HRS,
    ACT_STUD_WKS,
    ACT_NOTINUSE_START,
    ACT_NOTINUSE_END,
    ACT_CONF_SESSION_ORDER,
    ACT_ADDED_BY,
    ACT_OUTLOOK_UID,
    ACT_UNIQUE_REF,
    ACT_NO_SLOTS,
    ACT_CANCELLED,
    ACT_DELETE,
    ACT_BOM_ID,
    ACT_STATUS,
    ACT_OUTCOME,
    ACT_QUEST_ID,
    ACT_BUILD_VERSION,
    ACT_LOCKED_DATE,
    ACT_TIMEOUT,
    ACT_CG_CODE,
    ACT_PROV_PACK,
    ACT_CONF_PACK,
    ACT_JOINING_PACK,
    ACT_POST_PACK,
    ACT_PREJOIN_PACK,
    ACT_PSTJOIN_PACK,
    ACT_PROV_SENT_DTE,
    ACT_CONF_SENT_DTE,
    ACT_JOIN_SENT_DTE,
    ACT_PP_SENT_DTE,
    ACT_PRJOIN_SENT_DTE,
    ACT_POJOIN_SENT_DTE,
    ACT_DROPDOWN_1,
    ACT_DROPDOWN_2,
    ACT_REVENUE_SPLIT,
    ACT_HOURS_SPLIT,
    ACT_ARRIVED,
    ACT_EXP_OCCUPANCY,
    ACT_RESERVE,
    ACT_VISIT_OUTCOME,
    ACT_TRNP_ID,
    ACT_SHOW_ATT_LOG
  ) values (
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    '',
    @PA_ACT_LOCK,
    @PA_ACT_TYPE,
    @PA_ACT_DONE_IT,
    @PA_ACT_KEY_NOTE,
    @PA_ACT_ACTION_DATE,
    @PA_ACT_TIME,
    @PA_ACT_NEXT_DATE,
    @PA_ACT_END_DATE,
    @PA_ACT_END_TIME,
    @PA_ACT_LOC_ID,
    @PA_ACT_RESULT,
    @PA_ACT_PREV_ACTIV,
    @PA_ACT_PROMOTION_ID,
    @PA_ACT_BOOK_ID,
    @PA_ACT_COURSE_ID,
    @PA_ACT_TRAINER_ID,
    @PA_ACT_TEXT_ID,
    @PA_ACT_NOTE,
    @PA_ACT_DONE_IT_DATE,
    @PA_ACT_SOURCE_CODE,
    @PA_ACT_LAST_NO,
    @PA_ACT_HIERARCHY,
    @PA_ACT_LEVEL,
    @PA_ACT_INITIATED_BY,
    @PA_ACT_MAN_ISSUES,
    @PA_ACT_VISIT_OBJ,
    @PA_ACT_CB_1,
    @PA_ACT_CB_2,
    @PA_ACT_CB_3,
    @PA_ACT_CB_4,
    @PA_ACT_CB_5,
    @PA_ACT_CB_6,
    @PA_ACT_CB_7,
    @PA_ACT_CB_8,
    @PA_ACT_CB_9,
    @PA_ACT_CB_10,
    @PA_ACT_OPP_ID,
    @PA_ACT_HELP_TYPE,
    @PA_ACT_PRODUCT_CODE,
    @PA_ACT_PRODUCT_GROUP,
    @PA_ACT_PIC_ID,
    @PA_ACT_CLOS_CAT,
    @PA_ACT_CLOS_DATA,
    @PA_ACT_SOURCE,
    @PA_ACT_SUBJECT,
    @PA_ACT_SUB_TEXT,
    @PA_ACT_SERVICE_TYPE,
    @PA_ACT_PROBLEM_CAT,
    @PA_ACT_IN_ID,
    @PA_ACT_INVOICED,
    @PA_ACT_SUP_CONT_REF,
    @PA_ACT_CHARGE_TYPE,
    @PA_ACT_MINUTES,
    @PA_ACT_VALUE,
    @PA_ACT_VALUE_BC,
    @PA_ACT_CURRENCY_TYPE,
    @PA_ACT_SCHEME_ID,
    @PA_ACT_NXT_STAGE,
    @PA_ACT_NXT_STGE_DATE,
    @PA_ACT_ALARMDATE,
    @PA_ACT_ALARMTIME,
    @PA_ACT_SYLLABUS_ID,
    @PA_ACT_SESSION_NAME,
    @PA_ACT_RESOURCE_ID,
    @PA_ACT_REAL,
    @PA_ACT_ELEMENT,
    @PA_ACT_MANDATORY,
    @PA_ACT_INVOICE_PRINT,
    @PA_ACT_MAX_PLACES,
    @PA_ACT_MIN_PLACES,
    @PA_ACT_FREE_PLACES,
    @PA_ACT_PRICE,
    @PA_ACT_BLOCK_PRICE,
    @PA_ACT_PRICE_BC,
    @PA_ACT_BLOCK_PRICE_BC,
    @PA_ACT_VATCD,
    @PA_ACT_REV_CODE,
    @PA_ACT_COST_CODE,
    @PA_ACT_DO_NOT_INVOICE,
    @PA_ACT_FROM_BOM_TYPE,
    @PA_ACT_ROOM_GRADE,
    @PA_ACT_TASK_NAME,
    @PA_ACT_TASK_STATUS,
    @PA_ACT_EST_HOURS,
    @PA_ACT_ACTUAL_HOURS,
    @PA_ACT_USERNUM_1,
    @PA_ACT_USERNUM_2,
    @PA_ACT_USERNUM_3,
    @PA_ACT_REVIEW_DATE,
    @PA_ACT_REVIEW_TIME,
    @PA_ACT_PROJ_ID,
    @PA_ACT_FILE_PATH,
    @PA_ACT_BIP,
    @PA_ACT_PART_NOTE,
    @PA_ACT_PERIOD,
    @PA_ACT_OVERBOOK,
    @PA_ACT_SESSION_NAME2,
    @PA_ACT_ORG_ID,
    @PA_ACT_ADDRESS,
    @PA_ACT_PQ_ID,
    @PA_ACT_PQ_STATUS,
    @PA_ACT_PQ_STATUS_TEXT,
    @PA_ACT_PQ_SEND_TYPE,
    @PA_ACT_PQ_SENT_DATE,
    @PA_ACT_PQ_KEEP,
    @PA_ACT_MEP_ID,
    @PA_ACT_TYPE_SUB,
    @PA_ACT_AUTO_ALLOCATE,
    @PA_ACT_WF_ID,
    @PA_ACT_EVR_INC_TOT,
    @PA_ACT_EVR_INC_QUO,
    @PA_ACT_ADD_ID,
    @PA_ACT_ATTENDEES,
    @PA_ACT_CEN_ID,
    @PA_ACT_ROOM_LAYOUT,
    @PA_ACT_NOTE_HTML,
    @PA_ACT_LAYOUT,
    @PA_ACT_PLACES_TO_SET,
    @PA_ACT_PROD_ID,
    @PA_ACT_STAFF_NEEDED,
    @PA_ACT_TIME_PREP,
    @PA_ACT_TIME_CLEAN,
    @PA_ACT_TRN_ID,
    @PA_ACT_PRIORITY,
    @PA_ACT_FLOAT,
    @PA_ACT_ALLOC_STATUS,
    @PA_ACT_DEPT_ID,
    @PA_ACT_ROOM_BOOKING,
    @PA_ACT_CONTPROL_ID,
    @PA_ACT_RES_TYPE,
    @PA_ACT_DURATION,
    @PA_ACT_PD_ID,
    @PA_ACT_SELCO_SP_ID,
    @PA_ACT_INC_IN_BUDGET,
    @PA_ACT_VER_CAT,
    @PA_ACT_PDPEMP_ID,
    @PA_ACT_APP_BY,
    @PA_ACT_APP_DATE,
    @PA_ACT_NEXT_REVIEW,
    @PA_ACT_INV_ID,
    @PA_ACT_CODE,
    @PA_ACT_SESSION_TYPE,
    @PA_ACT_TEACH_HRS,
    @PA_ACT_STUD_WKS,
    @PA_ACT_NOTINUSE_START,
    @PA_ACT_NOTINUSE_END,
    @PA_ACT_CONF_SESSION_ORDER,
    @PA_ACT_ADDED_BY,
    @PA_ACT_OUTLOOK_UID,
    @PA_ACT_UNIQUE_REF,
    @PA_ACT_NO_SLOTS,
    @PA_ACT_CANCELLED,
    @PA_ACT_DELETE,
    @PA_ACT_BOM_ID,
    @PA_ACT_STATUS,
    @PA_ACT_OUTCOME,
    @PA_ACT_QUEST_ID,
    @PA_ACT_BUILD_VERSION,
    @PA_ACT_LOCKED_DATE,
    @PA_ACT_TIMEOUT,
    @PA_ACT_CG_CODE,
    @PA_ACT_PROV_PACK,
    @PA_ACT_CONF_PACK,
    @PA_ACT_JOINING_PACK,
    @PA_ACT_POST_PACK,
    @PA_ACT_PREJOIN_PACK,
    @PA_ACT_PSTJOIN_PACK,
    @PA_ACT_PROV_SENT_DTE,
    @PA_ACT_CONF_SENT_DTE,
    @PA_ACT_JOIN_SENT_DTE,
    @PA_ACT_PP_SENT_DTE,
    @PA_ACT_PRJOIN_SENT_DTE,
    @PA_ACT_POJOIN_SENT_DTE,
    @PA_ACT_DROPDOWN_1,
    @PA_ACT_DROPDOWN_2,
    @PA_ACT_REVENUE_SPLIT,
    @PA_ACT_HOURS_SPLIT,
    @PA_ACT_ARRIVED,
    @PA_ACT_EXP_OCCUPANCY,
    @PA_ACT_RESERVE,
    @PA_ACT_VISIT_OUTCOME,
    @PA_ACT_TRNP_ID,
    @PA_ACT_SHOW_ATT_LOG
  );
    set @PA_ACT_ID = @@identity;
end
go
