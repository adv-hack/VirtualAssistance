if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusPortalPortalUserRemoveById')
  exec ('create procedure dbo.spConsensusPortalPortalUserRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusPortalPortalUserRemoveById(@PA_PU_ID integer = null output) as 
begin
  delete 
  from dbo.PORTAL_USER
  where PU_ID = @PA_PU_ID
end
go
