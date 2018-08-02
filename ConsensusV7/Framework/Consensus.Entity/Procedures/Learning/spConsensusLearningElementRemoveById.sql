if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusLearningElementRemoveById')
  exec ('create procedure dbo.spConsensusLearningElementRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusLearningElementRemoveById(@PA_ELEM_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.Element
  where ELEM_ID = @PA_ELEM_ID
end
go
