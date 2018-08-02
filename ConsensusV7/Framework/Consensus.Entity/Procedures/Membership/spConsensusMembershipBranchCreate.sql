if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMembershipBranchCreate')
  exec ('create procedure dbo.spConsensusMembershipBranchCreate as select 1 as temp')
go
alter procedure dbo.spConsensusMembershipBranchCreate(@PA_BR_ID varchar(11) = null output, @PA_BR_NAME varchar(255) = null output, @PA_BR_STATUS varchar(40) = null output, @PA_BR_TYPE varchar(40) = null output, @PA_BR_CATEGORY varchar(40) = null output, @PA_BR_GROUP varchar(40) = null output, @PA_BR_REGION varchar(40) = null output, @PA_BR_WEB tinyint = null output, @PA_BR_EXT_URL varchar(240) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  exec spNextID 330, @PA_BR_ID output
  
  insert into dbo.Branch(
    BR_ID,
    BR_ADD_DATE,
    BR_ADD_BY,
    BR_MOD_DATE,
    BR_MOD_BY,
    BR_RCV_DATE,
    BR_RCV_FROM,
    BR_NAME,
    BR_STATUS,
    BR_TYPE,
    BR_CATEGORY,
    BR_GROUP,
    BR_REGION,
    BR_WEB,
    BR_EXT_URL
  ) values (
    @PA_BR_ID,
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    '',
    @PA_BR_NAME,
    @PA_BR_STATUS,
    @PA_BR_TYPE,
    @PA_BR_CATEGORY,
    @PA_BR_GROUP,
    @PA_BR_REGION,
    @PA_BR_WEB,
    @PA_BR_EXT_URL
  );
end
go
