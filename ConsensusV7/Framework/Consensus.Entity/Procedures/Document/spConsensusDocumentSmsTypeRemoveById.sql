if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusDocumentSmsTypeRemoveById')
  exec ('create procedure dbo.spConsensusDocumentSmsTypeRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusDocumentSmsTypeRemoveById(@PA_SMT_ID integer = null output) as 
begin
  delete 
  from dbo.SMS_Type
  where SMT_ID = @PA_SMT_ID
end
go
