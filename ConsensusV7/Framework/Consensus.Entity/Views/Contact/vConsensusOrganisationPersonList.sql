IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'dbo.vConsensusOrganisationPersonList'))
BEGIN
	exec ('create view [dbo].[vConsensusOrganisationPersonList] as select 1 TEMP')
END
GO

ALTER VIEW [dbo].vConsensusOrganisationPersonList

AS

Select PROLE_PN_NAME,PROLE_PHONE, PROLE_FAX, PROLE_EMAIL, PROLE_ORG_ID, PROLE_ID, PROLE_POS_TITLE,PROLE_KEY_CONTACT,PROLE_PERSON_ID,PN_SURNAME,PROLE_MOBILE, uri = 'contact/role/' + convert(varchar, PROLE_ID)
from dbo.PERSON_ROLE 
join dbo.PERSON on PN_ID = PROLE_PERSON_ID 
where (isnull(PROLE_DIS_FLAG,0) = 0 or PROLE_DIS_FLAG = 2 ) 
--want to display disabled by org as we want to see who is on this disabled org

GO