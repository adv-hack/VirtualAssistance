if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusDocumentArticleRemoveById')
  exec ('create procedure dbo.spConsensusDocumentArticleRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusDocumentArticleRemoveById(@PA_ARTI_ID integer = null output) as 
begin
  delete 
  from dbo.Article
  where ARTI_ID = @PA_ARTI_ID
end
go
