IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'dbo.vConsensusAssociateCourseList'))
BEGIN
	exec ('create view [dbo].[vConsensusAssociateCourseList] as select 1 TEMP')
END
GO
ALTER VIEW [dbo].[vConsensusAssociateCourseList]
AS
	Select TPXREF_TRAIN_ID
		,TPXREF_ID
		,TPXREF_START_DATE
		,TPXREF_END_DATE
		,TPXREF_STATUS
		,TPXREF_GRADE
		,TPXREF_COST
		,PROD_SY_PRODUCT 
		,PROD_ID
		,PROD_NAME 
		,uri = 'contact/trainprodxref/' + convert(varchar, TPXREF_ID)
	From Train_Prod_Xref 
		 Inner join Product on TPXREF_PROD_ID = PROD_ID 


GO