if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusUserInterfaceScreenObjectColumnRemoveById')
  exec ('create procedure dbo.spConsensusUserInterfaceScreenObjectColumnRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusUserInterfaceScreenObjectColumnRemoveById(@PA_OBJCOL_ID integer = null output) as 
begin
  delete 
  from dbo.Screen_Object_Column
  where OBJCOL_ID = @PA_OBJCOL_ID
end
go
