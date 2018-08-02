if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityUserSessionCreate')
  exec ('create procedure dbo.spConsensusSecurityUserSessionCreate as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityUserSessionCreate(@PA_SESSION_ID uniqueidentifier = null output, @PA_SESSION_USER_ID integer = null output, @PA_SESSION_ACTIVE datetime = null output, @PA_SESSION_EXPIRY datetime = null output, @PA_SESSION_STATUS integer = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  set @PA_SESSION_ID = newid();
  
  insert into dbo.User_Session(
    SESSION_ID,
    SESSION_USER_ID,
    SESSION_ACTIVE,
    SESSION_EXPIRY,
    SESSION_STATUS
  ) values (
    @PA_SESSION_ID,
    @PA_SESSION_USER_ID,
    @PA_SESSION_ACTIVE,
    @PA_SESSION_EXPIRY,
    @PA_SESSION_STATUS
  );
end
go
