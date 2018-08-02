if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusUserInterfaceScreenCustomFieldTypeCreate')
  exec ('create procedure dbo.spConsensusUserInterfaceScreenCustomFieldTypeCreate as select 1 as temp')
go
alter procedure dbo.spConsensusUserInterfaceScreenCustomFieldTypeCreate(@PA_CFTYPE_ID varchar(40) = null output, @PA_CFTYPE_NAME nvarchar(50) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.Screen_Custom_Field_Type(
    CFTYPE_ADD_DATE,
    CFTYPE_ADD_BY,
    CFTYPE_MOD_DATE,
    CFTYPE_MOD_BY,
    CFTYPE_NAME
  ) values (
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    @PA_CFTYPE_NAME
  );
    set @PA_CFTYPE_ID = @@identity;
end
go
