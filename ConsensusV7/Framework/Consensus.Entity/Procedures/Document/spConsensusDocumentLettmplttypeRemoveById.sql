if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusDocumentLettmplttypeRemoveById')
  exec ('create procedure dbo.spConsensusDocumentLettmplttypeRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusDocumentLettmplttypeRemoveById(@PA_LTT_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.LetTmpltType
  where LTT_ID = @PA_LTT_ID
end
go
