if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusPortalPortaluserroleFetchAllByPuid')
  exec ('create procedure dbo.spConsensusPortalPortaluserroleFetchAllByPuid as select 1 as temp')
go
alter procedure dbo.spConsensusPortalPortaluserroleFetchAllByPuid(@PA_PUR_PU_ID integer = null output) as 
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
  where PUR_PU_ID = @PA_PUR_PU_ID
end
go
