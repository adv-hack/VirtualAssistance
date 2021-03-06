if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusFinanceC4currencyFetchAll')
  exec ('create procedure dbo.spConsensusFinanceC4currencyFetchAll as select 1 as temp')
go
alter procedure dbo.spConsensusFinanceC4currencyFetchAll as 
begin
  select 
    CURR_ID,
    CURR_CODE,
    CURR_START_DATE,
    CURR_END_DATE,
    CURR_CONV_FACTOR,
    CURR_DISP_FACTOR,
    CURR_DESCRIP,
    CURR_LOCK,
    CURR_EURO,
    CURR_ADD_DATE,
    CURR_ADD_BY,
    CURR_MOD_DATE,
    CURR_MOD_BY,
    CURR_RCV_DATE,
    CURR_RCV_FROM,
    CURR_CONV_FACT2,
    CURR_SP_ID,
    CURR_SYMBOL_VALUE
  from dbo.C4Currency
end
go
