if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusLearningTemplateXrefRemoveById')
  exec ('create procedure dbo.spConsensusLearningTemplateXrefRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusLearningTemplateXrefRemoveById(@PA_TXREF_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.Template_Xref
  where TXREF_ID = @PA_TXREF_ID
end
go
