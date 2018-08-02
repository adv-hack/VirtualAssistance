if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMarketingPromotionModify')
  exec ('create procedure dbo.spConsensusMarketingPromotionModify as select 1 as temp')
go
alter procedure dbo.spConsensusMarketingPromotionModify(@PA_PM_ID varchar(11) = null output, @PA_PM_CMP_ID varchar(11) = null output, @PA_PM_NAME varchar(30) = null output, @PA_PM_START_DATE datetime = null output, @PA_PM_CHANNEL varchar(15) = null output, @PA_PM_TEXT_ID varchar(11) = null output, @PA_PM_DM_NUMBER float = null output, @PA_PM_REPLIES float = null output, @PA_PM_ORDERS float = null output, @PA_PM_ORDER_VAL float = null output, @PA_PM_BUDGET_COST float = null output, @PA_PM_ACTUAL_COST float = null output, @PA_PM_UPDATED datetime = null output, @PA_PM_CURRENT tinyint = null output, @PA_PM_MOD_BY_SYS varchar(20) = null output, @PA_PM_LOCK varchar(10) = null output, @PA_PM_ORDER_VALUE_BC float = null output, @PA_PM_BUDGET_COST_BC float = null output, @PA_PM_ACTUAL_COST_BC float = null output, @PA_PM_CURRENCY_TYPE varchar(3) = null output, @PA_PM_MEDIA_NAME varchar(50) = null output, @PA_PM_SCHEME_ID varchar(11) = null output, @PA_PM_TELESALES integer = null output, @PA_PM_BOOKING integer = null output, @PA_PM_BOOK_VALUE float = null output, @PA_PM_OPP_TOT integer = null output, @PA_PM_QUOTES integer = null output, @PA_PM_QUO_VALUE float = null output, @PA_PM_SALES integer = null output, @PA_PM_SALE_VALUE float = null output, @PA_PM_USERNUM_1 float = null output, @PA_PM_USERNUM_2 float = null output, @PA_PM_CODE varchar(11) = null output, @PA_PM_PACK_ID varchar(11) = null output, @PA_PM_OUT_DATE datetime = null output, @PA_PM_FOOTER varchar(255) = null output, @PA_PM_UNSUBSCRIBE varchar(255) = null output, @PA_PM_HEADER varchar(255) = null output, @PA_PM_BODY varchar(max) = null output, @PA_PM_APPROVE varchar(20) = null output, @PA_PM_REPLY varchar(255) = null output, @PA_PM_TIME datetime = null output, @PA_PM_E_STATUS tinyint = null output, @PA_PM_JOB_TITLE varchar(80) = null output, @PA_PM_TYPE varchar(40) = null output, @PA_PM_E_TYPE varchar(40) = null output, @PA_PM_PROLE_ID varchar(11) = null output, @PA_PM_APP_PROLE_ID varchar(11) = null output, @PA_PM_RUN_TIME datetime = null output, @PA_PM_FINISH_TIME datetime = null output, @PA_PM_GOOD_MAIL integer = null output, @PA_PM_BAD_MAIL integer = null output, @PA_PM_SMTP_HOST varchar(25) = null output, @PA_PM_EMAIL_DESC varchar(100) = null output, @PA_PM_ACTUAL_VAR_COST float = null output, @PA_PM_ACTUAL_FIX_COST float = null output, @PA_PM_BUDGET_VAR_COST float = null output, @PA_PM_BUDGET_FIX_COST float = null output, @PA_PM_TARGET_OPP integer = null output, @PA_PM_TARGET_REPLIES integer = null output, @PA_PM_TARGET_OPP_VAL float = null output, @PA_PM_TARGET_BOOK_VAL float = null output, @PA_PM_TARGET_COMPLAINTS integer = null output, @PA_PM_TARGET_INFO_REQ integer = null output, @PA_PM_TARGET_HELPCALLS integer = null output, @PA_PM_TARGET_MEMBERSHIPS integer = null output, @PA_PM_TARGET_MEMBERSHIPS_VAL float = null output, @PA_PM_TARGET_SUBSCRIPTIONS integer = null output, @PA_PM_TARGET_SUBSCRIPTIONS_VAL float = null output, @PA_PM_ACTUAL_COMPLAINTS integer = null output, @PA_PM_ACTUAL_INFO_REQ integer = null output, @PA_PM_ACTUAL_HELPCALLS integer = null output, @PA_PM_ACTUAL_MEMBERSHIPS integer = null output, @PA_PM_ACTUAL_MEMBERSHIPS_VAL float = null output, @PA_PM_ACTUAL_SUBSCRIPTIONS integer = null output, @PA_PM_ACTUAL_SUBSCRIPTIONS_VAL float = null output, @PA_PM_WEB tinyint = null output, @PA_PM_EMAIL_CAMPAIGN tinyint = null output, @PA_PM_CAMPAIGN_TYPE integer = null output, @PA_PM_SEND_CONTACTS tinyint = null output, @PA_PM_CONTACTS_SENT datetime = null output, @PA_PM_EMAILS_SENT integer = null output, @PA_PM_EMAILS_OPENED integer = null output, @PA_PM_LINKS_CLICKED integer = null output, @PA_PM_LZ_CLICKED integer = null output, @PA_PM_SURVEYS_COMPLETED integer = null output, @PA_PM_GLOBAL_UNSUBSCRIBES integer = null output, @PA_PM_LIST_UNSUBSCRIBES integer = null output, @PA_PM_DOCS_DOWNLOADS integer = null output, @PA_PM_BOUNCE_BACKS integer = null output, @PA_PM_EMAILS_SENT_TARGET integer = null output, @PA_PM_EMAILS_OPENED_TARGET integer = null output, @PA_PM_LINKS_CLICKED_TARGET integer = null output, @PA_PM_LZ_CLICKED_TARGET integer = null output, @PA_PM_SURVEYS_COMPLETED_TARGET integer = null output, @PA_PM_GLOBAL_UNSUBSCRIBES_TARGET integer = null output, @PA_PM_LIST_UNSUBSCRIBES_TARGET integer = null output, @PA_PM_DOCS_DOWNLOADS_TARGET integer = null output, @PA_PM_BOUNCE_BACKS_TARGET integer = null output, @PA_PM_QCODE varchar(15) = null output, @PA_PM_FQCODE varchar(45) = null output, @PA_PM_FOLLOW_ON_PM_ID varchar(11) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.Promotion set
    PM_MOD_DATE = getDate(),
    PM_MOD_BY = @_AUDIT_USER_ID,
    PM_CMP_ID = @PA_PM_CMP_ID,
    PM_NAME = @PA_PM_NAME,
    PM_START_DATE = @PA_PM_START_DATE,
    PM_CHANNEL = @PA_PM_CHANNEL,
    PM_TEXT_ID = @PA_PM_TEXT_ID,
    PM_DM_NUMBER = @PA_PM_DM_NUMBER,
    PM_REPLIES = @PA_PM_REPLIES,
    PM_ORDERS = @PA_PM_ORDERS,
    PM_ORDER_VAL = @PA_PM_ORDER_VAL,
    PM_BUDGET_COST = @PA_PM_BUDGET_COST,
    PM_ACTUAL_COST = @PA_PM_ACTUAL_COST,
    PM_UPDATED = @PA_PM_UPDATED,
    PM_CURRENT = @PA_PM_CURRENT,
    PM_MOD_BY_SYS = @PA_PM_MOD_BY_SYS,
    PM_LOCK = @PA_PM_LOCK,
    PM_ORDER_VALUE_BC = @PA_PM_ORDER_VALUE_BC,
    PM_BUDGET_COST_BC = @PA_PM_BUDGET_COST_BC,
    PM_ACTUAL_COST_BC = @PA_PM_ACTUAL_COST_BC,
    PM_CURRENCY_TYPE = @PA_PM_CURRENCY_TYPE,
    PM_MEDIA_NAME = @PA_PM_MEDIA_NAME,
    PM_SCHEME_ID = @PA_PM_SCHEME_ID,
    PM_TELESALES = @PA_PM_TELESALES,
    PM_BOOKING = @PA_PM_BOOKING,
    PM_BOOK_VALUE = @PA_PM_BOOK_VALUE,
    PM_OPP_TOT = @PA_PM_OPP_TOT,
    PM_QUOTES = @PA_PM_QUOTES,
    PM_QUO_VALUE = @PA_PM_QUO_VALUE,
    PM_SALES = @PA_PM_SALES,
    PM_SALE_VALUE = @PA_PM_SALE_VALUE,
    PM_USERNUM_1 = @PA_PM_USERNUM_1,
    PM_USERNUM_2 = @PA_PM_USERNUM_2,
    PM_CODE = @PA_PM_CODE,
    PM_PACK_ID = @PA_PM_PACK_ID,
    PM_OUT_DATE = @PA_PM_OUT_DATE,
    PM_FOOTER = @PA_PM_FOOTER,
    PM_UNSUBSCRIBE = @PA_PM_UNSUBSCRIBE,
    PM_HEADER = @PA_PM_HEADER,
    PM_BODY = @PA_PM_BODY,
    PM_APPROVE = @PA_PM_APPROVE,
    PM_REPLY = @PA_PM_REPLY,
    PM_TIME = @PA_PM_TIME,
    PM_E_STATUS = @PA_PM_E_STATUS,
    PM_JOB_TITLE = @PA_PM_JOB_TITLE,
    PM_TYPE = @PA_PM_TYPE,
    PM_E_TYPE = @PA_PM_E_TYPE,
    PM_PROLE_ID = @PA_PM_PROLE_ID,
    PM_APP_PROLE_ID = @PA_PM_APP_PROLE_ID,
    PM_RUN_TIME = @PA_PM_RUN_TIME,
    PM_FINISH_TIME = @PA_PM_FINISH_TIME,
    PM_GOOD_MAIL = @PA_PM_GOOD_MAIL,
    PM_BAD_MAIL = @PA_PM_BAD_MAIL,
    PM_SMTP_HOST = @PA_PM_SMTP_HOST,
    PM_EMAIL_DESC = @PA_PM_EMAIL_DESC,
    PM_ACTUAL_VAR_COST = @PA_PM_ACTUAL_VAR_COST,
    PM_ACTUAL_FIX_COST = @PA_PM_ACTUAL_FIX_COST,
    PM_BUDGET_VAR_COST = @PA_PM_BUDGET_VAR_COST,
    PM_BUDGET_FIX_COST = @PA_PM_BUDGET_FIX_COST,
    PM_TARGET_OPP = @PA_PM_TARGET_OPP,
    PM_TARGET_REPLIES = @PA_PM_TARGET_REPLIES,
    PM_TARGET_OPP_VAL = @PA_PM_TARGET_OPP_VAL,
    PM_TARGET_BOOK_VAL = @PA_PM_TARGET_BOOK_VAL,
    PM_TARGET_COMPLAINTS = @PA_PM_TARGET_COMPLAINTS,
    PM_TARGET_INFO_REQ = @PA_PM_TARGET_INFO_REQ,
    PM_TARGET_HELPCALLS = @PA_PM_TARGET_HELPCALLS,
    PM_TARGET_MEMBERSHIPS = @PA_PM_TARGET_MEMBERSHIPS,
    PM_TARGET_MEMBERSHIPS_VAL = @PA_PM_TARGET_MEMBERSHIPS_VAL,
    PM_TARGET_SUBSCRIPTIONS = @PA_PM_TARGET_SUBSCRIPTIONS,
    PM_TARGET_SUBSCRIPTIONS_VAL = @PA_PM_TARGET_SUBSCRIPTIONS_VAL,
    PM_ACTUAL_COMPLAINTS = @PA_PM_ACTUAL_COMPLAINTS,
    PM_ACTUAL_INFO_REQ = @PA_PM_ACTUAL_INFO_REQ,
    PM_ACTUAL_HELPCALLS = @PA_PM_ACTUAL_HELPCALLS,
    PM_ACTUAL_MEMBERSHIPS = @PA_PM_ACTUAL_MEMBERSHIPS,
    PM_ACTUAL_MEMBERSHIPS_VAL = @PA_PM_ACTUAL_MEMBERSHIPS_VAL,
    PM_ACTUAL_SUBSCRIPTIONS = @PA_PM_ACTUAL_SUBSCRIPTIONS,
    PM_ACTUAL_SUBSCRIPTIONS_VAL = @PA_PM_ACTUAL_SUBSCRIPTIONS_VAL,
    PM_WEB = @PA_PM_WEB,
    PM_EMAIL_CAMPAIGN = @PA_PM_EMAIL_CAMPAIGN,
    PM_CAMPAIGN_TYPE = @PA_PM_CAMPAIGN_TYPE,
    PM_SEND_CONTACTS = @PA_PM_SEND_CONTACTS,
    PM_CONTACTS_SENT = @PA_PM_CONTACTS_SENT,
    PM_EMAILS_SENT = @PA_PM_EMAILS_SENT,
    PM_EMAILS_OPENED = @PA_PM_EMAILS_OPENED,
    PM_LINKS_CLICKED = @PA_PM_LINKS_CLICKED,
    PM_LZ_CLICKED = @PA_PM_LZ_CLICKED,
    PM_SURVEYS_COMPLETED = @PA_PM_SURVEYS_COMPLETED,
    PM_GLOBAL_UNSUBSCRIBES = @PA_PM_GLOBAL_UNSUBSCRIBES,
    PM_LIST_UNSUBSCRIBES = @PA_PM_LIST_UNSUBSCRIBES,
    PM_DOCS_DOWNLOADS = @PA_PM_DOCS_DOWNLOADS,
    PM_BOUNCE_BACKS = @PA_PM_BOUNCE_BACKS,
    PM_EMAILS_SENT_TARGET = @PA_PM_EMAILS_SENT_TARGET,
    PM_EMAILS_OPENED_TARGET = @PA_PM_EMAILS_OPENED_TARGET,
    PM_LINKS_CLICKED_TARGET = @PA_PM_LINKS_CLICKED_TARGET,
    PM_LZ_CLICKED_TARGET = @PA_PM_LZ_CLICKED_TARGET,
    PM_SURVEYS_COMPLETED_TARGET = @PA_PM_SURVEYS_COMPLETED_TARGET,
    PM_GLOBAL_UNSUBSCRIBES_TARGET = @PA_PM_GLOBAL_UNSUBSCRIBES_TARGET,
    PM_LIST_UNSUBSCRIBES_TARGET = @PA_PM_LIST_UNSUBSCRIBES_TARGET,
    PM_DOCS_DOWNLOADS_TARGET = @PA_PM_DOCS_DOWNLOADS_TARGET,
    PM_BOUNCE_BACKS_TARGET = @PA_PM_BOUNCE_BACKS_TARGET,
    PM_QCODE = @PA_PM_QCODE,
    PM_FQCODE = @PA_PM_FQCODE,
    PM_FOLLOW_ON_PM_ID = @PA_PM_FOLLOW_ON_PM_ID
  where PM_ID = @PA_PM_ID;
end
go
