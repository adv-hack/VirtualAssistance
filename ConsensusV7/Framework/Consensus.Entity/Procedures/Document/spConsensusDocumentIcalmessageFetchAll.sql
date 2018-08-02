if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusDocumentIcalmessageFetchAll')
  exec ('create procedure dbo.spConsensusDocumentIcalmessageFetchAll as select 1 as temp')
go
alter procedure dbo.spConsensusDocumentIcalmessageFetchAll as 
begin
  select 
    ICM_ID,
    ICM_ADD_DATE,
    ICM_ADD_BY,
    ICM_MOD_DATE,
    ICM_MOD_BY,
    ICM_ICMT_ID,
    ICM_CURRENT,
    ICM_METHOD,
    ICM_NAME,
    ICM_DESCRIPTION,
    ICM_SUBJECT,
    ICM_LOCATION,
    ICM_TEXT,
    ICM_SELCO_SP_ID
  from dbo.ICalMessage
end
go
