if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMarketingSaqFilterModify')
  exec ('create procedure dbo.spConsensusMarketingSaqFilterModify as select 1 as temp')
go
alter procedure dbo.spConsensusMarketingSaqFilterModify(@PA_F_ID bigint = null output, @PA_F_DISPLAY_ORDER smallint = null output, @PA_F_DISPLAY tinyint = null output, @PA_F_TABLE_PREFIX varchar(20) = null output, @PA_F_TABLE_DESC varchar(100) = null output, @PA_F_COLUMN_NAME varchar(100) = null output, @PA_F_COLUMN_TYPE varchar(20) = null output, @PA_F_COLUMN_LENGTH integer = null output, @PA_F_COLUMN_DESC varchar(100) = null output, @PA_F_CODE_LOOKUP tinyint = null output, @PA_F_CODE_HEADER varchar(10) = null output, @PA_F_CODE_VAL tinyint = null output, @PA_F_ID_IN_LOOKUP tinyint = null output, @PA_F_DEFAULT_OPERAND varchar(15) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.SAQ_FILTER set
    F_MOD_DATE = getDate(),
    F_MOD_BY = @_AUDIT_USER_ID,
    F_DISPLAY_ORDER = @PA_F_DISPLAY_ORDER,
    F_DISPLAY = @PA_F_DISPLAY,
    F_TABLE_PREFIX = @PA_F_TABLE_PREFIX,
    F_TABLE_DESC = @PA_F_TABLE_DESC,
    F_COLUMN_NAME = @PA_F_COLUMN_NAME,
    F_COLUMN_TYPE = @PA_F_COLUMN_TYPE,
    F_COLUMN_LENGTH = @PA_F_COLUMN_LENGTH,
    F_COLUMN_DESC = @PA_F_COLUMN_DESC,
    F_CODE_LOOKUP = @PA_F_CODE_LOOKUP,
    F_CODE_HEADER = @PA_F_CODE_HEADER,
    F_CODE_VAL = @PA_F_CODE_VAL,
    F_ID_IN_LOOKUP = @PA_F_ID_IN_LOOKUP,
    F_DEFAULT_OPERAND = @PA_F_DEFAULT_OPERAND
  where F_ID = @PA_F_ID;
end
go
