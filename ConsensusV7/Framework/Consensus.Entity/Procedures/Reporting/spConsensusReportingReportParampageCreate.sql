if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusReportingReportParampageCreate')
  exec ('create procedure dbo.spConsensusReportingReportParampageCreate as select 1 as temp')
go
alter procedure dbo.spConsensusReportingReportParampageCreate(@PA_RPP_ID integer = null output, @PA_RPP_PAGE_NAME varchar(100) = null output, @PA_RPP_PAGE_PATH varchar(150) = null output, @PA_RPP_PARAM_DESC varchar(300) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.Report_ParamPage(
    RPP_ADD_DATE,
    RPP_ADD_BY,
    RPP_MOD_DATE,
    RPP_MOD_BY,
    RPP_PAGE_NAME,
    RPP_PAGE_PATH,
    RPP_PARAM_DESC
  ) values (
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    @PA_RPP_PAGE_NAME,
    @PA_RPP_PAGE_PATH,
    @PA_RPP_PARAM_DESC
  );
    set @PA_RPP_ID = @@identity;
end
go
