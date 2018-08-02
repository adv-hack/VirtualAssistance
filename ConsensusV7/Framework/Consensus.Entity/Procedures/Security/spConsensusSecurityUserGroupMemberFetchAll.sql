if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityUserGroupMemberFetchAll')
  exec ('create procedure dbo.spConsensusSecurityUserGroupMemberFetchAll as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityUserGroupMemberFetchAll as 
begin
  select 
    MEMBER_ID,
    MEMBER_PRINCIPAL_ID,
    MEMBER_GROUP_ID
  from dbo.User_Group_Member
end
go
