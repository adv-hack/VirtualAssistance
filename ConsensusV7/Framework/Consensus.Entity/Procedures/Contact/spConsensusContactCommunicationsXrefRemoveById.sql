if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusContactCommunicationsXrefRemoveById')
  exec ('create procedure dbo.spConsensusContactCommunicationsXrefRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusContactCommunicationsXrefRemoveById(@PA_COMMXREF_ID bigint = null output) as 
begin
  delete 
  from dbo.Communications_Xref
  where COMMXREF_ID = @PA_COMMXREF_ID
end
go
