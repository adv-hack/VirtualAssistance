if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusDocumentLiteratureFetchAllByLtid')
  exec ('create procedure dbo.spConsensusDocumentLiteratureFetchAllByLtid as select 1 as temp')
go
alter procedure dbo.spConsensusDocumentLiteratureFetchAllByLtid(@PA_LIT_LT_ID varchar(11) = null output) as 
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
  where LIT_LT_ID = @PA_LIT_LT_ID
end
go
