if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMarketingPromotionRemoveById')
  exec ('create procedure dbo.spConsensusMarketingPromotionRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusMarketingPromotionRemoveById(@PA_PM_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.Promotion
  where PM_ID = @PA_PM_ID
end
go
