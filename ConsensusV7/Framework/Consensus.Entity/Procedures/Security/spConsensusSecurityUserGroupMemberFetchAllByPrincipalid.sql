if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityUserGroupMemberFetchAllByPrincipalid')
  exec ('create procedure dbo.spConsensusSecurityUserGroupMemberFetchAllByPrincipalid as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityUserGroupMemberFetchAllByPrincipalid(@PA_MEMBER_PRINCIPAL_ID integer = null output) as 
begin
  select 
    MEMBER_ID,
    MEMBER_PRINCIPAL_ID,
    MEMBER_GROUP_ID
  from dbo.User_Group_Member
  where MEMBER_PRINCIPAL_ID = @PA_MEMBER_PRINCIPAL_ID
end
go
