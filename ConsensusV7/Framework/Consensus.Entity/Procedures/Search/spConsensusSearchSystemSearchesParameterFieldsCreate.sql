if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSearchSystemSearchesParameterFieldsCreate')
  exec ('create procedure dbo.spConsensusSearchSystemSearchesParameterFieldsCreate as select 1 as temp')
go
alter procedure dbo.spConsensusSearchSystemSearchesParameterFieldsCreate(@PA_SYSSP_ID integer = null output, @PA_SYSSP_SYSS_ID integer = null output, @PA_SYSSP_DISPLAY_OPTION_TYPE tinyint = null output, @PA_SYSSP_DISPLAY_ORDER integer = null output, @PA_SYSSP_FIELD_NAME varchar(255) = null output, @PA_SYSSP_DEFAULT_LABEL varchar(100) = null output, @PA_SYSSP_LABEL varchar(100) = null output, @PA_SYSSP_FIELD_TYPE varchar(50) = null output, @PA_SYSSP_WHERE_CLAUSE_OPERATOR varchar(25) = null output, @PA_SYSSP_VISIBLE tinyint = null output, @PA_SYSSP_VISIBLE_CONDITION varchar(max) = null output, @PA_SYSSP_DEFAULT_VALUE varchar(100) = null output, @PA_SYSSP_CODE_LIST varchar(50) = null output, @PA_SYSSP_DATA varchar(max) = null output, @PA_SYSSP_WHERE_CLAUSE_OVERRIDE varchar(max) = null output, @PA_SYSSP_PERMISSIONS varchar(100) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.System_Searches_Parameter_Fields(
    SYSSP_ADD_DATE,
    SYSSP_ADD_BY,
    SYSSP_MOD_DATE,
    SYSSP_MOD_BY,
    SYSSP_SYSS_ID,
    SYSSP_DISPLAY_OPTION_TYPE,
    SYSSP_DISPLAY_ORDER,
    SYSSP_FIELD_NAME,
    SYSSP_DEFAULT_LABEL,
    SYSSP_LABEL,
    SYSSP_FIELD_TYPE,
    SYSSP_WHERE_CLAUSE_OPERATOR,
    SYSSP_VISIBLE,
    SYSSP_VISIBLE_CONDITION,
    SYSSP_DEFAULT_VALUE,
    SYSSP_CODE_LIST,
    SYSSP_DATA,
    SYSSP_WHERE_CLAUSE_OVERRIDE,
    SYSSP_PERMISSIONS
  ) values (
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    @PA_SYSSP_SYSS_ID,
    @PA_SYSSP_DISPLAY_OPTION_TYPE,
    @PA_SYSSP_DISPLAY_ORDER,
    @PA_SYSSP_FIELD_NAME,
    @PA_SYSSP_DEFAULT_LABEL,
    @PA_SYSSP_LABEL,
    @PA_SYSSP_FIELD_TYPE,
    @PA_SYSSP_WHERE_CLAUSE_OPERATOR,
    @PA_SYSSP_VISIBLE,
    @PA_SYSSP_VISIBLE_CONDITION,
    @PA_SYSSP_DEFAULT_VALUE,
    @PA_SYSSP_CODE_LIST,
    @PA_SYSSP_DATA,
    @PA_SYSSP_WHERE_CLAUSE_OVERRIDE,
    @PA_SYSSP_PERMISSIONS
  );
    set @PA_SYSSP_ID = @@identity;
end
go
