if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusCommonLearningzonecategoriesCreate')
  exec ('create procedure dbo.spConsensusCommonLearningzonecategoriesCreate as select 1 as temp')
go
alter procedure dbo.spConsensusCommonLearningzonecategoriesCreate(@PA_LZC_ID integer = null output, @PA_LZC_CATEGORY_TITLE nvarchar(255) = null output, @PA_LZC_DESCRIPTION nvarchar(max) = null output, @PA_LZC_DESCRIPTION_HTML nvarchar(max) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.LearningZoneCategories(
    LZC_ADD_DATE,
    LZC_ADD_BY,
    LZC_MOD_DATE,
    LZC_MOD_BY,
    LZC_CATEGORY_TITLE,
    LZC_DESCRIPTION,
    LZC_DESCRIPTION_HTML
  ) values (
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    @PA_LZC_CATEGORY_TITLE,
    @PA_LZC_DESCRIPTION,
    @PA_LZC_DESCRIPTION_HTML
  );
    set @PA_LZC_ID = @@identity;
end
go
