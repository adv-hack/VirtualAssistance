if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusContactPersonRoleRemoveById')
  exec ('create procedure dbo.spConsensusContactPersonRoleRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusContactPersonRoleRemoveById(@PA_PROLE_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.Person_Role
  where PROLE_ID = @PA_PROLE_ID
end
go
