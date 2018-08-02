if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusFinanceAccountXrefFetchAllByAddid')
  exec ('create procedure dbo.spConsensusFinanceAccountXrefFetchAllByAddid as select 1 as temp')
go
alter procedure dbo.spConsensusFinanceAccountXrefFetchAllByAddid(@PA_ACXREF_ADD_ID varchar(11) = null output) as 
begin
  select 
    ACXREF_ID,
    ACXREF_LOCK,
    ACXREF_ADD_DATE,
    ACXREF_ADD_BY,
    ACXREF_MOD_DATE,
    ACXREF_MOD_BY,
    ACXREF_RCV_DATE,
    ACXREF_RCV_FROM,
    ACXREF_ACC_ID,
    ACXREF_ORG_ID,
    ACXREF_ADD_ID,
    ACXREF_MAIN,
    ACXREF_INVOICE,
    ACXREF_STATEMENT,
    ACXREF_NO_ADD_CHANGE,
    ACXREF_PROLE_ID,
    ACXREF_FOR_ATTN_OF,
    ACXREF_CODE,
    ACXREF_NOMINATED,
    ACXREF_INCL_HIERARCHY,
    ACXREF_FROM_HIERARCHY
  from dbo.Account_Xref
  where ACXREF_ADD_ID = @PA_ACXREF_ADD_ID
end
go
