if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusPortalPortaluserroleCreate')
  exec ('create procedure dbo.spConsensusPortalPortaluserroleCreate as select 1 as temp')
go
alter procedure dbo.spConsensusPortalPortaluserroleCreate(@PA_PUR_ID integer = null output, @PA_PUR_PU_ID integer = null output, @PA_PUR_PR_ID integer = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.PortalUserRole(
    PUR_ADD_DATE,
    PUR_ADD_BY,
    PUR_MOD_DATE,
    PUR_MOD_BY,
    PUR_PU_ID,
    PUR_PR_ID
  ) values (
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    @PA_PUR_PU_ID,
    @PA_PUR_PR_ID
  );
    set @PA_PUR_ID = @@identity;
end
go
