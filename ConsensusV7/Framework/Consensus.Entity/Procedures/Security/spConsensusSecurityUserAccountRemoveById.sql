if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityUserAccountRemoveById')
  exec ('create procedure dbo.spConsensusSecurityUserAccountRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityUserAccountRemoveById(@PA_USER_ID integer = null output) as 
begin
  delete 
  from dbo.User_Account
  where USER_ID = @PA_USER_ID
end
go
