if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusPortalPuSiteModify')
  exec ('create procedure dbo.spConsensusPortalPuSiteModify as select 1 as temp')
go
alter procedure dbo.spConsensusPortalPuSiteModify(@PA_PUSTE_ID integer = null output, @PA_PUSTE_PU_ID integer = null output, @PA_PUSTE_PS_ID integer = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.PU_SITE set
    PUSTE_MOD_DATE = getDate(),
    PUSTE_MOD_BY = @_AUDIT_USER_ID,
    PUSTE_PU_ID = @PA_PUSTE_PU_ID,
    PUSTE_PS_ID = @PA_PUSTE_PS_ID
  where PUSTE_ID = @PA_PUSTE_ID;
end
go
