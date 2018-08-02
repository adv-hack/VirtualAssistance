if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusOtherBatchXrefModify')
  exec ('create procedure dbo.spConsensusOtherBatchXrefModify as select 1 as temp')
go
alter procedure dbo.spConsensusOtherBatchXrefModify(@PA_BATXR_ID integer = null output, @PA_BATXR_BAT_ID varchar(11) = null output, @PA_BATXR_RECORD_ID varchar(11) = null output, @PA_BATXR_TABLE_NAME varchar(255) = null output, @PA_BATXR_LINK_ID varchar(11) = null output, @PA_BATXR_LINK_URL varchar(255) = null output, @PA_BATXR_STATUS tinyint = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.BATCH_XREF set
    BATXR_MOD_DATE = getDate(),
    BATXR_MOD_BY = @_AUDIT_USER_ID,
    BATXR_BAT_ID = @PA_BATXR_BAT_ID,
    BATXR_RECORD_ID = @PA_BATXR_RECORD_ID,
    BATXR_TABLE_NAME = @PA_BATXR_TABLE_NAME,
    BATXR_LINK_ID = @PA_BATXR_LINK_ID,
    BATXR_LINK_URL = @PA_BATXR_LINK_URL,
    BATXR_STATUS = @PA_BATXR_STATUS
  where BATXR_ID = @PA_BATXR_ID;
end
go
