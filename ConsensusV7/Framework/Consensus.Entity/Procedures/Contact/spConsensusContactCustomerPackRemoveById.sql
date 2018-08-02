if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusContactCustomerPackRemoveById')
  exec ('create procedure dbo.spConsensusContactCustomerPackRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusContactCustomerPackRemoveById(@PA_CPA_ID integer = null output) as 
begin
  delete 
  from dbo.Customer_Pack
  where CPA_ID = @PA_CPA_ID
end
go
