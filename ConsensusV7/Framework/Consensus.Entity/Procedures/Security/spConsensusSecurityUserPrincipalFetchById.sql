if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityUserPrincipalFetchById')
  exec ('create procedure dbo.spConsensusSecurityUserPrincipalFetchById as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityUserPrincipalFetchById(@PA_PRINCIPAL_ID integer = null output) as 
begin
  select 
    PRINCIPAL_ID,
    PRINCIPAL_NAME
  from dbo.User_Principal
  where PRINCIPAL_ID = @PA_PRINCIPAL_ID
end
go
