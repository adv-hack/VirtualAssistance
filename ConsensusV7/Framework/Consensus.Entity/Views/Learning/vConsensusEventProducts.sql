if not exists (select object_id from sys.objects where name = 'vConsensusEventProducts' and type = 'v')
  exec ('create view dbo.vConsensusEventProducts as select 1 as temp')
go

alter view dbo.vConsensusEventProducts as 
SELECT DISTINCT 
	EP_ID,	
	PROD_NAME,
	PROD_REF,
	PROD_ID,
	PROD_SY_PRODUCT,
	EP_DELEGATE_QTY,
	EP_QTY,
	CASE SXREF_MANDATORY WHEN 1 THEN 'Yes'
	WHEN 2 THEN 'Recommended' ELSE 'No' END AS SXREF_MANDATORY,
	EP_COURSE_ID,
	CSG_NAME,
	uri = 'learning/eventproduct/' + convert(varchar, EP_ID) 

FROM dbo.EVENT_PRODUCT
INNER JOIN dbo.PRODUCT ON PROD_ID = EP_PROD_ID 
INNER JOIN dbo.Session_Xref ON SXREF_EP_ID = EP_ID
LEFT JOIN dbo.CourseSelectGroups ON CSG_ID = SXREF_CSG_ID 

go