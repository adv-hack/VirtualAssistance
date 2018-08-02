if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityUserGroupMemberCreate')
  exec ('create procedure dbo.spConsensusSecurityUserGroupMemberCreate as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityUserGroupMemberCreate(@PA_MEMBER_ID integer = null output, @PA_MEMBER_PRINCIPAL_ID integer = null output, @PA_MEMBER_GROUP_ID integer = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.User_Group_Member(
    MEMBER_PRINCIPAL_ID,
    MEMBER_GROUP_ID
  ) values (
    @PA_MEMBER_PRINCIPAL_ID,
    @PA_MEMBER_GROUP_ID
  );
    set @PA_MEMBER_ID = @@identity;
end
go
