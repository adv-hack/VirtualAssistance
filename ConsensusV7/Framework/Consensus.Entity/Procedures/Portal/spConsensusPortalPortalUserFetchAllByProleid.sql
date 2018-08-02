if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusPortalPortalUserFetchAllByProleid')
  exec ('create procedure dbo.spConsensusPortalPortalUserFetchAllByProleid as select 1 as temp')
go
alter procedure dbo.spConsensusPortalPortalUserFetchAllByProleid(@PA_PU_PROLE_ID varchar(11) = null output) as 
begin
  select 
    PU_ID,
    PU_ADD_DATE,
    PU_ADD_BY,
    PU_MOD_DATE,
    PU_MOD_BY,
    PU_RCV_DATE,
    PU_RCV_FROM,
    PU_PR_ID,
    PU_PROLE_ID,
    PU_LOGIN_ID,
    PU_PASSWORD,
    PU_BARRED,
    PU_SYS_ADMIN,
    PU_SHT_LOGIN_ID,
    PU_CREATE,
    PU_READ,
    PU_UPDATE,
    PU_DELETE,
    PU_NTUSERNAME,
    PU_SELCO_SP_ID,
    PU_INC_MYORG,
    PU_ATTEMPT_COUNT,
    PU_LOCKED_UNTIL,
    PU_RESET_CODE,
    PU_PARTNER_SYS_REF,
    PU_SECRET_QUEST,
    PU_SECRET_ANSWER,
    PU_FIRST_LOGIN,
    PU_LAST_LOGIN,
    PU_NO_LOGINS,
    PU_RESET_VALID_UNTIL,
    PU_RESET_URL,
    PU_GUID,
    PU_AUTH_PROVIDER
  from dbo.PORTAL_USER
  where PU_PROLE_ID = @PA_PU_PROLE_ID
end
go
