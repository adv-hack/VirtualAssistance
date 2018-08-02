if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusDocumentLettmplttypeFetchAll')
  exec ('create procedure dbo.spConsensusDocumentLettmplttypeFetchAll as select 1 as temp')
go
alter procedure dbo.spConsensusDocumentLettmplttypeFetchAll as 
begin
  select 
    LTT_ID,
    LTT_LOCK,
    LTT_ADD_DATE,
    LTT_ADD_BY,
    LTT_MOD_DATE,
    LTT_MOD_BY,
    LTT_RCV_DATE,
    LTT_RCV_FROM,
    LTT_NAME,
    LTT_DESC,
    LTT_LEVELS,
    LTT_TYPE,
    LTT_PROC_NAME,
    LTT_EQUIVALENT,
    LTT_DEFAULT_PR_TYPE,
    LTT_URL
  from dbo.LetTmpltType
end
go
