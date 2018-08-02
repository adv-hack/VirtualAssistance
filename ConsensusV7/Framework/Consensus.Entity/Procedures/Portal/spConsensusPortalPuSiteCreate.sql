if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusPortalPuSiteCreate')
  exec ('create procedure dbo.spConsensusPortalPuSiteCreate as select 1 as temp')
go
alter procedure dbo.spConsensusPortalPuSiteCreate(@PA_PUSTE_ID integer = null output, @PA_PUSTE_PU_ID integer = null output, @PA_PUSTE_PS_ID integer = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.PU_SITE(
    PUSTE_ADD_DATE,
    PUSTE_ADD_BY,
    PUSTE_MOD_DATE,
    PUSTE_MOD_BY,
    PUSTE_RCV_DATE,
    PUSTE_RCV_FROM,
    PUSTE_PU_ID,
    PUSTE_PS_ID
  ) values (
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    '',
    @PA_PUSTE_PU_ID,
    @PA_PUSTE_PS_ID
  );
    set @PA_PUSTE_ID = @@identity;
end
go
