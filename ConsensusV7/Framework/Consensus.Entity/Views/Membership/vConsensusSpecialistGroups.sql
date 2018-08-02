IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'dbo.vConsensusSpecialistGroups'))
BEGIN
	exec ('create view [dbo].[vConsensusSpecialistGroups] as select 1 TEMP')
END
GO
ALTER VIEW [dbo].[vConsensusSpecialistGroups]
AS
	Select 
	PROD_ID,
	PROD_NAME,
	PROD_REF,
	MEL_START,
	MEL_CURRENT_DATE,
	MEL_END,
	MEL_FEE,
	MEL_VAT_AMT,
	MEL_VATCD,
	MEL_INVOICED,
	MEL_PRICE_MODIFIED,
	MEL_PROD_ID,
	MEL_MEP_ID,
	MEL_MEM_ID,
	MEP_ID,
	MEL_ID,	
	uri = 'Membership/MemberLocation/' + convert(varchar, MEL_ID)
	FROM Member_period
	left outer join Member_location on MEL_MEP_ID=MEP_ID
	LEFT OUTER JOIN Product on MEL_PROD_ID=PROD_ID

	where mel_sy_type=1 and mel_status=0 

GO
