if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusLearningCourseselectgroupsRemoveById')
  exec ('create procedure dbo.spConsensusLearningCourseselectgroupsRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusLearningCourseselectgroupsRemoveById(@PA_CSG_ID integer = null output) as 
begin
  delete 
  from dbo.CourseSelectGroups
  where CSG_ID = @PA_CSG_ID
end
go
