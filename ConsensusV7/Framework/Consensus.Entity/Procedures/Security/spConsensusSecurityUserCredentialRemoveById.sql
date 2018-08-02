if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityUserCredentialRemoveById')
  exec ('create procedure dbo.spConsensusSecurityUserCredentialRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityUserCredentialRemoveById(@PA_CREDENTIAL_ID integer = null output) as 
begin
  delete 
  from dbo.User_Credential
  where CREDENTIAL_ID = @PA_CREDENTIAL_ID
end
go
