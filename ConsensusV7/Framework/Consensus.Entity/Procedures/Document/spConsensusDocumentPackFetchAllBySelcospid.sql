if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusDocumentPackFetchAllBySelcospid')
  exec ('create procedure dbo.spConsensusDocumentPackFetchAllBySelcospid as select 1 as temp')
go
alter procedure dbo.spConsensusDocumentPackFetchAllBySelcospid(@PA_PACK_SELCO_SP_ID varchar(11) = null output) as 
begin
  select 
    PACK_ID,
    PACK_LOCK,
    PACK_ADD_DATE,
    PACK_ADD_BY,
    PACK_MOD_DATE,
    PACK_MOD_BY,
    PACK_RCV_DATE,
    PACK_RCV_FROM,
    PACK_NAME,
    PACK_TYPE,
    PACK_TO_BOOKER,
    PACK_TO_DEL,
    PACK_DOCS_METHOD,
    PACK_EMAIL_SUBJECT,
    PACK_INVOICE,
    PACK_ACT_PQ_KEEP,
    PACK_EMAIL_BODY,
    PACK_EMAIL_ONLY,
    PACK_PRINT_ONLY,
    PACK_STATUS,
    PACK_SEND_PROLE_ID,
    PACK_CATEGORY,
    PACK_PQ_ID,
    PACK_BCC_EMAIL,
    PACK_MDN_EMAIL,
    PACK_DSN_EMAIL,
    PACK_DSN_OPTIONS,
    PACK_SELCO_SP_ID
  from dbo.Pack
  where PACK_SELCO_SP_ID = @PA_PACK_SELCO_SP_ID
end
go
