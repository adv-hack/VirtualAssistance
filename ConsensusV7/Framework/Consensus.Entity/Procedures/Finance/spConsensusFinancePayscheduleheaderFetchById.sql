if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusFinancePayscheduleheaderFetchById')
  exec ('create procedure dbo.spConsensusFinancePayscheduleheaderFetchById as select 1 as temp')
go
alter procedure dbo.spConsensusFinancePayscheduleheaderFetchById(@PA_PSH_ID integer = null output) as 
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
  where PSH_ID = @PA_PSH_ID
end
go
