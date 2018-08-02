if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSearchSystemSearchesGridColumnsModify')
  exec ('create procedure dbo.spConsensusSearchSystemSearchesGridColumnsModify as select 1 as temp')
go
alter procedure dbo.spConsensusSearchSystemSearchesGridColumnsModify(@PA_SYSSC_ID integer = null output, @PA_SYSSC_SYSS_ID integer = null output, @PA_SYSSC_DISPLAY_ORDER integer = null output, @PA_SYSSC_FIELD_MAPPING varchar(255) = null output, @PA_SYSSC_NAME varchar(50) = null output, @PA_SYSSC_LABEL varchar(50) = null output, @PA_SYSSC_TOOLTIP_TEXT varchar(255) = null output, @PA_SYSSC_INDEX varchar(50) = null output, @PA_SYSSC_WIDTH integer = null output, @PA_SYSSC_ALIGN varchar(50) = null output, @PA_SYSSC_VISIBLE bit = null output, @PA_SYSSC_VISIBLE_CONDITION varchar(max) = null output, @PA_SYSSC_OUTPUT_TYPE tinyint = null output, @PA_SYSSC_SHOW_IN_BASIC_RESULTS bit = null output, @PA_SYSSC_CELLATTR varchar(max) = null output, @PA_SYSSC_SORT_TYPE varchar(50) = null output, @PA_SYSSC_PERMISSIONS varchar(100) = null output, @PA_SYSSC_DISPLAY_FORMAT varchar(max) = null output, @PA_SYSSC_DISPLAY_FORMAT_TRUE varchar(max) = null output, @PA_SYSSC_DISPLAY_FORMAT_FALSE varchar(max) = null output, @PA_SYSSC_KEY tinyint = null output, @PA_SYSSC_V7_COLUMN_TYPE varchar(4) = null output, @PA_SYSSC_V7_COLUMN_HTML nvarchar(max) = null output, @PA_SYSSC_V7_COLUMN_LINK_TEXT nvarchar(max) = null output, @PA_SYSSC_V7_COLUMN_LINK_HREF nvarchar(max) = null output, @PA_SYSSC_V7_COLUMN_ICON_TRUE_ICON nvarchar(50) = null output, @PA_SYSSC_V7_COLUMN_ICON_TRUE_TEXT nvarchar(max) = null output, @PA_SYSSC_V7_COLUMN_ICON_TRUE_CSS nvarchar(50) = null output, @PA_SYSSC_V7_COLUMN_ICON_FALSE_ICON nvarchar(50) = null output, @PA_SYSSC_V7_COLUMN_ICON_FALSE_TEXT nvarchar(max) = null output, @PA_SYSSC_V7_COLUMN_ICON_FALSE_CSS nvarchar(50) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.System_Searches_Grid_Columns set
    SYSSC_MOD_DATE = getDate(),
    SYSSC_MOD_BY = @_AUDIT_USER_ID,
    SYSSC_SYSS_ID = @PA_SYSSC_SYSS_ID,
    SYSSC_DISPLAY_ORDER = @PA_SYSSC_DISPLAY_ORDER,
    SYSSC_FIELD_MAPPING = @PA_SYSSC_FIELD_MAPPING,
    SYSSC_NAME = @PA_SYSSC_NAME,
    SYSSC_LABEL = @PA_SYSSC_LABEL,
    SYSSC_TOOLTIP_TEXT = @PA_SYSSC_TOOLTIP_TEXT,
    SYSSC_INDEX = @PA_SYSSC_INDEX,
    SYSSC_WIDTH = @PA_SYSSC_WIDTH,
    SYSSC_ALIGN = @PA_SYSSC_ALIGN,
    SYSSC_VISIBLE = @PA_SYSSC_VISIBLE,
    SYSSC_VISIBLE_CONDITION = @PA_SYSSC_VISIBLE_CONDITION,
    SYSSC_OUTPUT_TYPE = @PA_SYSSC_OUTPUT_TYPE,
    SYSSC_SHOW_IN_BASIC_RESULTS = @PA_SYSSC_SHOW_IN_BASIC_RESULTS,
    SYSSC_CELLATTR = @PA_SYSSC_CELLATTR,
    SYSSC_SORT_TYPE = @PA_SYSSC_SORT_TYPE,
    SYSSC_PERMISSIONS = @PA_SYSSC_PERMISSIONS,
    SYSSC_DISPLAY_FORMAT = @PA_SYSSC_DISPLAY_FORMAT,
    SYSSC_DISPLAY_FORMAT_TRUE = @PA_SYSSC_DISPLAY_FORMAT_TRUE,
    SYSSC_DISPLAY_FORMAT_FALSE = @PA_SYSSC_DISPLAY_FORMAT_FALSE,
    SYSSC_KEY = @PA_SYSSC_KEY,
    SYSSC_V7_COLUMN_TYPE = @PA_SYSSC_V7_COLUMN_TYPE,
    SYSSC_V7_COLUMN_HTML = @PA_SYSSC_V7_COLUMN_HTML,
    SYSSC_V7_COLUMN_LINK_TEXT = @PA_SYSSC_V7_COLUMN_LINK_TEXT,
    SYSSC_V7_COLUMN_LINK_HREF = @PA_SYSSC_V7_COLUMN_LINK_HREF,
    SYSSC_V7_COLUMN_ICON_TRUE_ICON = @PA_SYSSC_V7_COLUMN_ICON_TRUE_ICON,
    SYSSC_V7_COLUMN_ICON_TRUE_TEXT = @PA_SYSSC_V7_COLUMN_ICON_TRUE_TEXT,
    SYSSC_V7_COLUMN_ICON_TRUE_CSS = @PA_SYSSC_V7_COLUMN_ICON_TRUE_CSS,
    SYSSC_V7_COLUMN_ICON_FALSE_ICON = @PA_SYSSC_V7_COLUMN_ICON_FALSE_ICON,
    SYSSC_V7_COLUMN_ICON_FALSE_TEXT = @PA_SYSSC_V7_COLUMN_ICON_FALSE_TEXT,
    SYSSC_V7_COLUMN_ICON_FALSE_CSS = @PA_SYSSC_V7_COLUMN_ICON_FALSE_CSS
  where SYSSC_ID = @PA_SYSSC_ID;
end
go
