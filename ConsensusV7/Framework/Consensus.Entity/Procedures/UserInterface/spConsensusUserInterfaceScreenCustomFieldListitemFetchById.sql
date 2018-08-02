if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusUserInterfaceScreenCustomFieldListitemFetchById')
  exec ('create procedure dbo.spConsensusUserInterfaceScreenCustomFieldListitemFetchById as select 1 as temp')
go
alter procedure dbo.spConsensusUserInterfaceScreenCustomFieldListitemFetchById(@PA_CFLITEM_ID integer = null output) as 
begin
  select 
    CFLITEM_ID,
    CFLITEM_ADD_DATE,
    CFLITEM_ADD_BY,
    CFLITEM_MOD_DATE,
    CFLITEM_MOD_BY,
    CFLITEM_CFIELD_ID,
    CFLITEM_ID_VALUE,
    CFLITEM_TEXT
  from dbo.Screen_Custom_Field_ListItem
  where CFLITEM_ID = @PA_CFLITEM_ID
end
go
