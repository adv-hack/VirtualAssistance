if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusDocumentSmsMessageCreate')
  exec ('create procedure dbo.spConsensusDocumentSmsMessageCreate as select 1 as temp')
go
alter procedure dbo.spConsensusDocumentSmsMessageCreate(@PA_SMS_ID integer = null output, @PA_SMS_SMT_ID integer = null output, @PA_SMS_NAME varchar(40) = null output, @PA_SMS_DESCRIPTION varchar(200) = null output, @PA_SMS_TEXT varchar(200) = null output, @PA_SMS_CURRENT bit = null output, @PA_SMS_SELCO_SP_ID varchar(11) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.SMS_Message(
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
  ) values (
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    @PA_SMS_SMT_ID,
    @PA_SMS_NAME,
    @PA_SMS_DESCRIPTION,
    @PA_SMS_TEXT,
    @PA_SMS_CURRENT,
    @PA_SMS_SELCO_SP_ID
  );
    set @PA_SMS_ID = @@identity;
end
go
