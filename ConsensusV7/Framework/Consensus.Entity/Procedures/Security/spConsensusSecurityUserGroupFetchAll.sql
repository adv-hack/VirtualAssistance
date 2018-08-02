if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityUserGroupFetchAll')
  exec ('create procedure dbo.spConsensusSecurityUserGroupFetchAll as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityUserGroupFetchAll as 
begin
  select 
    GROUP_ID,
    GROUP_PRINCIPAL_ID
  from dbo.User_Group
end
go
