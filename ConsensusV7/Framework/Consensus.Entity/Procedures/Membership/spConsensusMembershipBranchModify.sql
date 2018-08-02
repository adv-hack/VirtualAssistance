if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMembershipBranchModify')
  exec ('create procedure dbo.spConsensusMembershipBranchModify as select 1 as temp')
go
alter procedure dbo.spConsensusMembershipBranchModify(@PA_BR_ID varchar(11) = null output, @PA_BR_NAME varchar(255) = null output, @PA_BR_STATUS varchar(40) = null output, @PA_BR_TYPE varchar(40) = null output, @PA_BR_CATEGORY varchar(40) = null output, @PA_BR_GROUP varchar(40) = null output, @PA_BR_REGION varchar(40) = null output, @PA_BR_WEB tinyint = null output, @PA_BR_EXT_URL varchar(240) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.Branch set
    BR_MOD_DATE = getDate(),
    BR_MOD_BY = @_AUDIT_USER_ID,
    BR_NAME = @PA_BR_NAME,
    BR_STATUS = @PA_BR_STATUS,
    BR_TYPE = @PA_BR_TYPE,
    BR_CATEGORY = @PA_BR_CATEGORY,
    BR_GROUP = @PA_BR_GROUP,
    BR_REGION = @PA_BR_REGION,
    BR_WEB = @PA_BR_WEB,
    BR_EXT_URL = @PA_BR_EXT_URL
  where BR_ID = @PA_BR_ID;
end
go
