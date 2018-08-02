if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityUserCredentialModify')
  exec ('create procedure dbo.spConsensusSecurityUserCredentialModify as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityUserCredentialModify(@PA_CREDENTIAL_ID integer = null output, @PA_CREDENTIAL_USER_ID integer = null output, @PA_CREDENTIAL_SALT varbinary(max) = null output, @PA_CREDENTIAL_PASS varbinary(max) = null output, @PA_CREDENTIAL_MODIFIED datetime = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.User_Credential set
    CREDENTIAL_USER_ID = @PA_CREDENTIAL_USER_ID,
    CREDENTIAL_SALT = @PA_CREDENTIAL_SALT,
    CREDENTIAL_PASS = @PA_CREDENTIAL_PASS,
    CREDENTIAL_MODIFIED = @PA_CREDENTIAL_MODIFIED
  where CREDENTIAL_ID = @PA_CREDENTIAL_ID;
end
go
