if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusDocumentArticleCreate')
  exec ('create procedure dbo.spConsensusDocumentArticleCreate as select 1 as temp')
go
alter procedure dbo.spConsensusDocumentArticleCreate(@PA_ARTI_ID integer = null output, @PA_ARTI_TYPE tinyint = null output, @PA_ARTI_STATE tinyint = null output, @PA_ARTI_NAME varchar(8000) = null output, @PA_ARTI_NOTES varchar(8000) = null output, @PA_ARTI_NOTES_HTML varchar(max) = null output, @PA_ARTI_GROUP varchar(40) = null output, @PA_ARTI_KEYWORDS varchar(1000) = null output, @PA_ARTI_CATEGORY varchar(40) = null output, @PA_ARTI_SUMMARY varchar(8000) = null output, @PA_ARTI_SUMMARY_HTML varchar(max) = null output, @PA_ARTI_WEB tinyint = null output, @PA_ARTI_IMAGE varchar(2000) = null output, @PA_ARTI_FEATURED tinyint = null output, @PA_ARTI_PUBLISH_DATE datetime = null output, @PA_ARTI_PUBLISH_PROLE_ID varchar(11) = null output, @PA_ARTI_PS_ID integer = null output, @PA_ARTI_AREA varchar(40) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.Article(
    ARTI_ADD_DATE,
    ARTI_ADD_BY,
    ARTI_MOD_DATE,
    ARTI_MOD_BY,
    ARTI_RCV_DATE,
    ARTI_RCV_FROM,
    ARTI_TYPE,
    ARTI_STATE,
    ARTI_NAME,
    ARTI_NOTES,
    ARTI_NOTES_HTML,
    ARTI_GROUP,
    ARTI_KEYWORDS,
    ARTI_CATEGORY,
    ARTI_SUMMARY,
    ARTI_SUMMARY_HTML,
    ARTI_WEB,
    ARTI_IMAGE,
    ARTI_FEATURED,
    ARTI_PUBLISH_DATE,
    ARTI_PUBLISH_PROLE_ID,
    ARTI_PS_ID,
    ARTI_AREA
  ) values (
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    '',
    @PA_ARTI_TYPE,
    @PA_ARTI_STATE,
    @PA_ARTI_NAME,
    @PA_ARTI_NOTES,
    @PA_ARTI_NOTES_HTML,
    @PA_ARTI_GROUP,
    @PA_ARTI_KEYWORDS,
    @PA_ARTI_CATEGORY,
    @PA_ARTI_SUMMARY,
    @PA_ARTI_SUMMARY_HTML,
    @PA_ARTI_WEB,
    @PA_ARTI_IMAGE,
    @PA_ARTI_FEATURED,
    @PA_ARTI_PUBLISH_DATE,
    @PA_ARTI_PUBLISH_PROLE_ID,
    @PA_ARTI_PS_ID,
    @PA_ARTI_AREA
  );
    set @PA_ARTI_ID = @@identity;
end
go
