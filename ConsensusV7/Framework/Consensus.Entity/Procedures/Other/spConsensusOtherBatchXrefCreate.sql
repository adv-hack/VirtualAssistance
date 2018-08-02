if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusOtherBatchXrefCreate')
  exec ('create procedure dbo.spConsensusOtherBatchXrefCreate as select 1 as temp')
go
alter procedure dbo.spConsensusOtherBatchXrefCreate(@PA_BATXR_ID integer = null output, @PA_BATXR_BAT_ID varchar(11) = null output, @PA_BATXR_RECORD_ID varchar(11) = null output, @PA_BATXR_TABLE_NAME varchar(255) = null output, @PA_BATXR_LINK_ID varchar(11) = null output, @PA_BATXR_LINK_URL varchar(255) = null output, @PA_BATXR_STATUS tinyint = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.BATCH_XREF(
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
  ) values (
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    '',
    @PA_BATXR_BAT_ID,
    @PA_BATXR_RECORD_ID,
    @PA_BATXR_TABLE_NAME,
    @PA_BATXR_LINK_ID,
    @PA_BATXR_LINK_URL,
    @PA_BATXR_STATUS
  );
    set @PA_BATXR_ID = @@identity;
end
go
