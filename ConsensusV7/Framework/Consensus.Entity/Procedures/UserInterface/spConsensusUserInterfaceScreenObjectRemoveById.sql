if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusUserInterfaceScreenObjectRemoveById')
  exec ('create procedure dbo.spConsensusUserInterfaceScreenObjectRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusUserInterfaceScreenObjectRemoveById(@PA_OBJ_ID integer = null output) as 
begin
  delete 
  from dbo.Screen_Object
  where OBJ_ID = @PA_OBJ_ID
end
go
