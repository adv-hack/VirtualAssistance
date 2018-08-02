IF not exists (SELECT object_id FROM sys.objects WHERE name = 'vConsensusMembershipProdGrades' and TYPE = 'v')
  exec ('create view dbo.vConsensusMembershipProdGrades as SELECT 1 as temp')
go

ALTER VIEW dbo.vConsensusMembershipProdGrades AS
 
SELECT 
	MBOM_ID,
	MBOM_PARENT_ID,
	MBOM_GRADE_ID,
	MBOM_PROD_ID,
	MBOM_MAIN,
	PROD_REF,
	PROD_NAME,
	PRS_PRICE = CASE ISNULL(PRS_PRICE, '')  WHEN '' THEN  0 ELSE PRS_PRICE END,
	uri = 'membership/memberbom/' + convert(varchar, MBOM_ID)
FROM MEMBER_BOM  
	INNER JOIN PRODUCT ON PROD_ID = MBOM_GRADE_ID  
	LEFT OUTER JOIN (SELECT MIN(PRS_PRICE) as PRS_PRICE,PRS_PROD_ID  FROM PRICES  GROUP BY PRS_PROD_ID) GroupPrices ON GroupPrices.PRS_PROD_ID = MBOM_GRADE_ID 
	--ORDER BY PRS_PRICE 
GO