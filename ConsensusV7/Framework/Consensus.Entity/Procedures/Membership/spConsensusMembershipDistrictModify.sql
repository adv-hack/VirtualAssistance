if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMembershipDistrictModify')
  exec ('create procedure dbo.spConsensusMembershipDistrictModify as select 1 as temp')
go
alter procedure dbo.spConsensusMembershipDistrictModify(@PA_DIS_ID varchar(11) = null output, @PA_DIS_NAME varchar(255) = null output, @PA_DIS_STATUS varchar(40) = null output, @PA_DIS_TYPE varchar(40) = null output, @PA_DIS_CATEGORY varchar(40) = null output, @PA_DIS_GROUP varchar(40) = null output, @PA_DIS_REGION varchar(40) = null output, @PA_DIS_WEB tinyint = null output, @PA_DIS_EXT_URL varchar(240) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.District set
    DIS_MOD_DATE = getDate(),
    DIS_MOD_BY = @_AUDIT_USER_ID,
    DIS_NAME = @PA_DIS_NAME,
    DIS_STATUS = @PA_DIS_STATUS,
    DIS_TYPE = @PA_DIS_TYPE,
    DIS_CATEGORY = @PA_DIS_CATEGORY,
    DIS_GROUP = @PA_DIS_GROUP,
    DIS_REGION = @PA_DIS_REGION,
    DIS_WEB = @PA_DIS_WEB,
    DIS_EXT_URL = @PA_DIS_EXT_URL
  where DIS_ID = @PA_DIS_ID;
end
go
