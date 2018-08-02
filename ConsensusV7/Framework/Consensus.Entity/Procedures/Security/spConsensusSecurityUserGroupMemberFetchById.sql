if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityUserGroupMemberFetchById')
  exec ('create procedure dbo.spConsensusSecurityUserGroupMemberFetchById as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityUserGroupMemberFetchById(@PA_MEMBER_ID integer = null output) as 
begin
  select 
    MEMBER_ID,
    MEMBER_PRINCIPAL_ID,
    MEMBER_GROUP_ID
  from dbo.User_Group_Member
  where MEMBER_ID = @PA_MEMBER_ID
end
go
