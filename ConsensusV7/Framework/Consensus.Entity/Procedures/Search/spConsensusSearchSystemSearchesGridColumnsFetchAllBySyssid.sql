if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSearchSystemSearchesGridColumnsFetchAllBySyssid')
  exec ('create procedure dbo.spConsensusSearchSystemSearchesGridColumnsFetchAllBySyssid as select 1 as temp')
go
alter procedure dbo.spConsensusSearchSystemSearchesGridColumnsFetchAllBySyssid(@PA_SYSSC_SYSS_ID integer = null output) as 
begin
  select 
    SYSSC_ID,
    SYSSC_ADD_BY,
    SYSSC_ADD_DATE,
    SYSSC_MOD_BY,
    SYSSC_MOD_DATE,
    SYSSC_SYSS_ID,
    SYSSC_DISPLAY_ORDER,
    SYSSC_FIELD_MAPPING,
    SYSSC_NAME,
    SYSSC_LABEL,
    SYSSC_TOOLTIP_TEXT,
    SYSSC_INDEX,
    SYSSC_WIDTH,
    SYSSC_ALIGN,
    SYSSC_VISIBLE,
    SYSSC_VISIBLE_CONDITION,
    SYSSC_OUTPUT_TYPE,
    SYSSC_SHOW_IN_BASIC_RESULTS,
    SYSSC_CELLATTR,
    SYSSC_SORT_TYPE,
    SYSSC_PERMISSIONS,
    SYSSC_DISPLAY_FORMAT,
    SYSSC_DISPLAY_FORMAT_TRUE,
    SYSSC_DISPLAY_FORMAT_FALSE,
    SYSSC_KEY,
    SYSSC_V7_COLUMN_TYPE,
    SYSSC_V7_COLUMN_HTML,
    SYSSC_V7_COLUMN_LINK_TEXT,
    SYSSC_V7_COLUMN_LINK_HREF,
    SYSSC_V7_COLUMN_ICON_TRUE_ICON,
    SYSSC_V7_COLUMN_ICON_TRUE_TEXT,
    SYSSC_V7_COLUMN_ICON_TRUE_CSS,
    SYSSC_V7_COLUMN_ICON_FALSE_ICON,
    SYSSC_V7_COLUMN_ICON_FALSE_TEXT,
    SYSSC_V7_COLUMN_ICON_FALSE_CSS
  from dbo.System_Searches_Grid_Columns
  where SYSSC_SYSS_ID = @PA_SYSSC_SYSS_ID
end
go
