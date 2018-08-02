if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusActivitiesC4textFetchAllByOwnerUrlAndOwnerId')
  exec ('create procedure dbo.spConsensusActivitiesC4textFetchAllByOwnerUrlAndOwnerId as select 1 as temp')
go
alter procedure dbo.spConsensusActivitiesC4textFetchAllByOwnerUrlAndOwnerId(
	@PA_OWNER_URL nvarchar(250) = null output,
	@PA_OWNER_ID varchar(11) = null output
) as 
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
  where TEXT_OWNER_URL = @PA_OWNER_URL
  AND TEXT_OWNER_ID = @PA_OWNER_ID
  order by TEXT_ADD_DATE desc
end
go
