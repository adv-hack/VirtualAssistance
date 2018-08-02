if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusUserInterfaceHistorylinkFetchById')
  exec ('create procedure dbo.spConsensusUserInterfaceHistorylinkFetchById as select 1 as temp')
go
alter procedure dbo.spConsensusUserInterfaceHistorylinkFetchById(@PA_HL_ID integer = null output) as 
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
  where HL_ID = @PA_HL_ID
end
go
