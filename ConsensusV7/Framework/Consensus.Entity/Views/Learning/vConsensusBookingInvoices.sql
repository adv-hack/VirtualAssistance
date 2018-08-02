if not exists (select object_id from sys.objects where name = 'vConsensusBookingInvoices' and type = 'v')
  exec ('create view dbo.vConsensusBookingInvoices as select 1 as temp')
go

alter view dbo.vConsensusBookingInvoices as 
	select distinct INV_ID,
		INVLN_BOOK_ID,
		INV_DATE,
		INV_TYPE,
		INV_GROSS_TOTAL, 
		INV_CURRENCY_TYPE, 
		INV_REF,
		INV_BK_ORG_CUST_AC,
		INV_INV_ORG_NAME,
		INV_DUE_DATE,
		INV_UNPAID_VAL,
		INV_CONTACT_NAME = PROLE_PN_NAME,
		INV_PERSON_ID,
		INV_ORG_ID,
		uri = 'finance/invoice/' + convert(varchar, INV_ID)
		from INVLINE  
		join INVHEADER  on INVLN_INV_ID = INV_ID 
		left outer join dbo.PERSON_ROLE on PROLE_PERSON_ID = INV_PERSON_ID
	where INV_TYPE ='Invoice'



