if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusUserInterfaceScreenObjectEntryRemoveById')
  exec ('create procedure dbo.spConsensusUserInterfaceScreenObjectEntryRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusUserInterfaceScreenObjectEntryRemoveById(@PA_OBJENT_ID integer = null output) as 
begin
  delete 
  from dbo.Screen_Object_Entry
  where OBJENT_ID = @PA_OBJENT_ID
end
go
