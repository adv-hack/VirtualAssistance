if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusOtherBatchXrefRemoveById')
  exec ('create procedure dbo.spConsensusOtherBatchXrefRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusOtherBatchXrefRemoveById(@PA_BATXR_ID integer = null output) as 
begin
  delete 
  from dbo.BATCH_XREF
  where BATXR_ID = @PA_BATXR_ID
end
go
