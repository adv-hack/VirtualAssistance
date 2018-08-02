if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusReportingReportParampageRemoveById')
  exec ('create procedure dbo.spConsensusReportingReportParampageRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusReportingReportParampageRemoveById(@PA_RPP_ID integer = null output) as 
begin
  delete 
  from dbo.Report_ParamPage
  where RPP_ID = @PA_RPP_ID
end
go
