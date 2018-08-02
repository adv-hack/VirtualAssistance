if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusContactCommunicationsXrefFetchById')
  exec ('create procedure dbo.spConsensusContactCommunicationsXrefFetchById as select 1 as temp')
go
alter procedure dbo.spConsensusContactCommunicationsXrefFetchById(@PA_COMMXREF_ID bigint = null output) as 
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
  where COMMXREF_ID = @PA_COMMXREF_ID
end
go
