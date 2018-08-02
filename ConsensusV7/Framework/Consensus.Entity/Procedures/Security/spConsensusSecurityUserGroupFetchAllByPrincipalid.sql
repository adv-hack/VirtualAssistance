if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityUserGroupFetchAllByPrincipalid')
  exec ('create procedure dbo.spConsensusSecurityUserGroupFetchAllByPrincipalid as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityUserGroupFetchAllByPrincipalid(@PA_GROUP_PRINCIPAL_ID integer = null output) as 
begin
  select 
    GROUP_ID,
    GROUP_PRINCIPAL_ID
  from dbo.User_Group
  where GROUP_PRINCIPAL_ID = @PA_GROUP_PRINCIPAL_ID
end
go
