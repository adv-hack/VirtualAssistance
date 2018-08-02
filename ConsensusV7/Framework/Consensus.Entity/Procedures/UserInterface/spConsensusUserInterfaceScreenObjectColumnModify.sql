if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusUserInterfaceScreenObjectColumnModify')
  exec ('create procedure dbo.spConsensusUserInterfaceScreenObjectColumnModify as select 1 as temp')
go
alter procedure dbo.spConsensusUserInterfaceScreenObjectColumnModify(@PA_OBJCOL_ID integer = null output, @PA_OBJCOL_OBJ_ID integer = null output, @PA_OBJCOL_ORDINAL integer = null output, @PA_OBJCOL_CUSTOM varchar(max) = null output, @PA_OBJCOL_EXPORTABLE bit = null output, @PA_OBJCOL_VISIBLE bit = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.Screen_Object_Column set
    OBJCOL_MOD_DATE = getDate(),
    OBJCOL_MOD_BY = @_AUDIT_USER_ID,
    OBJCOL_OBJ_ID = @PA_OBJCOL_OBJ_ID,
    OBJCOL_ORDINAL = @PA_OBJCOL_ORDINAL,
    OBJCOL_CUSTOM = @PA_OBJCOL_CUSTOM,
    OBJCOL_EXPORTABLE = @PA_OBJCOL_EXPORTABLE,
    OBJCOL_VISIBLE = @PA_OBJCOL_VISIBLE
  where OBJCOL_ID = @PA_OBJCOL_ID;
end
go
