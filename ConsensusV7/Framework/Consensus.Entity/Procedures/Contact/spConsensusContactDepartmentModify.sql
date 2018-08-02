if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusContactDepartmentModify')
  exec ('create procedure dbo.spConsensusContactDepartmentModify as select 1 as temp')
go
alter procedure dbo.spConsensusContactDepartmentModify(@PA_DEPT_ID varchar(11) = null output, @PA_DEPT_ORG_ID varchar(11) = null output, @PA_DEPT_NAME varchar(50) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.DEPARTMENT set
    DEPT_MOD_DATE = getDate(),
    DEPT_MOD_BY = @_AUDIT_USER_ID,
    DEPT_ORG_ID = @PA_DEPT_ORG_ID,
    DEPT_NAME = @PA_DEPT_NAME
  where DEPT_ID = @PA_DEPT_ID;
end
go
