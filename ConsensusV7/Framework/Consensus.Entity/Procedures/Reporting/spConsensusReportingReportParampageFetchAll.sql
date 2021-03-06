if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusReportingReportParampageFetchAll')
  exec ('create procedure dbo.spConsensusReportingReportParampageFetchAll as select 1 as temp')
go
alter procedure dbo.spConsensusReportingReportParampageFetchAll as 
begin
  select 
    RPP_ID,
    RPP_ADD_DATE,
    RPP_ADD_BY,
    RPP_MOD_DATE,
    RPP_MOD_BY,
    RPP_PAGE_NAME,
    RPP_PAGE_PATH,
    RPP_PARAM_DESC
  from dbo.Report_ParamPage
end
go
