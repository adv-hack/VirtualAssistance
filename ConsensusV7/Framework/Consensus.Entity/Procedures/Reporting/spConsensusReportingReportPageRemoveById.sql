if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusReportingReportPageRemoveById')
  exec ('create procedure dbo.spConsensusReportingReportPageRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusReportingReportPageRemoveById(@PA_RPTP_ID integer = null output) as 
begin
  delete 
  from dbo.Report_Page
  where RPTP_ID = @PA_RPTP_ID
end
go
