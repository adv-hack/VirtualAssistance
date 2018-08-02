IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'dbo.vConsensusMembershipDiscounts'))
BEGIN
	exec ('create view [dbo].[vConsensusMembershipDiscounts] as select 1 TEMP')
END
GO
ALTER VIEW [dbo].[vConsensusMembershipDiscounts]
AS
	Select 
	MEL_ID,
	MEL_DISC_REASON,
	MEL_DISC_RENEWAL,
	MEL_FEE,
	MEL_VAT_AMT,
	MEL_VATCD,
	MEL_INVOICED,
	MEL_MEP_ID,
	uri = 'Membership/MemberLocation/' + convert(varchar, MEL_ID)
	FROM Member_period
	left outer join Member_location on MEL_MEP_ID=MEP_ID
	
	where mel_sy_type=3 

GO
