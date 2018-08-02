if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusDocumentPackCreate')
  exec ('create procedure dbo.spConsensusDocumentPackCreate as select 1 as temp')
go
alter procedure dbo.spConsensusDocumentPackCreate(@PA_PACK_ID varchar(11) = null output, @PA_PACK_LOCK varchar(11) = null output, @PA_PACK_NAME varchar(50) = null output, @PA_PACK_TYPE tinyint = null output, @PA_PACK_TO_BOOKER tinyint = null output, @PA_PACK_TO_DEL tinyint = null output, @PA_PACK_DOCS_METHOD varchar(20) = null output, @PA_PACK_EMAIL_SUBJECT varchar(100) = null output, @PA_PACK_INVOICE tinyint = null output, @PA_PACK_ACT_PQ_KEEP tinyint = null output, @PA_PACK_EMAIL_BODY varchar(11) = null output, @PA_PACK_EMAIL_ONLY tinyint = null output, @PA_PACK_PRINT_ONLY tinyint = null output, @PA_PACK_STATUS tinyint = null output, @PA_PACK_SEND_PROLE_ID varchar(11) = null output, @PA_PACK_CATEGORY varchar(500) = null output, @PA_PACK_PQ_ID varchar(11) = null output, @PA_PACK_BCC_EMAIL varchar(240) = null output, @PA_PACK_MDN_EMAIL varchar(240) = null output, @PA_PACK_DSN_EMAIL varchar(240) = null output, @PA_PACK_DSN_OPTIONS varchar(10) = null output, @PA_PACK_SELCO_SP_ID varchar(11) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  exec spNextID 600, @PA_PACK_ID output
  
  insert into dbo.Pack(
    PACK_ID,
    PACK_ADD_DATE,
    PACK_ADD_BY,
    PACK_MOD_DATE,
    PACK_MOD_BY,
    PACK_RCV_DATE,
    PACK_RCV_FROM,
    PACK_LOCK,
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
  ) values (
    @PA_PACK_ID,
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    '',
    @PA_PACK_LOCK,
    @PA_PACK_NAME,
    @PA_PACK_TYPE,
    @PA_PACK_TO_BOOKER,
    @PA_PACK_TO_DEL,
    @PA_PACK_DOCS_METHOD,
    @PA_PACK_EMAIL_SUBJECT,
    @PA_PACK_INVOICE,
    @PA_PACK_ACT_PQ_KEEP,
    @PA_PACK_EMAIL_BODY,
    @PA_PACK_EMAIL_ONLY,
    @PA_PACK_PRINT_ONLY,
    @PA_PACK_STATUS,
    @PA_PACK_SEND_PROLE_ID,
    @PA_PACK_CATEGORY,
    @PA_PACK_PQ_ID,
    @PA_PACK_BCC_EMAIL,
    @PA_PACK_MDN_EMAIL,
    @PA_PACK_DSN_EMAIL,
    @PA_PACK_DSN_OPTIONS,
    @PA_PACK_SELCO_SP_ID
  );
end
go
