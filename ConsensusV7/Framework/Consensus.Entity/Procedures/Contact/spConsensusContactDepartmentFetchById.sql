if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusContactDepartmentFetchById')
  exec ('create procedure dbo.spConsensusContactDepartmentFetchById as select 1 as temp')
go
alter procedure dbo.spConsensusContactDepartmentFetchById(@PA_DEPT_ID varchar(11) = null output) as 
begin
  select 
    DEPT_ID,
    DEPT_ADD_DATE,
    DEPT_ADD_BY,
    DEPT_MOD_DATE,
    DEPT_MOD_BY,
    DEPT_RCV_DATE,
    DEPT_RCV_FROM,
    DEPT_ORG_ID,
    DEPT_NAME
  from dbo.DEPARTMENT
  where DEPT_ID = @PA_DEPT_ID
end
go
