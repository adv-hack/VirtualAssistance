if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityUserPrincipalModify')
  exec ('create procedure dbo.spConsensusSecurityUserPrincipalModify as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityUserPrincipalModify(@PA_PRINCIPAL_ID integer = null output, @PA_PRINCIPAL_NAME varchar(128) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.User_Principal set
    PRINCIPAL_NAME = @PA_PRINCIPAL_NAME
  where PRINCIPAL_ID = @PA_PRINCIPAL_ID;
end
go
