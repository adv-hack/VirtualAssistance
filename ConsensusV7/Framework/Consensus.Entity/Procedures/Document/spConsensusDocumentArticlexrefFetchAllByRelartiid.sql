if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusDocumentArticlexrefFetchAllByRelartiid')
  exec ('create procedure dbo.spConsensusDocumentArticlexrefFetchAllByRelartiid as select 1 as temp')
go
alter procedure dbo.spConsensusDocumentArticlexrefFetchAllByRelartiid(@PA_ARTIXREF_REL_ARTI_ID integer = null output) as 
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
  where ARTIXREF_REL_ARTI_ID = @PA_ARTIXREF_REL_ARTI_ID
end
go
