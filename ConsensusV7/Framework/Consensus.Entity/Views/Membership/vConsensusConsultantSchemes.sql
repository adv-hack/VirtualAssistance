IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'dbo.vConsensusConsultantSchemes'))
BEGIN
	exec ('create view [dbo].[vConsensusConsultantSchemes] as select 1 TEMP')
END
GO
ALTER VIEW [dbo].[vConsensusConsultantSchemes]
AS
	Select 
	PROD_ID,
	PROD_NAME,
	PROD_REF,
	MEL_FEE,
	MEL_VAT_AMT,
	MEL_VATCD,
	MEL_INVOICED,
	MEL_PRICE_MODIFIED,
	MEL_PROD_ID,
	MEL_MEP_ID,
	MEP_ID,
	MEL_ID,
	MEL_DATE=COALESCE(MEL_CURRENT_DATE,MEL_START),
	MEL_END,
	CASE MEL_STATUS WHEN 0 THEN 'Current and active'
					WHEN 1 THEN 'Cancelled and credited'
					WHEN 2 THEN 'Changed and inactive' END AS Status, 
	uri = 'Membership/MemberLocation/' + convert(varchar, MEL_ID)
	FROM Member_period
	left outer join Member_location on MEL_MEP_ID=MEP_ID
	LEFT OUTER JOIN Product on MEL_PROD_ID=PROD_ID
	where mel_sy_type=5 

GO
