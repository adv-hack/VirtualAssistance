if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusActivitiesHelpdeskFetchAllByDetailsid')
  exec ('create procedure dbo.spConsensusActivitiesHelpdeskFetchAllByDetailsid as select 1 as temp')
go
alter procedure dbo.spConsensusActivitiesHelpdeskFetchAllByDetailsid(@PA_HD_DETAILS_ID varchar(11) = null output) as 
begin
  select 
    HD_ID,
    HD_LOCK,
    HD_ADD_DATE,
    HD_ADD_BY,
    HD_MOD_DATE,
    HD_MOD_BY,
    HD_RCV_DATE,
    HD_RCV_FROM,
    HD_ORG_ID,
    HD_ORG_NAME,
    HD_PROLE_ID,
    HD_PN_NAME,
    HD_SERIAL_NO,
    HD_IN_ID,
    HD_PROD_CODE,
    HD_PROD_ID,
    HD_WARR_DATE,
    HD_CONTR_REF,
    HD_CONT_TYPE,
    HD_CONT_DATE,
    HD_GIVEN_TO,
    HD_GIVEN_TO_ID,
    HD_FIXED_DATE,
    HD_FIXED_TIME,
    HD_STATUS,
    HD_DETAILS_ID,
    HD_FIX_ID,
    HD_CATEGORY,
    HD_FIX_CAT,
    HD_CALL_DATE,
    HD_CALL_TIME,
    HD_CALLER_PHONE,
    HD_FAULT_TYPE,
    HD_PROD_NAME,
    HD_SEVERITY,
    HD_PROJ_REF,
    HD_PROJ_ID,
    HD_ACT_ID,
    HD_HISTORY_TXT,
    HD_TITLE,
    HD_CUST_REF,
    HD_CUST_ACPT,
    HD_RPT_DATE,
    HD_TRG_RSP_DATE,
    HD_ACT_RSP_DATE,
    HD_TRG_TPFIX_D,
    HD_ACT_TPFIX_D,
    HD_TRG_ACTFIX_D,
    HD_SUC_ID,
    HD_ACC_DATE,
    HD_RESOLVED_VER,
    HD_EST_TIME,
    HD_TYPE,
    HD_WIP_ID,
    HD_RES_DATE,
    HD_SELCO_SP_ID,
    HD_GROUP,
    HD_ASSIGNED,
    HD_READ,
    HD_RESOLUTION_ID,
    HD_VERSION,
    HD_PM_ID,
    HD_BUILD_VERSION
  from dbo.Helpdesk
  where HD_DETAILS_ID = @PA_HD_DETAILS_ID
end
go
