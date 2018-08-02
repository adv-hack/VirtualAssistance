if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusDocumentSmsMessageModify')
  exec ('create procedure dbo.spConsensusDocumentSmsMessageModify as select 1 as temp')
go
alter procedure dbo.spConsensusDocumentSmsMessageModify(@PA_SMS_ID integer = null output, @PA_SMS_SMT_ID integer = null output, @PA_SMS_NAME varchar(40) = null output, @PA_SMS_DESCRIPTION varchar(200) = null output, @PA_SMS_TEXT varchar(200) = null output, @PA_SMS_CURRENT bit = null output, @PA_SMS_SELCO_SP_ID varchar(11) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.SMS_Message set
    SMS_MOD_DATE = getDate(),
    SMS_MOD_BY = @_AUDIT_USER_ID,
    SMS_SMT_ID = @PA_SMS_SMT_ID,
    SMS_NAME = @PA_SMS_NAME,
    SMS_DESCRIPTION = @PA_SMS_DESCRIPTION,
    SMS_TEXT = @PA_SMS_TEXT,
    SMS_CURRENT = @PA_SMS_CURRENT,
    SMS_SELCO_SP_ID = @PA_SMS_SELCO_SP_ID
  where SMS_ID = @PA_SMS_ID;
end
go
