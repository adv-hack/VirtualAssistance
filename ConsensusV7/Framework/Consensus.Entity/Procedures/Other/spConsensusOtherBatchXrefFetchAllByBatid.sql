if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusOtherBatchXrefFetchAllByBatid')
  exec ('create procedure dbo.spConsensusOtherBatchXrefFetchAllByBatid as select 1 as temp')
go
alter procedure dbo.spConsensusOtherBatchXrefFetchAllByBatid(@PA_BATXR_BAT_ID varchar(11) = null output) as 
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
  where BATXR_BAT_ID = @PA_BATXR_BAT_ID
end
go
