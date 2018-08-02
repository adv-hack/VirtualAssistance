if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMembershipDistrictCreate')
  exec ('create procedure dbo.spConsensusMembershipDistrictCreate as select 1 as temp')
go
alter procedure dbo.spConsensusMembershipDistrictCreate(@PA_DIS_ID varchar(11) = null output, @PA_DIS_NAME varchar(255) = null output, @PA_DIS_STATUS varchar(40) = null output, @PA_DIS_TYPE varchar(40) = null output, @PA_DIS_CATEGORY varchar(40) = null output, @PA_DIS_GROUP varchar(40) = null output, @PA_DIS_REGION varchar(40) = null output, @PA_DIS_WEB tinyint = null output, @PA_DIS_EXT_URL varchar(240) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  exec spNextID 333, @PA_DIS_ID output
  
  insert into dbo.District(
    DIS_ID,
    DIS_ADD_DATE,
    DIS_ADD_BY,
    DIS_MOD_DATE,
    DIS_MOD_BY,
    DIS_RCV_DATE,
    DIS_RCV_FROM,
    DIS_NAME,
    DIS_STATUS,
    DIS_TYPE,
    DIS_CATEGORY,
    DIS_GROUP,
    DIS_REGION,
    DIS_WEB,
    DIS_EXT_URL
  ) values (
    @PA_DIS_ID,
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    '',
    @PA_DIS_NAME,
    @PA_DIS_STATUS,
    @PA_DIS_TYPE,
    @PA_DIS_CATEGORY,
    @PA_DIS_GROUP,
    @PA_DIS_REGION,
    @PA_DIS_WEB,
    @PA_DIS_EXT_URL
  );
end
go
