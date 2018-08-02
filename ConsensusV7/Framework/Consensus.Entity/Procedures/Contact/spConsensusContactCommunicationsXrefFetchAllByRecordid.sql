if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusContactCommunicationsXrefFetchAllByRecordid')
  exec ('create procedure dbo.spConsensusContactCommunicationsXrefFetchAllByRecordid as select 1 as temp')
go
alter procedure dbo.spConsensusContactCommunicationsXrefFetchAllByRecordid(@PA_COMMXREF_RECORD_ID varchar(11) = null output) as 
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
  where COMMXREF_RECORD_ID = @PA_COMMXREF_RECORD_ID
end
go
