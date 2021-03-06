if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusUserInterfaceScreenObjectDisplayFetchById')
  exec ('create procedure dbo.spConsensusUserInterfaceScreenObjectDisplayFetchById as select 1 as temp')
go
alter procedure dbo.spConsensusUserInterfaceScreenObjectDisplayFetchById(@PA_OBJDIS_ID integer = null output) as 
begin
  select 
    OBJDIS_ID,
    OBJDIS_ADD_DATE,
    OBJDIS_ADD_BY,
    OBJDIS_MOD_DATE,
    OBJDIS_MOD_BY,
    OBJDIS_OBJ_ID,
    OBJDIS_PRINCIPAL_ID,
    OBJDIS_DISPLAY
  from dbo.Screen_Object_Display
  where OBJDIS_ID = @PA_OBJDIS_ID
end
go
