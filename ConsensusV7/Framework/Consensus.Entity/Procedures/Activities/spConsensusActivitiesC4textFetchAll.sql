if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusActivitiesC4textFetchAll')
  exec ('create procedure dbo.spConsensusActivitiesC4textFetchAll as select 1 as temp')
go
alter procedure dbo.spConsensusActivitiesC4textFetchAll as 
begin
  select 
    TEXT_ID,
    TEXT_ADD_DATE,
    TEXT_ADD_BY,
    TEXT_MOD_DATE,
    TEXT_MOD_BY,
    TEXT_RCV_DATE,
    TEXT_RCV_FROM,
    TEXT_TYPE,
    TEXT_OWNER_ID,
    TEXT_BODY,
    TEXT_RTF,
    TEXT_HTML,
    TEXT_OWNER_URL
  from dbo.C4Text
end
go
