if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusDocumentArticlexrefModify')
  exec ('create procedure dbo.spConsensusDocumentArticlexrefModify as select 1 as temp')
go
alter procedure dbo.spConsensusDocumentArticlexrefModify(@PA_ARTIXREF_ID integer = null output, @PA_ARTIXREF_ARTI_ID varchar(11) = null output, @PA_ARTIXREF_REL_ARTI_ID integer = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.ArticleXref set
    ARTIXREF_MOD_DATE = getDate(),
    ARTIXREF_MOD_BY = @_AUDIT_USER_ID,
    ARTIXREF_ARTI_ID = @PA_ARTIXREF_ARTI_ID,
    ARTIXREF_REL_ARTI_ID = @PA_ARTIXREF_REL_ARTI_ID
  where ARTIXREF_ID = @PA_ARTIXREF_ID;
end
go
