if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityUserGroupModify')
  exec ('create procedure dbo.spConsensusSecurityUserGroupModify as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityUserGroupModify(@PA_GROUP_ID integer = null output, @PA_GROUP_PRINCIPAL_ID integer = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.User_Group set
    GROUP_PRINCIPAL_ID = @PA_GROUP_PRINCIPAL_ID
  where GROUP_ID = @PA_GROUP_ID;
end
go
