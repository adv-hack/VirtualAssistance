if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusUserInterfaceScreenObjectDisplayModify')
  exec ('create procedure dbo.spConsensusUserInterfaceScreenObjectDisplayModify as select 1 as temp')
go
alter procedure dbo.spConsensusUserInterfaceScreenObjectDisplayModify(@PA_OBJDIS_ID integer = null output, @PA_OBJDIS_OBJ_ID integer = null output, @PA_OBJDIS_PRINCIPAL_ID integer = null output, @PA_OBJDIS_DISPLAY tinyint = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.Screen_Object_Display set
    OBJDIS_MOD_DATE = getDate(),
    OBJDIS_MOD_BY = @_AUDIT_USER_ID,
    OBJDIS_OBJ_ID = @PA_OBJDIS_OBJ_ID,
    OBJDIS_PRINCIPAL_ID = @PA_OBJDIS_PRINCIPAL_ID,
    OBJDIS_DISPLAY = @PA_OBJDIS_DISPLAY
  where OBJDIS_ID = @PA_OBJDIS_ID;
end
go
