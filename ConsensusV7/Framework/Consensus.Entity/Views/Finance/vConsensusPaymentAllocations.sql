IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'dbo.vConsensusPaymentAllocations'))
BEGIN
	exec ('create view [dbo].[vConsensusPaymentAllocations] as select 1 TEMP')
END
GO

ALTER VIEW [dbo].vConsensusPaymentAllocations

AS

Select 
	PA_ID,
	PA_INV_REF,
	PA_INV_ID,
	PA_CREDIT_ID,
	PA_CREDIT_REF,
	PA_PAY_ID,
	PA_CURR_TYPE,
	PA_VALUE,
	PA_REFUND_ID,
	PA_ADD_DATE,
	uri = 'finance/PayAllocation/' + convert(varchar, PA_ID) 
FROM Pay_Allocation
left outer join dbo.Payment on PAY_ID=PA_PAY_ID
GO