if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityStuserRemoveById')
  exec ('create procedure dbo.spConsensusSecurityStuserRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityStuserRemoveById(@PA_USER_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.STUser
  where USER_ID = @PA_USER_ID
end
go
