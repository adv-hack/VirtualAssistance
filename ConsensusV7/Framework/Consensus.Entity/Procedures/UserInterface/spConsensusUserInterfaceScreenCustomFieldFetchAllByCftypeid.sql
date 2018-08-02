if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusUserInterfaceScreenCustomFieldFetchAllByCftypeid')
  exec ('create procedure dbo.spConsensusUserInterfaceScreenCustomFieldFetchAllByCftypeid as select 1 as temp')
go
alter procedure dbo.spConsensusUserInterfaceScreenCustomFieldFetchAllByCftypeid(@PA_CFIELD_CFTYPE_ID varchar(40) = null output) as 
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
  where CFIELD_CFTYPE_ID = @PA_CFIELD_CFTYPE_ID
end
go
