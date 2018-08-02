if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSearchSystemSearchesFetchById')
  exec ('create procedure dbo.spConsensusSearchSystemSearchesFetchById as select 1 as temp')
go
alter procedure dbo.spConsensusSearchSystemSearchesFetchById(@PA_SYSS_ID integer = null output) as 
begin
  select 
    SYSS_ID,
    SYSS_ADD_BY,
    SYSS_ADD_DATE,
    SYSS_MOD_BY,
    SYSS_MOD_DATE,
    SYSS_TYPE,
    SYSS_SYS_TYPE,
    SYSS_PAGE_TITLE,
    SYSS_SEARCH_DISPLAY_NAME,
    SYSS_DISPLAY_ORDER,
    SYSS_DB_VIEW_NAME,
    SYSS_DB_VIEW_FIELDS,
    SYSS_ORDER_BY,
    SYSS_DOUBLE_CLICK_ACTION_COLUMN,
    SYSS_DEFAULT_SORT_COLUMN,
    SYSS_BANNER_TEXT,
    SYSS_SHOW_DROPDOWN,
    SYSS_AUTOSEARCH,
    SYSS_HIDE_PARAMETER_SECTION,
    SYSS_DEFAULT_MAX_RESULTS,
    SYSS_CUSTOM_CLIENT_SCRIPT,
    SYSS_PERMISSIONS,
    SYSS_SHOW_EXPORT_OPTION,
    SYSS_MULTISELECT,
    SYSS_SEARCH_CUSTOM,
    SYSS_DB_STORED_PROC,
    SYSS_USE_STORED_PROC,
    SYSS_NEW_BUTTON,
    SYSS_SAVE_JSON
  from dbo.System_Searches
  where SYSS_ID = @PA_SYSS_ID
end
go
