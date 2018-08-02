if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityUserPermissionCreate')
  exec ('create procedure dbo.spConsensusSecurityUserPermissionCreate as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityUserPermissionCreate(@PA_PERMISSION_ID integer = null output, @PA_PERMISSION_PRINCIPAL_ID integer = null output, @PA_PERMISSION_DATA_TYPE nvarchar(max) = null output, @PA_PERMISSION_ACTION integer = null output, @PA_PERMISSION_ALLOW bit = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.User_Permission(
    PERMISSION_PRINCIPAL_ID,
    PERMISSION_DATA_TYPE,
    PERMISSION_ACTION,
    PERMISSION_ALLOW
  ) values (
    @PA_PERMISSION_PRINCIPAL_ID,
    @PA_PERMISSION_DATA_TYPE,
    @PA_PERMISSION_ACTION,
    @PA_PERMISSION_ALLOW
  );
    set @PA_PERMISSION_ID = @@identity;
end
go
