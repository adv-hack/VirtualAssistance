if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusFinanceInvlineRemoveById')
  exec ('create procedure dbo.spConsensusFinanceInvlineRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusFinanceInvlineRemoveById(@PA_INVLN_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.InvLine
  where INVLN_ID = @PA_INVLN_ID
end
go
