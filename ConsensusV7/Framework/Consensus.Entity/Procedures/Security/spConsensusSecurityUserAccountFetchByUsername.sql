if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityUserAccountFetchByUsername')
  exec ('create procedure dbo.spConsensusSecurityUserAccountFetchByUsername as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityUserAccountFetchByUsername(@PA_USERNAME varchar(128) = null output) as 
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
  join dbo.User_Principal on User_Principal.PRINCIPAL_ID = User_Account.USER_PRINCIPAL_ID
  where PRINCIPAL_NAME = @PA_USERNAME
end
go
