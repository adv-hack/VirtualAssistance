if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusUserInterfaceScreenCustomFieldFetchAllByPage')
  exec ('create procedure dbo.spConsensusUserInterfaceScreenCustomFieldFetchAllByPage as select 1 as temp')
go
alter procedure dbo.spConsensusUserInterfaceScreenCustomFieldFetchAllByPage (
	@PA_PAGE nvarchar(250) = null output
) 
as 
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
  where CFIELD_PAGE = @PA_PAGE
end
go
