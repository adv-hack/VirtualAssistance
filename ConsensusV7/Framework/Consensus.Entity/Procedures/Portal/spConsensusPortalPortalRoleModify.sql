if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusPortalPortalRoleModify')
  exec ('create procedure dbo.spConsensusPortalPortalRoleModify as select 1 as temp')
go
alter procedure dbo.spConsensusPortalPortalRoleModify(@PA_PR_ID integer = null output, @PA_PR_TITLE varchar(50) = null output, @PA_PR_CREATE varchar(500) = null output, @PA_PR_READ varchar(500) = null output, @PA_PR_UPDATE varchar(500) = null output, @PA_PR_DELETE varchar(500) = null output, @PA_PR_IMP_PR_ID integer = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.PORTAL_ROLE set
    PR_MOD_DATE = getDate(),
    PR_MOD_BY = @_AUDIT_USER_ID,
    PR_TITLE = @PA_PR_TITLE,
    PR_CREATE = @PA_PR_CREATE,
    PR_READ = @PA_PR_READ,
    PR_UPDATE = @PA_PR_UPDATE,
    PR_DELETE = @PA_PR_DELETE,
    PR_IMP_PR_ID = @PA_PR_IMP_PR_ID
  where PR_ID = @PA_PR_ID;
end
go
