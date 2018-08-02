if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusFinanceInvheaderRemoveById')
  exec ('create procedure dbo.spConsensusFinanceInvheaderRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusFinanceInvheaderRemoveById(@PA_INV_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.InvHeader
  where INV_ID = @PA_INV_ID
end
go
