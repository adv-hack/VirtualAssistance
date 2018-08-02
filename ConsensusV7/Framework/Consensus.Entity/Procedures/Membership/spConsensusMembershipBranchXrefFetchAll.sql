if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMembershipBranchXrefFetchAll')
  exec ('create procedure dbo.spConsensusMembershipBranchXrefFetchAll as select 1 as temp')
go
alter procedure dbo.spConsensusMembershipBranchXrefFetchAll as 
begin
  select 
    BRXREF_ID,
    BRXREF_ADD_BY,
    BRXREF_ADD_DATE,
    BRXREF_MOD_BY,
    BRXREF_MOD_DATE,
    BRXREF_RCV_FROM,
    BRXREF_RCV_DATE,
    BRXREF_BR_ID,
    BRXREF_TABLE_NAME,
    BRXREF_RECORD_ID,
    BRXREF_DISABLED,
    BRXREF_POSITION,
    BRXREF_DISTRICT,
    BRXREF_DIS_ID,
    BRXREF_STATUS,
    BRXREF_START_DATE,
    BRXREF_END_DATE
  from dbo.Branch_Xref
end
go
