if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityUserGroupRemoveById')
  exec ('create procedure dbo.spConsensusSecurityUserGroupRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityUserGroupRemoveById(@PA_GROUP_ID integer = null output) as 
begin
  delete 
  from dbo.User_Group
  where GROUP_ID = @PA_GROUP_ID
end
go
