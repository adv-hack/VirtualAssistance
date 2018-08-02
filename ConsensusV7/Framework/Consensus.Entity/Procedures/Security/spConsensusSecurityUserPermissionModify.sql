if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityUserPermissionModify')
  exec ('create procedure dbo.spConsensusSecurityUserPermissionModify as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityUserPermissionModify(@PA_PERMISSION_ID integer = null output, @PA_PERMISSION_PRINCIPAL_ID integer = null output, @PA_PERMISSION_DATA_TYPE nvarchar(max) = null output, @PA_PERMISSION_ACTION integer = null output, @PA_PERMISSION_ALLOW bit = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.User_Permission set
    PERMISSION_PRINCIPAL_ID = @PA_PERMISSION_PRINCIPAL_ID,
    PERMISSION_DATA_TYPE = @PA_PERMISSION_DATA_TYPE,
    PERMISSION_ACTION = @PA_PERMISSION_ACTION,
    PERMISSION_ALLOW = @PA_PERMISSION_ALLOW
  where PERMISSION_ID = @PA_PERMISSION_ID;
end
go
