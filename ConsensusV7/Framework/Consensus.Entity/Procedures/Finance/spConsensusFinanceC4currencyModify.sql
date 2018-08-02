if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusFinanceC4currencyModify')
  exec ('create procedure dbo.spConsensusFinanceC4currencyModify as select 1 as temp')
go
alter procedure dbo.spConsensusFinanceC4currencyModify(@PA_CURR_ID varchar(11) = null output, @PA_CURR_CODE varchar(3) = null output, @PA_CURR_START_DATE datetime = null output, @PA_CURR_END_DATE datetime = null output, @PA_CURR_CONV_FACTOR decimal(19, 8) = null output, @PA_CURR_DISP_FACTOR decimal(19, 8) = null output, @PA_CURR_DESCRIP varchar(50) = null output, @PA_CURR_LOCK varchar(10) = null output, @PA_CURR_EURO tinyint = null output, @PA_CURR_CONV_FACT2 decimal(19, 8) = null output, @PA_CURR_SP_ID varchar(11) = null output, @PA_CURR_SYMBOL_VALUE varchar(11) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.C4Currency set
    CURR_MOD_DATE = getDate(),
    CURR_MOD_BY = @_AUDIT_USER_ID,
    CURR_CODE = @PA_CURR_CODE,
    CURR_START_DATE = @PA_CURR_START_DATE,
    CURR_END_DATE = @PA_CURR_END_DATE,
    CURR_CONV_FACTOR = @PA_CURR_CONV_FACTOR,
    CURR_DISP_FACTOR = @PA_CURR_DISP_FACTOR,
    CURR_DESCRIP = @PA_CURR_DESCRIP,
    CURR_LOCK = @PA_CURR_LOCK,
    CURR_EURO = @PA_CURR_EURO,
    CURR_CONV_FACT2 = @PA_CURR_CONV_FACT2,
    CURR_SP_ID = @PA_CURR_SP_ID,
    CURR_SYMBOL_VALUE = @PA_CURR_SYMBOL_VALUE
  where CURR_ID = @PA_CURR_ID;
end
go
