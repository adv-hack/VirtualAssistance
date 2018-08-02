if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusActivitiesActLinkXrefFetchAll')
  exec ('create procedure dbo.spConsensusActivitiesActLinkXrefFetchAll as select 1 as temp')
go
alter procedure dbo.spConsensusActivitiesActLinkXrefFetchAll as 
begin
  select 
    ACTLINK_ID,
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
  from dbo.ACT_LINK_XREF
end
go
