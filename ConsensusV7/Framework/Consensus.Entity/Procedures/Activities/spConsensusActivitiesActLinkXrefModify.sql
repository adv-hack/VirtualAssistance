if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusActivitiesActLinkXrefModify')
  exec ('create procedure dbo.spConsensusActivitiesActLinkXrefModify as select 1 as temp')
go
alter procedure dbo.spConsensusActivitiesActLinkXrefModify(@PA_ACTLINK_ID varchar(11) = null output, @PA_ACTLINK_ACT_ID varchar(11) = null output, @PA_ACTLINK_TABLE_NUM float = null output, @PA_ACTLINK_REC_ID varchar(11) = null output, @PA_ACTLINK_BOM_ID varchar(11) = null output, @PA_ACTLINK_TEXT varchar(max) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.ACT_LINK_XREF set
    ACTLINK_MOD_DATE = getDate(),
    ACTLINK_MOD_BY = @_AUDIT_USER_ID,
    ACTLINK_ACT_ID = @PA_ACTLINK_ACT_ID,
    ACTLINK_TABLE_NUM = @PA_ACTLINK_TABLE_NUM,
    ACTLINK_REC_ID = @PA_ACTLINK_REC_ID,
    ACTLINK_BOM_ID = @PA_ACTLINK_BOM_ID,
    ACTLINK_TEXT = @PA_ACTLINK_TEXT
  where ACTLINK_ID = @PA_ACTLINK_ID;
end
go
