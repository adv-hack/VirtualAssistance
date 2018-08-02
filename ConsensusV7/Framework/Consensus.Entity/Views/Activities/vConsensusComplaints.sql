IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'dbo.vConsensusComplaints'))
BEGIN
	exec ('create view [dbo].[vConsensusComplaints] as select 1 TEMP')
END
GO
ALTER VIEW [dbo].[vConsensusComplaints]
AS

	SELECT 
		CMPL_ID,
		CMPL_TITLE,
		detailtext.TEXT_BODY CMPL_TEXTBODY,
		CMPL_FROM_PROLE_ID,
		a.PROLE_PN_NAME FROM_PROLE_PN_NAME,
		CMPL_RE_PROLE_ID, 
		b.PROLE_PN_NAME RE_PROLE_PN_NAME, 
		CMPL_MGR_PROLE_ID, 
		c.PROLE_PN_NAME MGR_PROLE_PN_NAME, 
		CMPL_MEDTR_PROLE_ID, 
		d.PROLE_PN_NAME MEDTR_PROLE_PN_NAME,
		CMPL_STATUS_1,
		CMPL_SCHEME,
		CMPL_DATE_OF_COMPL,
		CMPL_DATE_RCVD,
		CMPL_DATE_NEXT_ACT,
		a.PROLE_PERSON_ID PERSON_ID_COMPLAINANT,
		c.PROLE_PERSON_ID PERSON_ID_ASSIGNEE,
		d.PROLE_PERSON_ID PERSON_ID_OWNER,
		uri = 'activities/complaint/' + convert(varchar, CMPL_ID)
	FROM Complaint 
		Left outer join Person_Role a on a.PROLE_ID = CMPL_FROM_PROLE_ID 
		Left outer join Person_Role b on b.PROLE_ID = CMPL_RE_PROLE_ID 
		Left outer join Person_Role c on c.PROLE_ID = CMPL_MGR_PROLE_ID 
		Left outer join Person_Role d on d.PROLE_ID = CMPL_MEDTR_PROLE_ID 
		left OUTER JOIN C4Text detailtext ON TEXT_ID = CMPL_DETAILS_ID 

GO
