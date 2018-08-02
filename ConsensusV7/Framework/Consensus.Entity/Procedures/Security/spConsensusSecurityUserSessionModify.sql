if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityUserSessionModify')
  exec ('create procedure dbo.spConsensusSecurityUserSessionModify as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityUserSessionModify(@PA_SESSION_ID uniqueidentifier = null output, @PA_SESSION_USER_ID integer = null output, @PA_SESSION_ACTIVE datetime = null output, @PA_SESSION_EXPIRY datetime = null output, @PA_SESSION_STATUS integer = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.User_Session set
    SESSION_USER_ID = @PA_SESSION_USER_ID,
    SESSION_ACTIVE = @PA_SESSION_ACTIVE,
    SESSION_EXPIRY = @PA_SESSION_EXPIRY,
    SESSION_STATUS = @PA_SESSION_STATUS
  where SESSION_ID = @PA_SESSION_ID;
end
go
