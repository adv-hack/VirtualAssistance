if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusDocumentLettertmpltRemoveById')
  exec ('create procedure dbo.spConsensusDocumentLettertmpltRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusDocumentLettertmpltRemoveById(@PA_LT_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.LetterTmplt
  where LT_ID = @PA_LT_ID
end
go
