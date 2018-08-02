if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusLearningCourseRemoveById')
  exec ('create procedure dbo.spConsensusLearningCourseRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusLearningCourseRemoveById(@PA_COURSE_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.Course
  where COURSE_ID = @PA_COURSE_ID
end
go
