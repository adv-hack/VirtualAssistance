if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityUserGroupMemberRemoveById')
  exec ('create procedure dbo.spConsensusSecurityUserGroupMemberRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityUserGroupMemberRemoveById(@PA_MEMBER_ID integer = null output) as 
begin
  delete 
  from dbo.User_Group_Member
  where MEMBER_ID = @PA_MEMBER_ID
end
go
