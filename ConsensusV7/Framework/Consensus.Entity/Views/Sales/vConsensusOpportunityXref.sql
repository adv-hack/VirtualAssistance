IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'dbo.vConsensusOpportunityXref'))
BEGIN
	exec ('create view [dbo].[vConsensusOpportunityXref] as select 1 TEMP')
END
GO

ALTER VIEW [dbo].[vConsensusOpportunityXref]

AS
select OPPXREF_ID,OPPXREF_OPP_ID,OPPXREF_PROLE_ID,OPPXREF_END_ORG,OPPXREF_DIST_ORG,OPPXREF_SALESMAN,OPPXREF_ORG_NAME,OPPXREF_PN_NAME,OPPXREF_PN_PHONE,OPPXREF_ORG_ID,
OPPXREF_ORG_PHONE,OPPXREF_VALUE,OPPXREF_SHARE,PROLE_PERSON_ID OPPXREF_PN_ID,
OPPXREF_MAIN_SALESMAN = case when OPPXREF_SALESMAN = 1 then 1 else 0 end,
OPPXREF_TYPE = case when OPPXREF_END_ORG = 1 then
case when OPP_SY_TYPE='1' then 'Main contact'
 when OPP_SY_TYPE='2' then 'Pledger'
 when OPP_SY_TYPE='3' then 'Lead solicitor'
 when OPP_SY_TYPE='4' then 'Main contact'
 else 'End User'
 end
 when OPPXREF_DIST_ORG = 1 then
  case when OPP_SY_TYPE='3'then 'Legator'
  else 'Distributor'
  end
  when OPPXREF_SALESMAN = '1' then
   case when OPP_SY_TYPE='1' then 'Relationship owner'
    when OPP_SY_TYPE='2' then 'Relationship owner'
    when OPP_SY_TYPE='3' then 'Legacy manager'
    when OPP_SY_TYPE='4' then 'Application owner'
   else  'Main Sales Person' 
   end
  when OPPXREF_SALESMAN > '1' then
   case when OPP_SY_TYPE='0' then 'Sales Person'
   else 'Team member' 
   end
   else 'Other' end , PROLE_MOBILE,PROLE_EMAIL,
uri = 'sales/opportunityxref/' + convert(varchar, OPPXREF_ID)
from dbo.Opportunity_xref
join dbo.Person_role ON PROLE_ID=OPPXREF_PROLE_ID
join Opportunity on OPP_ID=OPPXREF_OPP_ID

GO