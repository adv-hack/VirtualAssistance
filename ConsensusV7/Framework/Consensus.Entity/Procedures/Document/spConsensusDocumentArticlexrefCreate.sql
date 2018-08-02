if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusDocumentArticlexrefCreate')
  exec ('create procedure dbo.spConsensusDocumentArticlexrefCreate as select 1 as temp')
go
alter procedure dbo.spConsensusDocumentArticlexrefCreate(@PA_ARTIXREF_ID integer = null output, @PA_ARTIXREF_ARTI_ID varchar(11) = null output, @PA_ARTIXREF_REL_ARTI_ID integer = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.ArticleXref(
    ARTIXREF_ADD_DATE,
    ARTIXREF_ADD_BY,
    ARTIXREF_MOD_DATE,
    ARTIXREF_MOD_BY,
    ARTIXREF_ARTI_ID,
    ARTIXREF_REL_ARTI_ID
  ) values (
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    @PA_ARTIXREF_ARTI_ID,
    @PA_ARTIXREF_REL_ARTI_ID
  );
    set @PA_ARTIXREF_ID = @@identity;
end
go
