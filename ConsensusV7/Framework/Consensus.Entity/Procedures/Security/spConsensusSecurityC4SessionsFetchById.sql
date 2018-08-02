if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityC4SessionsFetchById')
  exec ('create procedure dbo.spConsensusSecurityC4SessionsFetchById as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityC4SessionsFetchById(@PA_C4_SESSION_ID varchar(150) = null output) as 
begin
  select 
    C4_SESSION_ID,
    C4_PROLE_ID,
    C4_ORG_ID,
    C4_PN_ID,
    C4_LOGIN_ID,
    C4_STATUS,
    C4_LOGIN_TYPE,
    C4_EXPIRES_ON,
    C4_LOGGED_ON,
    C4_CONNECT_TIMEOUT,
    C4_FULLNAME,
    C4_PROFILE,
    C4_SCREEN_WIDTH,
    C4_SCREEN_HEIGHT,
    C4_IE_VERSION,
    C4_DEPUTY_ID,
    C4_DOTNET_SESSION_ID
  from dbo.C4_SESSIONS
  where C4_SESSION_ID = @PA_C4_SESSION_ID
end
go
