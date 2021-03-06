if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusUserInterfaceScreenObjectCreate')
  exec ('create procedure dbo.spConsensusUserInterfaceScreenObjectCreate as select 1 as temp')
go
alter procedure dbo.spConsensusUserInterfaceScreenObjectCreate(@PA_OBJ_ID integer = null output, @PA_OBJ_URL nvarchar(max) = null output, @PA_OBJ_CONTROL nvarchar(max) = null output, @PA_OBJ_TITLE nvarchar(max) = null output, @PA_OBJ_ICON nvarchar(128) = null output, @PA_OBJ_DISPLAY tinyint = null output, @PA_OBJ_VALIDATOR_EXPRESSION nvarchar(max) = null output, @PA_OBJ_VALIDATOR_MESSAGE nvarchar(max) = null output, @PA_OBJ_VALIDATOR_CRITICAL bit = null output, @PA_OBJ_MAX_LENGTH integer = null output, @PA_OBJ_OFF_TEXT nvarchar(128) = null output, @PA_OBJ_OFF_COLOUR nvarchar(128) = null output, @PA_OBJ_ON_TEXT nvarchar(128) = null output, @PA_OBJ_ON_COLOUR nvarchar(128) = null output, @PA_OBJ_REQUIREMENT tinyint = null output, @PA_OBJ_DEFAULT varchar(max) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.Screen_Object(
    OBJ_ADD_DATE,
    OBJ_ADD_BY,
    OBJ_MOD_DATE,
    OBJ_MOD_BY,
    OBJ_URL,
    OBJ_CONTROL,
    OBJ_TITLE,
    OBJ_ICON,
    OBJ_DISPLAY,
    OBJ_VALIDATOR_EXPRESSION,
    OBJ_VALIDATOR_MESSAGE,
    OBJ_VALIDATOR_CRITICAL,
    OBJ_MAX_LENGTH,
    OBJ_OFF_TEXT,
    OBJ_OFF_COLOUR,
    OBJ_ON_TEXT,
    OBJ_ON_COLOUR,
    OBJ_REQUIREMENT,
    OBJ_DEFAULT
  ) values (
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    @PA_OBJ_URL,
    @PA_OBJ_CONTROL,
    @PA_OBJ_TITLE,
    @PA_OBJ_ICON,
    @PA_OBJ_DISPLAY,
    @PA_OBJ_VALIDATOR_EXPRESSION,
    @PA_OBJ_VALIDATOR_MESSAGE,
    @PA_OBJ_VALIDATOR_CRITICAL,
    @PA_OBJ_MAX_LENGTH,
    @PA_OBJ_OFF_TEXT,
    @PA_OBJ_OFF_COLOUR,
    @PA_OBJ_ON_TEXT,
    @PA_OBJ_ON_COLOUR,
    @PA_OBJ_REQUIREMENT,
    @PA_OBJ_DEFAULT
  );
    set @PA_OBJ_ID = @@identity;
end
go
