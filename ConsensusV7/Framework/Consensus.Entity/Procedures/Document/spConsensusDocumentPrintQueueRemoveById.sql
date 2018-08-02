if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusDocumentPrintQueueRemoveById')
  exec ('create procedure dbo.spConsensusDocumentPrintQueueRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusDocumentPrintQueueRemoveById(@PA_PQ_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.PRINT_QUEUE
  where PQ_ID = @PA_PQ_ID
end
go
