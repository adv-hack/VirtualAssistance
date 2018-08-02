if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusFinanceAccountRemoveById')
  exec ('create procedure dbo.spConsensusFinanceAccountRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusFinanceAccountRemoveById(@PA_ACC_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.Account
  where ACC_ID = @PA_ACC_ID
end
go
