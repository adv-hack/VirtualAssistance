if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityUserAccountModify')
  exec ('create procedure dbo.spConsensusSecurityUserAccountModify as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityUserAccountModify(@PA_USER_ID integer = null output, @PA_USER_PRINCIPAL_ID integer = null output, @PA_USER_PERSON_ID varchar(11) = null output, @PA_USER_SELCO_ID varchar(11) = null output, @PA_USER_STATUS integer = null output, @PA_USER_FAIL_COUNT integer = null output, @PA_USER_LAST_LOGIN datetime = null output, @PA_USER_PROVIDER varchar(250) = null output, @PA_USER_SYS_ADMIN tinyint = null output, @PA_USER_LICENSE_TYPE integer = null output, @PA_USER_REP_ID varchar(11) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.User_Account set
    USER_PRINCIPAL_ID = @PA_USER_PRINCIPAL_ID,
    USER_PERSON_ID = @PA_USER_PERSON_ID,
    USER_SELCO_ID = @PA_USER_SELCO_ID,
    USER_STATUS = @PA_USER_STATUS,
    USER_FAIL_COUNT = @PA_USER_FAIL_COUNT,
    USER_LAST_LOGIN = @PA_USER_LAST_LOGIN,
    USER_PROVIDER = @PA_USER_PROVIDER,
    USER_SYS_ADMIN = @PA_USER_SYS_ADMIN,
    USER_LICENSE_TYPE = @PA_USER_LICENSE_TYPE,
    USER_REP_ID = @PA_USER_REP_ID
  where USER_ID = @PA_USER_ID;
end
go
