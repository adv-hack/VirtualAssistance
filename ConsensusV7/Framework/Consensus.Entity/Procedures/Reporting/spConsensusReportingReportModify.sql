if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusReportingReportModify')
  exec ('create procedure dbo.spConsensusReportingReportModify as select 1 as temp')
go
alter procedure dbo.spConsensusReportingReportModify(@PA_REP_ID varchar(11) = null output, @PA_REP_LOCK varchar(10) = null output, @PA_REP_DESCRIPTION varchar(max) = null output, @PA_REP_NAME varchar(150) = null output, @PA_REP_CAT varchar(40) = null output, @PA_REP_TYPE varchar(50) = null output, @PA_REP_NOTES varchar(255) = null output, @PA_REP_LEVEL tinyint = null output, @PA_REP_CONNECTION tinyint = null output, @PA_REP_CURRENT tinyint = null output, @PA_REP_GEN_PARAMETERS tinyint = null output, @PA_REP_RPTP_ID integer = null output, @PA_REP_RPP_ID integer = null output, @PA_REP_SYSTEM tinyint = null output, @PA_REP_STANDARD tinyint = null output, @PA_REP_CN_ID varchar(11) = null output, @PA_REP_SSRS_PARAMETERS tinyint = null output, @PA_REP_CREATED_BY_V1 bit = null output, @PA_REP_PMENU_ID integer = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.Report set
    REP_MOD_DATE = getDate(),
    REP_MOD_BY = @_AUDIT_USER_ID,
    REP_LOCK = @PA_REP_LOCK,
    REP_DESCRIPTION = @PA_REP_DESCRIPTION,
    REP_NAME = @PA_REP_NAME,
    REP_CAT = @PA_REP_CAT,
    REP_TYPE = @PA_REP_TYPE,
    REP_NOTES = @PA_REP_NOTES,
    REP_LEVEL = @PA_REP_LEVEL,
    REP_CONNECTION = @PA_REP_CONNECTION,
    REP_CURRENT = @PA_REP_CURRENT,
    REP_GEN_PARAMETERS = @PA_REP_GEN_PARAMETERS,
    REP_RPTP_ID = @PA_REP_RPTP_ID,
    REP_RPP_ID = @PA_REP_RPP_ID,
    REP_SYSTEM = @PA_REP_SYSTEM,
    REP_STANDARD = @PA_REP_STANDARD,
    REP_CN_ID = @PA_REP_CN_ID,
    REP_SSRS_PARAMETERS = @PA_REP_SSRS_PARAMETERS,
    REP_CREATED_BY_V1 = @PA_REP_CREATED_BY_V1,
    REP_PMENU_ID = @PA_REP_PMENU_ID
  where REP_ID = @PA_REP_ID;
end
go
