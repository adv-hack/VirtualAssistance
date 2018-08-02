if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusFinancePayAllocationRemoveById')
  exec ('create procedure dbo.spConsensusFinancePayAllocationRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusFinancePayAllocationRemoveById(@PA_PA_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.Pay_Allocation
  where PA_ID = @PA_PA_ID
end
go
