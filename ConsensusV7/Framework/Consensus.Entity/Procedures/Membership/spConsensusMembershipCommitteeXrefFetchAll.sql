if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMembershipCommitteeXrefFetchAll')
  exec ('create procedure dbo.spConsensusMembershipCommitteeXrefFetchAll as select 1 as temp')
go
alter procedure dbo.spConsensusMembershipCommitteeXrefFetchAll as 
begin
  select 
    COMXREF_ID,
    COMXREF_ADD_BY,
    COMXREF_ADD_DATE,
    COMXREF_MOD_BY,
    COMXREF_MOD_DATE,
    COMXREF_RCV_FROM,
    COMXREF_RCV_DATE,
    COMXREF_COM_ID,
    COMXREF_TABLE_NAME,
    COMXREF_RECORD_ID,
    COMXREF_DISABLED,
    COMXREF_ROLE,
    COMXREF_DATE
  from dbo.Committee_Xref
end
go
