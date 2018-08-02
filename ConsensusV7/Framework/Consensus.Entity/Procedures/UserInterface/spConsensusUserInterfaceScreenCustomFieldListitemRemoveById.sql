if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusUserInterfaceScreenCustomFieldListitemRemoveById')
  exec ('create procedure dbo.spConsensusUserInterfaceScreenCustomFieldListitemRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusUserInterfaceScreenCustomFieldListitemRemoveById(@PA_CFLITEM_ID integer = null output) as 
begin
  delete 
  from dbo.Screen_Custom_Field_ListItem
  where CFLITEM_ID = @PA_CFLITEM_ID
end
go
