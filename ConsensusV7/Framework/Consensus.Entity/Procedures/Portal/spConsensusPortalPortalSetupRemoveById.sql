if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusPortalPortalSetupRemoveById')
  exec ('create procedure dbo.spConsensusPortalPortalSetupRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusPortalPortalSetupRemoveById(@PA_PS_ID integer = null output) as 
begin
  delete 
  from dbo.PORTAL_SETUP
  where PS_ID = @PA_PS_ID
end
go
