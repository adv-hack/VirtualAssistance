if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityUserGroupMemberFetchAllByGroupid')
  exec ('create procedure dbo.spConsensusSecurityUserGroupMemberFetchAllByGroupid as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityUserGroupMemberFetchAllByGroupid(@PA_MEMBER_GROUP_ID integer = null output) as 
begin
  select 
    MEMBER_ID,
    MEMBER_PRINCIPAL_ID,
    MEMBER_GROUP_ID
  from dbo.User_Group_Member
  where MEMBER_GROUP_ID = @PA_MEMBER_GROUP_ID
end
go
