if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusUserInterfaceScreenCustomFieldValueRemoveById')
  exec ('create procedure dbo.spConsensusUserInterfaceScreenCustomFieldValueRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusUserInterfaceScreenCustomFieldValueRemoveById(@PA_CFVALUE_ID integer = null output) as 
begin
  delete 
  from dbo.Screen_Custom_Field_Value
  where CFVALUE_ID = @PA_CFVALUE_ID
end
go
