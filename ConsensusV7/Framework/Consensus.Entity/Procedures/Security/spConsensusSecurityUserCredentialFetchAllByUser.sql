if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityUserCredentialFetchAllByUser')
  exec ('create procedure dbo.spConsensusSecurityUserCredentialFetchAllByUser as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityUserCredentialFetchAllByUser(@PA_CREDENTIAL_USER_ID integer = null output) as 
begin
  select 
    CREDENTIAL_ID,
    CREDENTIAL_USER_ID,
    CREDENTIAL_SALT,
    CREDENTIAL_PASS,
    CREDENTIAL_MODIFIED
  from dbo.User_Credential
  where CREDENTIAL_USER_ID = @PA_CREDENTIAL_USER_ID
end
go
