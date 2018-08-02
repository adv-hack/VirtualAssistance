if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityUserCredentialCreate')
  exec ('create procedure dbo.spConsensusSecurityUserCredentialCreate as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityUserCredentialCreate(@PA_CREDENTIAL_ID integer = null output, @PA_CREDENTIAL_USER_ID integer = null output, @PA_CREDENTIAL_SALT varbinary(max) = null output, @PA_CREDENTIAL_PASS varbinary(max) = null output, @PA_CREDENTIAL_MODIFIED datetime = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.User_Credential(
    CREDENTIAL_USER_ID,
    CREDENTIAL_SALT,
    CREDENTIAL_PASS,
    CREDENTIAL_MODIFIED
  ) values (
    @PA_CREDENTIAL_USER_ID,
    @PA_CREDENTIAL_SALT,
    @PA_CREDENTIAL_PASS,
    @PA_CREDENTIAL_MODIFIED
  );
    set @PA_CREDENTIAL_ID = @@identity;
end
go
