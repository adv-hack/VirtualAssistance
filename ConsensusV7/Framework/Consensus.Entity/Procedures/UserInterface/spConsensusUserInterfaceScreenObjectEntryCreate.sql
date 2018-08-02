if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusUserInterfaceScreenObjectEntryCreate')
  exec ('create procedure dbo.spConsensusUserInterfaceScreenObjectEntryCreate as select 1 as temp')
go
alter procedure dbo.spConsensusUserInterfaceScreenObjectEntryCreate(@PA_OBJENT_ID integer = null output, @PA_OBJENT_OBJ_ID integer = null output, @PA_OBJENT_ITEM_NORMAL nvarchar(max) = null output, @PA_OBJENT_ITEM_CUSTOM nvarchar(max) = null output, @PA_OBJENT_ITEM_HIDE bit = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.Screen_Object_Entry(
    OBJENT_ADD_DATE,
    OBJENT_ADD_BY,
    OBJENT_MOD_DATE,
    OBJENT_MOD_BY,
    OBJENT_OBJ_ID,
    OBJENT_ITEM_NORMAL,
    OBJENT_ITEM_CUSTOM,
    OBJENT_ITEM_HIDE
  ) values (
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    @PA_OBJENT_OBJ_ID,
    @PA_OBJENT_ITEM_NORMAL,
    @PA_OBJENT_ITEM_CUSTOM,
    @PA_OBJENT_ITEM_HIDE
  );
    set @PA_OBJENT_ID = @@identity;
end
go
