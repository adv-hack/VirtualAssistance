if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityUserSessionRemoveById')
  exec ('create procedure dbo.spConsensusSecurityUserSessionRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityUserSessionRemoveById(@PA_SESSION_ID uniqueidentifier = null output) as 
begin
  delete 
  from dbo.User_Session
  where SESSION_ID = @PA_SESSION_ID
end
go
