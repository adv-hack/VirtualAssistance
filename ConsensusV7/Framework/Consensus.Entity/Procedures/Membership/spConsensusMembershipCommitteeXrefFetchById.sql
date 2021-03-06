if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMembershipCommitteeXrefFetchById')
  exec ('create procedure dbo.spConsensusMembershipCommitteeXrefFetchById as select 1 as temp')
go
alter procedure dbo.spConsensusMembershipCommitteeXrefFetchById(@PA_COMXREF_ID varchar(11) = null output) as 
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
  where COMXREF_ID = @PA_COMXREF_ID
end
go
