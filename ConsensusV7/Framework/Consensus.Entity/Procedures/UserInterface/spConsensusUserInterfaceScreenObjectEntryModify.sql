if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusUserInterfaceScreenObjectEntryModify')
  exec ('create procedure dbo.spConsensusUserInterfaceScreenObjectEntryModify as select 1 as temp')
go
alter procedure dbo.spConsensusUserInterfaceScreenObjectEntryModify(@PA_OBJENT_ID integer = null output, @PA_OBJENT_OBJ_ID integer = null output, @PA_OBJENT_ITEM_NORMAL nvarchar(max) = null output, @PA_OBJENT_ITEM_CUSTOM nvarchar(max) = null output, @PA_OBJENT_ITEM_HIDE bit = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.Screen_Object_Entry set
    OBJENT_MOD_DATE = getDate(),
    OBJENT_MOD_BY = @_AUDIT_USER_ID,
    OBJENT_OBJ_ID = @PA_OBJENT_OBJ_ID,
    OBJENT_ITEM_NORMAL = @PA_OBJENT_ITEM_NORMAL,
    OBJENT_ITEM_CUSTOM = @PA_OBJENT_ITEM_CUSTOM,
    OBJENT_ITEM_HIDE = @PA_OBJENT_ITEM_HIDE
  where OBJENT_ID = @PA_OBJENT_ID;
end
go
