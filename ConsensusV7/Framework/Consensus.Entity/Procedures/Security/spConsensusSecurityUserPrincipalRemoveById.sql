if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityUserPrincipalRemoveById')
  exec ('create procedure dbo.spConsensusSecurityUserPrincipalRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityUserPrincipalRemoveById(@PA_PRINCIPAL_ID integer = null output) as 
begin
  delete 
  from dbo.User_Principal
  where PRINCIPAL_ID = @PA_PRINCIPAL_ID
end
go
