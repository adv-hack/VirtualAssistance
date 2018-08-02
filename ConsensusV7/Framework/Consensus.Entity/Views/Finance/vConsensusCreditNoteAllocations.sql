IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'dbo.vConsensusCreditNoteAllocations'))
BEGIN
	exec ('create view [dbo].[vConsensusCreditNoteAllocations] as select 1 TEMP')
END
GO

ALTER VIEW [dbo].[vConsensusCreditNoteAllocations]

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
	uri = 'finance/PayAllocation/' + convert(varchar, PA_ID) 
FROM Pay_Allocation
left outer join dbo.InvHeader on INV_ID=PA_CREDIT_ID
where INV_TYPE='Credit'
GO

