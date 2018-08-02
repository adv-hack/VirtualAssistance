if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusFinancePayscheduleheaderRemoveById')
  exec ('create procedure dbo.spConsensusFinancePayscheduleheaderRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusFinancePayscheduleheaderRemoveById(@PA_PSH_ID integer = null output) as 
begin
  delete 
  from dbo.PayScheduleHeader
  where PSH_ID = @PA_PSH_ID
end
go
