if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMarketingPromotionMasterFetchAllByRegion')
  exec ('create procedure dbo.spConsensusMarketingPromotionMasterFetchAllByRegion as select 1 as temp')
go
alter procedure dbo.spConsensusMarketingPromotionMasterFetchAllByRegion(@PA_PM_MST_REGION varchar(20) = null output) as 
begin
  select 
    PM_MST_ID,
    PM_MST_NAME,
    PM_MST_START_DATE,
    PM_MST_END_DATE,
    PM_MST_REGION,
    PM_MST_OBJ_TEXT_ID,
    PM_MST_SEL_TEXT_ID,
    PM_MST_RVW_TEXT_ID,
    PM_MST_BUDGET_COST,
    PM_MST_ACTUAL_COST,
    PM_MST_REPLIES,
    PM_MST_ORDERS,
    PM_MST_ORDER_VALUE,
    PM_MST_UPDATED,
    PM_MST_MOD_DATE,
    PM_MST_MOD_BY,
    PM_MST_MOD_BY_SYS,
    PM_MST_ADD_DATE,
    PM_MST_ADD_BY,
    PM_MST_LOCK,
    PM_MST_BDGT_CST_BC,
    PM_MST_ACTL_CST_BC,
    PM_MST_ORDR_VAL_BC,
    PM_MST_CURR_TYPE,
    PM_MST_CMP_ID,
    PM_MST_RCV_DATE,
    PM_MST_RCV_FROM,
    PM_MST_MAILINGS,
    PM_MST_TELESALES,
    PM_MST_BOOKINGS,
    PM_MST_OPP_TOT,
    PM_MST_QUOTES,
    PM_MST_QUO_VAL,
    PM_MST_SALES,
    PM_MST_SALE_VAL,
    PM_MST_CALC_ACT,
    PM_MST_CALC_EST,
    PM_MST_BOOK_VAL,
    PM_MST_COURSE_ID,
    PM_MST_CODE,
    PM_MST_TYPE,
    PM_MST_TARGET_OPP,
    PM_MST_TARGET_REPLIES,
    PM_MST_TARGET_OPP_VAL,
    PM_MST_TARGET_BOOK_VAL,
    PM_MST_PROLE_ID,
    PM_MST_APP_PROLE_ID,
    PM_MST_EMAILS_SENT,
    PM_MST_EMAILS_OPENED,
    PM_MST_LINKS_CLICKED,
    PM_MST_LZ_CLICKED,
    PM_MST_SURVEYS_COMPLETED,
    PM_MST_GLOBAL_UNSUBSCRIBES,
    PM_MST_LIST_UNSUBSCRIBES,
    PM_MST_DOCS_DOWNLOADS,
    PM_MST_BOUNCE_BACKS,
    PM_MST_EMAILS_SENT_TARGET,
    PM_MST_EMAILS_OPENED_TARGET,
    PM_MST_LINKS_CLICKED_TARGET,
    PM_MST_LZ_CLICKED_TARGET,
    PM_MST_SURVEYS_COMPLETED_TARGET,
    PM_MST_GLOBAL_UNSUBSCRIBES_TARGET,
    PM_MST_LIST_UNSUBSCRIBES_TARGET,
    PM_MST_DOCS_DOWNLOADS_TARGET,
    PM_MST_BOUNCE_BACKS_TARGET,
    PM_MST_QCODE,
    PM_MST_FQCODE
  from dbo.Promotion_Master
  where PM_MST_REGION = @PA_PM_MST_REGION
end
go
