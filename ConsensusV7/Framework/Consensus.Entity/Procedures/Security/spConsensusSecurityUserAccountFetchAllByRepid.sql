if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityUserAccountFetchAllByRepid')
  exec ('create procedure dbo.spConsensusSecurityUserAccountFetchAllByRepid as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityUserAccountFetchAllByRepid(@PA_USER_REP_ID varchar(11) = null output) as 
begin
  select 
    USER_ID,
    USER_PRINCIPAL_ID,
    USER_PERSON_ID,
    USER_SELCO_ID,
    USER_STATUS,
    USER_FAIL_COUNT,
    USER_LAST_LOGIN,
    USER_PROVIDER,
    USER_SYS_ADMIN,
    USER_LICENSE_TYPE,
    USER_REP_ID
  from dbo.User_Account
  where USER_REP_ID = @PA_USER_REP_ID
end
go
