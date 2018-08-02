if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusUserInterfaceQuickaccesslinkRemoveById')
  exec ('create procedure dbo.spConsensusUserInterfaceQuickaccesslinkRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusUserInterfaceQuickaccesslinkRemoveById(@PA_QAL_ID integer = null output) as 
begin
  delete 
  from dbo.QuickAccessLink
  where QAL_ID = @PA_QAL_ID
end
go
