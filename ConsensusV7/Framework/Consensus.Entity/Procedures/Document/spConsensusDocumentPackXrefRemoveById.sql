if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusDocumentPackXrefRemoveById')
  exec ('create procedure dbo.spConsensusDocumentPackXrefRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusDocumentPackXrefRemoveById(@PA_PACKXREF_ID varchar(11) = null output) as 
begin
  delete 
  from dbo.Pack_Xref
  where PACKXREF_ID = @PA_PACKXREF_ID
end
go
