if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMarketingSaqFilterRemoveById')
  exec ('create procedure dbo.spConsensusMarketingSaqFilterRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusMarketingSaqFilterRemoveById(@PA_F_ID bigint = null output) as 
begin
  delete 
  from dbo.SAQ_FILTER
  where F_ID = @PA_F_ID
end
go
