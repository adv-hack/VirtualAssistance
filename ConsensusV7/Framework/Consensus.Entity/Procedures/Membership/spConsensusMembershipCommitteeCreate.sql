if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMembershipCommitteeCreate')
  exec ('create procedure dbo.spConsensusMembershipCommitteeCreate as select 1 as temp')
go
alter procedure dbo.spConsensusMembershipCommitteeCreate(@PA_COM_ID varchar(11) = null output, @PA_COM_NAME varchar(255) = null output, @PA_COM_STATUS varchar(40) = null output, @PA_COM_TYPE varchar(40) = null output, @PA_COM_START_DATE datetime = null output, @PA_COM_CATEGORY varchar(40) = null output, @PA_COM_GROUP varchar(40) = null output, @PA_COM_DIS_ID varchar(11) = null output, @PA_COM_PROD_ID varchar(11) = null output, @PA_COM_BR_ID varchar(11) = null output, @PA_COM_EXT_URL varchar(240) = null output, @PA_COM_SHOW_ON_ORG tinyint = null output, @PA_COM_NO_PEOPLE integer = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  exec spNextID 332, @PA_COM_ID output
  
  insert into dbo.Committee(
    COM_ID,
    COM_ADD_DATE,
    COM_ADD_BY,
    COM_MOD_DATE,
    COM_MOD_BY,
    COM_RCV_DATE,
    COM_RCV_FROM,
    COM_NAME,
    COM_STATUS,
    COM_TYPE,
    COM_START_DATE,
    COM_CATEGORY,
    COM_GROUP,
    COM_DIS_ID,
    COM_PROD_ID,
    COM_BR_ID,
    COM_EXT_URL,
    COM_SHOW_ON_ORG,
    COM_NO_PEOPLE
  ) values (
    @PA_COM_ID,
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    '',
    @PA_COM_NAME,
    @PA_COM_STATUS,
    @PA_COM_TYPE,
    @PA_COM_START_DATE,
    @PA_COM_CATEGORY,
    @PA_COM_GROUP,
    @PA_COM_DIS_ID,
    @PA_COM_PROD_ID,
    @PA_COM_BR_ID,
    @PA_COM_EXT_URL,
    @PA_COM_SHOW_ON_ORG,
    @PA_COM_NO_PEOPLE
  );
end
go
