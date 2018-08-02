if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusReportingReportPageFetchById')
  exec ('create procedure dbo.spConsensusReportingReportPageFetchById as select 1 as temp')
go
alter procedure dbo.spConsensusReportingReportPageFetchById(@PA_RPTP_ID integer = null output) as 
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
  where RPTP_ID = @PA_RPTP_ID
end
go
