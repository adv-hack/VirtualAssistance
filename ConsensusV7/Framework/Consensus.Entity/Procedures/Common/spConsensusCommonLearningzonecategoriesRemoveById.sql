if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusCommonLearningzonecategoriesRemoveById')
  exec ('create procedure dbo.spConsensusCommonLearningzonecategoriesRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusCommonLearningzonecategoriesRemoveById(@PA_LZC_ID integer = null output) as 
begin
  delete 
  from dbo.LearningZoneCategories
  where LZC_ID = @PA_LZC_ID
end
go
