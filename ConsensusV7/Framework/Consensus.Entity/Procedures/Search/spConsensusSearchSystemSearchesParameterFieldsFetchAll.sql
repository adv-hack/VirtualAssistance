if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSearchSystemSearchesParameterFieldsFetchAll')
  exec ('create procedure dbo.spConsensusSearchSystemSearchesParameterFieldsFetchAll as select 1 as temp')
go
alter procedure dbo.spConsensusSearchSystemSearchesParameterFieldsFetchAll as 
begin
  select 
    SYSSP_ID,
    SYSSP_ADD_BY,
    SYSSP_ADD_DATE,
    SYSSP_MOD_BY,
    SYSSP_MOD_DATE,
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
  from dbo.System_Searches_Parameter_Fields
end
go
