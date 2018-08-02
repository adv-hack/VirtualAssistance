if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityUserPermissionFetchAll')
  exec ('create procedure dbo.spConsensusSecurityUserPermissionFetchAll as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityUserPermissionFetchAll as 
begin
  select 
    PERMISSION_ID,
    PERMISSION_PRINCIPAL_ID,
    PERMISSION_DATA_TYPE,
    PERMISSION_ACTION,
    PERMISSION_ALLOW
  from dbo.User_Permission
end
go
