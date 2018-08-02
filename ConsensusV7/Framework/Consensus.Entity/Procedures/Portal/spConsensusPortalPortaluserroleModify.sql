if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusPortalPortaluserroleModify')
  exec ('create procedure dbo.spConsensusPortalPortaluserroleModify as select 1 as temp')
go
alter procedure dbo.spConsensusPortalPortaluserroleModify(@PA_PUR_ID integer = null output, @PA_PUR_PU_ID integer = null output, @PA_PUR_PR_ID integer = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.PortalUserRole set
    PUR_MOD_DATE = getDate(),
    PUR_MOD_BY = @_AUDIT_USER_ID,
    PUR_PU_ID = @PA_PUR_PU_ID,
    PUR_PR_ID = @PA_PUR_PR_ID
  where PUR_ID = @PA_PUR_ID;
end
go
