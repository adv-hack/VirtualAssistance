if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusDocumentArticlexrefFetchById')
  exec ('create procedure dbo.spConsensusDocumentArticlexrefFetchById as select 1 as temp')
go
alter procedure dbo.spConsensusDocumentArticlexrefFetchById(@PA_ARTIXREF_ID integer = null output) as 
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
  where ARTIXREF_ID = @PA_ARTIXREF_ID
end
go
