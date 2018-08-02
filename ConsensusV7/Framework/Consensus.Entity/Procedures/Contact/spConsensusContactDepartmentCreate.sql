if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusContactDepartmentCreate')
  exec ('create procedure dbo.spConsensusContactDepartmentCreate as select 1 as temp')
go
alter procedure dbo.spConsensusContactDepartmentCreate(@PA_DEPT_ID varchar(11) = null output, @PA_DEPT_ORG_ID varchar(11) = null output, @PA_DEPT_NAME varchar(50) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  exec spNextID 33, @PA_DEPT_ID output
  
  insert into dbo.DEPARTMENT(
    DEPT_ID,
    DEPT_ADD_DATE,
    DEPT_ADD_BY,
    DEPT_MOD_DATE,
    DEPT_MOD_BY,
    DEPT_RCV_DATE,
    DEPT_RCV_FROM,
    DEPT_ORG_ID,
    DEPT_NAME
  ) values (
    @PA_DEPT_ID,
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    '',
    @PA_DEPT_ORG_ID,
    @PA_DEPT_NAME
  );
end
go
