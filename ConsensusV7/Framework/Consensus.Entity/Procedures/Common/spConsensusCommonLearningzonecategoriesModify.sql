if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusCommonLearningzonecategoriesModify')
  exec ('create procedure dbo.spConsensusCommonLearningzonecategoriesModify as select 1 as temp')
go
alter procedure dbo.spConsensusCommonLearningzonecategoriesModify(@PA_LZC_ID integer = null output, @PA_LZC_CATEGORY_TITLE nvarchar(255) = null output, @PA_LZC_DESCRIPTION nvarchar(max) = null output, @PA_LZC_DESCRIPTION_HTML nvarchar(max) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.LearningZoneCategories set
    LZC_MOD_DATE = getDate(),
    LZC_MOD_BY = @_AUDIT_USER_ID,
    LZC_CATEGORY_TITLE = @PA_LZC_CATEGORY_TITLE,
    LZC_DESCRIPTION = @PA_LZC_DESCRIPTION,
    LZC_DESCRIPTION_HTML = @PA_LZC_DESCRIPTION_HTML
  where LZC_ID = @PA_LZC_ID;
end
go
