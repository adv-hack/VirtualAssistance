IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'dbo.vConsensusOrganisationOpportunities'))
BEGIN
	exec ('create view [dbo].[vConsensusOrganisationOpportunities] as select 1 TEMP')
END
GO

ALTER VIEW [dbo].[vConsensusOrganisationOpportunities]
AS

select distinct OPP_ID, OPP_NAME, OPP_STATUS, OPP_DATE_ENQ, OPP_PROD_INTEREST, OPP_VAL_POT,
OPPXREF_ORG_NAME, OPPXREF_ORG_ID, OPP_DATE_DEC, OPP_SALES_TYPE, OPP_SY_TYPE,
uri = 'sales/opportunity/' + convert(varchar, OPP_ID)
from dbo.Opportunity
join dbo.Opportunity_xref ON OPPXREF_OPP_ID = OPP_ID and isnull(OPPXREF_SALESMAN,0) = 0

GO
