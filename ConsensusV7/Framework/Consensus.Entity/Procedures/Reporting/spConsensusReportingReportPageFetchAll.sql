if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusReportingReportPageFetchAll')
  exec ('create procedure dbo.spConsensusReportingReportPageFetchAll as select 1 as temp')
go
alter procedure dbo.spConsensusReportingReportPageFetchAll as 
begin
  select 
    RPTP_ID,
    RPTP_ADD_DATE,
    RPTP_ADD_BY,
    RPTP_MOD_DATE,
    RPTP_MOD_BY,
    RPTP_PAGE_NAME,
    RPTP_PAGE_PATH,
    RPTP_SECTION
  from dbo.Report_Page
end
go
