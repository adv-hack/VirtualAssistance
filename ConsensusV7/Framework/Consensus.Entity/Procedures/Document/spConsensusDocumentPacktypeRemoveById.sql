if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusDocumentPacktypeRemoveById')
  exec ('create procedure dbo.spConsensusDocumentPacktypeRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusDocumentPacktypeRemoveById(@PA_PACKTYP_ID integer = null output) as 
begin
  delete 
  from dbo.PackType
  where PACKTYP_ID = @PA_PACKTYP_ID
end
go
