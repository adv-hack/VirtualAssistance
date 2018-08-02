if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusReportingReportPageCreate')
  exec ('create procedure dbo.spConsensusReportingReportPageCreate as select 1 as temp')
go
alter procedure dbo.spConsensusReportingReportPageCreate(@PA_RPTP_ID integer = null output, @PA_RPTP_PAGE_NAME varchar(100) = null output, @PA_RPTP_PAGE_PATH varchar(150) = null output, @PA_RPTP_SECTION varchar(50) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.Report_Page(
    RPTP_ADD_DATE,
    RPTP_ADD_BY,
    RPTP_MOD_DATE,
    RPTP_MOD_BY,
    RPTP_PAGE_NAME,
    RPTP_PAGE_PATH,
    RPTP_SECTION
  ) values (
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    @PA_RPTP_PAGE_NAME,
    @PA_RPTP_PAGE_PATH,
    @PA_RPTP_SECTION
  );
    set @PA_RPTP_ID = @@identity;
end
go
