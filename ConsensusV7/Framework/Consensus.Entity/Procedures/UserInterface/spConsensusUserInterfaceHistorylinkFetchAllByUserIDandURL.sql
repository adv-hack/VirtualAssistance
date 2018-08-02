if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusUserInterfaceHistorylinkFetchAllByUserIDandURL')
  exec ('create procedure dbo.spConsensusUserInterfaceHistorylinkFetchAllByUserIDandURL as select 1 as temp')
go
alter procedure dbo.spConsensusUserInterfaceHistorylinkFetchAllByUserIDandURL(@PA_HL_USER_ID integer = null output, @PA_HL_URL nvarchar(max) = null output) as 
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
  where HL_USER_ID = @PA_HL_USER_ID
  and HL_URL = @PA_HL_URL
end
go
