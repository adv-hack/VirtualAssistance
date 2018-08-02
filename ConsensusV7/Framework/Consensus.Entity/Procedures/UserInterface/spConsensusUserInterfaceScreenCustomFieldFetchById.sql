if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusUserInterfaceScreenCustomFieldFetchById')
  exec ('create procedure dbo.spConsensusUserInterfaceScreenCustomFieldFetchById as select 1 as temp')
go
alter procedure dbo.spConsensusUserInterfaceScreenCustomFieldFetchById(@PA_CFIELD_ID integer = null output) as 
begin
  select 
    CFIELD_ID,
    CFIELD_ADD_DATE,
    CFIELD_ADD_BY,
    CFIELD_MOD_DATE,
    CFIELD_MOD_BY,
    CFIELD_URL,
    CFIELD_PARENT_CONTROL,
    CFIELD_NAME,
    CFIELD_LABEL,
    CFIELD_CFTYPE_ID,
    CFIELD_POPUP_URL,
    CFIELD_DECIMALS,
    CFIELD_PAGE,
    CFIELD_TABLE
  from dbo.Screen_Custom_Field
  where CFIELD_ID = @PA_CFIELD_ID
end
go
