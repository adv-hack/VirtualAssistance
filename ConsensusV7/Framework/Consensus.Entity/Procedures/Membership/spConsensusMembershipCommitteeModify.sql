if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMembershipCommitteeModify')
  exec ('create procedure dbo.spConsensusMembershipCommitteeModify as select 1 as temp')
go
alter procedure dbo.spConsensusMembershipCommitteeModify(@PA_COM_ID varchar(11) = null output, @PA_COM_NAME varchar(255) = null output, @PA_COM_STATUS varchar(40) = null output, @PA_COM_TYPE varchar(40) = null output, @PA_COM_START_DATE datetime = null output, @PA_COM_CATEGORY varchar(40) = null output, @PA_COM_GROUP varchar(40) = null output, @PA_COM_DIS_ID varchar(11) = null output, @PA_COM_PROD_ID varchar(11) = null output, @PA_COM_BR_ID varchar(11) = null output, @PA_COM_EXT_URL varchar(240) = null output, @PA_COM_SHOW_ON_ORG tinyint = null output, @PA_COM_NO_PEOPLE integer = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.Committee set
    COM_MOD_DATE = getDate(),
    COM_MOD_BY = @_AUDIT_USER_ID,
    COM_NAME = @PA_COM_NAME,
    COM_STATUS = @PA_COM_STATUS,
    COM_TYPE = @PA_COM_TYPE,
    COM_START_DATE = @PA_COM_START_DATE,
    COM_CATEGORY = @PA_COM_CATEGORY,
    COM_GROUP = @PA_COM_GROUP,
    COM_DIS_ID = @PA_COM_DIS_ID,
    COM_PROD_ID = @PA_COM_PROD_ID,
    COM_BR_ID = @PA_COM_BR_ID,
    COM_EXT_URL = @PA_COM_EXT_URL,
    COM_SHOW_ON_ORG = @PA_COM_SHOW_ON_ORG,
    COM_NO_PEOPLE = @PA_COM_NO_PEOPLE
  where COM_ID = @PA_COM_ID;
end
go
