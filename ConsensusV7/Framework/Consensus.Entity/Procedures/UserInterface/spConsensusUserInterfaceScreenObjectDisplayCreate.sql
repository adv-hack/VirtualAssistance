if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusUserInterfaceScreenObjectDisplayCreate')
  exec ('create procedure dbo.spConsensusUserInterfaceScreenObjectDisplayCreate as select 1 as temp')
go
alter procedure dbo.spConsensusUserInterfaceScreenObjectDisplayCreate(@PA_OBJDIS_ID integer = null output, @PA_OBJDIS_OBJ_ID integer = null output, @PA_OBJDIS_PRINCIPAL_ID integer = null output, @PA_OBJDIS_DISPLAY tinyint = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.Screen_Object_Display(
    OBJDIS_ADD_DATE,
    OBJDIS_ADD_BY,
    OBJDIS_MOD_DATE,
    OBJDIS_MOD_BY,
    OBJDIS_OBJ_ID,
    OBJDIS_PRINCIPAL_ID,
    OBJDIS_DISPLAY
  ) values (
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    @PA_OBJDIS_OBJ_ID,
    @PA_OBJDIS_PRINCIPAL_ID,
    @PA_OBJDIS_DISPLAY
  );
    set @PA_OBJDIS_ID = @@identity;
end
go
