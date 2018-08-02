if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusUserInterfaceScreenObjectEntryFetchAll')
  exec ('create procedure dbo.spConsensusUserInterfaceScreenObjectEntryFetchAll as select 1 as temp')
go
alter procedure dbo.spConsensusUserInterfaceScreenObjectEntryFetchAll as 
begin
  select 
    OBJENT_ID,
    OBJENT_ADD_DATE,
    OBJENT_ADD_BY,
    OBJENT_MOD_DATE,
    OBJENT_MOD_BY,
    OBJENT_OBJ_ID,
    OBJENT_ITEM_NORMAL,
    OBJENT_ITEM_CUSTOM,
    OBJENT_ITEM_HIDE
  from dbo.Screen_Object_Entry
end
go
