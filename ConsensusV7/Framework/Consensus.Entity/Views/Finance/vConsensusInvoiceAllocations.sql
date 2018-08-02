IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'dbo.vConsensusInvoiceAllocations'))
BEGIN
	exec ('create view [dbo].[vConsensusInvoiceAllocations] as select 1 TEMP')
END
GO

ALTER VIEW [dbo].vConsensusInvoiceAllocations

AS

SELECT	PA_INV_ID,
	PA_CREDIT_ID,
	PA_ID,
	CASE WHEN ISNULL(PA_REVERSES_PA_ID,'') = ''
	THEN	CASE WHEN ISNULL(PAY_TYPE,'') = ''
	THEN 'Credit note'
	ELSE PAY_TYPE
	END
	ELSE 'Reversal'
	END as	PAY_TYPE,
	PA_DATE,
	PA_INV_REF,
	PA_CREDIT_REF,
	PA_PAY_ID,
	PA_CURR_TYPE,
	PA_VALUE,
	uri = 'finance/PayAllocation/' + convert(varchar, PA_ID) 
	FROM PAY_ALLOCATION
	LEFT JOIN PAYMENT ON PA_PAY_ID = PAY_ID

GO
