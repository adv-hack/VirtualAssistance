if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusUserInterfaceScreenCustomFieldRemoveById')
  exec ('create procedure dbo.spConsensusUserInterfaceScreenCustomFieldRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusUserInterfaceScreenCustomFieldRemoveById(@PA_CFIELD_ID integer = null output) as 
begin
  delete 
  from dbo.Screen_Custom_Field
  where CFIELD_ID = @PA_CFIELD_ID
end
go
