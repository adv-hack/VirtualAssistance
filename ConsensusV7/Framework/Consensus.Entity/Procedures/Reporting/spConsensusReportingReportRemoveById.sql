if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusReportingReportRemoveById')
  exec ('create procedure dbo.spConsensusReportingReportRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusReportingReportRemoveById(@PA_REP_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.Report
  where REP_ID = @PA_REP_ID
end
go
