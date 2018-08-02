if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityStuserGroupRemoveById')
  exec ('create procedure dbo.spConsensusSecurityStuserGroupRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityStuserGroupRemoveById(@PA_UG_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.STUSER_GROUP
  where UG_ID = @PA_UG_ID
end
go
