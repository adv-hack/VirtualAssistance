if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusCommonLearningzonecategoriesFetchById')
  exec ('create procedure dbo.spConsensusCommonLearningzonecategoriesFetchById as select 1 as temp')
go
alter procedure dbo.spConsensusCommonLearningzonecategoriesFetchById(@PA_LZC_ID integer = null output) as 
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
  where LZC_ID = @PA_LZC_ID
end
go
