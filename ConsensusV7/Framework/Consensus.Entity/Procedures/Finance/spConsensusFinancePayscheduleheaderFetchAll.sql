if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusFinancePayscheduleheaderFetchAll')
  exec ('create procedure dbo.spConsensusFinancePayscheduleheaderFetchAll as select 1 as temp')
go
alter procedure dbo.spConsensusFinancePayscheduleheaderFetchAll as 
begin
  select 
    PSH_ID,
    PSH_ADD_DATE,
    PSH_ADD_BY,
    PSH_MOD_DATE,
    PSH_MOD_BY,
    PSH_DESCRIPTION,
    PSH_NOTES
  from dbo.PayScheduleHeader
end
go
