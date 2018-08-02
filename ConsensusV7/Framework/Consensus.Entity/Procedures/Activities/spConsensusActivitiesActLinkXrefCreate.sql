if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusActivitiesActLinkXrefCreate')
  exec ('create procedure dbo.spConsensusActivitiesActLinkXrefCreate as select 1 as temp')
go
alter procedure dbo.spConsensusActivitiesActLinkXrefCreate(@PA_ACTLINK_ID varchar(11) = null output, @PA_ACTLINK_ACT_ID varchar(11) = null output, @PA_ACTLINK_TABLE_NUM float = null output, @PA_ACTLINK_REC_ID varchar(11) = null output, @PA_ACTLINK_BOM_ID varchar(11) = null output, @PA_ACTLINK_TEXT varchar(max) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.ACT_LINK_XREF(
    ACTLINK_ADD_DATE,
    ACTLINK_ADD_BY,
    ACTLINK_MOD_DATE,
    ACTLINK_MOD_BY,
    ACTLINK_RCV_DATE,
    ACTLINK_RCV_FROM,
    ACTLINK_ACT_ID,
    ACTLINK_TABLE_NUM,
    ACTLINK_REC_ID,
    ACTLINK_BOM_ID,
    ACTLINK_TEXT
  ) values (
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    '',
    @PA_ACTLINK_ACT_ID,
    @PA_ACTLINK_TABLE_NUM,
    @PA_ACTLINK_REC_ID,
    @PA_ACTLINK_BOM_ID,
    @PA_ACTLINK_TEXT
  );
    set @PA_ACTLINK_ID = @@identity;
end
go
