if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMembershipDistrictFetchAllByCategory')
  exec ('create procedure dbo.spConsensusMembershipDistrictFetchAllByCategory as select 1 as temp')
go
alter procedure dbo.spConsensusMembershipDistrictFetchAllByCategory(@PA_DIS_CATEGORY varchar(40) = null output) as 
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
  where DIS_CATEGORY = @PA_DIS_CATEGORY
end
go
