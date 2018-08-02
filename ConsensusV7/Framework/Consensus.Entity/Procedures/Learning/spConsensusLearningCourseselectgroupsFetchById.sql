if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusLearningCourseselectgroupsFetchById')
  exec ('create procedure dbo.spConsensusLearningCourseselectgroupsFetchById as select 1 as temp')
go
alter procedure dbo.spConsensusLearningCourseselectgroupsFetchById(@PA_CSG_ID integer = null output) as 
begin
  select 
    CSG_ID,
    CSG_ADD_DATE,
    CSG_ADD_BY,
    CSG_MOD_DATE,
    CSG_MOD_BY,
    CSG_PSG_ID,
    CSG_COURSE_ID,
    CSG_TYPE,
    CSG_NAME,
    CSG_DESCRIPTION,
    CSG_MIN,
    CSG_MAX,
    CSG_ORDER,
    CSG_ERROR_MESSAGE
  from dbo.CourseSelectGroups
  where CSG_ID = @PA_CSG_ID
end
go
