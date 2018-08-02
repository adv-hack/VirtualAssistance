if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityC4SessionsCreate')
  exec ('create procedure dbo.spConsensusSecurityC4SessionsCreate as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityC4SessionsCreate(@PA_C4_SESSION_ID varchar(150) = null output, @PA_C4_PROLE_ID varchar(11) = null output, @PA_C4_ORG_ID varchar(11) = null output, @PA_C4_PN_ID varchar(11) = null output, @PA_C4_LOGIN_ID varchar(150) = null output, @PA_C4_STATUS tinyint = null output, @PA_C4_LOGIN_TYPE tinyint = null output, @PA_C4_EXPIRES_ON datetime = null output, @PA_C4_LOGGED_ON datetime = null output, @PA_C4_CONNECT_TIMEOUT tinyint = null output, @PA_C4_FULLNAME varchar(150) = null output, @PA_C4_PROFILE varchar(100) = null output, @PA_C4_SCREEN_WIDTH varchar(10) = null output, @PA_C4_SCREEN_HEIGHT varchar(10) = null output, @PA_C4_IE_VERSION varchar(10) = null output, @PA_C4_DEPUTY_ID varchar(11) = null output, @PA_C4_DOTNET_SESSION_ID nvarchar(128) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.C4_SESSIONS(
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
  ) values (
    @PA_C4_PROLE_ID,
    @PA_C4_ORG_ID,
    @PA_C4_PN_ID,
    @PA_C4_LOGIN_ID,
    @PA_C4_STATUS,
    @PA_C4_LOGIN_TYPE,
    @PA_C4_EXPIRES_ON,
    @PA_C4_LOGGED_ON,
    @PA_C4_CONNECT_TIMEOUT,
    @PA_C4_FULLNAME,
    @PA_C4_PROFILE,
    @PA_C4_SCREEN_WIDTH,
    @PA_C4_SCREEN_HEIGHT,
    @PA_C4_IE_VERSION,
    @PA_C4_DEPUTY_ID,
    @PA_C4_DOTNET_SESSION_ID
  );
    set @PA_C4_SESSION_ID = @@identity;
end
go
