if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityUserSessionFetchAll')
  exec ('create procedure dbo.spConsensusSecurityUserSessionFetchAll as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityUserSessionFetchAll as 
begin
  select 
    SESSION_ID,
    SESSION_USER_ID,
    SESSION_ACTIVE,
    SESSION_EXPIRY,
    SESSION_STATUS
  from dbo.User_Session
end
go
