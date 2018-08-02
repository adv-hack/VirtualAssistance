if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusUserInterfaceSystemmenusFetchById')
  exec ('create procedure dbo.spConsensusUserInterfaceSystemmenusFetchById as select 1 as temp')
go
alter procedure dbo.spConsensusUserInterfaceSystemmenusFetchById(@PA_SMENU_ID integer = null output) as 
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
  where SMENU_ID = @PA_SMENU_ID
end
go
