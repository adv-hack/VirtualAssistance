if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusUserInterfaceScreenObjectEntryFetchById')
  exec ('create procedure dbo.spConsensusUserInterfaceScreenObjectEntryFetchById as select 1 as temp')
go
alter procedure dbo.spConsensusUserInterfaceScreenObjectEntryFetchById(@PA_OBJENT_ID integer = null output) as 
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
  where OBJENT_ID = @PA_OBJENT_ID
end
go
