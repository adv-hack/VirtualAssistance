if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusDocumentLettertmpltModify')
  exec ('create procedure dbo.spConsensusDocumentLettertmpltModify as select 1 as temp')
go
alter procedure dbo.spConsensusDocumentLettertmpltModify(@PA_LT_ID varchar(11) = null output, @PA_LT_LOCK varchar(11) = null output, @PA_LT_NAME varchar(500) = null output, @PA_LT_TYPE varchar(40) = null output, @PA_LT_PRIVATE tinyint = null output, @PA_LT_SECTION tinyint = null output, @PA_LT_PROLE_ID varchar(11) = null output, @PA_LT_LANGUAGE varchar(25) = null output, @PA_LT_DESC varchar(240) = null output, @PA_LT_TEXT varchar(max) = null output, @PA_LT_LEVEL integer = null output, @PA_LT_INDEX varchar(255) = null output, @PA_LT_PAGE varchar(100) = null output, @PA_LT_FOR_USE_WITH tinyint = null output, @PA_LT_FILE_NAME varchar(255) = null output, @PA_LT_SELCO_SP_ID varchar(11) = null output, @PA_LT_PRINT_ONLY tinyint = null output, @PA_LT_EMAIL_SUBJECT varchar(100) = null output, @PA_LT_LOCALPRINT_ONLY tinyint = null output, @PA_LT_PDF tinyint = null output, @PA_LT_SEND_PROLE_ID varchar(11) = null output, @PA_LT_CURRENT tinyint = null output, @PA_LT_EMAIL_BODY tinyint = null output, @PA_LT_PQ_ID varchar(11) = null output, @PA_LT_ATT_ID varchar(11) = null output, @PA_LT_LABEL tinyint = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.LetterTmplt set
    LT_MOD_DATE = getDate(),
    LT_MOD_BY = @_AUDIT_USER_ID,
    LT_LOCK = @PA_LT_LOCK,
    LT_NAME = @PA_LT_NAME,
    LT_TYPE = @PA_LT_TYPE,
    LT_PRIVATE = @PA_LT_PRIVATE,
    LT_SECTION = @PA_LT_SECTION,
    LT_PROLE_ID = @PA_LT_PROLE_ID,
    LT_LANGUAGE = @PA_LT_LANGUAGE,
    LT_DESC = @PA_LT_DESC,
    LT_TEXT = @PA_LT_TEXT,
    LT_LEVEL = @PA_LT_LEVEL,
    LT_INDEX = @PA_LT_INDEX,
    LT_PAGE = @PA_LT_PAGE,
    LT_FOR_USE_WITH = @PA_LT_FOR_USE_WITH,
    LT_FILE_NAME = @PA_LT_FILE_NAME,
    LT_SELCO_SP_ID = @PA_LT_SELCO_SP_ID,
    LT_PRINT_ONLY = @PA_LT_PRINT_ONLY,
    LT_EMAIL_SUBJECT = @PA_LT_EMAIL_SUBJECT,
    LT_LOCALPRINT_ONLY = @PA_LT_LOCALPRINT_ONLY,
    LT_PDF = @PA_LT_PDF,
    LT_SEND_PROLE_ID = @PA_LT_SEND_PROLE_ID,
    LT_CURRENT = @PA_LT_CURRENT,
    LT_EMAIL_BODY = @PA_LT_EMAIL_BODY,
    LT_PQ_ID = @PA_LT_PQ_ID,
    LT_ATT_ID = @PA_LT_ATT_ID,
    LT_LABEL = @PA_LT_LABEL
  where LT_ID = @PA_LT_ID;
end
go
