if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusDocumentArticlexrefRemoveById')
  exec ('create procedure dbo.spConsensusDocumentArticlexrefRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusDocumentArticlexrefRemoveById(@PA_ARTIXREF_ID integer = null output) as 
begin
  delete 
  from dbo.ArticleXref
  where ARTIXREF_ID = @PA_ARTIXREF_ID
end
go
