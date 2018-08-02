if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusDocumentIcalmessagetypeFetchAll')
  exec ('create procedure dbo.spConsensusDocumentIcalmessagetypeFetchAll as select 1 as temp')
go
alter procedure dbo.spConsensusDocumentIcalmessagetypeFetchAll as 
begin
  select 
    ICMT_ID,
    ICMT_ADD_DATE,
    ICMT_ADD_BY,
    ICMT_MOD_DATE,
    ICMT_MOD_BY,
    ICMT_NAME,
    ICMT_VIEW,
    ICMT_PROC
  from dbo.ICalMessageType
end
go
