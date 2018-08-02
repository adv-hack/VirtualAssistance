if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMarketingSaqQueryRemoveById')
  exec ('create procedure dbo.spConsensusMarketingSaqQueryRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusMarketingSaqQueryRemoveById(@PA_QRY_ID bigint = null output) as 
begin
  delete 
  from dbo.SAQ_QUERY
  where QRY_ID = @PA_QRY_ID
end
go
