if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSearchSystemSearchesModify')
  exec ('create procedure dbo.spConsensusSearchSystemSearchesModify as select 1 as temp')
go
alter procedure dbo.spConsensusSearchSystemSearchesModify(@PA_SYSS_ID integer = null output, @PA_SYSS_TYPE varchar(50) = null output, @PA_SYSS_SYS_TYPE tinyint = null output, @PA_SYSS_PAGE_TITLE varchar(50) = null output, @PA_SYSS_SEARCH_DISPLAY_NAME varchar(100) = null output, @PA_SYSS_DISPLAY_ORDER integer = null output, @PA_SYSS_DB_VIEW_NAME varchar(255) = null output, @PA_SYSS_DB_VIEW_FIELDS varchar(max) = null output, @PA_SYSS_ORDER_BY varchar(255) = null output, @PA_SYSS_DOUBLE_CLICK_ACTION_COLUMN integer = null output, @PA_SYSS_DEFAULT_SORT_COLUMN varchar(max) = null output, @PA_SYSS_BANNER_TEXT varchar(max) = null output, @PA_SYSS_SHOW_DROPDOWN bit = null output, @PA_SYSS_AUTOSEARCH bit = null output, @PA_SYSS_HIDE_PARAMETER_SECTION bit = null output, @PA_SYSS_DEFAULT_MAX_RESULTS integer = null output, @PA_SYSS_CUSTOM_CLIENT_SCRIPT varchar(max) = null output, @PA_SYSS_PERMISSIONS varchar(100) = null output, @PA_SYSS_SHOW_EXPORT_OPTION bit = null output, @PA_SYSS_MULTISELECT tinyint = null output, @PA_SYSS_SEARCH_CUSTOM varchar(max) = null output, @PA_SYSS_DB_STORED_PROC varchar(255) = null output, @PA_SYSS_USE_STORED_PROC bit = null output, @PA_SYSS_NEW_BUTTON varchar(1000) = null output, @PA_SYSS_SAVE_JSON varchar(1000) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.System_Searches set
    SYSS_MOD_DATE = getDate(),
    SYSS_MOD_BY = @_AUDIT_USER_ID,
    SYSS_TYPE = @PA_SYSS_TYPE,
    SYSS_SYS_TYPE = @PA_SYSS_SYS_TYPE,
    SYSS_PAGE_TITLE = @PA_SYSS_PAGE_TITLE,
    SYSS_SEARCH_DISPLAY_NAME = @PA_SYSS_SEARCH_DISPLAY_NAME,
    SYSS_DISPLAY_ORDER = @PA_SYSS_DISPLAY_ORDER,
    SYSS_DB_VIEW_NAME = @PA_SYSS_DB_VIEW_NAME,
    SYSS_DB_VIEW_FIELDS = @PA_SYSS_DB_VIEW_FIELDS,
    SYSS_ORDER_BY = @PA_SYSS_ORDER_BY,
    SYSS_DOUBLE_CLICK_ACTION_COLUMN = @PA_SYSS_DOUBLE_CLICK_ACTION_COLUMN,
    SYSS_DEFAULT_SORT_COLUMN = @PA_SYSS_DEFAULT_SORT_COLUMN,
    SYSS_BANNER_TEXT = @PA_SYSS_BANNER_TEXT,
    SYSS_SHOW_DROPDOWN = @PA_SYSS_SHOW_DROPDOWN,
    SYSS_AUTOSEARCH = @PA_SYSS_AUTOSEARCH,
    SYSS_HIDE_PARAMETER_SECTION = @PA_SYSS_HIDE_PARAMETER_SECTION,
    SYSS_DEFAULT_MAX_RESULTS = @PA_SYSS_DEFAULT_MAX_RESULTS,
    SYSS_CUSTOM_CLIENT_SCRIPT = @PA_SYSS_CUSTOM_CLIENT_SCRIPT,
    SYSS_PERMISSIONS = @PA_SYSS_PERMISSIONS,
    SYSS_SHOW_EXPORT_OPTION = @PA_SYSS_SHOW_EXPORT_OPTION,
    SYSS_MULTISELECT = @PA_SYSS_MULTISELECT,
    SYSS_SEARCH_CUSTOM = @PA_SYSS_SEARCH_CUSTOM,
    SYSS_DB_STORED_PROC = @PA_SYSS_DB_STORED_PROC,
    SYSS_USE_STORED_PROC = @PA_SYSS_USE_STORED_PROC,
    SYSS_NEW_BUTTON = @PA_SYSS_NEW_BUTTON,
    SYSS_SAVE_JSON = @PA_SYSS_SAVE_JSON
  where SYSS_ID = @PA_SYSS_ID;
end
go
