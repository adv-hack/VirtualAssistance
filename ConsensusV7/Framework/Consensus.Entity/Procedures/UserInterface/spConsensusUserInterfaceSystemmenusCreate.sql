if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusUserInterfaceSystemmenusCreate')
  exec ('create procedure dbo.spConsensusUserInterfaceSystemmenusCreate as select 1 as temp')
go
alter procedure dbo.spConsensusUserInterfaceSystemmenusCreate(@PA_SMENU_ID integer = null output, @PA_SMENU_NAME varchar(240) = null output, @PA_SMENU_URL varchar(240) = null output, @PA_SMENU_GROUP varchar(20) = null output, @PA_SMENU_USER_ID varchar(11) = null output, @PA_SMENU_TYPE varchar(40) = null output, @PA_SMENU_SYSTEM tinyint = null output, @PA_SMENU_ICON varchar(100) = null output, @PA_SMENU_RELATIVE_PATH varchar(2048) = null output, @PA_SMENU_SMENU_ID integer = null output, @PA_SMENU_NAME_ID varchar(100) = null output, @PA_SMENU_NAME_REF varchar(100) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.SystemMenus(
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
  ) values (
    @PA_SMENU_NAME,
    @PA_SMENU_URL,
    @PA_SMENU_GROUP,
    @PA_SMENU_USER_ID,
    @PA_SMENU_TYPE,
    @PA_SMENU_SYSTEM,
    @PA_SMENU_ICON,
    @PA_SMENU_RELATIVE_PATH,
    @PA_SMENU_SMENU_ID,
    @PA_SMENU_NAME_ID,
    @PA_SMENU_NAME_REF
  );
    set @PA_SMENU_ID = @@identity;
end
go
