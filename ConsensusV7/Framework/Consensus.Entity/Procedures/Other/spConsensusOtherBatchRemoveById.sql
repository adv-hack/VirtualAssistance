if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusOtherBatchRemoveById')
  exec ('create procedure dbo.spConsensusOtherBatchRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusOtherBatchRemoveById(@PA_BAT_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.Batch
  where BAT_ID = @PA_BAT_ID
end
go
