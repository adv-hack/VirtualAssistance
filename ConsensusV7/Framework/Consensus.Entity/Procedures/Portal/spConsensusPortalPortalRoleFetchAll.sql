if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusPortalPortalRoleFetchAll')
  exec ('create procedure dbo.spConsensusPortalPortalRoleFetchAll as select 1 as temp')
go
alter procedure dbo.spConsensusPortalPortalRoleFetchAll as 
begin
  select 
    PR_ID,
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
  from dbo.PORTAL_ROLE
end
go
