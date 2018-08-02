if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityC4SessionsRemoveById')
  exec ('create procedure dbo.spConsensusSecurityC4SessionsRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityC4SessionsRemoveById(@PA_C4_SESSION_ID varchar(150) = null output) as 
begin
  delete 
  from dbo.C4_SESSIONS
  where C4_SESSION_ID = @PA_C4_SESSION_ID
end
go
