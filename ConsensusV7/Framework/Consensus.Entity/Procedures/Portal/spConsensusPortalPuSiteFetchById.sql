if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusPortalPuSiteFetchById')
  exec ('create procedure dbo.spConsensusPortalPuSiteFetchById as select 1 as temp')
go
alter procedure dbo.spConsensusPortalPuSiteFetchById(@PA_PUSTE_ID integer = null output) as 
begin
  select 
    PUSTE_ID,
    PUSTE_ADD_DATE,
    PUSTE_ADD_BY,
    PUSTE_MOD_DATE,
    PUSTE_MOD_BY,
    PUSTE_RCV_DATE,
    PUSTE_RCV_FROM,
    PUSTE_PU_ID,
    PUSTE_PS_ID
  from dbo.PU_SITE
  where PUSTE_ID = @PA_PUSTE_ID
end
go
