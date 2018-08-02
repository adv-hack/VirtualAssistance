if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusDocumentPrintQueueModify')
  exec ('create procedure dbo.spConsensusDocumentPrintQueueModify as select 1 as temp')
go
alter procedure dbo.spConsensusDocumentPrintQueueModify(@PA_PQ_ID varchar(11) = null output, @PA_PQ_QUEUE_TYPE varchar(50) = null output, @PA_PQ_ADD_ID varchar(11) = null output, @PA_PQ_ORG_ID varchar(11) = null output, @PA_PQ_SEND_TYPE tinyint = null output, @PA_PQ_STATIONARY_TYPE tinyint = null output, @PA_PQ_ADMIN_PN_ID varchar(11) = null output, @PA_PQ_ADMIN_PROLE_ID varchar(11) = null output, @PA_PQ_MAIL_SERVER varchar(255) = null output, @PA_PQ_LOGON_ID varchar(255) = null output, @PA_PQ_LOGON_PASSWORD varchar(255) = null output, @PA_PQ_PRINT_SERVER varchar(255) = null output, @PA_PQ_PRINT_PRINTER varchar(255) = null output, @PA_PQ_PRINTER_TYPE varchar(255) = null output, @PA_PQ_PRINTER_NOTES varchar(max) = null output, @PA_PQ_DESCRIPTION varchar(255) = null output, @PA_PQ_SYSTEM_DEFAULT tinyint = null output, @PA_PQ_DPM_SERVER varchar(50) = null output, @PA_PQ_STATUS tinyint = null output, @PA_PQ_PORT varchar(4) = null output, @PA_PQ_SSL tinyint = null output, @PA_PQ_PROXY tinyint = null output, @PA_PQ_FROM varchar(16) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.PRINT_QUEUE set
    PQ_MOD_DATE = getDate(),
    PQ_MOD_BY = @_AUDIT_USER_ID,
    PQ_QUEUE_TYPE = @PA_PQ_QUEUE_TYPE,
    PQ_ADD_ID = @PA_PQ_ADD_ID,
    PQ_ORG_ID = @PA_PQ_ORG_ID,
    PQ_SEND_TYPE = @PA_PQ_SEND_TYPE,
    PQ_STATIONARY_TYPE = @PA_PQ_STATIONARY_TYPE,
    PQ_ADMIN_PN_ID = @PA_PQ_ADMIN_PN_ID,
    PQ_ADMIN_PROLE_ID = @PA_PQ_ADMIN_PROLE_ID,
    PQ_MAIL_SERVER = @PA_PQ_MAIL_SERVER,
    PQ_LOGON_ID = @PA_PQ_LOGON_ID,
    PQ_LOGON_PASSWORD = @PA_PQ_LOGON_PASSWORD,
    PQ_PRINT_SERVER = @PA_PQ_PRINT_SERVER,
    PQ_PRINT_PRINTER = @PA_PQ_PRINT_PRINTER,
    PQ_PRINTER_TYPE = @PA_PQ_PRINTER_TYPE,
    PQ_PRINTER_NOTES = @PA_PQ_PRINTER_NOTES,
    PQ_DESCRIPTION = @PA_PQ_DESCRIPTION,
    PQ_SYSTEM_DEFAULT = @PA_PQ_SYSTEM_DEFAULT,
    PQ_DPM_SERVER = @PA_PQ_DPM_SERVER,
    PQ_STATUS = @PA_PQ_STATUS,
    PQ_PORT = @PA_PQ_PORT,
    PQ_SSL = @PA_PQ_SSL,
    PQ_PROXY = @PA_PQ_PROXY,
    PQ_FROM = @PA_PQ_FROM
  where PQ_ID = @PA_PQ_ID;
end
go
