if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusDocumentPrintQueueCreate')
  exec ('create procedure dbo.spConsensusDocumentPrintQueueCreate as select 1 as temp')
go
alter procedure dbo.spConsensusDocumentPrintQueueCreate(@PA_PQ_ID varchar(11) = null output, @PA_PQ_QUEUE_TYPE varchar(50) = null output, @PA_PQ_ADD_ID varchar(11) = null output, @PA_PQ_ORG_ID varchar(11) = null output, @PA_PQ_SEND_TYPE tinyint = null output, @PA_PQ_STATIONARY_TYPE tinyint = null output, @PA_PQ_ADMIN_PN_ID varchar(11) = null output, @PA_PQ_ADMIN_PROLE_ID varchar(11) = null output, @PA_PQ_MAIL_SERVER varchar(255) = null output, @PA_PQ_LOGON_ID varchar(255) = null output, @PA_PQ_LOGON_PASSWORD varchar(255) = null output, @PA_PQ_PRINT_SERVER varchar(255) = null output, @PA_PQ_PRINT_PRINTER varchar(255) = null output, @PA_PQ_PRINTER_TYPE varchar(255) = null output, @PA_PQ_PRINTER_NOTES varchar(max) = null output, @PA_PQ_DESCRIPTION varchar(255) = null output, @PA_PQ_SYSTEM_DEFAULT tinyint = null output, @PA_PQ_DPM_SERVER varchar(50) = null output, @PA_PQ_STATUS tinyint = null output, @PA_PQ_PORT varchar(4) = null output, @PA_PQ_SSL tinyint = null output, @PA_PQ_PROXY tinyint = null output, @PA_PQ_FROM varchar(16) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  exec spNextID 300, @PA_PQ_ID output
  
  insert into dbo.PRINT_QUEUE(
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
  ) values (
    @PA_PQ_ID,
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    '',
    @PA_PQ_QUEUE_TYPE,
    @PA_PQ_ADD_ID,
    @PA_PQ_ORG_ID,
    @PA_PQ_SEND_TYPE,
    @PA_PQ_STATIONARY_TYPE,
    @PA_PQ_ADMIN_PN_ID,
    @PA_PQ_ADMIN_PROLE_ID,
    @PA_PQ_MAIL_SERVER,
    @PA_PQ_LOGON_ID,
    @PA_PQ_LOGON_PASSWORD,
    @PA_PQ_PRINT_SERVER,
    @PA_PQ_PRINT_PRINTER,
    @PA_PQ_PRINTER_TYPE,
    @PA_PQ_PRINTER_NOTES,
    @PA_PQ_DESCRIPTION,
    @PA_PQ_SYSTEM_DEFAULT,
    @PA_PQ_DPM_SERVER,
    @PA_PQ_STATUS,
    @PA_PQ_PORT,
    @PA_PQ_SSL,
    @PA_PQ_PROXY,
    @PA_PQ_FROM
  );
end
go
