IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'dbo.vConsensusBatchRecords'))
BEGIN
	exec ('create view [dbo].[vConsensusBatchRecords] as select 1 TEMP')
END
GO

ALTER VIEW [dbo].vConsensusBatchRecords

AS
Select
	BATXR_ID,
	BATXR_RECORD_ID,
	BATXR_BAT_ID,
	BATXR_LINK_ID,
	BATXR_LINK_URL= REPLACE(BATXR_LINK_URL,'[[LINK_ID]]',BATXR_LINK_ID) ,
	BATXR_STATUS =  CASE BATXR_STATUS
	WHEN 1 then 'Success'
	WHEN 0 THEN 'FAILED'
	ELSE 'N/A' END,

	BATXR_TABLE_NAME = CASE BATXR_TABLE_NAME 
	When 'Account' THEN 'Account'
	WHEN 'CIPD_Customers_API' THEN  'Account'
                                WHEN 'Course' THEN  'Event'
								WHEN 'Event_Budget_Lines' THEN  'Event Budget Line'
								WHEN 'InvHeader' THEN  'Invoice'
								WHEN 'CIPD_Invoices_API' THEN  'Invoice'
								WHEN 'Person_Role' THEN  'Person'
								WHEN 'Payment' THEN  'Payment'
								WHEN 'Pay_Allocation' THEN  'Pay Allocation'
                                WHEN 'Booking' THEN  'Booking'
								WHEN 'CIPD_Journals_API' THEN  'Booking'
								WHEN 'CIPD_Nominal_API' THEN  'Events'
								WHEN 'CIPD_Payments_API' THEN  'Payments'
								WHEN 'CIPD_InvLines_API' THEN  'Invoice Line'
								
								ELSE BATXR_TABLE_NAME
								END,
								uri = 'other/batchxref/' + convert(varchar, BATXR_ID)
 
From BATCH_XREF

GO
