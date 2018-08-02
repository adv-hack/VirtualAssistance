IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'dbo.vConsensusRoles'))
BEGIN
	exec ('create view [dbo].[vConsensusRoles] as select 1 TEMP')
END
GO

ALTER VIEW [dbo].vConsensusRoles

AS

Select PROLE_ID,PROLE_PERSON_ID,PROLE_PN_NAME,PROLE_POS_TITLE,isnull(PROLE_ORG_NAME,'') PROLE_ORG_NAME,PROLE_ORG_ID,
PROLE_PHONE,PROLE_EMAIL,PROLE_PRINCIP_ROLE,PROLE_DIS_FLAG,ADD_MAILSTRING, case PROLE_DIS_FLAG when 0 then 'Active' else 'Archived' end PROLE_DIS_FLAG_DESC,PROLE_MOBILE,
uri = 'contact/role/' + convert(varchar, PROLE_ID)
From dbo.Person_Role
join [dbo].[Address] ON ADD_ID=PROLE_ADD_ID
GO