if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusReportingReportParampageModify')
  exec ('create procedure dbo.spConsensusReportingReportParampageModify as select 1 as temp')
go
alter procedure dbo.spConsensusReportingReportParampageModify(@PA_RPP_ID integer = null output, @PA_RPP_PAGE_NAME varchar(100) = null output, @PA_RPP_PAGE_PATH varchar(150) = null output, @PA_RPP_PARAM_DESC varchar(300) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.Report_ParamPage set
    RPP_MOD_DATE = getDate(),
    RPP_MOD_BY = @_AUDIT_USER_ID,
    RPP_PAGE_NAME = @PA_RPP_PAGE_NAME,
    RPP_PAGE_PATH = @PA_RPP_PAGE_PATH,
    RPP_PARAM_DESC = @PA_RPP_PARAM_DESC
  where RPP_ID = @PA_RPP_ID;
end
go
