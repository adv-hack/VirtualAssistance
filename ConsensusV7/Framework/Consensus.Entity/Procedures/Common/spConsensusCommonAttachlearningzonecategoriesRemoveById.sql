if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusCommonAttachlearningzonecategoriesRemoveById')
  exec ('create procedure dbo.spConsensusCommonAttachlearningzonecategoriesRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusCommonAttachlearningzonecategoriesRemoveById(@PA_ATTLZC_ID integer = null output) as 
begin
  delete 
  from dbo.AttachLearningZoneCategories
  where ATTLZC_ID = @PA_ATTLZC_ID
end
go
