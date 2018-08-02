IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'dbo.vConsensusActiveSpecialistGroups'))
BEGIN
	exec ('create view [dbo].[vConsensusActiveSpecialistGroups] as select 1 TEMP')
END
GO
ALTER VIEW [dbo].[vConsensusActiveSpecialistGroups]
AS
	Select 
		PROD_ID,
		PROD_NAME,
		PROD_REF,
		PROD_STATE,	
		PRS_PRICE,
		PROD_VAT_CODE,
		PRS_PL_ID,
		PROD_PRICE= case 
			when PRS_PRICE is null then 0
			else cast(PRS_PRICE as decimal(10,2))
		end
	from dbo.Product 	
	LEFT JOIN(SELECT  distinct PRS_PRICE,PRS_PROD_ID, PRS_PL_ID
    FROM(SELECT *,DENSE_RANK()  OVER (PARTITION BY PRS_PROD_ID ORDER BY PRS_PRICE ) as Rank    
    FROM dbo.Prices ) AS Derived where rank=1 ) GroupPrices1 on GroupPrices1.PRS_PROD_ID = PROD_ID	
	WHERE PROD_SY_PRODUCT=16 and PROD_STATE=1

GO
