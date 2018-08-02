if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMarketingSaqFilterFetchById')
  exec ('create procedure dbo.spConsensusMarketingSaqFilterFetchById as select 1 as temp')
go
alter procedure dbo.spConsensusMarketingSaqFilterFetchById(@PA_F_ID bigint = null output) as 
begin
  select 
    F_ID,
    F_ADD_BY,
    F_ADD_DATE,
    F_MOD_BY,
    F_MOD_DATE,
    F_DISPLAY_ORDER,
    F_DISPLAY,
    F_TABLE_PREFIX,
    F_TABLE_DESC,
    F_COLUMN_NAME,
    F_COLUMN_TYPE,
    F_COLUMN_LENGTH,
    F_COLUMN_DESC,
    F_CODE_LOOKUP,
    F_CODE_HEADER,
    F_CODE_VAL,
    F_ID_IN_LOOKUP,
    F_DEFAULT_OPERAND
  from dbo.SAQ_FILTER
  where F_ID = @PA_F_ID
end
go
