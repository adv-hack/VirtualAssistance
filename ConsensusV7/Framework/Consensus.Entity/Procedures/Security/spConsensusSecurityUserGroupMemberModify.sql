if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityUserGroupMemberModify')
  exec ('create procedure dbo.spConsensusSecurityUserGroupMemberModify as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityUserGroupMemberModify(@PA_MEMBER_ID integer = null output, @PA_MEMBER_PRINCIPAL_ID integer = null output, @PA_MEMBER_GROUP_ID integer = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.User_Group_Member set
    MEMBER_PRINCIPAL_ID = @PA_MEMBER_PRINCIPAL_ID,
    MEMBER_GROUP_ID = @PA_MEMBER_GROUP_ID
  where MEMBER_ID = @PA_MEMBER_ID;
end
go
