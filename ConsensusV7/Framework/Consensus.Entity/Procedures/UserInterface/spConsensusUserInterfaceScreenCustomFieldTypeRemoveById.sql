if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusUserInterfaceScreenCustomFieldTypeRemoveById')
  exec ('create procedure dbo.spConsensusUserInterfaceScreenCustomFieldTypeRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusUserInterfaceScreenCustomFieldTypeRemoveById(@PA_CFTYPE_ID varchar(40) = null output) as 
begin
  delete 
  from dbo.Screen_Custom_Field_Type
  where CFTYPE_ID = @PA_CFTYPE_ID
end
go
