IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'dbo.vConsensusMembershipLocations'))
BEGIN
	exec ('create view [dbo].[vConsensusMembershipLocations] as select 1 TEMP')
END
GO

ALTER VIEW [dbo].[vConsensusMembershipLocations]

AS
SELECT MEL_ID, MEL_MEP_ID, PN_ID, MEL_PROLE_ID, PROLE_PN_NAME, MEL_ORG_ID, ORG_NAME, 
	CASE MEL_STATUS WHEN 0 THEN 'Current and active'
					WHEN 1 THEN 'Cancelled and credited'
					WHEN 2 THEN 'Changed and inactive' END AS Status, 
	MEL_OVERSEAS, MEL_FEE, MEL_VAT_AMT, MEL_VATCD, MEL_INVOICED, MEL_RENEW_LOC,  
		 MEL_PRICE_MODIFIED,MEL_ADD_DATE,MEL_SY_TYPE,  uri = 'membership/memberlocation/' + convert(varchar, MEL_ID) 
		from MEMBER_LOCATION   
		left outer join PERSON_ROLE on PROLE_ID = MEL_PROLE_ID   
		left outer join PERSON on PROLE_PERSON_ID = PN_ID   
		left outer join ORGANISATION on MEL_ORG_ID = ORG_ID   


GO
