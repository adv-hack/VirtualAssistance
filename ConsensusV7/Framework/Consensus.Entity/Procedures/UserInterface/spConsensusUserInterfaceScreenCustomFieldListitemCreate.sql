if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusUserInterfaceScreenCustomFieldListitemCreate')
  exec ('create procedure dbo.spConsensusUserInterfaceScreenCustomFieldListitemCreate as select 1 as temp')
go
alter procedure dbo.spConsensusUserInterfaceScreenCustomFieldListitemCreate(@PA_CFLITEM_ID integer = null output, @PA_CFLITEM_CFIELD_ID integer = null output, @PA_CFLITEM_ID_VALUE nvarchar(11) = null output, @PA_CFLITEM_TEXT nvarchar(max) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.Screen_Custom_Field_ListItem(
    CFLITEM_ADD_DATE,
    CFLITEM_ADD_BY,
    CFLITEM_MOD_DATE,
    CFLITEM_MOD_BY,
    CFLITEM_CFIELD_ID,
    CFLITEM_ID_VALUE,
    CFLITEM_TEXT
  ) values (
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    @PA_CFLITEM_CFIELD_ID,
    @PA_CFLITEM_ID_VALUE,
    @PA_CFLITEM_TEXT
  );
    set @PA_CFLITEM_ID = @@identity;
end
go
