if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityUserCredentialFetchById')
  exec ('create procedure dbo.spConsensusSecurityUserCredentialFetchById as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityUserCredentialFetchById(@PA_CREDENTIAL_ID integer = null output) as 
begin
  select 
    CREDENTIAL_ID,
    CREDENTIAL_USER_ID,
    CREDENTIAL_SALT,
    CREDENTIAL_PASS,
    CREDENTIAL_MODIFIED
  from dbo.User_Credential
  where CREDENTIAL_ID = @PA_CREDENTIAL_ID
end
go
