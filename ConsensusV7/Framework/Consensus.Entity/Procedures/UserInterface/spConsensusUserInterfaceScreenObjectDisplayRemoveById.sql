if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusUserInterfaceScreenObjectDisplayRemoveById')
  exec ('create procedure dbo.spConsensusUserInterfaceScreenObjectDisplayRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusUserInterfaceScreenObjectDisplayRemoveById(@PA_OBJDIS_ID integer = null output) as 
begin
  delete 
  from dbo.Screen_Object_Display
  where OBJDIS_ID = @PA_OBJDIS_ID
end
go
