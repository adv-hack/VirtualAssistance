if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityUserPrincipalCreate')
  exec ('create procedure dbo.spConsensusSecurityUserPrincipalCreate as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityUserPrincipalCreate(@PA_PRINCIPAL_ID integer = null output, @PA_PRINCIPAL_NAME varchar(128) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.User_Principal(
    PRINCIPAL_NAME
  ) values (
    @PA_PRINCIPAL_NAME
  );
    set @PA_PRINCIPAL_ID = @@identity;
end
go
