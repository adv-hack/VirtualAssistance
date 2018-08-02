if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusFinancePaymentRemoveById')
  exec ('create procedure dbo.spConsensusFinancePaymentRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusFinancePaymentRemoveById(@PA_PAY_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.Payment
  where PAY_ID = @PA_PAY_ID
end
go
