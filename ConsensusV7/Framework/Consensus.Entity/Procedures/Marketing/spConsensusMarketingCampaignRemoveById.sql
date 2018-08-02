if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMarketingCampaignRemoveById')
  exec ('create procedure dbo.spConsensusMarketingCampaignRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusMarketingCampaignRemoveById(@PA_CMP_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.Campaign
  where CMP_ID = @PA_CMP_ID
end
go
