if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityUserPermissionRemoveById')
  exec ('create procedure dbo.spConsensusSecurityUserPermissionRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityUserPermissionRemoveById(@PA_PERMISSION_ID integer = null output) as 
begin
  delete 
  from dbo.User_Permission
  where PERMISSION_ID = @PA_PERMISSION_ID
end
go
