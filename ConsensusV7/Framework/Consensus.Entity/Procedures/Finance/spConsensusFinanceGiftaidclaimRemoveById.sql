if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusFinanceGiftaidclaimRemoveById')
  exec ('create procedure dbo.spConsensusFinanceGiftaidclaimRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusFinanceGiftaidclaimRemoveById(@PA_GAC_ID integer = null output) as 
begin
  delete 
  from dbo.GiftAidClaim
  where GAC_ID = @PA_GAC_ID
end
go
