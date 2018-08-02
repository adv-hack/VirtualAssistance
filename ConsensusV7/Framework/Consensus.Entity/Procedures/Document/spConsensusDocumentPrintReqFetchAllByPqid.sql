if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusDocumentPrintReqFetchAllByPqid')
  exec ('create procedure dbo.spConsensusDocumentPrintReqFetchAllByPqid as select 1 as temp')
go
alter procedure dbo.spConsensusDocumentPrintReqFetchAllByPqid(@PA_PR_PQ_ID varchar(11) = null output) as 
begin
  select 
    PR_ID,
    PR_ADD_DATE,
    PR_ADD_BY,
    PR_MOD_DATE,
    PR_MOD_BY,
    PR_RCV_DATE,
    PR_RCV_FROM,
    PR_ID_1,
    PR_ID_2,
    PR_ID_3,
    PR_TYPE,
    PR_STATUS,
    PR_REQ_DATE,
    PR_DONE_DATE,
    PR_REQ_BY,
    PR_PQ_ID,
    PR_ACT_PQ_STATUS,
    PR_PQ_SEND_TYPE,
    PR_PACK_ID,
    PR_WF_ID,
    PR_BAT_ID,
    PR_LT_ID,
    PR_SEND_TO_BOOKER,
    PR_SEND_TO_DELEGATE,
    PR_SEND_FROM_PROLE_ID,
    PR_SEND_TO_PROLE_ID,
    PR_EMAIL_SUBJECT,
    PR_EMAIL_CC_ADDRESS,
    PR_REISSUE,
    PR_ID_4,
    PR_WFA_ID,
    PR_USE_HOME_ADDRESS,
    PR_EMAIL_SEND_FROM_PERSON,
    PR_SMS_ID,
    PR_PR_ID,
    PR_ID_5,
    PR_WFXREF_REC_ID,
    PR_ARG_ID,
    PR_BCC_EMAIL,
    PR_MDN_EMAIL,
    PR_DSN_EMAIL,
    PR_DSN_OPTIONS,
    PR_ICM_ID,
    PR_NAME
  from dbo.Print_Req
  where PR_PQ_ID = @PA_PR_PQ_ID
end
go
