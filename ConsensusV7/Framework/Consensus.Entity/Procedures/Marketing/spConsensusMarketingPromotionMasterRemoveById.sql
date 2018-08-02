if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMarketingPromotionMasterRemoveById')
  exec ('create procedure dbo.spConsensusMarketingPromotionMasterRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusMarketingPromotionMasterRemoveById(@PA_PM_MST_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.Promotion_Master
  where PM_MST_ID = @PA_PM_MST_ID
end
go
