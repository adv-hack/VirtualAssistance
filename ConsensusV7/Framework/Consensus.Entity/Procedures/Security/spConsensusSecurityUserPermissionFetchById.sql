if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityUserPermissionFetchById')
  exec ('create procedure dbo.spConsensusSecurityUserPermissionFetchById as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityUserPermissionFetchById(@PA_PERMISSION_ID integer = null output) as 
begin
  select 
    PERMISSION_ID,
    PERMISSION_PRINCIPAL_ID,
    PERMISSION_DATA_TYPE,
    PERMISSION_ACTION,
    PERMISSION_ALLOW
  from dbo.User_Permission
  where PERMISSION_ID = @PA_PERMISSION_ID
end
go
