if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusReportingReportFetchById')
  exec ('create procedure dbo.spConsensusReportingReportFetchById as select 1 as temp')
go
alter procedure dbo.spConsensusReportingReportFetchById(@PA_REP_ID varchar(11) = null output) as 
begin
  select 
    REP_ID,
    REP_LOCK,
    REP_ADD_DATE,
    REP_ADD_BY,
    REP_MOD_DATE,
    REP_MOD_BY,
    REP_RCV_DATE,
    REP_RCV_FROM,
    REP_DESCRIPTION,
    REP_NAME,
    REP_CAT,
    REP_TYPE,
    REP_NOTES,
    REP_LEVEL,
    REP_CONNECTION,
    REP_CURRENT,
    REP_GEN_PARAMETERS,
    REP_RPTP_ID,
    REP_RPP_ID,
    REP_SYSTEM,
    REP_STANDARD,
    REP_CN_ID,
    REP_SSRS_PARAMETERS,
    REP_CREATED_BY_V1,
    REP_PMENU_ID
  from dbo.Report
  where REP_ID = @PA_REP_ID
end
go
