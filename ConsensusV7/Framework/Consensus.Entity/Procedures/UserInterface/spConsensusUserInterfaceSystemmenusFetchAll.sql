if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusUserInterfaceSystemmenusFetchAll')
  exec ('create procedure dbo.spConsensusUserInterfaceSystemmenusFetchAll as select 1 as temp')
go
alter procedure dbo.spConsensusUserInterfaceSystemmenusFetchAll as 
begin
  select 
    SMENU_ID,
    SMENU_NAME,
    SMENU_URL,
    SMENU_GROUP,
    SMENU_USER_ID,
    SMENU_TYPE,
    SMENU_SYSTEM,
    SMENU_ICON,
    SMENU_RELATIVE_PATH,
    SMENU_SMENU_ID,
    SMENU_NAME_ID,
    SMENU_NAME_REF
  from dbo.SystemMenus
end
go
