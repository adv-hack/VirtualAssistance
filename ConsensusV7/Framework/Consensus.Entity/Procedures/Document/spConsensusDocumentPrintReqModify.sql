if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusDocumentPrintReqModify')
  exec ('create procedure dbo.spConsensusDocumentPrintReqModify as select 1 as temp')
go
alter procedure dbo.spConsensusDocumentPrintReqModify(@PA_PR_ID varchar(11) = null output, @PA_PR_ID_1 varchar(900) = null output, @PA_PR_ID_2 varchar(11) = null output, @PA_PR_ID_3 varchar(11) = null output, @PA_PR_TYPE varchar(20) = null output, @PA_PR_STATUS integer = null output, @PA_PR_REQ_DATE datetime = null output, @PA_PR_DONE_DATE datetime = null output, @PA_PR_REQ_BY varchar(11) = null output, @PA_PR_PQ_ID varchar(11) = null output, @PA_PR_ACT_PQ_STATUS varchar(50) = null output, @PA_PR_PQ_SEND_TYPE varchar(40) = null output, @PA_PR_PACK_ID varchar(11) = null output, @PA_PR_WF_ID varchar(11) = null output, @PA_PR_BAT_ID varchar(11) = null output, @PA_PR_LT_ID varchar(11) = null output, @PA_PR_SEND_TO_BOOKER tinyint = null output, @PA_PR_SEND_TO_DELEGATE tinyint = null output, @PA_PR_SEND_FROM_PROLE_ID varchar(11) = null output, @PA_PR_SEND_TO_PROLE_ID varchar(900) = null output, @PA_PR_EMAIL_SUBJECT varchar(200) = null output, @PA_PR_EMAIL_CC_ADDRESS varchar(240) = null output, @PA_PR_REISSUE tinyint = null output, @PA_PR_ID_4 varchar(11) = null output, @PA_PR_WFA_ID varchar(11) = null output, @PA_PR_USE_HOME_ADDRESS tinyint = null output, @PA_PR_EMAIL_SEND_FROM_PERSON tinyint = null output, @PA_PR_SMS_ID integer = null output, @PA_PR_PR_ID varchar(11) = null output, @PA_PR_ID_5 varchar(11) = null output, @PA_PR_WFXREF_REC_ID varchar(11) = null output, @PA_PR_ARG_ID varchar(11) = null output, @PA_PR_BCC_EMAIL varchar(240) = null output, @PA_PR_MDN_EMAIL varchar(240) = null output, @PA_PR_DSN_EMAIL varchar(240) = null output, @PA_PR_DSN_OPTIONS varchar(10) = null output, @PA_PR_ICM_ID integer = null output, @PA_PR_NAME varchar(40) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.Print_Req set
    PR_MOD_DATE = getDate(),
    PR_MOD_BY = @_AUDIT_USER_ID,
    PR_ID_1 = @PA_PR_ID_1,
    PR_ID_2 = @PA_PR_ID_2,
    PR_ID_3 = @PA_PR_ID_3,
    PR_TYPE = @PA_PR_TYPE,
    PR_STATUS = @PA_PR_STATUS,
    PR_REQ_DATE = @PA_PR_REQ_DATE,
    PR_DONE_DATE = @PA_PR_DONE_DATE,
    PR_REQ_BY = @PA_PR_REQ_BY,
    PR_PQ_ID = @PA_PR_PQ_ID,
    PR_ACT_PQ_STATUS = @PA_PR_ACT_PQ_STATUS,
    PR_PQ_SEND_TYPE = @PA_PR_PQ_SEND_TYPE,
    PR_PACK_ID = @PA_PR_PACK_ID,
    PR_WF_ID = @PA_PR_WF_ID,
    PR_BAT_ID = @PA_PR_BAT_ID,
    PR_LT_ID = @PA_PR_LT_ID,
    PR_SEND_TO_BOOKER = @PA_PR_SEND_TO_BOOKER,
    PR_SEND_TO_DELEGATE = @PA_PR_SEND_TO_DELEGATE,
    PR_SEND_FROM_PROLE_ID = @PA_PR_SEND_FROM_PROLE_ID,
    PR_SEND_TO_PROLE_ID = @PA_PR_SEND_TO_PROLE_ID,
    PR_EMAIL_SUBJECT = @PA_PR_EMAIL_SUBJECT,
    PR_EMAIL_CC_ADDRESS = @PA_PR_EMAIL_CC_ADDRESS,
    PR_REISSUE = @PA_PR_REISSUE,
    PR_ID_4 = @PA_PR_ID_4,
    PR_WFA_ID = @PA_PR_WFA_ID,
    PR_USE_HOME_ADDRESS = @PA_PR_USE_HOME_ADDRESS,
    PR_EMAIL_SEND_FROM_PERSON = @PA_PR_EMAIL_SEND_FROM_PERSON,
    PR_SMS_ID = @PA_PR_SMS_ID,
    PR_PR_ID = @PA_PR_PR_ID,
    PR_ID_5 = @PA_PR_ID_5,
    PR_WFXREF_REC_ID = @PA_PR_WFXREF_REC_ID,
    PR_ARG_ID = @PA_PR_ARG_ID,
    PR_BCC_EMAIL = @PA_PR_BCC_EMAIL,
    PR_MDN_EMAIL = @PA_PR_MDN_EMAIL,
    PR_DSN_EMAIL = @PA_PR_DSN_EMAIL,
    PR_DSN_OPTIONS = @PA_PR_DSN_OPTIONS,
    PR_ICM_ID = @PA_PR_ICM_ID,
    PR_NAME = @PA_PR_NAME
  where PR_ID = @PA_PR_ID;
end
go
