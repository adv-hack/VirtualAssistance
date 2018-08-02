if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMembershipDistrictFetchAllByGroup')
  exec ('create procedure dbo.spConsensusMembershipDistrictFetchAllByGroup as select 1 as temp')
go
alter procedure dbo.spConsensusMembershipDistrictFetchAllByGroup(@PA_DIS_GROUP varchar(40) = null output) as 
begin
  select 
    DIS_ID,
    DIS_ADD_BY,
    DIS_ADD_DATE,
    DIS_MOD_BY,
    DIS_MOD_DATE,
    DIS_RCV_FROM,
    DIS_RCV_DATE,
    DIS_NAME,
    DIS_STATUS,
    DIS_TYPE,
    DIS_CATEGORY,
    DIS_GROUP,
    DIS_REGION,
    DIS_WEB,
    DIS_EXT_URL
  from dbo.District
  where DIS_GROUP = @PA_DIS_GROUP
end
go
