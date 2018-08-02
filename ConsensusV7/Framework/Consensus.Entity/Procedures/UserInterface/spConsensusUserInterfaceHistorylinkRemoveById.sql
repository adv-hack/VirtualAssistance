if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusUserInterfaceHistorylinkRemoveById')
  exec ('create procedure dbo.spConsensusUserInterfaceHistorylinkRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusUserInterfaceHistorylinkRemoveById(@PA_HL_ID integer = null output) as 
begin
  delete 
  from dbo.HistoryLink
  where HL_ID = @PA_HL_ID
end
go
