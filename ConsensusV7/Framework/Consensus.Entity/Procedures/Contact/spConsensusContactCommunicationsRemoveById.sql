if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusContactCommunicationsRemoveById')
  exec ('create procedure dbo.spConsensusContactCommunicationsRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusContactCommunicationsRemoveById(@PA_COMM_ID bigint = null output) as 
begin
  delete 
  from dbo.Communications
  where COMM_ID = @PA_COMM_ID
end
go
