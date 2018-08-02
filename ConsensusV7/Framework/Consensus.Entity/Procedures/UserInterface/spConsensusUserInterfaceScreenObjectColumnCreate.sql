if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusUserInterfaceScreenObjectColumnCreate')
  exec ('create procedure dbo.spConsensusUserInterfaceScreenObjectColumnCreate as select 1 as temp')
go
alter procedure dbo.spConsensusUserInterfaceScreenObjectColumnCreate(@PA_OBJCOL_ID integer = null output, @PA_OBJCOL_OBJ_ID integer = null output, @PA_OBJCOL_ORDINAL integer = null output, @PA_OBJCOL_CUSTOM varchar(max) = null output, @PA_OBJCOL_EXPORTABLE bit = null output, @PA_OBJCOL_VISIBLE bit = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.Screen_Object_Column(
    OBJCOL_ADD_DATE,
    OBJCOL_ADD_BY,
    OBJCOL_MOD_DATE,
    OBJCOL_MOD_BY,
    OBJCOL_OBJ_ID,
    OBJCOL_ORDINAL,
    OBJCOL_CUSTOM,
    OBJCOL_EXPORTABLE,
    OBJCOL_VISIBLE
  ) values (
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    @PA_OBJCOL_OBJ_ID,
    @PA_OBJCOL_ORDINAL,
    @PA_OBJCOL_CUSTOM,
    @PA_OBJCOL_EXPORTABLE,
    @PA_OBJCOL_VISIBLE
  );
    set @PA_OBJCOL_ID = @@identity;
end
go
