if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusPortalPortalUserModify')
  exec ('create procedure dbo.spConsensusPortalPortalUserModify as select 1 as temp')
go
alter procedure dbo.spConsensusPortalPortalUserModify(@PA_PU_ID integer = null output, @PA_PU_PR_ID integer = null output, @PA_PU_PROLE_ID varchar(11) = null output, @PA_PU_LOGIN_ID varchar(255) = null output, @PA_PU_PASSWORD varchar(255) = null output, @PA_PU_BARRED tinyint = null output, @PA_PU_SYS_ADMIN tinyint = null output, @PA_PU_SHT_LOGIN_ID varchar(3) = null output, @PA_PU_CREATE varchar(500) = null output, @PA_PU_READ varchar(500) = null output, @PA_PU_UPDATE varchar(500) = null output, @PA_PU_DELETE varchar(500) = null output, @PA_PU_NTUSERNAME varchar(255) = null output, @PA_PU_SELCO_SP_ID varchar(11) = null output, @PA_PU_INC_MYORG tinyint = null output, @PA_PU_ATTEMPT_COUNT tinyint = null output, @PA_PU_LOCKED_UNTIL datetime = null output, @PA_PU_RESET_CODE varchar(36) = null output, @PA_PU_PARTNER_SYS_REF varchar(30) = null output, @PA_PU_SECRET_QUEST varchar(255) = null output, @PA_PU_SECRET_ANSWER varchar(255) = null output, @PA_PU_FIRST_LOGIN datetime = null output, @PA_PU_LAST_LOGIN datetime = null output, @PA_PU_NO_LOGINS bigint = null output, @PA_PU_RESET_VALID_UNTIL datetime = null output, @PA_PU_RESET_URL varchar(2000) = null output, @PA_PU_GUID uniqueidentifier = null output, @PA_PU_AUTH_PROVIDER varchar(255) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.PORTAL_USER set
    PU_MOD_DATE = getDate(),
    PU_MOD_BY = @_AUDIT_USER_ID,
    PU_PR_ID = @PA_PU_PR_ID,
    PU_PROLE_ID = @PA_PU_PROLE_ID,
    PU_LOGIN_ID = @PA_PU_LOGIN_ID,
    PU_PASSWORD = @PA_PU_PASSWORD,
    PU_BARRED = @PA_PU_BARRED,
    PU_SYS_ADMIN = @PA_PU_SYS_ADMIN,
    PU_SHT_LOGIN_ID = @PA_PU_SHT_LOGIN_ID,
    PU_CREATE = @PA_PU_CREATE,
    PU_READ = @PA_PU_READ,
    PU_UPDATE = @PA_PU_UPDATE,
    PU_DELETE = @PA_PU_DELETE,
    PU_NTUSERNAME = @PA_PU_NTUSERNAME,
    PU_SELCO_SP_ID = @PA_PU_SELCO_SP_ID,
    PU_INC_MYORG = @PA_PU_INC_MYORG,
    PU_ATTEMPT_COUNT = @PA_PU_ATTEMPT_COUNT,
    PU_LOCKED_UNTIL = @PA_PU_LOCKED_UNTIL,
    PU_RESET_CODE = @PA_PU_RESET_CODE,
    PU_PARTNER_SYS_REF = @PA_PU_PARTNER_SYS_REF,
    PU_SECRET_QUEST = @PA_PU_SECRET_QUEST,
    PU_SECRET_ANSWER = @PA_PU_SECRET_ANSWER,
    PU_FIRST_LOGIN = @PA_PU_FIRST_LOGIN,
    PU_LAST_LOGIN = @PA_PU_LAST_LOGIN,
    PU_NO_LOGINS = @PA_PU_NO_LOGINS,
    PU_RESET_VALID_UNTIL = @PA_PU_RESET_VALID_UNTIL,
    PU_RESET_URL = @PA_PU_RESET_URL,
    PU_GUID = @PA_PU_GUID,
    PU_AUTH_PROVIDER = @PA_PU_AUTH_PROVIDER
  where PU_ID = @PA_PU_ID;
end
go
