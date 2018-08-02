if not exists (select object_id from sys.objects where name = 'vConsensusRelatedProducts' and type = 'v')
  exec ('create view dbo.vConsensusRelatedProducts as select 1 as temp')
go

alter view dbo.vConsensusRelatedProducts as 
		SELECT PPX_ID,
		PARENT_PROD_ID = PPX_MAST_PROD_ID,
		REL_PROD_ID = PPX_SIM_PROD_ID,
		REL_PROD_NAME = PROD_NAME,
		REL_PROD_REF = PROD_REF, 
		REL_SY_PRODUCT = P.PROD_SY_PRODUCT,
		REL_PROD_TYPE = PROD_SY_PRODUCT_DESC,
		PPX_NOTES,
		PPX_PREREQ,
		CASE PPX_PREREQ
				WHEN 0 THEN 'Similar To'
				WHEN 1 THEN 'Pre-Requisite'
				WHEN 2 THEN 'Recommended'
		END AS REL_TYPE,
		ISNULL(SCHN_NAME, 'All') as SCHN_NAME , uri = 'learning/relatedproduct/' + convert(varchar, PPX_ID)
        FROM   dbo.Product_Prod_Xref  
		LEFT OUTER JOIN dbo.PRODUCT P ON P.PROD_ID = PPX_SIM_PROD_ID 
		LEFT OUTER JOIN vPROD_SY_PRODUCT SY ON P.PROD_SY_PRODUCT = SY.PROD_SY_PRODUCT
		left outer join dbo.Sales_Channel on SCHN_ID = PPX_SCHN_ID 

go