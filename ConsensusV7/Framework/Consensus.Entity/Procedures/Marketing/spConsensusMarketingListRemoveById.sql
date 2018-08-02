if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMarketingListRemoveById')
  exec ('create procedure dbo.spConsensusMarketingListRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusMarketingListRemoveById(@PA_LIST_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.List
  where LIST_ID = @PA_LIST_ID
end
go
