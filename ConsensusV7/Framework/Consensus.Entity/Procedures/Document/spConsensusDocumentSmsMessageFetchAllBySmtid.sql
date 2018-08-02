if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusDocumentSmsMessageFetchAllBySmtid')
  exec ('create procedure dbo.spConsensusDocumentSmsMessageFetchAllBySmtid as select 1 as temp')
go
alter procedure dbo.spConsensusDocumentSmsMessageFetchAllBySmtid(@PA_SMS_SMT_ID integer = null output) as 
begin
  select 
    SMS_ID,
    SMS_ADD_DATE,
    SMS_ADD_BY,
    SMS_MOD_DATE,
    SMS_MOD_BY,
    SMS_SMT_ID,
    SMS_NAME,
    SMS_DESCRIPTION,
    SMS_TEXT,
    SMS_CURRENT,
    SMS_SELCO_SP_ID
  from dbo.SMS_Message
  where SMS_SMT_ID = @PA_SMS_SMT_ID
end
go
