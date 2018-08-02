if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusFinanceDirectdebitRemoveById')
  exec ('create procedure dbo.spConsensusFinanceDirectdebitRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusFinanceDirectdebitRemoveById(@PA_DD_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.DirectDebit
  where DD_ID = @PA_DD_ID
end
go
