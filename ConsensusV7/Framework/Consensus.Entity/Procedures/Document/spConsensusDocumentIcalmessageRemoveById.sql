if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusDocumentIcalmessageRemoveById')
  exec ('create procedure dbo.spConsensusDocumentIcalmessageRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusDocumentIcalmessageRemoveById(@PA_ICM_ID integer = null output) as 
begin
  delete 
  from dbo.ICalMessage
  where ICM_ID = @PA_ICM_ID
end
go
