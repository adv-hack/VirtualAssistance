if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusUserInterfaceSystemmenusRemoveById')
  exec ('create procedure dbo.spConsensusUserInterfaceSystemmenusRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusUserInterfaceSystemmenusRemoveById(@PA_SMENU_ID integer = null output) as 
begin
  delete 
  from dbo.SystemMenus
  where SMENU_ID = @PA_SMENU_ID
end
go
