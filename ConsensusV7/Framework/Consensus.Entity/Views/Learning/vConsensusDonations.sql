if not exists (select object_id from sys.objects where name = 'vConsensusDonations' and type = 'v')
  exec ('create view dbo.vConsensusDonations as select 1 as temp')
go

alter view dbo.vConsensusDonations as 
	select BOOK_ID,
		ELEM_ID,
		PROD_REF, 
		PROD_NAME,	
		ELEM_DESCRIPTION,
		BOOK_ADD_DATE, 		
		ELEM_START_DATE, 
		ELEM_PROD_ID, 
		ELEM_DEL_ID,
		BOOK_ORG_ID, 
		BOOK_OPP_ID,
	ORG_NAME,
	Book.ACC_SYSTEM_REF													as BOOKING_ACC_REF,
	ORG_REF,
	Booker.PROLE_PERSON_ID												as BOOKER_PN_ID,
	Booker.PROLE_ID														as BOOKER_PROLE_ID, 
	Booker.PROLE_PN_NAME												as BOOKER_PROLE_PN_NAME, 
	Inv.PROLE_PERSON_ID													as INVOICE_PN_ID,
	Inv.PROLE_ID														as INVOICE_PROLE_ID,
	Inv.PROLE_PN_NAME													as INVOICE_PROLE_PN_NAME,
	case ELEM_STATUS 
		WHEN 0 THEN 'Provisional'
		WHEN 1 THEN 'Confirmed'
		WHEN 2 THEN 'Cancelled'
		WHEN 7 THEN 'Transferred'
		WHEN 8 THEN 'Attended'
		WHEN 9 THEN 'Substituted'
		WHEN 10 THEN 'Waiting'
		WHEN 11 THEN 'Reservation'
		WHEN 12 THEN 'Lapsed Wait'
		WHEN 13 THEN 'Lapsed Res'
		WHEN 98 THEN 'Payment Error'
	end																	as ELEM_STATUS,	
	BOOK_ORDER_TYPE, 
	BOOK_CUST_ORD_NO,
	case DEL_BOOK_APPROVED
		WHEN 0 THEN 'Provisional'
		WHEN 1 THEN 'Confirmed'
		WHEN 2 THEN 'Cancelled' 
		WHEN 7 THEN 'Transferred' 
		WHEN 8 THEN 'Attended' 
		WHEN 9 THEN 'Substituted'
		WHEN 10 THEN 'Waiting'
		WHEN 11 THEN 'Reservation'
		WHEN 12 THEN 'No Show' 
		WHEN 20 THEN 'Wait listed' 
		WHEN 30 THEN 'Invited' 
		WHEN 90 THEN 'Training request has been cancelled/rejected' 
		WHEN 98 THEN 'Payment Error' 
	END																	as DEL_BOOK_APPROVED,
	ELEM_MAIN_SESSION,
	ELEM_GIFT_AID,
	ELEM_PRICE,
	BookerP.PN_SURNAME as BOOKER_PN_SURNAME,
	InvoiceP.PN_SURNAME as INVOICE_PN_SURNAME,
	ELEM_COST_CODE,
	BOOK_BOOKING_METHD,
	BOOK_SELCO_SP_ID,
	 uri = 'learning/booking/' + convert(varchar, BOOK_ID)
from dbo.Booking 
join dbo.Person_Role Booker on Booker.PROLE_ID = BOOK_PROLE_ID 
join dbo.Delegate on DEL_BOOK_ID = BOOK_ID 
left join dbo.Person_Role Inv on Inv.PROLE_ID = BOOK_INV_PROLE_ID
left join dbo.Person BookerP on BookerP.PN_ID=BOOK_PERSON_ID
left join dbo.Person InvoiceP on InvoiceP.PN_ID=Inv.PROLE_PERSON_ID
left join dbo.Account Book on BOOK_ACC_ID = ACC_ID
join dbo.Element on ELEM_DEL_ID = DEL_ID and ELEM_MAIN_SESSION = 1 and ELEM_SHOW_SALES = 1 and ELEM_TYPE = 29
join dbo.Product on PROD_ID = ELEM_PROD_ID
left join dbo.Organisation on ORG_ID = BOOK_ORG_ID
go