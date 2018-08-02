if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusUserInterfaceScreenCustomFieldListitemFetchAllByCfieldid')
  exec ('create procedure dbo.spConsensusUserInterfaceScreenCustomFieldListitemFetchAllByCfieldid as select 1 as temp')
go
alter procedure dbo.spConsensusUserInterfaceScreenCustomFieldListitemFetchAllByCfieldid(@PA_CFLITEM_CFIELD_ID integer = null output) as 
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
  where CFLITEM_CFIELD_ID = @PA_CFLITEM_CFIELD_ID
end
go
