if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusDocumentPrintReqRemoveById')
  exec ('create procedure dbo.spConsensusDocumentPrintReqRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusDocumentPrintReqRemoveById(@PA_PR_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.Print_Req
  where PR_ID = @PA_PR_ID
end
go
