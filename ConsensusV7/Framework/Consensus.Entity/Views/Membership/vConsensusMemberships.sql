IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'dbo.vConsensusMemberships'))
BEGIN
	exec ('create view [dbo].[vConsensusMemberships] as select 1 TEMP')
END
GO

ALTER VIEW [dbo].[vConsensusMemberships]

AS
Select distinct MEM_ID, COALESCE(MEM_REF,MEM_ID) MEM_REF, MEM_ADD_DATE,MEP_ID,MEP_STATUS ,PROD_ID, PROD_NAME,PROD_SY_PRODUCT,MEM_START,MEL_PROLE_ID,MEL_ORG_ID,PROLE_PERSON_ID PN_ID ,
MEP_START, MEP_END,MEP_RENEWAL_DATE,PN_SALUTATION, 
MEP_MEMBERSHIP_NAME = CASE ISNULL(MEP_MEMBERSHIP_NAME, '')  WHEN '' THEN  PN_SALUTATION ELSE MEP_MEMBERSHIP_NAME END,
uri = 'membership/memberperiod/' + convert(varchar, MEP_ID)
from dbo.Member_period
join dbo.Product on PROD_ID = MEP_PROD_ID
join dbo.Membership ON MEM_ID = MEP_MEM_ID
join dbo.Member_location ON MEL_MEP_ID = MEP_ID 
join dbo.Person_Role ON PROLE_ID=MEL_PROLE_ID 
join dbo.Person on PN_ID = prole_person_id

GO