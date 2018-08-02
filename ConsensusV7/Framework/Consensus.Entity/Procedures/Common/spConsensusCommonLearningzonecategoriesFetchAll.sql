if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusCommonLearningzonecategoriesFetchAll')
  exec ('create procedure dbo.spConsensusCommonLearningzonecategoriesFetchAll as select 1 as temp')
go
alter procedure dbo.spConsensusCommonLearningzonecategoriesFetchAll as 
begin
  select 
    LZC_ID,
    LZC_ADD_DATE,
    LZC_ADD_BY,
    LZC_MOD_DATE,
    LZC_MOD_BY,
    LZC_CATEGORY_TITLE,
    LZC_DESCRIPTION,
    LZC_DESCRIPTION_HTML
  from dbo.LearningZoneCategories
end
go
