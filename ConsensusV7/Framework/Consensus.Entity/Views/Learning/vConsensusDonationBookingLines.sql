if not exists (select object_id from sys.objects where name = 'vConsensusDonationBookingLines' and type = 'v')
  exec ('create view dbo.vConsensusDonationBookingLines as select 1 as temp')
go

alter view dbo.vConsensusDonationBookingLines as 
	select ELEM_BOOK_ID,
		ELEM_ID,
		PROD_REF, 
		PROD_NAME,	
		ELEM_DESCRIPTION,	
		ELEM_START_DATE, 
		ELEM_PROD_ID, 
		ELEM_DEL_ID,
		ELEM_GRP_ID,
		ELEM_ELEM_ID,
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
	ELEM_COST_CODE,
	 uri = 'learning/donationbookingline/' + convert(varchar, ELEM_ID)
from dbo.Element
join dbo.Delegate on DEL_ID = ELEM_DEL_ID  
left join dbo.Product on PROD_ID = ELEM_PROD_ID
where ELEM_SHOW_SALES = 1 and ELEM_TYPE in (29,41)
go