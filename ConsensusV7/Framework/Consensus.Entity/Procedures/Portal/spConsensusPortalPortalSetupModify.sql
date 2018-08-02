if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusPortalPortalSetupModify')
  exec ('create procedure dbo.spConsensusPortalPortalSetupModify as select 1 as temp')
go
alter procedure dbo.spConsensusPortalPortalSetupModify(@PA_PS_ID integer = null output, @PA_PS_DISPLAY_LOGO tinyint = null output, @PA_PS_LOGO_FILE varchar(255) = null output, @PA_PS_DISPLAY_MENU tinyint = null output, @PA_PS_DISPLAY_HEADER tinyint = null output, @PA_PS_DISPLAY_FOOTER tinyint = null output, @PA_PS_COPYRIGHT_MESSAGE varchar(max) = null output, @PA_PS_PST_ID integer = null output, @PA_PS_PORTAL_TITLE varchar(100) = null output, @PA_PS_START_PMENU_ID integer = null output, @PA_PS_PORTAL_URL varchar(1024) = null output, @PA_PS_PORTAL_LANG_PREFIX varchar(50) = null output, @PA_PS_SESSION_TIMEOUT integer = null output, @PA_PS_SECURE_SITE tinyint = null output, @PA_PS_DISPLAY_DATE tinyint = null output, @PA_PS_SINGLE_SIGNON tinyint = null output, @PA_PS_PRINCIP_ORG_ID varchar(11) = null output, @PA_PS_RSS_FEED_TTL integer = null output, @PA_PS_RSS_FEED_CH_DESC varchar(200) = null output, @PA_PS_GLB_PMENU_ID integer = null output, @PA_PS_TOP_MENU_HTML varchar(max) = null output, @PA_PS_ADDITIONAL_HEADTAGS varchar(max) = null output, @PA_PS_BOOTSTRAP tinyint = null output, @PA_PS_MENUBRAND varchar(max) = null output, @PA_PS_FB_APP_ID varchar(50) = null output, @PA_PS_HIDE_TOOLBAR_ANONY tinyint = null output, @PA_PS_MINI_IMAGE varchar(256) = null output, @PA_PS_IMPERSONATE_USER varchar(255) = null output, @PA_PS_IMPERSONATE_PASSWORD varchar(255) = null output, @PA_PS_LOCAL_PATH varchar(500) = null output, @PA_PS_GLOBAL_LOGIN_PMENU_ID integer = null output, @PA_PS_MESSAGES_PMENU_ID integer = null output, @PA_PS_PRIMARY_PRODUCT_PMENU_ID integer = null output, @PA_PS_PRIMARY_EVENT_PMENU_ID integer = null output, @PA_PS_GOOGLE_API_KEY varchar(50) = null output, @PA_PS_SHOW_BREADCRUMB tinyint = null output, @PA_PS_SHOW_USER_AVATAR tinyint = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.PORTAL_SETUP set
    PS_MOD_DATE = getDate(),
    PS_MOD_BY = @_AUDIT_USER_ID,
    PS_DISPLAY_LOGO = @PA_PS_DISPLAY_LOGO,
    PS_LOGO_FILE = @PA_PS_LOGO_FILE,
    PS_DISPLAY_MENU = @PA_PS_DISPLAY_MENU,
    PS_DISPLAY_HEADER = @PA_PS_DISPLAY_HEADER,
    PS_DISPLAY_FOOTER = @PA_PS_DISPLAY_FOOTER,
    PS_COPYRIGHT_MESSAGE = @PA_PS_COPYRIGHT_MESSAGE,
    PS_PST_ID = @PA_PS_PST_ID,
    PS_PORTAL_TITLE = @PA_PS_PORTAL_TITLE,
    PS_START_PMENU_ID = @PA_PS_START_PMENU_ID,
    PS_PORTAL_URL = @PA_PS_PORTAL_URL,
    PS_PORTAL_LANG_PREFIX = @PA_PS_PORTAL_LANG_PREFIX,
    PS_SESSION_TIMEOUT = @PA_PS_SESSION_TIMEOUT,
    PS_SECURE_SITE = @PA_PS_SECURE_SITE,
    PS_DISPLAY_DATE = @PA_PS_DISPLAY_DATE,
    PS_SINGLE_SIGNON = @PA_PS_SINGLE_SIGNON,
    PS_PRINCIP_ORG_ID = @PA_PS_PRINCIP_ORG_ID,
    PS_RSS_FEED_TTL = @PA_PS_RSS_FEED_TTL,
    PS_RSS_FEED_CH_DESC = @PA_PS_RSS_FEED_CH_DESC,
    PS_GLB_PMENU_ID = @PA_PS_GLB_PMENU_ID,
    PS_TOP_MENU_HTML = @PA_PS_TOP_MENU_HTML,
    PS_ADDITIONAL_HEADTAGS = @PA_PS_ADDITIONAL_HEADTAGS,
    PS_BOOTSTRAP = @PA_PS_BOOTSTRAP,
    PS_MENUBRAND = @PA_PS_MENUBRAND,
    PS_FB_APP_ID = @PA_PS_FB_APP_ID,
    PS_HIDE_TOOLBAR_ANONY = @PA_PS_HIDE_TOOLBAR_ANONY,
    PS_MINI_IMAGE = @PA_PS_MINI_IMAGE,
    PS_IMPERSONATE_USER = @PA_PS_IMPERSONATE_USER,
    PS_IMPERSONATE_PASSWORD = @PA_PS_IMPERSONATE_PASSWORD,
    PS_LOCAL_PATH = @PA_PS_LOCAL_PATH,
    PS_GLOBAL_LOGIN_PMENU_ID = @PA_PS_GLOBAL_LOGIN_PMENU_ID,
    PS_MESSAGES_PMENU_ID = @PA_PS_MESSAGES_PMENU_ID,
    PS_PRIMARY_PRODUCT_PMENU_ID = @PA_PS_PRIMARY_PRODUCT_PMENU_ID,
    PS_PRIMARY_EVENT_PMENU_ID = @PA_PS_PRIMARY_EVENT_PMENU_ID,
    PS_GOOGLE_API_KEY = @PA_PS_GOOGLE_API_KEY,
    PS_SHOW_BREADCRUMB = @PA_PS_SHOW_BREADCRUMB,
    PS_SHOW_USER_AVATAR = @PA_PS_SHOW_USER_AVATAR
  where PS_ID = @PA_PS_ID;
end
go
