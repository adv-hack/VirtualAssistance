IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'dbo.vConsensusMembershipBranches'))
BEGIN
	exec ('create view [dbo].[vConsensusMembershipBranches] as select 1 TEMP')
END
GO
ALTER VIEW [dbo].[vConsensusMembershipBranches]
AS
	Select 
	BRXREF_ID
	,BR_ID
	,BR_NAME
	,BRXREF_STATUS
	,BRXREF_START_DATE
	,BRXREF_END_DATE
	,BR_REGION
	,BR_TYPE
	,BR_Category
	,BR_Group
	,BR_STATUS
	,BRXREF_RECORD_ID
	,uri = 'Membership/BranchXref/' + convert(varchar, BRXREF_ID)
	FROM Branch_Xref 
	Inner join Branch on BR_ID = BRXREF_BR_ID 
	where BRXREF_TABLE_NAME='Member_period' 

GO