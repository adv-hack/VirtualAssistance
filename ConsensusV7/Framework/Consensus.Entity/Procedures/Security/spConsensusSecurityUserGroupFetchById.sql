if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityUserGroupFetchById')
  exec ('create procedure dbo.spConsensusSecurityUserGroupFetchById as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityUserGroupFetchById(@PA_GROUP_ID integer = null output) as 
begin
  select 
    GROUP_ID,
    GROUP_PRINCIPAL_ID
  from dbo.User_Group
  where GROUP_ID = @PA_GROUP_ID
end
go
