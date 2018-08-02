if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusFinanceCostCodeRemoveById')
  exec ('create procedure dbo.spConsensusFinanceCostCodeRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusFinanceCostCodeRemoveById(@PA_COST_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.Cost_Code
  where COST_ID = @PA_COST_ID
end
go
