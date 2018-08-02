if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusCommonSysConfigFetchAllBySpid')
  exec ('create procedure dbo.spConsensusCommonSysConfigFetchAllBySpid as select 1 as temp')
go
alter procedure dbo.spConsensusCommonSysConfigFetchAllBySpid(@PA_SC_SP_ID varchar(11) = null output) as 
begin
  select 
    SC_ID,
    SC_ADD_DATE,
    SC_ADD_BY,
    SC_MOD_DATE,
    SC_MOD_BY,
    SC_RCV_DATE,
    SC_RCV_FROM,
    SC_SP_ID,
    SC_KEY_NAME,
    SC_VALUE_TO_USE,
    SC_LABEL_NAME,
    SC_CHAR_VALUE,
    SC_RECORD_ID,
    SC_INT_VALUE,
    SC_DATETIME_VALUE,
    SC_DECIMAL_VALUE
  from dbo.SYS_CONFIG
  where SC_SP_ID = @PA_SC_SP_ID
end
go
