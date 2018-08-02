if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusPortalPortaluserroleFetchAll')
  exec ('create procedure dbo.spConsensusPortalPortaluserroleFetchAll as select 1 as temp')
go
alter procedure dbo.spConsensusPortalPortaluserroleFetchAll as 
begin
  select 
    PUR_ID,
    PUR_ADD_DATE,
    PUR_ADD_BY,
    PUR_MOD_DATE,
    PUR_MOD_BY,
    PUR_PU_ID,
    PUR_PR_ID
  from dbo.PortalUserRole
end
go
