IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'dbo.vConsensusMembershipPeriods'))
BEGIN
	exec ('create view [dbo].[vConsensusMembershipPeriods] as select 1 TEMP')
END
GO

ALTER VIEW [dbo].[vConsensusMembershipPeriods]

AS
SELECT MEP_ID,
	MEP_MEM_ID,
	MEL_PROLE_ID, PROLE_PN_NAME,
	MEL_ORG_ID, ORG_NAME,
	MEP_PROD_ID,PROD_NAME,
	MEP_START,
	MEP_END,
	MEP_STATUS,
	uri = 'membership/memberperiod/' + convert(varchar, MEP_ID)
FROM Member_period 
INNER JOIN Member_location on MEP_ID = MEL_MEP_ID and MEL_RENEW_LOC = '1' 
Inner join Person_Role ON PROLE_ID = MEL_PROLE_ID
Left outer join Organisation on ORG_ID = MEL_ORG_ID
Inner join Product ON PROD_ID = MEP_PROD_ID 


GO
