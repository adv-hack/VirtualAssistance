if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusDocumentPrintQueueFetchById')
  exec ('create procedure dbo.spConsensusDocumentPrintQueueFetchById as select 1 as temp')
go
alter procedure dbo.spConsensusDocumentPrintQueueFetchById(@PA_PQ_ID varchar(11) = null output) as 
begin
  select 
    PQ_ID,
    PQ_ADD_DATE,
    PQ_ADD_BY,
    PQ_MOD_DATE,
    PQ_MOD_BY,
    PQ_RCV_DATE,
    PQ_RCV_FROM,
    PQ_QUEUE_TYPE,
    PQ_ADD_ID,
    PQ_ORG_ID,
    PQ_SEND_TYPE,
    PQ_STATIONARY_TYPE,
    PQ_ADMIN_PN_ID,
    PQ_ADMIN_PROLE_ID,
    PQ_MAIL_SERVER,
    PQ_LOGON_ID,
    PQ_LOGON_PASSWORD,
    PQ_PRINT_SERVER,
    PQ_PRINT_PRINTER,
    PQ_PRINTER_TYPE,
    PQ_PRINTER_NOTES,
    PQ_DESCRIPTION,
    PQ_SYSTEM_DEFAULT,
    PQ_DPM_SERVER,
    PQ_STATUS,
    PQ_PORT,
    PQ_SSL,
    PQ_PROXY,
    PQ_FROM
  from dbo.PRINT_QUEUE
  where PQ_ID = @PA_PQ_ID
end
go
