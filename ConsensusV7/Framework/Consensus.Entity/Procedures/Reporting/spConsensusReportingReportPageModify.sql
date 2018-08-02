if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusReportingReportPageModify')
  exec ('create procedure dbo.spConsensusReportingReportPageModify as select 1 as temp')
go
alter procedure dbo.spConsensusReportingReportPageModify(@PA_RPTP_ID integer = null output, @PA_RPTP_PAGE_NAME varchar(100) = null output, @PA_RPTP_PAGE_PATH varchar(150) = null output, @PA_RPTP_SECTION varchar(50) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.Report_Page set
    RPTP_MOD_DATE = getDate(),
    RPTP_MOD_BY = @_AUDIT_USER_ID,
    RPTP_PAGE_NAME = @PA_RPTP_PAGE_NAME,
    RPTP_PAGE_PATH = @PA_RPTP_PAGE_PATH,
    RPTP_SECTION = @PA_RPTP_SECTION
  where RPTP_ID = @PA_RPTP_ID;
end
go
