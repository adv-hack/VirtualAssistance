if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityStuserGroupCreate')
  exec ('create procedure dbo.spConsensusSecurityStuserGroupCreate as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityStuserGroupCreate(@PA_UG_ID varchar(11) = null output, @PA_UG_NAME varchar(50) = null output, @PA_UG_READ varchar(256) = null output, @PA_UG_CREATE varchar(256) = null output, @PA_UG_UPDATE varchar(256) = null output, @PA_UG_DELETIONS varchar(256) = null output, @PA_UG_USER_CONNECT integer = null output, @PA_UG_TEMPLATE_PATH varchar(150) = null output, @PA_UG_MAX_SESSIONS integer = null output, @PA_UG_SYSTEM tinyint = null output, @PA_UG_FLOATING tinyint = null output, @PA_UG_BARRED tinyint = null output, @PA_UG_PQ_ID varchar(11) = null output, @PA_UG_CAMPAIGNS tinyint = null output, @PA_UG_PROM_MASTER tinyint = null output, @PA_UG_PROMOTIONS tinyint = null output, @PA_UG_EDIT_EVENT_REF tinyint = null output, @PA_UG_PERSON_PREF tinyint = null output, @PA_UG_PWDP_ID integer = null output, @PA_UG_EXPORT_SEARCH bit = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.STUSER_GROUP(
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
  ) values (
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    '',
    @PA_UG_NAME,
    @PA_UG_READ,
    @PA_UG_CREATE,
    @PA_UG_UPDATE,
    @PA_UG_DELETIONS,
    @PA_UG_USER_CONNECT,
    @PA_UG_TEMPLATE_PATH,
    @PA_UG_MAX_SESSIONS,
    @PA_UG_SYSTEM,
    @PA_UG_FLOATING,
    @PA_UG_BARRED,
    @PA_UG_PQ_ID,
    @PA_UG_CAMPAIGNS,
    @PA_UG_PROM_MASTER,
    @PA_UG_PROMOTIONS,
    @PA_UG_EDIT_EVENT_REF,
    @PA_UG_PERSON_PREF,
    @PA_UG_PWDP_ID,
    @PA_UG_EXPORT_SEARCH
  );
    set @PA_UG_ID = @@identity;
end
go
