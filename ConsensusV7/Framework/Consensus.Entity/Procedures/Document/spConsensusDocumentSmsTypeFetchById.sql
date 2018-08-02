if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusDocumentSmsTypeFetchById')
  exec ('create procedure dbo.spConsensusDocumentSmsTypeFetchById as select 1 as temp')
go
alter procedure dbo.spConsensusDocumentSmsTypeFetchById(@PA_SMT_ID integer = null output) as 
begin
  select 
    SMT_ID,
    SMT_ADD_DATE,
    SMT_ADD_BY,
    SMT_MOD_DATE,
    SMT_MOD_BY,
    SMT_NAME,
    SMT_VIEW,
    SMT_STORED_PROC
  from dbo.SMS_Type
  where SMT_ID = @PA_SMT_ID
end
go
