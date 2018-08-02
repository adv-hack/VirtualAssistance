if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusContactCommunicationsXrefFetchAll')
  exec ('create procedure dbo.spConsensusContactCommunicationsXrefFetchAll as select 1 as temp')
go
alter procedure dbo.spConsensusContactCommunicationsXrefFetchAll as 
begin
  select 
    COMMXREF_ID,
    COMMXREF_ADD_DATE,
    COMMXREF_ADD_BY,
    COMMXREF_MOD_DATE,
    COMMXREF_MOD_BY,
    COMMXREF_TABLE_NAME,
    COMMXREF_RECORD_ID,
    COMMXREF_COMM_ID
  from dbo.Communications_Xref
end
go
