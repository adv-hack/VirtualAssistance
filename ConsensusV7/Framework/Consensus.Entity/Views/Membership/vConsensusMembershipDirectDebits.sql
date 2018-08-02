IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'dbo.vConsensusMembershipDirectDebits'))
BEGIN
	exec ('create view [dbo].[vConsensusMembershipDirectDebits] as select 1 TEMP')
END
GO

ALTER view dbo.vConsensusMembershipDirectDebits  
AS
Select DD_STATUS_TEXT = case DD_STATUS 
		 When 0 then 'New Instruction' 
		 When 1 then 'Authorisation Sent to Bank' 
		 When 2 then 'Rejected by Bank' 
		 When 3 then 'First Collection' 
		 When 4 then 'Standard Collection' 
		 When 5 then 'Payment sent to Bank' 
		 When 6 then 'Payment Rejected' 
		 When 7 then 'Cancelled by Member' 
		 When 8 then 'Cancellation sent to Bank' 
		 When 9 then 'Cancellation accepted by Bank' 
		 When 10 then 'Membership Cancelled' 		 
		 Else ''  END,
		 DD_ID,
		 PROLE_PN_NAME,
		 DD_RCV_DATE,
		 DD_DUE_DATE,
		 DD_END_DATE,
		 MEP_ID,
		 MEP_MEM_ID,
		 uri = 'finance/directdebit/' + convert(varchar, DD_ID)
         from		
		 dbo.DirectDebit 
		 inner join ( 
			select MEM_REF,MEP_ID, MEP_MEM_ID, PROLE_PN_NAME, PN_FIRST_NAME, PN_SURNAME ,PROLE_EMAIL
			from Member_Period  
			Inner join Member_location  on MEL_MEP_ID = MEP_ID and MEL_RENEW_LOC = '1' 
			Inner join Membership  on MEM_ID = MEP_MEM_ID 
			Inner join Person_Role cp  ON cp.PROLE_ID = MEL_PROLE_ID 
			inner join person  on PN_ID = PROLE_PERSON_ID 			
		) Member on DD_TABLE_NUM = 271 and MEP_ID = DD_REC_ID
		 