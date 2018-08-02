if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusFinancePricesRemoveById')
  exec ('create procedure dbo.spConsensusFinancePricesRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusFinancePricesRemoveById(@PA_PRS_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.Prices
  where PRS_ID = @PA_PRS_ID
end
go
