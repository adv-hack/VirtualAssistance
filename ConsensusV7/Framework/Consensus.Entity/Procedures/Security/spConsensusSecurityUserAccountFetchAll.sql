if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityUserAccountFetchAll')
  exec ('create procedure dbo.spConsensusSecurityUserAccountFetchAll as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityUserAccountFetchAll as 
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
end
go
