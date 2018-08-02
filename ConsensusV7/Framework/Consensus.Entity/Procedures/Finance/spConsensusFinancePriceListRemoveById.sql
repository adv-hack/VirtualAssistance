if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusFinancePriceListRemoveById')
  exec ('create procedure dbo.spConsensusFinancePriceListRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusFinancePriceListRemoveById(@PA_PL_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.Price_List
  where PL_ID = @PA_PL_ID
end
go
