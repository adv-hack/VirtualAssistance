if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusPortalPortalRoleRemoveById')
  exec ('create procedure dbo.spConsensusPortalPortalRoleRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusPortalPortalRoleRemoveById(@PA_PR_ID integer = null output) as 
begin
  delete 
  from dbo.PORTAL_ROLE
  where PR_ID = @PA_PR_ID
end
go
