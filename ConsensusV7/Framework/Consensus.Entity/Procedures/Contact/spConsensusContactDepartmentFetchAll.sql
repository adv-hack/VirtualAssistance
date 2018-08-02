if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusContactDepartmentFetchAll')
  exec ('create procedure dbo.spConsensusContactDepartmentFetchAll as select 1 as temp')
go
alter procedure dbo.spConsensusContactDepartmentFetchAll as 
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
end
go
