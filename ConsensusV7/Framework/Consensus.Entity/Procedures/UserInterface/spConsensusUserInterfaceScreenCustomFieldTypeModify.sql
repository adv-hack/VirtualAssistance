if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusUserInterfaceScreenCustomFieldTypeModify')
  exec ('create procedure dbo.spConsensusUserInterfaceScreenCustomFieldTypeModify as select 1 as temp')
go
alter procedure dbo.spConsensusUserInterfaceScreenCustomFieldTypeModify(@PA_CFTYPE_ID varchar(40) = null output, @PA_CFTYPE_NAME nvarchar(50) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.Screen_Custom_Field_Type set
    CFTYPE_MOD_DATE = getDate(),
    CFTYPE_MOD_BY = @_AUDIT_USER_ID,
    CFTYPE_NAME = @PA_CFTYPE_NAME
  where CFTYPE_ID = @PA_CFTYPE_ID;
end
go
