if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityUserAccountFetchAllByPersonid')
  exec ('create procedure dbo.spConsensusSecurityUserAccountFetchAllByPersonid as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityUserAccountFetchAllByPersonid(@PA_USER_PERSON_ID varchar(11) = null output) as 
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
  where USER_PERSON_ID = @PA_USER_PERSON_ID
end
go
