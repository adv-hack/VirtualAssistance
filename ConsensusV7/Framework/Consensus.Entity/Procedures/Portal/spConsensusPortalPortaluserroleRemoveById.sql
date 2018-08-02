if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusPortalPortaluserroleRemoveById')
  exec ('create procedure dbo.spConsensusPortalPortaluserroleRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusPortalPortaluserroleRemoveById(@PA_PUR_ID integer = null output) as 
begin
  delete 
  from dbo.PortalUserRole
  where PUR_ID = @PA_PUR_ID
end
go
