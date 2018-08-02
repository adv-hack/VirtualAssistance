if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityUserPrincipalFetchAll')
  exec ('create procedure dbo.spConsensusSecurityUserPrincipalFetchAll as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityUserPrincipalFetchAll as 
begin
  select 
    PRINCIPAL_ID,
    PRINCIPAL_NAME
  from dbo.User_Principal
end
go
