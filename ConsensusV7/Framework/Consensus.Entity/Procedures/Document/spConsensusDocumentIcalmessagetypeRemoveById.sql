if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusDocumentIcalmessagetypeRemoveById')
  exec ('create procedure dbo.spConsensusDocumentIcalmessagetypeRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusDocumentIcalmessagetypeRemoveById(@PA_ICMT_ID integer = null output) as 
begin
  delete 
  from dbo.ICalMessageType
  where ICMT_ID = @PA_ICMT_ID
end
go
