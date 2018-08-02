IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'dbo.vConsensusBranchDistricts'))
BEGIN
	exec ('create view [dbo].[vConsensusBranchDistricts] as select 1 TEMP')
END
GO
ALTER VIEW [dbo].[vConsensusBranchDistricts]
AS
	select 
	BRXREF_BR_ID,
	BRXREF_RECORD_ID,
	BR_ID,
	DIS_ID,
	DIS_NAME,
	DIS_CATEGORY,
	DIS_GROUP,
	DIS_REGION,
	DIS_STATUS,
	DIS_TYPE,
	uri = 'Membership/BranchXref/' + convert(varchar, BRXREF_ID)
	FROM Branch_Xref 
	JOIN Branch ON BR_ID=BRXREF_BR_ID
	JOIN District ON DIS_ID=BRXREF_RECORD_ID


GO
