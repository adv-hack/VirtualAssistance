if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusDocumentLettertmpltFetchAllByType')
  exec ('create procedure dbo.spConsensusDocumentLettertmpltFetchAllByType as select 1 as temp')
go
alter procedure dbo.spConsensusDocumentLettertmpltFetchAllByType(@PA_LT_TYPE varchar(40) = null output) as 
begin
  select 
    LT_ID,
    LT_LOCK,
    LT_ADD_DATE,
    LT_ADD_BY,
    LT_MOD_DATE,
    LT_MOD_BY,
    LT_RCV_DATE,
    LT_RCV_FROM,
    LT_NAME,
    LT_TYPE,
    LT_PRIVATE,
    LT_SECTION,
    LT_PROLE_ID,
    LT_LANGUAGE,
    LT_DESC,
    LT_TEXT,
    LT_LEVEL,
    LT_INDEX,
    LT_PAGE,
    LT_FOR_USE_WITH,
    LT_FILE_NAME,
    LT_SELCO_SP_ID,
    LT_PRINT_ONLY,
    LT_EMAIL_SUBJECT,
    LT_LOCALPRINT_ONLY,
    LT_PDF,
    LT_SEND_PROLE_ID,
    LT_CURRENT,
    LT_EMAIL_BODY,
    LT_PQ_ID,
    LT_ATT_ID,
    LT_LABEL
  from dbo.LetterTmplt
  where LT_TYPE = @PA_LT_TYPE
end
go
