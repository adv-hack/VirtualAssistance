if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusDocumentIcalmessagetypeFetchById')
  exec ('create procedure dbo.spConsensusDocumentIcalmessagetypeFetchById as select 1 as temp')
go
alter procedure dbo.spConsensusDocumentIcalmessagetypeFetchById(@PA_ICMT_ID integer = null output) as 
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
  where ICMT_ID = @PA_ICMT_ID
end
go
