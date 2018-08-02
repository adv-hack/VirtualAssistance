if not exists (select object_id from sys.objects where name = 'vConsensusBookingCreditNotes')
  exec ('create view dbo.vConsensusBookingCreditNotes as select 1 as temp')
go

ALTER view [dbo].[vConsensusBookingCreditNotes] as 
	select distinct INV1.INV_ID as INV_ID,
		INV1.INV_BOOK_ID as INV_BOOK_ID,
		INV1.INV_DATE as INV_DATE,
		INV1.INV_TYPE as INV_TYPE,
		INV1.INV_GROSS_TOTAL as INV_GROSS_TOTAL, 
		INV1.INV_CURRENCY_TYPE as INV_CURRENCY_TYPE, 
		INV1.INV_REF as INV_REF,
		INV1.INV_BK_ORG_CUST_AC as INV_BK_ORG_CUST_AC,
		INV1.INV_INV_ORG_NAME as INV_INV_ORG_NAME,
		INV_CONTACT_NAME = PROLE_PN_NAME,
		INV1.INV_PERSON_ID as INV_PERSON_ID,
		INV1.INV_ORG_ID as INV_ORG_ID,
		INV1.INV_CREDIT_NTE_REF as InvoiceID,
		INV2.INV_REF as InvoiceReference,
		INV2.INV_ID as INV_ID2,
		INV1.INV_ACC_ID as INV_ACC_ID,
		uri = 'finance/invoice/' + convert(varchar, INV1.INV_ID)
		from INVHEADER INV1
		left outer join dbo.PERSON_ROLE on PROLE_PERSON_ID = INV_PERSON_ID
		left outer join dbo.Account on ACC_ID=INV_ACC_ID
		left outer join dbo.INVHEADER INV2 on INV1.INV_CREDIT_NTE_REF = INV2.INV_ID
		where INV1.INV_TYPE = 'Credit' 



GO





