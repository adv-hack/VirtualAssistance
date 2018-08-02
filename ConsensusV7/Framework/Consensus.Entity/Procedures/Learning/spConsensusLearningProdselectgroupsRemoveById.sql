if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusLearningProdselectgroupsRemoveById')
  exec ('create procedure dbo.spConsensusLearningProdselectgroupsRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusLearningProdselectgroupsRemoveById(@PA_PSG_ID integer = null output) as 
begin
  delete 
  from dbo.ProdSelectGroups
  where PSG_ID = @PA_PSG_ID
end
go
