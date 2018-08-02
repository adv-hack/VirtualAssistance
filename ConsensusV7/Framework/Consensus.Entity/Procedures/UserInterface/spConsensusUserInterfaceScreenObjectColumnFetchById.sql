if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusUserInterfaceScreenObjectColumnFetchById')
  exec ('create procedure dbo.spConsensusUserInterfaceScreenObjectColumnFetchById as select 1 as temp')
go
alter procedure dbo.spConsensusUserInterfaceScreenObjectColumnFetchById(@PA_OBJCOL_ID integer = null output) as 
begin
  select 
    OBJCOL_ID,
    OBJCOL_ADD_DATE,
    OBJCOL_ADD_BY,
    OBJCOL_MOD_DATE,
    OBJCOL_MOD_BY,
    OBJCOL_OBJ_ID,
    OBJCOL_ORDINAL,
    OBJCOL_CUSTOM,
    OBJCOL_EXPORTABLE,
    OBJCOL_VISIBLE
  from dbo.Screen_Object_Column
  where OBJCOL_ID = @PA_OBJCOL_ID
end
go
