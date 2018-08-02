if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusDocumentLiteratureFetchById')
  exec ('create procedure dbo.spConsensusDocumentLiteratureFetchById as select 1 as temp')
go
alter procedure dbo.spConsensusDocumentLiteratureFetchById(@PA_LIT_ID varchar(11) = null output) as 
begin
  select 
    LIT_ID,
    LIT_LOCK,
    LIT_ADD_DATE,
    LIT_ADD_BY,
    LIT_MOD_DATE,
    LIT_MOD_BY,
    LIT_RCV_DATE,
    LIT_RCV_FROM,
    LIT_NAME,
    LIT_COST,
    LIT_TEMPLATE,
    LIT_EXAM,
    LIT_ATTENDANCE,
    LIT_TYPE,
    LIT_CURRENT,
    LIT_LT_ID,
    LIT_SEND_OVERRIDE,
    LIT_EMAIL_ONLY,
    LIT_PRINT_ONLY,
    LIT_FILE_NAME
  from dbo.Literature
  where LIT_ID = @PA_LIT_ID
end
go
