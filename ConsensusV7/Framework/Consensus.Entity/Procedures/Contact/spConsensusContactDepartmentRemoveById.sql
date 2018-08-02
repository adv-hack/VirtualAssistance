if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusContactDepartmentRemoveById')
  exec ('create procedure dbo.spConsensusContactDepartmentRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusContactDepartmentRemoveById(@PA_DEPT_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.DEPARTMENT
  where DEPT_ID = @PA_DEPT_ID
end
go
