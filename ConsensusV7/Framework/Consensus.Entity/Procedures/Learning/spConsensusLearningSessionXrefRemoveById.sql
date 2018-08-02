if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusLearningSessionXrefRemoveById')
  exec ('create procedure dbo.spConsensusLearningSessionXrefRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusLearningSessionXrefRemoveById(@PA_SXREF_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.Session_Xref
  where SXREF_ID = @PA_SXREF_ID
end
go
