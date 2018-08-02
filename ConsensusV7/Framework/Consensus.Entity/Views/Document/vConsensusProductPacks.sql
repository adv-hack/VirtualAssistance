IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'dbo.vConsensusProductPacks'))
BEGIN
	exec ('create view [dbo].[vConsensusProductPacks] as select 1 TEMP')
END
GO

ALTER VIEW [dbo].vConsensusProductPacks

AS

Select 
PPA_ID,
PPA_PROD_ID, 
PACK_NAME, 
PPA_TYPE, 
PPA_SUPPRESS, 
PACK_TYPE,
uri = 'document/PackProduct/' + convert(varchar, PPA_ID)
from dbo.PRODUCT_PACK 
left outer join dbo.PACK on PPA_PACK_ID = PACK_ID 
left outer join dbo.PRODUCT on PPA_PROD_ID  = PROD_ID

GO