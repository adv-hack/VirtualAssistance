if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSalesOpportunityXrefFetchAll')
  exec ('create procedure dbo.spConsensusSalesOpportunityXrefFetchAll as select 1 as temp')
go
alter procedure dbo.spConsensusSalesOpportunityXrefFetchAll as 
begin
  select 
    OPPXREF_ID,
    OPPXREF_ADD_DATE,
    OPPXREF_ADD_BY,
    OPPXREF_MOD_DATE,
    OPPXREF_MOD_BY,
    OPPXREF_RCV_DATE,
    OPPXREF_RCV_FROM,
    OPPXREF_PROLE_ID,
    OPPXREF_OPP_ID,
    OPPXREF_PRINCIPAL,
    OPPXREF_RELATION,
    OPPXREF_NOTE,
    OPPXREF_START,
    OPPXREF_END,
    OPPXREF_END_ORG,
    OPPXREF_DIST_ORG,
    OPPXREF_SALESMAN,
    OPPXREF_ORG_NAME,
    OPPXREF_PN_NAME,
    OPPXREF_ORG_ID,
    OPPXREF_ORG_PHONE,
    OPPXREF_PN_PHONE,
    OPPXREF_REL_1,
    OPPXREF_REL_2,
    OPPXREF_REL_3,
    OPPXREF_REL_4,
    OPPXREF_REL_5,
    OPPXREF_REL_6,
    OPPXREF_VALUE,
    OPPXREF_SHARE
  from dbo.Opportunity_Xref
end
go
