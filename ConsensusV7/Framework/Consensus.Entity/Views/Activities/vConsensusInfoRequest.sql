IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'dbo.vConsensusInfoRequest'))
BEGIN
	exec ('create view [dbo].[vConsensusInfoRequest] as select 1 TEMP')
END
GO
ALTER VIEW [dbo].[vConsensusInfoRequest]
AS

	SELECT 
		HD_ID,
		HD_TITLE,
		HD_CATEGORY,
		HD_STATUS,
		a.PROLE_PN_NAME HD_PROLE_PN_NAME,
		b.PROLE_PN_NAME HD_GIVEN_TO_PN_NAME,
		HD_ADD_DATE,
		HD_FIXED_DATE,
		HD_RES_DATE,
		a.PROLE_PERSON_ID PERSON_ID_REQUESTED_BY,
		b.PROLE_PERSON_ID PERSON_ID_GIVEN_TO,
		uri = 'activities/helpdesk/' + convert(varchar, HD_ID)
	FROM Helpdesk 
		Left outer join Person_Role a on a.PROLE_ID = HD_PROLE_ID 
		Left outer join Person_Role b on b.PROLE_ID = HD_GIVEN_TO_ID 

GO
