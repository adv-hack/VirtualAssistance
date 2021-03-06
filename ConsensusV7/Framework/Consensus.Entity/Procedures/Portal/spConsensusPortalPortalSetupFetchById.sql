if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusPortalPortalSetupFetchById')
  exec ('create procedure dbo.spConsensusPortalPortalSetupFetchById as select 1 as temp')
go
alter procedure dbo.spConsensusPortalPortalSetupFetchById(@PA_PS_ID integer = null output) as 
begin
  select 
    PS_ID,
    PS_ADD_DATE,
    PS_ADD_BY,
    PS_MOD_DATE,
    PS_MOD_BY,
    PS_RCV_DATE,
    PS_RCV_FROM,
    PS_DISPLAY_LOGO,
    PS_LOGO_FILE,
    PS_DISPLAY_MENU,
    PS_DISPLAY_HEADER,
    PS_DISPLAY_FOOTER,
    PS_COPYRIGHT_MESSAGE,
    PS_PST_ID,
    PS_PORTAL_TITLE,
    PS_START_PMENU_ID,
    PS_PORTAL_URL,
    PS_PORTAL_LANG_PREFIX,
    PS_SESSION_TIMEOUT,
    PS_SECURE_SITE,
    PS_DISPLAY_DATE,
    PS_SINGLE_SIGNON,
    PS_PRINCIP_ORG_ID,
    PS_RSS_FEED_TTL,
    PS_RSS_FEED_CH_DESC,
    PS_GLB_PMENU_ID,
    PS_TOP_MENU_HTML,
    PS_ADDITIONAL_HEADTAGS,
    PS_BOOTSTRAP,
    PS_MENUBRAND,
    PS_FB_APP_ID,
    PS_HIDE_TOOLBAR_ANONY,
    PS_MINI_IMAGE,
    PS_IMPERSONATE_USER,
    PS_IMPERSONATE_PASSWORD,
    PS_LOCAL_PATH,
    PS_GLOBAL_LOGIN_PMENU_ID,
    PS_MESSAGES_PMENU_ID,
    PS_PRIMARY_PRODUCT_PMENU_ID,
    PS_PRIMARY_EVENT_PMENU_ID,
    PS_GOOGLE_API_KEY,
    PS_SHOW_BREADCRUMB,
    PS_SHOW_USER_AVATAR
  from dbo.PORTAL_SETUP
  where PS_ID = @PA_PS_ID
end
go
