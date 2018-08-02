if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusReportingReportCreate')
  exec ('create procedure dbo.spConsensusReportingReportCreate as select 1 as temp')
go
alter procedure dbo.spConsensusReportingReportCreate(@PA_REP_ID varchar(11) = null output, @PA_REP_LOCK varchar(10) = null output, @PA_REP_DESCRIPTION varchar(max) = null output, @PA_REP_NAME varchar(150) = null output, @PA_REP_CAT varchar(40) = null output, @PA_REP_TYPE varchar(50) = null output, @PA_REP_NOTES varchar(255) = null output, @PA_REP_LEVEL tinyint = null output, @PA_REP_CONNECTION tinyint = null output, @PA_REP_CURRENT tinyint = null output, @PA_REP_GEN_PARAMETERS tinyint = null output, @PA_REP_RPTP_ID integer = null output, @PA_REP_RPP_ID integer = null output, @PA_REP_SYSTEM tinyint = null output, @PA_REP_STANDARD tinyint = null output, @PA_REP_CN_ID varchar(11) = null output, @PA_REP_SSRS_PARAMETERS tinyint = null output, @PA_REP_CREATED_BY_V1 bit = null output, @PA_REP_PMENU_ID integer = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  exec spNextID 900, @PA_REP_ID output
  
  insert into dbo.Report(
    REP_ID,
    REP_ADD_DATE,
    REP_ADD_BY,
    REP_MOD_DATE,
    REP_MOD_BY,
    REP_RCV_DATE,
    REP_RCV_FROM,
    REP_LOCK,
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
  ) values (
    @PA_REP_ID,
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    '',
    @PA_REP_LOCK,
    @PA_REP_DESCRIPTION,
    @PA_REP_NAME,
    @PA_REP_CAT,
    @PA_REP_TYPE,
    @PA_REP_NOTES,
    @PA_REP_LEVEL,
    @PA_REP_CONNECTION,
    @PA_REP_CURRENT,
    @PA_REP_GEN_PARAMETERS,
    @PA_REP_RPTP_ID,
    @PA_REP_RPP_ID,
    @PA_REP_SYSTEM,
    @PA_REP_STANDARD,
    @PA_REP_CN_ID,
    @PA_REP_SSRS_PARAMETERS,
    @PA_REP_CREATED_BY_V1,
    @PA_REP_PMENU_ID
  );
end
go
