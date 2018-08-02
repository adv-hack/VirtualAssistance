if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityUserSessionFetchAllByUserid')
  exec ('create procedure dbo.spConsensusSecurityUserSessionFetchAllByUserid as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityUserSessionFetchAllByUserid(@PA_SESSION_USER_ID integer = null output) as 
begin
  select 
    SESSION_ID,
    SESSION_USER_ID,
    SESSION_ACTIVE,
    SESSION_EXPIRY,
    SESSION_STATUS
  from dbo.User_Session
  where SESSION_USER_ID = @PA_SESSION_USER_ID
end
go
