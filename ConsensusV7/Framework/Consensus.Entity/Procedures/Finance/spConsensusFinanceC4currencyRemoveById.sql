if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusFinanceC4currencyRemoveById')
  exec ('create procedure dbo.spConsensusFinanceC4currencyRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusFinanceC4currencyRemoveById(@PA_CURR_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.C4Currency
  where CURR_ID = @PA_CURR_ID
end
go
