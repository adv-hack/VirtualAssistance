if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusDocumentArticleFetchAll')
  exec ('create procedure dbo.spConsensusDocumentArticleFetchAll as select 1 as temp')
go
alter procedure dbo.spConsensusDocumentArticleFetchAll as 
begin
  select 
    ARTI_ID,
    ARTI_TYPE,
    ARTI_STATE,
    ARTI_ADD_DATE,
    ARTI_MOD_DATE,
    ARTI_RCV_DATE,
    ARTI_ADD_BY,
    ARTI_MOD_BY,
    ARTI_RCV_FROM,
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
  from dbo.Article
end
go
