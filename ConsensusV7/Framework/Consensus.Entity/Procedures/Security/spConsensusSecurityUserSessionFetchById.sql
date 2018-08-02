if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityUserSessionFetchById')
  exec ('create procedure dbo.spConsensusSecurityUserSessionFetchById as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityUserSessionFetchById(@PA_SESSION_ID uniqueidentifier = null output) as 
begin
  select 
    SESSION_ID,
    SESSION_USER_ID,
    SESSION_ACTIVE,
    SESSION_EXPIRY,
    SESSION_STATUS
  from dbo.User_Session
  where SESSION_ID = @PA_SESSION_ID
end
go
