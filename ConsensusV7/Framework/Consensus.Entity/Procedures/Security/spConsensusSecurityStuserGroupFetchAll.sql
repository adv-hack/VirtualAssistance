if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityStuserGroupFetchAll')
  exec ('create procedure dbo.spConsensusSecurityStuserGroupFetchAll as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityStuserGroupFetchAll as 
begin
  select 
    UG_ID,
    UG_ADD_DATE,
    UG_ADD_BY,
    UG_MOD_DATE,
    UG_MOD_BY,
    UG_RCV_DATE,
    UG_RCV_FROM,
    UG_NAME,
    UG_READ,
    UG_CREATE,
    UG_UPDATE,
    UG_DELETIONS,
    UG_USER_CONNECT,
    UG_TEMPLATE_PATH,
    UG_MAX_SESSIONS,
    UG_SYSTEM,
    UG_FLOATING,
    UG_BARRED,
    UG_PQ_ID,
    UG_CAMPAIGNS,
    UG_PROM_MASTER,
    UG_PROMOTIONS,
    UG_EDIT_EVENT_REF,
    UG_PERSON_PREF,
    UG_PWDP_ID,
    UG_EXPORT_SEARCH
  from dbo.STUSER_GROUP
end
go
