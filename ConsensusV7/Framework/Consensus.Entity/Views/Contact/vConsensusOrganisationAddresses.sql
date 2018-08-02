IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'dbo.vConsensusOrganisationAddresses'))
BEGIN
	exec ('create view [dbo].[vConsensusOrganisationAddresses] as select 1 TEMP')
END
GO

ALTER VIEW [dbo].vConsensusOrganisationAddresses

AS

Select ADD_ID,ADDXREF_ORG_ID, ADD_MAILSTRING,addxref_type,ADDXREF_PRINCIPAL,
REPLACE(ADD_MAILSTRING,char(13),', ') ALT_ADD_MAILSTRING,
ADD_BUILDING,ADD_AREA,ADD_STREET,ADD_TOWN,ADD_COUNTY,ADD_POSTCODE,ADD_COUNTRY,ADDXREF_ID, uri = 'contact/organisationaddress/' + convert(varchar, ADDXREF_ID)
From dbo.Address_xref 
join dbo.Address on ADD_ID = ADDXREF_ADD_ID 
GO