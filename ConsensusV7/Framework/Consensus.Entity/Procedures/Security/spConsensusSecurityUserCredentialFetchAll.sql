if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityUserCredentialFetchAll')
  exec ('create procedure dbo.spConsensusSecurityUserCredentialFetchAll as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityUserCredentialFetchAll as 
begin
  select 
    CREDENTIAL_ID,
    CREDENTIAL_USER_ID,
    CREDENTIAL_SALT,
    CREDENTIAL_PASS,
    CREDENTIAL_MODIFIED
  from dbo.User_Credential
end
go
