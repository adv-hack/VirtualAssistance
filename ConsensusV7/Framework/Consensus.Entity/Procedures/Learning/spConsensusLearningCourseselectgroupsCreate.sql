if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusLearningCourseselectgroupsCreate')
  exec ('create procedure dbo.spConsensusLearningCourseselectgroupsCreate as select 1 as temp')
go
alter procedure dbo.spConsensusLearningCourseselectgroupsCreate(@PA_CSG_ID integer = null output, @PA_CSG_PSG_ID integer = null output, @PA_CSG_COURSE_ID varchar(11) = null output, @PA_CSG_TYPE tinyint = null output, @PA_CSG_NAME varchar(100) = null output, @PA_CSG_DESCRIPTION varchar(250) = null output, @PA_CSG_MIN tinyint = null output, @PA_CSG_MAX tinyint = null output, @PA_CSG_ORDER tinyint = null output, @PA_CSG_ERROR_MESSAGE varchar(max) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.CourseSelectGroups(
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
  ) values (
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    @PA_CSG_PSG_ID,
    @PA_CSG_COURSE_ID,
    @PA_CSG_TYPE,
    @PA_CSG_NAME,
    @PA_CSG_DESCRIPTION,
    @PA_CSG_MIN,
    @PA_CSG_MAX,
    @PA_CSG_ORDER,
    @PA_CSG_ERROR_MESSAGE
  );
    set @PA_CSG_ID = @@identity;
end
go
