if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusDocumentArticlexrefFetchAll')
  exec ('create procedure dbo.spConsensusDocumentArticlexrefFetchAll as select 1 as temp')
go
alter procedure dbo.spConsensusDocumentArticlexrefFetchAll as 
begin
  select 
    ARTIXREF_ID,
    ARTIXREF_ADD_DATE,
    ARTIXREF_ADD_BY,
    ARTIXREF_MOD_DATE,
    ARTIXREF_MOD_BY,
    ARTIXREF_ARTI_ID,
    ARTIXREF_REL_ARTI_ID
  from dbo.ArticleXref
end
go
