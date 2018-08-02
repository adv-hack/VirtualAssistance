if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusUserInterfaceHistorylinkFetchAll')
  exec ('create procedure dbo.spConsensusUserInterfaceHistorylinkFetchAll as select 1 as temp')
go
alter procedure dbo.spConsensusUserInterfaceHistorylinkFetchAll as 
begin
  select 
    HL_ID,
    HL_ADD_DATE,
    HL_ADD_BY,
    HL_MOD_DATE,
    HL_MOD_BY,
    HL_USER_ID,
    HL_DESCRIPTION,
    HL_URL,
    HL_ICON
  from dbo.HistoryLink
end
go
