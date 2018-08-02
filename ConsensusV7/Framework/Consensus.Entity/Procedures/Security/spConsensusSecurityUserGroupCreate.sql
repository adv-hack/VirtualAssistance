if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityUserGroupCreate')
  exec ('create procedure dbo.spConsensusSecurityUserGroupCreate as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityUserGroupCreate(@PA_GROUP_ID integer = null output, @PA_GROUP_PRINCIPAL_ID integer = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.User_Group(
    GROUP_PRINCIPAL_ID
  ) values (
    @PA_GROUP_PRINCIPAL_ID
  );
    set @PA_GROUP_ID = @@identity;
end
go
