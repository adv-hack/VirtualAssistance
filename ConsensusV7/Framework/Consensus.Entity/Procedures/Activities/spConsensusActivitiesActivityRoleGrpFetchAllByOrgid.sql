if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusActivitiesActivityRoleGrpFetchAllByOrgid')
  exec ('create procedure dbo.spConsensusActivitiesActivityRoleGrpFetchAllByOrgid as select 1 as temp')
go
alter procedure dbo.spConsensusActivitiesActivityRoleGrpFetchAllByOrgid(@PA_ARG_ORG_ID varchar(11) = null output) as 
begin
  select 
    ARG_ID,
    ARG_ADD_BY,
    ARG_ADD_DATE,
    ARG_MOD_BY,
    ARG_MOD_DATE,
    ARG_RCV_FROM,
    ARG_RCV_DATE,
    ARG_TITLE,
    ARG_ORG_ID,
    ARG_LOC_ID,
    ARG_ADD_ID,
    ARG_TYPE,
    ARG_SELCO_SP_ID,
    ARG_HOUR_RTE,
    ARG_RESPTIME,
    ARG_RESPUNIT,
    ARG_RUN_DATE
  from dbo.ACTIVITY_ROLE_GRP
  where ARG_ORG_ID = @PA_ARG_ORG_ID
end
go
