if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusLogisticsProjectRemoveById')
  exec ('create procedure dbo.spConsensusLogisticsProjectRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusLogisticsProjectRemoveById(@PA_PROJ_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.Project
  where PROJ_ID = @PA_PROJ_ID
end
go
