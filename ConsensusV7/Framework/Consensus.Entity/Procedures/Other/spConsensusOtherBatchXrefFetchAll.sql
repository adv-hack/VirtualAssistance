if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusOtherBatchXrefFetchAll')
  exec ('create procedure dbo.spConsensusOtherBatchXrefFetchAll as select 1 as temp')
go
alter procedure dbo.spConsensusOtherBatchXrefFetchAll as 
begin
  select 
    BATXR_ID,
    BATXR_ADD_DATE,
    BATXR_ADD_BY,
    BATXR_MOD_DATE,
    BATXR_MOD_BY,
    BATXR_RCV_DATE,
    BATXR_RCV_FROM,
    BATXR_BAT_ID,
    BATXR_RECORD_ID,
    BATXR_TABLE_NAME,
    BATXR_LINK_ID,
    BATXR_LINK_URL,
    BATXR_STATUS
  from dbo.BATCH_XREF
end
go
