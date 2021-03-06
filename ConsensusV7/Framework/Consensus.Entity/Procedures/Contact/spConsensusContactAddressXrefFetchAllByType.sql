if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusContactAddressXrefFetchAllByType')
  exec ('create procedure dbo.spConsensusContactAddressXrefFetchAllByType as select 1 as temp')
go
alter procedure dbo.spConsensusContactAddressXrefFetchAllByType(@PA_ADDXREF_TYPE varchar(40) = null output) as 
begin
  select 
    ADDXREF_ID,
    ADDXREF_ADD_DATE,
    ADDXREF_ADD_BY,
    ADDXREF_MOD_DATE,
    ADDXREF_MOD_BY,
    ADDXREF_RCV_DATE,
    ADDXREF_RCV_FROM,
    ADDXREF_ADD_ID,
    ADDXREF_START,
    ADDXREF_END,
    ADDXREF_TYPE,
    ADDXREF_ORG_ID,
    ADDXREF_PRINCIPAL,
    ADDXREF_SALES_REP,
    ADDXREF_ADD_POSTCODE,
    ADDXREF_ORG_NAME,
    ADDXREF_ORG_DUNS,
    ADDXREF_PROLE_ID
  from dbo.Address_Xref
  where ADDXREF_TYPE = @PA_ADDXREF_TYPE
end
go
