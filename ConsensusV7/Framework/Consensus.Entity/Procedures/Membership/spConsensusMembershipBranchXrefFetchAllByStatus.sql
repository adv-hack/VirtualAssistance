if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMembershipBranchXrefFetchAllByStatus')
  exec ('create procedure dbo.spConsensusMembershipBranchXrefFetchAllByStatus as select 1 as temp')
go
alter procedure dbo.spConsensusMembershipBranchXrefFetchAllByStatus(@PA_BRXREF_STATUS varchar(40) = null output) as 
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
  where BRXREF_STATUS = @PA_BRXREF_STATUS
end
go
