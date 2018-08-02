if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusFinanceC4currencyCreate')
  exec ('create procedure dbo.spConsensusFinanceC4currencyCreate as select 1 as temp')
go
alter procedure dbo.spConsensusFinanceC4currencyCreate(@PA_CURR_ID varchar(11) = null output, @PA_CURR_CODE varchar(3) = null output, @PA_CURR_START_DATE datetime = null output, @PA_CURR_END_DATE datetime = null output, @PA_CURR_CONV_FACTOR decimal(19, 8) = null output, @PA_CURR_DISP_FACTOR decimal(19, 8) = null output, @PA_CURR_DESCRIP varchar(50) = null output, @PA_CURR_LOCK varchar(10) = null output, @PA_CURR_EURO tinyint = null output, @PA_CURR_CONV_FACT2 decimal(19, 8) = null output, @PA_CURR_SP_ID varchar(11) = null output, @PA_CURR_SYMBOL_VALUE varchar(11) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.C4Currency(
    CURR_ADD_DATE,
    CURR_ADD_BY,
    CURR_MOD_DATE,
    CURR_MOD_BY,
    CURR_RCV_DATE,
    CURR_RCV_FROM,
    CURR_CODE,
    CURR_START_DATE,
    CURR_END_DATE,
    CURR_CONV_FACTOR,
    CURR_DISP_FACTOR,
    CURR_DESCRIP,
    CURR_LOCK,
    CURR_EURO,
    CURR_CONV_FACT2,
    CURR_SP_ID,
    CURR_SYMBOL_VALUE
  ) values (
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    '',
    @PA_CURR_CODE,
    @PA_CURR_START_DATE,
    @PA_CURR_END_DATE,
    @PA_CURR_CONV_FACTOR,
    @PA_CURR_DISP_FACTOR,
    @PA_CURR_DESCRIP,
    @PA_CURR_LOCK,
    @PA_CURR_EURO,
    @PA_CURR_CONV_FACT2,
    @PA_CURR_SP_ID,
    @PA_CURR_SYMBOL_VALUE
  );
    set @PA_CURR_ID = @@identity;
end
go
