if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMarketingSaqQueryQueueRemoveById')
  exec ('create procedure dbo.spConsensusMarketingSaqQueryQueueRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusMarketingSaqQueryQueueRemoveById(@PA_QQ_ID bigint = null output) as 
begin
  delete 
  from dbo.SAQ_QUERY_QUEUE
  where QQ_ID = @PA_QQ_ID
end
go
