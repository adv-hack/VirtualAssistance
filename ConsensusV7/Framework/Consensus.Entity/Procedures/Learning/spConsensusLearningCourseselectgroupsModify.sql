if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusLearningCourseselectgroupsModify')
  exec ('create procedure dbo.spConsensusLearningCourseselectgroupsModify as select 1 as temp')
go
alter procedure dbo.spConsensusLearningCourseselectgroupsModify(@PA_CSG_ID integer = null output, @PA_CSG_PSG_ID integer = null output, @PA_CSG_COURSE_ID varchar(11) = null output, @PA_CSG_TYPE tinyint = null output, @PA_CSG_NAME varchar(100) = null output, @PA_CSG_DESCRIPTION varchar(250) = null output, @PA_CSG_MIN tinyint = null output, @PA_CSG_MAX tinyint = null output, @PA_CSG_ORDER tinyint = null output, @PA_CSG_ERROR_MESSAGE varchar(max) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.CourseSelectGroups set
    CSG_MOD_DATE = getDate(),
    CSG_MOD_BY = @_AUDIT_USER_ID,
    CSG_PSG_ID = @PA_CSG_PSG_ID,
    CSG_COURSE_ID = @PA_CSG_COURSE_ID,
    CSG_TYPE = @PA_CSG_TYPE,
    CSG_NAME = @PA_CSG_NAME,
    CSG_DESCRIPTION = @PA_CSG_DESCRIPTION,
    CSG_MIN = @PA_CSG_MIN,
    CSG_MAX = @PA_CSG_MAX,
    CSG_ORDER = @PA_CSG_ORDER,
    CSG_ERROR_MESSAGE = @PA_CSG_ERROR_MESSAGE
  where CSG_ID = @PA_CSG_ID;
end
go
