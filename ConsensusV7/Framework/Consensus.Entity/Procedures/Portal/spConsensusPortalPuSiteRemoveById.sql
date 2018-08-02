if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusPortalPuSiteRemoveById')
  exec ('create procedure dbo.spConsensusPortalPuSiteRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusPortalPuSiteRemoveById(@PA_PUSTE_ID integer = null output) as 
begin
  delete 
  from dbo.PU_SITE
  where PUSTE_ID = @PA_PUSTE_ID
end
go
