if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusPortalPortalRoleCreate')
  exec ('create procedure dbo.spConsensusPortalPortalRoleCreate as select 1 as temp')
go
alter procedure dbo.spConsensusPortalPortalRoleCreate(@PA_PR_ID integer = null output, @PA_PR_TITLE varchar(50) = null output, @PA_PR_CREATE varchar(500) = null output, @PA_PR_READ varchar(500) = null output, @PA_PR_UPDATE varchar(500) = null output, @PA_PR_DELETE varchar(500) = null output, @PA_PR_IMP_PR_ID integer = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.PORTAL_ROLE(
    PR_ADD_DATE,
    PR_ADD_BY,
    PR_MOD_DATE,
    PR_MOD_BY,
    PR_RCV_DATE,
    PR_RCV_FROM,
    PR_TITLE,
    PR_CREATE,
    PR_READ,
    PR_UPDATE,
    PR_DELETE,
    PR_IMP_PR_ID
  ) values (
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    '',
    @PA_PR_TITLE,
    @PA_PR_CREATE,
    @PA_PR_READ,
    @PA_PR_UPDATE,
    @PA_PR_DELETE,
    @PA_PR_IMP_PR_ID
  );
    set @PA_PR_ID = @@identity;
end
go
