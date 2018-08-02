if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusUserInterfaceScreenObjectFetchById')
  exec ('create procedure dbo.spConsensusUserInterfaceScreenObjectFetchById as select 1 as temp')
go
alter procedure dbo.spConsensusUserInterfaceScreenObjectFetchById(@PA_OBJ_ID integer = null output) as 
begin
  select 
    OBJ_ID,
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
  from dbo.Screen_Object
  where OBJ_ID = @PA_OBJ_ID
end
go
