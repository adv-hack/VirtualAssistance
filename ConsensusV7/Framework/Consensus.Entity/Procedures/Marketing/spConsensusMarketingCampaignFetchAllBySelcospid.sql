if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMarketingCampaignFetchAllBySelcospid')
  exec ('create procedure dbo.spConsensusMarketingCampaignFetchAllBySelcospid as select 1 as temp')
go
alter procedure dbo.spConsensusMarketingCampaignFetchAllBySelcospid(@PA_CMP_SELCO_SP_ID varchar(11) = null output) as 
begin
  select 
    CMP_ID,
    CMP_NAME,
    CMP_START_DATE,
    CMP_END_DATE,
    CMP_REGION,
    CMP_OBJ_TEXT_ID,
    CMP_SEL_TEXT_ID,
    CMP_RVW_TEXT_ID,
    CMP_BUDGET_COSTS,
    CMP_ACTUAL_COSTS,
    CMP_REPLIES,
    CMP_ORDERS,
    CMP_ORDER_VALUE,
    CMP_UPDATED,
    CMP_MOD_DATE,
    CMP_MOD_BY,
    CMP_MOD_BY_SYS,
    CMP_ADD_DATE,
    CMP_ADD_BY,
    CMP_LOCK,
    CMP_BUDGET_COST_BC,
    CMP_ACTUAL_COST_BC,
    CMP_ORDER_VALUE_BC,
    CMP_CURRENCY_TYPE,
    CMP_RCV_DATE,
    CMP_RCV_FROM,
    CMP_MAILINGS,
    CMP_TELESALES,
    CMP_BOOKINGS,
    CMP_BOOK_VALUE,
    CMP_QUOTES,
    CMP_QUO_VALUE,
    CMP_SALES,
    CMP_SALE_VALUE,
    CMP_CALC_ACT,
    CMP_CALC_EST,
    CMP_OPP_TOT,
    CMP_PROJ_ID,
    CMP_BUDGET_COST_BC2,
    CMP_ACTUAL_COST_BC2,
    CMP_ORDER_VALUE_BC2,
    CMP_SELCO_SP_ID,
    CMP_TARGET_OPP,
    CMP_TARGET_REPLIES,
    CMP_TARGET_OPP_VAL,
    CMP_TARGET_BOOK_VAL,
    CMP_PROLE_ID,
    CMP_APP_PROLE_ID,
    CMP_EMAILS_SENT,
    CMP_EMAILS_OPENED,
    CMP_LINKS_CLICKED,
    CMP_LZ_CLICKED,
    CMP_SURVEYS_COMPLETED,
    CMP_GLOBAL_UNSUBSCRIBES,
    CMP_LIST_UNSUBSCRIBES,
    CMP_DOCS_DOWNLOADS,
    CMP_BOUNCE_BACKS,
    CMP_EMAILS_SENT_TARGET,
    CMP_EMAILS_OPENED_TARGET,
    CMP_LINKS_CLICKED_TARGET,
    CMP_LZ_CLICKED_TARGET,
    CMP_SURVEYS_COMPLETED_TARGET,
    CMP_GLOBAL_UNSUBSCRIBES_TARGET,
    CMP_LIST_UNSUBSCRIBES_TARGET,
    CMP_DOCS_DOWNLOADS_TARGET,
    CMP_BOUNCE_BACKS_TARGET,
    CMP_QCODE,
    CMP_CURRENT
  from dbo.Campaign
  where CMP_SELCO_SP_ID = @PA_CMP_SELCO_SP_ID
end
go
