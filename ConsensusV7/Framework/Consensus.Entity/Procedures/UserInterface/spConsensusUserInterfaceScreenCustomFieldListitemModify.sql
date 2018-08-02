if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusUserInterfaceScreenCustomFieldListitemModify')
  exec ('create procedure dbo.spConsensusUserInterfaceScreenCustomFieldListitemModify as select 1 as temp')
go
alter procedure dbo.spConsensusUserInterfaceScreenCustomFieldListitemModify(@PA_CFLITEM_ID integer = null output, @PA_CFLITEM_CFIELD_ID integer = null output, @PA_CFLITEM_ID_VALUE nvarchar(11) = null output, @PA_CFLITEM_TEXT nvarchar(max) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.Screen_Custom_Field_ListItem set
    CFLITEM_MOD_DATE = getDate(),
    CFLITEM_MOD_BY = @_AUDIT_USER_ID,
    CFLITEM_CFIELD_ID = @PA_CFLITEM_CFIELD_ID,
    CFLITEM_ID_VALUE = @PA_CFLITEM_ID_VALUE,
    CFLITEM_TEXT = @PA_CFLITEM_TEXT
  where CFLITEM_ID = @PA_CFLITEM_ID;
end
go
