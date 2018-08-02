if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusDocumentSmsMessageRemoveById')
  exec ('create procedure dbo.spConsensusDocumentSmsMessageRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusDocumentSmsMessageRemoveById(@PA_SMS_ID integer = null output) as 
begin
  delete 
  from dbo.SMS_Message
  where SMS_ID = @PA_SMS_ID
end
go
